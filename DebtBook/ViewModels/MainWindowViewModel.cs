using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.Views;
using Prism.Commands;
using Prism.Mvvm;
using TheDebtBook.Model;


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
                var vm = new AddDebtorViewModel();
                var dlg = new AddDebtorView {DataContext = vm};
                dlg.Show();
            }
            )); }
        }

        private ICommand _viewDebtorCommand;

        public ICommand ViewDebtorCommand
        {
            get { return _viewDebtorCommand ?? (_viewDebtorCommand = new DelegateCommand(()=>
            {
                var vm = new DebtorViewViewModel();
                var dlg = new DebtorView() {DataContext = vm};
                dlg.Show();
            }));
            }
        }

        #endregion

    }
}
