using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DebtBook.Annotations;
using Prism.Mvvm;

namespace DebtBook.ViewModels
{
    class AddDebtorViewModel : BindableBase
    {
        #region Properties

        private string _debtor;

        public string Debtor
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
