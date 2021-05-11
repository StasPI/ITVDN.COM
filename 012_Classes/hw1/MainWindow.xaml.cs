﻿using System;
using System.Windows;

// View

namespace hw1
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler myEvent = null;


        //public EventHandler MyEvent { get; internal set; }
        public event EventHandler MyEvent
        {
           add { myEvent += value; }
           remove { myEvent -= value; }
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvent.Invoke(sender, e);
        }
   }
}
