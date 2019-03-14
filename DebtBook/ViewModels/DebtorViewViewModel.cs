using System;
using System.Collections.Generic;
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
        private Debtor current;

        public Debtor Current
        {
            get { return current; }
            set { SetProperty(ref current, value); }
        }

        public List<DebtAndDate> Debts
        {
            get { return current.DebtAndDate; }
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
            try
            {
                double value = Double.Parse(Value);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private void addDebt()
        {
            DebtAndDate debt = new DebtAndDate(Double.Parse(Value), DateTime.Now);
            current.DebtAndDate.Add(debt);
        }
    }
}
