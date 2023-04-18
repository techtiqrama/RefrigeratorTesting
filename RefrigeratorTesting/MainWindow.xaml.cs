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

namespace RefrigeratorTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void btnTableView_Click(object sender, RoutedEventArgs e)
        {
            TableViewData tableViewData = new TableViewData();
            this.Hide();
            tableViewData.Show();
        }

        private void btnGraphView_Click(object sender, RoutedEventArgs e)
        {
            GraphViewData graphViewData = new GraphViewData();
            this.Hide();
            graphViewData.Show();
        }

        private void btnTestInfo_Click(object sender, RoutedEventArgs e)
        {
            TestInformation testInformation = new TestInformation();
            this.Hide();
            testInformation.Show();
        }

        private void btnRefFreezerReport_Click(object sender, RoutedEventArgs e)
        {
            RefrigeratorFreezerReport refrigeratorFreezerReport = new RefrigeratorFreezerReport();
            this.Hide();
            refrigeratorFreezerReport.Show();
        }

        private void btnRefrigeratorReport_Click(object sender, RoutedEventArgs e)
        {
            RefrigeratorReport refrigeratorReport = new RefrigeratorReport();
            this.Hide();
            refrigeratorReport.Show();
        }

        private void btnFreezerReport_Click(object sender, RoutedEventArgs e)
        {
            FreezerReport freezerReport = new FreezerReport();
            this.Hide();
            freezerReport.Show();
        }

        private void btnGlobalSettings_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings globalSettings = new GlobalSettings();
            this.Hide();
            globalSettings.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HomeWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you really want to Exit?", "Exit Confirmation!",MessageBoxButton.YesNo,MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel=true;
            }
        }
    }
}
