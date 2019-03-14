using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.Views;
using Prism.Commands;
using Prism.Mvvm;
using TheDebtBook.Model;
using System.Diagnostics;

namespace DebtBook.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        AddDebtorView AddDialog = null;
        DebtorView debtorView = null;
        private ObservableCollection<Debtor> _debtors;



        public MainWindowViewModel()
        {
            _debtors = new ObservableCollection<Debtor>()
            {
                new Debtor("Oscar T. Hansen"),
                new Debtor("T. Moeller")
            };

            CurrentDebtor = null;

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
                // Initialize the dialog
                if (AddDialog != null)
                    AddDialog.Focus();
                else
                {
                    AddDialog = new AddDebtorView();
                    AddDialog.Owner = App.Current.MainWindow;


                    // Listen for the Apply button and show the dialog modelessly
                    //dlg.Apply += new EventHandler(Dlg_Apply);
                    //dlg.Closed += new EventHandler(Dlg_Closed);
                    AddDialog.Show();
                }

                //var newDebtor = new Debtor();
                //var vm = new AddDebtorViewModel();
                //var dlg = new AddDebtorView {DataContext = vm};
                //dlg.Show();
            }
            )); }
        }

        private ICommand _viewDebtorCommand;

        public ICommand ViewDebtorCommand
        {
            get { return _viewDebtorCommand ?? (_viewDebtorCommand = new DelegateCommand(()=>
            {
                // Initialize the dialog
                if (debtorView != null)
                    debtorView.Focus();
                else
                {
                    debtorView = new DebtorView();
                    debtorView.Owner = App.Current.MainWindow;


                    debtorView.Add += 
                    // Listen for the Apply button and show the dialog modelessly

                    //dlg.Apply += new EventHandler(Dlg_Apply);
                    //dlg.Closed += new EventHandler(Dlg_Closed);
                    debtorView.Show();
                }


                //var vm = new DebtorViewViewModel(CurrentDebtor);
                //var dlg = new DebtorView() {DataContext = vm};
                //dlg.Show();
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
