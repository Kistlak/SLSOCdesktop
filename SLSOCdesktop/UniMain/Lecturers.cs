﻿using System;
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
    public partial class Lecturers : Form
    {
        public Lecturers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Lecturersc ldc = new Lecturersc();

            ldc.Fname = txtFname.Text;
            ldc.Lname = txtLname.Text;
            ldc.Adone = txtAdone.Text;
            ldc.Adtwo = txtAddtwo.Text;
            ldc.City = txtCity.Text;
            ldc.Number = txtNum.Text;
            ldc.Faculty = cmbFac.SelectedItem.ToString();
            ldc.Moduleone = txtModone.Text;
            ldc.Moduletwo = txtModtwo.Text;
            ldc.Modulethree = txtModthree.Text;
            ldc.Jdate = dateTimePicker1.Value.ToString();
            ldc.Rdate = dateTimePicker2.Text;
            ldc.Username = txtUsername.Text;
            ldc.Password = txtPassword.Text;

            Service1Client service = new Service1Client();

            if (service.SaveLecturers(ldc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void Lecturers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slsocDataSet.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.slsocDataSet.lecturers);

        }

        void TableLoad()
        {
            List<Lecturersc> modl = new List<Lecturersc>();
            Service1Client service = new Service1Client();

            dataGridView1.DataSource = service.GetLecturersDetails();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Lecturersc u = new Lecturersc();

            Service1Client service = new Service1Client();
            u = service.SearchLecsForm(txtUsername.Text);
            if (u != null)
            {
                txtFname.Text = u.Fname;
                txtLname.Text = u.Lname;
                txtAdone.Text = u.Adone;
                txtAddtwo.Text = u.Adtwo;
                txtCity.Text = u.City;
                txtNum.Text = u.Number;
                cmbFac.Text = u.Faculty;
                txtModone.Text = u.Moduleone;
                txtModtwo.Text = u.Moduletwo;
                txtModthree.Text = u.Modulethree;
                dateTimePicker1.Text = u.Jdate;
                dateTimePicker2.Text = u.Rdate;
                txtUsername.Text = u.Username;
                txtPassword.Text = u.Password;
            }

            else
            {
                MessageBox.Show("Invalid Username !! Try Again !!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lecturersc ul = new Lecturersc();
            {
                ul.Username = txtUsername.Text;
                ul.Fname = txtFname.Text;
                ul.Lname = txtLname.Text;
                ul.Adone = txtLname.Text;
                ul.Adtwo = txtLname.Text;
                ul.City = txtLname.Text;
                ul.Number = txtLname.Text;
                ul.Moduleone = txtModone.Text;
                ul.Moduletwo = txtModtwo.Text;
                ul.Modulethree = txtModthree.Text;
                ul.Rdate = dateTimePicker2.Value.ToString();
                ul.Password = txtLname.Text;
            };

            Service1Client service = new Service1Client();
            if (service.UpdateLecturers(ul) == 1)
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
            Lecturersc dlec = new Lecturersc();
            {
                dlec.Username = txtUsername.Text;
            };

            Service1Client service = new Service1Client();
            if (service.DeleteLecturers(dlec) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Lecturer Panel");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            UniMain.Students stuform = new UniMain.Students();
            stuform.ShowDialog();
        }
    }
}
