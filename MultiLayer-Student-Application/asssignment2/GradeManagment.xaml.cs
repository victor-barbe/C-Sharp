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
using business_Logic_Layer;

using System.Data;
namespace asssignment2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class GradeManagment : Window
    {
        int indexStudent;
            
        DataTable allStudents;
        public GradeManagment()
        {
            InitializeComponent();
            indexStudent = 0;

            try
            {
                allStudents = business.Select();
                //MessageBox.Show(allStudents.Rows[0]["StudentID"].ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
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
            textBox3.Text = "";
            datePicker1.Text = "";
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            foreach (DataRow student in allStudents.Rows)
            {
                if (textBox1.Text.Equals(student["StudentID"].ToString()))
                {
                    textBox1.Text = student["StudentID"].ToString();
                    textBox3.Text = student["Name"].ToString();
                    textBox2.Text = student["Family"].ToString();
                    datePicker1.SelectedDate = (DateTime)student["BirthDate"];
                    return;
                }
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    business.Insert(allStudents.Rows.Add(new Object[] { textBox1.Text, textBox3.Text, textBox2.Text, datePicker1.SelectedDate }));
                    MessageBox.Show("Student added");
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

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    foreach(DataRow student in allStudents.Rows)
                    {
                        if (student["StudentID"].ToString() == textBox1.Text)
                        {
                            DataRow transferRow = student;
                            transferRow["Name"] = textBox3.Text;
                            transferRow["Family"] = textBox2.Text;
                            transferRow["BirthDate"] = datePicker1.SelectedDate;
                            business.Update(transferRow);
                            MessageBox.Show("Student modified");

                        }
                    }
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    foreach (DataRow student in allStudents.Rows)
                    {
                        if (student["StudentID"].ToString() == textBox1.Text)
                        {
                            business.Delete(student["StudentID"].ToString());
                            MessageBox.Show("Student deleted");
                            allStudents = business.Select();
                            return;
                        }
                    }
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                indexStudent = 0;
                textBox1.Text = allStudents.Rows[indexStudent]["StudentID"].ToString();
                textBox2.Text = allStudents.Rows[indexStudent]["Family"].ToString();
                textBox3.Text = allStudents.Rows[indexStudent]["Name"].ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {

                if (indexStudent > 0)
                {
                    indexStudent--;
                }
                textBox1.Text = allStudents.Rows[indexStudent]["StudentID"].ToString();
                textBox2.Text = allStudents.Rows[indexStudent]["Family"].ToString();
                textBox3.Text = allStudents.Rows[indexStudent]["Name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (indexStudent < allStudents.Rows.Count - 1)
                {
                    indexStudent++;
                }
                textBox1.Text = allStudents.Rows[indexStudent]["StudentID"].ToString();
                textBox2.Text = allStudents.Rows[indexStudent]["Family"].ToString();
                textBox3.Text = allStudents.Rows[indexStudent]["Name"].ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                indexStudent = allStudents.Rows.Count - 1;

                textBox1.Text = allStudents.Rows[indexStudent]["StudentID"].ToString();
                textBox2.Text = allStudents.Rows[indexStudent]["Family"].ToString();
                textBox3.Text = allStudents.Rows[indexStudent]["Name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
