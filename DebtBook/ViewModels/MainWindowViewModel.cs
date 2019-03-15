using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.Views;
using Prism.Commands;
using Prism.Mvvm;
using TheDebtBook.Model;
using System.Diagnostics;
using System.Windows.Documents;

namespace DebtBook.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        private ObservableCollection<Debtor> _debtors;



        public MainWindowViewModel()
        {
            _debtors = new ObservableCollection<Debtor>()
            {
                new Debtor("Oscar T. Hansen"),
                new Debtor("T. Moeller")
            };

        }

        #region Properties

        public ObservableCollection<Debtor> Debtors
        {
            get => _debtors;
            set => SetProperty(ref _debtors, value);
        }

        private Debtor _currentDebtor = null;

        public Debtor CurrentDebtor
        {
            get => _currentDebtor;
            set => SetProperty(ref _currentDebtor, value); 
        }

        private Debtor debtorToAddDebt;

        public Debtor DebtorToAddDebt
        {
            get { return debtorToAddDebt; }
            set { SetProperty(ref debtorToAddDebt, value); }
        }

        private int _currentIndex = -1;

        public int CurrentIndex
        {
            get => _currentIndex;
            set => SetProperty(ref _currentIndex, value);
        }

        #endregion


        #region Commands

        private ICommand _addDebtorCommand;

        public ICommand AddDebtorCommand
        {
            get { return _addDebtorCommand ?? (_addDebtorCommand = new DelegateCommand(() =>
            {
                var newDebtor = new Debtor();
                var vm = new AddDebtorViewModel(newDebtor);
                var dlg = new AddDebtorView {DataContext = vm};
                if (dlg.ShowDialog()==true)
                {
                    foreach (var debtor in Debtors)
                    {
                        if (debtor.Name==newDebtor.Name)
                        {
                            debtor.AddDebt(newDebtor.Debt);
                            debtor.Debt += newDebtor.Debt;
                            CurrentDebtor = debtor;
                            return;
                        }
                    }
                    
                    newDebtor.AddDebt(newDebtor.Debt);
                    Debtors.Add(newDebtor);
                    CurrentDebtor = newDebtor;
                }
            }
            )); }
        }

        private ICommand _viewDebtorCommand;

        public ICommand ViewDebtorCommand
        {
            get { return _viewDebtorCommand ?? (_viewDebtorCommand = new DelegateCommand(()=>
                             {
                Debtor newDebtor = CurrentDebtor.Clone();
                ObservableCollection<DebtAndDate> tempDebtAndDates = new ObservableCollection<DebtAndDate>(newDebtor.DebtAndDate);
                var vm = new DebtorViewViewModel(newDebtor,tempDebtAndDates);
                var dlg = new DebtorView() {DataContext = vm};
                dlg.Owner = App.Current.MainWindow;
                
                if(dlg.ShowDialog()==true)
                {
                    CurrentDebtor.DebtAndDate = tempDebtAndDates;
                    CurrentDebtor.Debt = newDebtor.Debt;
                }
            }, 
            () =>
            {
                if (CurrentDebtor != null)
                    return true;
                else
                    return false;
            }).ObservesProperty(() => CurrentDebtor));
            }
        }

        #endregion

    }
}
