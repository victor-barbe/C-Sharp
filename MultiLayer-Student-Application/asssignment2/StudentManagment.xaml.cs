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

namespace asssignment2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class StudentManagment : Window
    {
        DataTable allStudents;
        DataTable allGrades;
        DataTable allCourses;
        public StudentManagment()
        {
            InitializeComponent();
            allStudents = business.Select();
            allGrades = business2.Select();
            allCourses = business3.Select();

            foreach (DataRow student in allStudents.Rows)
            {
                comboBox1.Items.Add(student["StudentID"].ToString());
            }

            foreach (DataRow course in allCourses.Rows)
            {
                comboBox2.Items.Add(course["CourseID"].ToString());
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            // Close(); 
            Close();

        }

        private void New(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (DataRow student in allStudents.Rows)
            {
                if (comboBox1.SelectedValue.ToString().Equals(student["StudentID"].ToString()))
                {
                    textBox1.Text = student["Name"].ToString() + " " + student["Family"].ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    business2.Insert(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), textBox2.Text);
                    MessageBox.Show("Grade added");
                }
                else
                {
                    MessageBox.Show("ID is required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (DataRow grade in allGrades.Rows)
                {
                    if (comboBox1.SelectedValue.ToString().Equals(grade["StudentID"].ToString()) && comboBox2.SelectedValue.ToString().Equals(grade["CourseID"].ToString()))
                    {
                        DataRow transferRow = grade;
                        transferRow["StudentID"] = comboBox1.SelectedValue;
                        transferRow["CourseID"] = comboBox2.SelectedValue;
                        transferRow["Grade"] = textBox2.Text;
                        business2.Update(transferRow);
                        MessageBox.Show("grade modified");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                foreach (DataRow grade in allGrades.Rows)
                {
                    if (comboBox1.SelectedValue.ToString().Equals(grade["StudentID"].ToString()) && comboBox2.SelectedValue.ToString().Equals(grade["CourseID"].ToString()))
                    {
                        textBox2.Text = grade["Grade"].ToString();
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            List.DataContext = allGrades.DefaultView;

            string filter = "StudentID = '" + comboBox1.SelectedItem?.ToString() + "'";

            DataView dv = new DataView(allGrades, filter, null, DataViewRowState.CurrentRows);
            List.ItemsSource = dv;
        }
    }
}
