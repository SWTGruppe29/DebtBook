using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DebtBook.Annotations;
using Prism.Commands;
using Prism.Mvvm;
using TheDebtBook.Model;

namespace DebtBook.ViewModels
{
    public class AddDebtorViewModel : BindableBase
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


        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(CurrentDebtor.Name))
                    return false;
                if (string.IsNullOrWhiteSpace(CurrentDebtor.Debt.ToString(CultureInfo.InvariantCulture)))
                    return false;
                if (double.IsNaN(CurrentDebtor.Debt))
                    return false;

                return true;
            }
        }


        #endregion

        #region Commands



        #endregion


    }
}
