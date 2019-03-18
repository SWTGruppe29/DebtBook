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

        public DebtorViewViewModel(Debtor debtor, ObservableCollection<DebtAndDate> tempDebtAndDates)
        {
            CurrentDebtor = debtor;
            DebtAndDates = tempDebtAndDates;
        }

        private Debtor _debtor;

        public Debtor CurrentDebtor
        {
            get => _debtor;
            set => SetProperty(ref _debtor, value);
        }

        private ObservableCollection<DebtAndDate> _debtAndDates;

        public ObservableCollection<DebtAndDate> DebtAndDates
        {
            get { return _debtAndDates; }
            set { SetProperty(ref _debtAndDates, value); }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
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
                bool tryParse = false;
                double result = 0;
                tryParse= Double.TryParse(Value,out result);
                if (tryParse)
                {
                    DebtAndDate debt = new DebtAndDate(result, DateTime.Now);
                    CurrentDebtor.Debt += result;
                    DebtAndDates.Add(debt);
                    return;
                }
                else
                {
                   MessageBox.Show("Invalid debt, please enter valid information", "Missing data");
                }
            }
            
        }
        
    }
}
