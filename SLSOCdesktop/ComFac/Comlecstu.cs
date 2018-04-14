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

namespace SLSOCdesktop.ComFac
{
    public partial class Comlecstu : Form
    {
        public Comlecstu()
        {
            InitializeComponent();
            TableLoad();
        }

        private void btnStudnets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Lecturers and Student panel");
        }

        void TableLoad()
        {
            List<Lecturersc> modl = new List<Lecturersc>();
            Service1Client service = new Service1Client();

            dataGridView1.DataSource = service.GetComputingLecturers();
            dataGridView2.DataSource = service.GetComputingStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Lecturersc> sl = new List<Lecturersc>();
            Lecturersc t = new Lecturersc();
            {
                t.Username = txtUsername.Text;
            };

            Service1Client service = new Service1Client();
            sl.Add(service.SearchLecturers(t));
            dataGridView1.DataSource = sl;
        }

        private void btnStusearch_Click(object sender, EventArgs e)
        {
            List<Studentsc> stus = new List<Studentsc>();
            Studentsc ts = new Studentsc();
            {
                ts.Username = txtUsername.Text;
            };

            Service1Client service = new Service1Client();
            stus.Add(service.SearchStudents(ts));
            dataGridView2.DataSource = stus;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }
    }
}
