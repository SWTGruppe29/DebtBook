using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Prism.Mvvm;
using TheDebtBook.Model;


namespace DebtBook.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        private ObservableCollection<Debtor> debtors;

        public MainWindowViewModel()
        {
            debtors = new ObservableCollection<Debtor>();



        }

        #region Properties

        public ObservableCollection<Debtor> Debtors
        {
            get { return debtors; }
            set { SetProperty(ref debtors, value); }
        }

        private Debtor currentDebtor = null;
        
        


        #endregion



        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
