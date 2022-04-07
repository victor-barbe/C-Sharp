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
    public partial class Show_All : Form
    {
        SqlConnection Connection;

        public Show_All()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand cmd = new SqlCommand();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                CurrencyManager cr;

                string query = "select * from Doctors";
                cmd.CommandText = query;
                cmd.Connection = Connection;

                dataAdapter.SelectCommand = cmd;
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "Doctors");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("datasource", dataSet, "Doctors");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Doctors.DoctorId");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Doctors.DoctorName");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Doctors.DoctorTel");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Doctors.HiringDate");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Doctors.DoctorSpecialism");
                dataGridView1.DataBindings.Clear();

                cr = (CurrencyManager)this.BindingContext[dataSet, "Doctors"];

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand cmd = new SqlCommand();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                CurrencyManager cr;

                string query = "select * from Patient";
                cmd.CommandText = query;
                cmd.Connection = Connection;

                dataAdapter.SelectCommand = cmd;
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "Patient");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("datasource", dataSet, "Patient");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Patient.PatientId");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Patient.PatientName");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Patient.PatientAddress");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Patient.BirthDate");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("text", dataSet, "Patient.PatientGender");
                dataGridView1.DataBindings.Clear();

                cr = (CurrencyManager)this.BindingContext[dataSet, "Patient"];
                Connection.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand cmd = new SqlCommand();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                CurrencyManager cr;

                string query = "select * from Appointments";
                cmd.CommandText = query;
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
                dataGridView1.DataBindings.Clear();

                cr = (CurrencyManager)this.BindingContext[dataSet, "Appointments"];
                Connection.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
