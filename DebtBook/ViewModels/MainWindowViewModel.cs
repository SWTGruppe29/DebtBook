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

        private ObservableCollection<Debtor> debtors;

        public MainWindowViewModel()
        {
           
            debtors = new ObservableCollection<Debtor>()
            {
                new Debtor("Oscar T. Hansen"),
                new Debtor("T. Moeller")
            };

        }

        #region Properties

        public ObservableCollection<Debtor> Debtors
        {
            get { return debtors; }
            set { SetProperty(ref debtors, value); }
        }

        private Debtor currentDebtor = null;

        public Debtor CurrentDebtor
        {
            get { return currentDebtor; }
            set { SetProperty(ref currentDebtor, value); }
        }

        private int currentIndex = -1;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }
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
                var dlg = new AddDebtorView();
                dlg.DataContext = vm;
                dlg.ShowDialog();
            }
            )); }
        }

        #endregion

    }
}
