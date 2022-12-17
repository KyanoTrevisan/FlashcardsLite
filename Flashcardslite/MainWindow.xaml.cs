using System.Windows;

namespace Flashcardslite
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

        private void CreateFlashcardsSetButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            ModifySets modifySetWindow = new ModifySets(this);
            modifySetWindow.Show();
        }

        private void StudyFlashcardSetsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            StudySets studySetsWindow = new StudySets(this);
            studySetsWindow.Show();
        }

        private void QuitApplicationButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
