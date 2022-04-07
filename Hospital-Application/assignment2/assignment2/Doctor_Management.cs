using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assignment2
{
    public partial class Doctor_Management : Form
    {
        SqlConnection Connection;
        public Doctor_Management()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");

            string query = "select DoctorSpecialism from Doctors";
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBox1.Items.Add(dataReader["DoctorSpecialism"].ToString());
                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Doctor_Management_Load(object sender, EventArgs e)
        {

        }

        // New
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        // Search
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select * from Doctors where DoctorId =" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    textBox2.Text = dataReader["DoctorName"].ToString();
                    textBox3.Text = dataReader["DoctorTel"].ToString();
                    dateTimePicker1.Value = (DateTime)dataReader["HiringDate"];
                    comboBox1.Text = dataReader["DoctorSpecialism"].ToString();
                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }
        }

        // Add
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != ""  && comboBox1.Text != "" && textBox3.Text.Length == 10)
            {
                string query = "insert into Doctors values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + comboBox1.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong informations, please try again");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text.Length == 10 && comboBox1.Text != "")
            {
                if (MessageBox.Show("", "You're going to edit this doctor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string query = "update Doctors set DoctorName = '" + textBox2.Text + "', DoctorTel = '" + textBox3.Text + "', HiringDate = '" + dateTimePicker1.Value + "', DoctorSpecialism = '" + comboBox1.Text + "' where DoctorId =" + textBox1.Text;
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    try
                    {
                        Connection.Open();
                        cmd.ExecuteNonQuery();
                        Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Connection.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong informations, please try again"); 
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "You're going to close this page", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("", "You're going to delete this doctor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query2 = "delete from Appointments where DoctorId =" + textBox1.Text;
                SqlCommand cmd2 = new SqlCommand(query2, Connection);

                try
                {
                    Connection.Open();
                    cmd2.ExecuteNonQuery();
                    Connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string query = "delete from Doctors where DoctorId =" + textBox1.Text;
                SqlCommand cmd = new SqlCommand(query, Connection);
                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show("Doctor with Id n°" + textBox1.Text + " successfuly deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
