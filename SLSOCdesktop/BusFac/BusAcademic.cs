﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLSOCdesktop.ServiceReference3;
using System.Data.SqlClient;

namespace SLSOCdesktop.BusFac
{
    public partial class BusAcademic : Form
    {
        public BusAcademic()
        {
            InitializeComponent();
            BusLecs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Modulesc u = new Modulesc();

            Service3Client service = new Service3Client();
            u = service.SearchModules(txtModcode.Text);
            if (u != null)
            {
                txtModcode.Text = u.Modcode;
                txtModname.Text = u.Modname;
                cmbLecname.Text = u.Lecname;
            }

            else
            {
                MessageBox.Show("Invalid Mode Code !! Try Again !!");
            }
        }

        void TableLoad()
        {
            List<Modulesc> modl = new List<Modulesc>();
            Service3Client service = new Service3Client();

            dataGridView1.DataSource = service.GetComModules();
            dataGridView2.DataSource = service.GetComLecHalls();
            dataGridView3.DataSource = service.GetComLabs();
        }

        void BusLecs()
        {

            SqlConnection con = new SqlConnection(@"Data Source=KISTLAK;Initial Catalog=slsoc;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT fname FROM lecturers WHERE fac='Business';", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cmbLecname.ValueMember = "fname";
            cmbLecname.DisplayMember = "fname";
            cmbLecname.DataSource = dt;

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modulesc mdc = new Modulesc();

            mdc.Modcode = txtModcode.Text;
            mdc.Modname = txtModname.Text;
            mdc.Lecname = cmbLecname.Text;

            Service3Client service = new Service3Client();

            if (service.AddModules(mdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Modulesc ucm = new Modulesc();
            {
                ucm.Modcode = txtModcode.Text;
                ucm.Modname = txtModname.Text;
                ucm.Lecname = cmbLecname.Text;
            };

            Service3Client service = new Service3Client();
            if (service.UpdateComModules(ucm) == 1)
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
            Modulesc dcm = new Modulesc();
            {
                dcm.Modcode = txtModcode.Text;
            };

            Service3Client service = new Service3Client();
            if (service.DeleteComModules(dcm) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Academic panel");
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusLecstu Lecstuform = new BusFac.BusLecstu();
            Lecstuform.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusTimetable Tform = new BusFac.BusTimetable();
            Tform.ShowDialog();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusFeedback Fbform = new BusFac.BusFeedback();
            Fbform.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void btnLechallSearch_Click(object sender, EventArgs e)
        {
            Lechallsc u = new Lechallsc();

            Service3Client service = new Service3Client();
            u = service.SearchLecHalls(txtHcode.Text);
            if (u != null)
            {
                txtHcode.Text = u.Lechallcode;
                txtNumstu.Text = u.Numstu;
            }

            else
            {
                MessageBox.Show("Invalid Mode Code !! Try Again !!");
            }
        }

        private void btnLechallAdd_Click(object sender, EventArgs e)
        {
            Lechallsc lhdc = new Lechallsc();

            lhdc.Lechallcode = txtHcode.Text;
            lhdc.Numstu = txtNumstu.Text;

            Service3Client service = new Service3Client();

            if (service.AddLecHalls(lhdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnLechallUpdate_Click(object sender, EventArgs e)
        {
            Lechallsc uclh = new Lechallsc();
            {
                uclh.Lechallcode = txtHcode.Text;
                uclh.Numstu = txtNumstu.Text;
            };

            Service3Client service = new Service3Client();
            if (service.UpdateComlecHalls(uclh) == 1)
            {
                MessageBox.Show("Successfully Updated");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnLechallDelete_Click(object sender, EventArgs e)
        {
            Lechallsc dclh = new Lechallsc();
            {
                dclh.Lechallcode = txtHcode.Text;
            };

            Service3Client service = new Service3Client();
            if (service.DeleteComLecHalls(dclh) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Labsc u = new Labsc();

            Service3Client service = new Service3Client();
            u = service.SearchLabs(txtLabcode.Text);
            if (u != null)
            {
                txtLabcode.Text = u.Labcode;
                txtLabnumstu.Text = u.Numstu;
            }

            else
            {
                MessageBox.Show("Invalid Mode Code !! Try Again !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Labsc lbdc = new Labsc();

            lbdc.Labcode = txtLabcode.Text;
            lbdc.Numstu = txtLabnumstu.Text;

            Service3Client service = new Service3Client();

            if (service.AddLabs(lbdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Labsc uclb = new Labsc();
            {
                uclb.Labcode = txtLabcode.Text;
                uclb.Numstu = txtLabnumstu.Text;
            };

            Service3Client service = new Service3Client();
            if (service.UpdateComLabs(uclb) == 1)
            {
                MessageBox.Show("Successfully Updated");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Labsc dclb = new Labsc();
            {
                dclb.Labcode = txtLabcode.Text;
            };

            Service3Client service = new Service3Client();
            if (service.DeleteComLabs(dclb) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }
    }
}
