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
    public partial class Appointment_Management : Form
    {
        SqlConnection Connection;
        public Appointment_Management()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");
            string query = "select PatientId from Patient";
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBox1.Items.Add(dataReader["PatientId"].ToString());
                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query2 = "select DoctorId from Doctors";
            SqlCommand cmd2 = new SqlCommand(query2, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader2 = cmd2.ExecuteReader();

                while (dataReader2.Read())
                {
                    comboBox2.Items.Add(dataReader2["DoctorId"].ToString());
                }
                Connection.Close();

            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Patient where PatientId = " + comboBox1.Text;
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    textBox1.Text = dataReader["PatientName"].ToString();
                    if (dataReader["PatientGender"].ToString() == "Masculine")
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = true; 
                    }
                    else if (dataReader["PatientGender"].ToString() == "Feminine")
                    {
                        radioButton2.Checked = false;
                        radioButton1.Checked = true; 
                    }
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Doctors where DoctorId = " + comboBox2.Text;
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    textBox2.Text = dataReader["DoctorName"].ToString();
                    textBox3.Text = dataReader["DoctorSpecialism"].ToString(); 
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "You're going to close this page", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = ""; 
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox1.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && maskedTextBox1 != null && dateTimePicker1.Value >= DateTime.Now)
            {
                //  string query = "insert into Appointments values (AppointmentDate = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', AppointmentTime = '" + TimeSpan.Parse(maskedTextBox1.Text) + "', DoctorId = '" + comboBox2.Text + "', PatientId = '" + comboBox1.Text + "')";
                // MessageBox.Show(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + comboBox1.Text + " " + comboBox2.Text + " " + dateTimePicker1.Value + " " + maskedTextBox1.Text); 
                // string query = "insert into Appointments values (AppointmentDate = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', AppointmentTime = '16:16', DoctorId = '100', PatientId = '666')";
                
                string query = "insert into Appointments (AppointmentDate, AppointmentTime, DoctorId, PatientId ) values ('" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "')";
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
                MessageBox.Show("Some fields are empty"); 
            }
            
        }

        private void Appointment_Management_Load(object sender, EventArgs e)
        {

        }
    }
}