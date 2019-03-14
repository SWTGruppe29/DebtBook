using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace TheDebtBook.Model
{
    public class DebtAndDate : BindableBase
    {
        private DateTime date;
        private double debt; 

        public DebtAndDate(double Debt, DateTime Date)
        {
            debt = Debt;
            date = Date;
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Debt
        {
            get { return debt; }
            set { debt = value; }
        }
    }
}
