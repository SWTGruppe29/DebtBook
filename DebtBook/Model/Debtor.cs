﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace TheDebtBook.Model
{
    public class Debtor : BindableBase
    {
        private string name;
        private ObservableCollection<DebtAndDate> debtAndDate = new ObservableCollection<DebtAndDate>();
        private double debt = 0.0;


        public void AddDebt(double debt)
        {
            DebtAndDate.Add(new Model.DebtAndDate(debt, DateTime.Now));
        }

        public Debtor()
        {
            
        }
        public Debtor(string DebtorName)
        {
            name = DebtorName;
        }
        
        public double Debt
        {
            get { return debt; }
            set { SetProperty(ref debt, value); }
        }

        public Debtor Clone()
        {
            return this.MemberwiseClone() as Debtor;
        }

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public ObservableCollection<DebtAndDate> DebtAndDate
        {
            get { return debtAndDate; }
            set { SetProperty(ref debtAndDate, value); }
        }
    }
}
