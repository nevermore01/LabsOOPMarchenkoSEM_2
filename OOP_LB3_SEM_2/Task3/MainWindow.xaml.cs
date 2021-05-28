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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private event EventHandler _myEvent;
        public event EventHandler MyEvent
        {
            add => _myEvent += value;
            remove => _myEvent -= value;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _myEvent?.Invoke(sender,e);
        }
    }
}