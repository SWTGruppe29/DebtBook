using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DebtBook.Annotations;
using Prism.Commands;
using Prism.Mvvm;
using TheDebtBook.Model;

namespace DebtBook.ViewModels
{
    class DebtorViewViewModel : BindableBase
    {
        public DebtorViewViewModel(Debtor debtor)
        {
            Debts = debtor.DebtAndDate;
        }

        private ObservableCollection<DebtAndDate> debts;

        public ObservableCollection<DebtAndDate> Debts
        {
            get { return debts; }
            set { SetProperty(ref debts, value); }
        }

        private string val;

        public string Value
        {
            get { return val; }
            set { SetProperty(ref val, value); }
        }


        private ICommand addDebtCommand;

        public ICommand AddDebtCommand
        {
            get { return addDebtCommand ?? (addDebtCommand = new DelegateCommand(addDebt, canAddDebt)); }
        }

        private bool canAddDebt()
        {
            bool result;
            Boolean.TryParse(Value,out result);
            return result;
        }

        private void addDebt()
        {
            DebtAndDate debt = new DebtAndDate(Double.Parse(Value), DateTime.Now);
            Debts.Add(debt);
        }
    }
}
