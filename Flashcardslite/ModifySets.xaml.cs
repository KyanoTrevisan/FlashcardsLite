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
        List<StudySet> studysets;

        private MainWindow mainWindow;

        public ModifySets(MainWindow mainWindow)
        {
            InitializeComponent();

            studysets = new List<StudySet>();

            ReadDatabase();


            this.mainWindow = mainWindow;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StudySet studyset = new StudySet()
            {
                Term = termText.Text,
                Definition = definitionText.Text
            };

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<StudySet>();
                connection.Insert(studyset);
            }

            ReadDatabase();
            termText.Clear();
            definitionText.Clear();
        }

        void ReadDatabase()
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<StudySet>(); ;
                studysets = (conn.Table<StudySet>().ToList()).ToList();
            }

            if (studysets != null)
            {
                StudySetListBox.ItemsSource = studysets;
            }
        }
    }
}
