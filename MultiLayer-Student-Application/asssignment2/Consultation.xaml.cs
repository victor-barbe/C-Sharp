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
using System.Data;
using business_Logic_Layer;
using System.Data;
using business_Logic_Layer;

namespace asssignment2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Consultation : Window
    {
        DataTable allCourses;

        public Consultation()
        {
            InitializeComponent();
            allCourses = business3.Select();

            foreach (DataRow course in allCourses.Rows)
            {
                ComboBox1.Items.Add(course["CourseID"].ToString());
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
