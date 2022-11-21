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

namespace DataAccess
{
    /// <summary>
    /// Interaction logic for AddingHistoryWindow.xaml
    /// </summary>
    public partial class AddingHistoryWindow : Window
    {
        public AddingHistoryWindow()
        {
            InitializeComponent();
        }

        private void DischargePatient_Click(object sender, RoutedEventArgs e)
        {
            PatNamText.Text = "";
            PatConText.Text = "";
            PatDiaText.Text = "";
            PatTreText.Text = "";
            PatDepText.Text = "";
            this.Hide();
        }
    }
}
