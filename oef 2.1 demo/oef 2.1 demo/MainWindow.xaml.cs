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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oef_2._1_demo
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content = "ja";
            labelB.Content = "ja";
            labelC.Content = "ja";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content = "nee";
            labelB.Content = "nee";
            labelC.Content = "nee";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content = "A";
            labelB.Content = "B";
            labelC.Content = "C";
        }
    }
}
