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
    public partial class Search_Appointment : Form
    {
        SqlConnection Connection;

        public Search_Appointment()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            try
            {
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                CurrencyManager cr;

                string query = "select * from Appointments where AppointmentDate = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";
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

                cr = (CurrencyManager)this.BindingContext[dataSet, "Appointments"];

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // textBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            string docID = dataGridView1.Rows[0].Cells[2].Value.ToString();
            string query = "select * from Doctors where DoctorId = '" + docID + "'";

            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    // textBox2.Text = dataReader["DoctorName"].ToString();
                    textBox2.Text = "Salut";
                }
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();

            }
        }

        private void Search_Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
