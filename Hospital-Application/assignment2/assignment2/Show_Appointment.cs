using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace assignment2
{
    public partial class Show_Appointment : Form
    {
        SqlConnection Connection;

        public Show_Appointment()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = ""; 
            // clear the datagridview
            dataGridView1.DataSource = null; 
        }

        private void button1_Click(object sender, EventArgs e)
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
                  textBox3.Text = dataReader["PatientAddress"].ToString();
                  maskedTextBox1.Text = dataReader["BirthDate"].ToString();                
                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }


            try
            {
                Connection.Open();
                SqlCommand cmd2 = new SqlCommand();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                CurrencyManager cr;
                
                string query2 = "select * from Appointments where PatientId = '" + textBox1.Text + "'";
                cmd.CommandText = query2;
                cmd.Connection = Connection;

                dataAdapter.SelectCommand = cmd;
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "Appointments");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("datasource", dataSet, "Appointments");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Appointments.AppointmentCode");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Appointments.AppointmentDate");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Appointments.AppointmentTime");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Appointments.DoctorId");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Appointments.PatientId");

                cr = (CurrencyManager)this.BindingContext[dataSet, "Appointments"];

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }
        }

        private void Show_Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
