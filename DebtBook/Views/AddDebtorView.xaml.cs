using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DebtBook.ViewModels;

namespace DebtBook.Views
{
    /// <summary>
    /// Interaction logic for AddDebtorView.xaml
    /// </summary>
    public partial class AddDebtorView : Window
    {
        public AddDebtorView()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as AddDebtorViewModel;
            if (vm.IsValid)
            {
                DialogResult = true;
            }

            else
            {
                MessageBox.Show("Invalid Name or debt, please enter valid information", "Missing data");
            }

        }
    }
}
