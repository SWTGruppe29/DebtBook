using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DebtBook.Annotations;
using Prism.Mvvm;
using TheDebtBook.Model;

namespace DebtBook.ViewModels
{
    class AddDebtorViewModel : BindableBase
    {

        public AddDebtorViewModel(Debtor debtor)
        {
            CurrentDebtor = debtor;
        }

        #region Properties

        private Debtor _debtor;

        public Debtor CurrentDebtor
        {
            get => _debtor;
            set => SetProperty(ref _debtor, value);
        }

        private double _value;

        public double Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

        #endregion

        #region Commands

        #endregion


    }
}
