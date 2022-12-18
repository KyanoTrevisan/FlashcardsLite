using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using SQLite;

namespace Flashcardslite
{
    public partial class StudySets : Window
    {
        List<StudySet> studysets;

        private MainWindow mainWindow;
        public StudySets(MainWindow mainWindow)
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

        void ReadDatabase()
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<StudySet>(); ;
                studysets = (conn.Table<StudySet>().ToList()).ToList();
            }
        }
    }
}
