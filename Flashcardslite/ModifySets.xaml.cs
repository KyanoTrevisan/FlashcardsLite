using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using SQLite;
using System.Windows.Controls;
using System.Linq;

namespace Flashcardslite
{
    public partial class ModifySets : Window
    {

        private MainWindow mainWindow;

        public ModifySets(MainWindow mainWindow)
        {
            InitializeComponent();


            this.mainWindow = mainWindow;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }


    }





}
