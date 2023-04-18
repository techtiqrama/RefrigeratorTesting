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

namespace RefrigeratorTesting
{
    /// <summary>
    /// Interaction logic for TableViewData.xaml
    /// </summary>
    public partial class TableViewData : Window
    {
        public TableViewData()
        {
            InitializeComponent();
        }

        private void winTableView_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void winTableView_Closed(object sender, EventArgs e)
        {
            App.Current.MainWindow.Show();
        }
    }
}
