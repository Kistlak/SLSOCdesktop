using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLSOCdesktop.ServiceReference1;

namespace SLSOCdesktop.UniMain
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Studentsc sdc = new Studentsc();

            sdc.Fname = txtFname.Text;
            sdc.Lname = txtLname.Text;
            sdc.Adone = txtAdone.Text;
            sdc.Adtwo = txtAddtwo.Text;
            sdc.City = txtCity.Text;
            sdc.Number = txtNum.Text;
            sdc.Byear = dateTimePicker2.Value.ToString();
            sdc.Nic = txtNic.Text;
            sdc.Faculty = cmbFac.SelectedItem.ToString();
            sdc.Jdate = dateTimePicker1.Value.ToString();
            sdc.Username = txtUsername.Text;
            sdc.Password = txtPassword.Text;

            Service1Client service = new Service1Client();

            if (service.SaveStudents(sdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        void TableLoad()
        {
            List<Studentsc> modl = new List<Studentsc>();
            Service1Client service = new Service1Client();

            dataGridView1.DataSource = service.GetStudentsDetails();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Studentsc> stus = new List<Studentsc>();
            Studentsc t = new Studentsc();
            {
                t.Username = txtUsername.Text;
            };

            Service1Client service = new Service1Client();
            stus.Add(service.SearchStudents(t));
            dataGridView1.DataSource = stus;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Studentsc us = new Studentsc();
            {
                us.Fname = txtFname.Text;
                us.Lname = txtLname.Text;
                us.Adone = txtAdone.Text;
                us.Adtwo = txtAddtwo.Text;
                us.City = txtCity.Text;
                us.Number = txtNum.Text;
                us.Nic = txtNic.Text;
                us.Username = txtUsername.Text;
                us.Password = txtPassword.Text;
            };

            Service1Client service = new Service1Client();
            if (service.UpdateStudents(us) == 1)
            {
                MessageBox.Show("Successfully Updated");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Studentsc dstu = new Studentsc();
            {
                dstu.Username = txtUsername.Text;
            };

            Service1Client service = new Service1Client();
            if (service.DeleteStudents(dstu) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slsocDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.slsocDataSet1.students);

        }
    }
}
