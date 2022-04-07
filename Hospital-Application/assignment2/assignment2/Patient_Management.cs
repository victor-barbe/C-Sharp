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
    public partial class Patient_Management : Form
    {
        SqlConnection Connection;

        public Patient_Management()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "You're going to edit this patient", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string gender = "";
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    if (radioButton1.Checked == true || radioButton2.Checked == true)
                    {

                        if (radioButton1.Checked == true)
                        {
                            gender = "Masculine";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            gender = "Feminine";
                        }
                        string query = "update Patient set PatientName = '" + textBox2.Text + "', PatientAddress = '" + textBox3.Text + "', BirthDate = '" + dateTimePicker1.Value + "', PatientGender = '" + gender + "' where PatientId = " + textBox1.Text;

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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = ""; 
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select * from Patient where PatientId = " + textBox1.Text;
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    textBox2.Text = dataReader["PatientName"].ToString();
                    dateTimePicker1.Value = (DateTime)dataReader["BirthDate"];
                    textBox3.Text = dataReader["PatientAddress"].ToString();

   
                    if (dataReader["PatientGender"].ToString().Equals("Masculine"))
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;

                    }
                    else if (dataReader["PatientGender"].ToString().Equals("Feminine"))
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;

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

        private void button3_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") {
                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {
                    if(radioButton1.Checked == true)
                    {
                        gender = "Masculine";
                    }
                    else if(radioButton2.Checked == true)
                    {
                        gender = "Feminine"; 
                    }

                    string query = "insert into Patient values ('" + textBox1.Text + "', '" + textBox2.Text + "',' " + textBox3.Text + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', '" + gender + "')";
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "You're going to delete this patient", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query2 = "delete from Appointments where PatientId =" + textBox1.Text;
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
                    Connection.Close();

                }

                string query = "delete from Patient where PatientId = " + textBox1.Text;
                SqlCommand cmd = new SqlCommand(query, Connection);
                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show("Patient with Id n°" + textBox1.Text + " successfuly deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.Close();

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "You're going to close this page", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
