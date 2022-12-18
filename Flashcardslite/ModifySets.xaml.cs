using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace Flashcardslite
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
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
    }





}
