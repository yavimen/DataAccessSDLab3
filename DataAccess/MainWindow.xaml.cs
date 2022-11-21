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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataAccess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AddingHistoryWindow addingHistoryWindow;
        public MainWindow()
        {
            InitializeComponent();
            addingHistoryWindow = new AddingHistoryWindow();
        }

        public new object DataContext
        {
            get { return base.DataContext; }
            set
            {
                base.DataContext = value;
                addingHistoryWindow.DataContext = value;
            }
        }

        private void AddNewPatient_Click(object sender, RoutedEventArgs e)
        {
            addingHistoryWindow.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            addingHistoryWindow.Close();
        }

        private void UpdatePatient_Click(object sender, RoutedEventArgs e)
        {
            UpdateHistoryWindow updateHistoryWindow = new UpdateHistoryWindow();
            updateHistoryWindow.DataContext = this.DataContext;
            updateHistoryWindow.Show();
        }
    }
}
