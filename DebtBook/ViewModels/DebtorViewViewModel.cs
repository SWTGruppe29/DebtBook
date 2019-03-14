using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DebtBook.Annotations;
using DebtBook.Views;
using Prism.Commands;
using Prism.Mvvm;
using TheDebtBook.Model;

namespace DebtBook.ViewModels
{
    public class DebtorViewViewModel : BindableBase
    {
        // Fired when the Add debt button is pressed
        public event EventHandler Add;

        public DebtorViewViewModel(Debtor debtor)
        {
            CurrentDebtor = debtor;
            Debts = debtor.DebtAndDate;
            
        }


        private ObservableCollection<DebtAndDate> debts;
        private Debtor _debtor;

        public Debtor CurrentDebtor
        {
            get => _debtor;
            set => SetProperty(ref _debtor, value);
        }

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
            get { return addDebtCommand ?? (addDebtCommand = new DelegateCommand(addDebt, canAddDebt).ObservesProperty(() => Value)); }
        }

        
        private bool canAddDebt()
        {
            return true;

            bool result;
            Boolean.TryParse(Value,out result);
            return result;
        }

        private void addDebt()
        {
            if(Value != null)
            {
                var val = Double.Parse(Value);
                DebtAndDate debt = new DebtAndDate(val, DateTime.Now);

                CurrentDebtor.Debt += val;
                Debts.Add(debt);

                if (Add != null) { Add(this, EventArgs.Empty); }
            }
            else
            {
                MessageBox.Show("You must enter a debt",
                                          "Confirmation",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Error);
            }
     
        
        }
    }
}
