﻿using System;
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
    /// Interaction logic for RefrigeratorReport.xaml
    /// </summary>
    public partial class RefrigeratorReport : Window
    {
        public RefrigeratorReport()
        {
            InitializeComponent();
        }

        private void winRefrigeratorReport_Closed(object sender, EventArgs e)
        {
            App.Current.MainWindow.Show();
        }
    }
}
