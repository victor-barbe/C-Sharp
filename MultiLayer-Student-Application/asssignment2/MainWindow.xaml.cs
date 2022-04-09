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

namespace asssignment2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        private void StudentClick(object sender, RoutedEventArgs e)
        {
            StudentManagment f1 = new StudentManagment();
            f1.ShowDialog();
        }

        private void GradeClick(object sender, RoutedEventArgs e)
        {
            GradeManagment f1 = new GradeManagment();
            f1.ShowDialog();
        }

        private void Consultation(object sender, RoutedEventArgs e)
        {
            Consultation f1 = new Consultation();
            f1.ShowDialog();
        }

            private void Exit(object sender, RoutedEventArgs e)
        {
            // Close(); 
            Close();

        }
    }
}
