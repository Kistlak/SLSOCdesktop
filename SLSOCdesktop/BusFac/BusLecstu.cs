using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLSOCdesktop.ServiceReference3;

namespace SLSOCdesktop.BusFac
{
    public partial class BusLecstu : Form
    {
        public BusLecstu()
        {
            InitializeComponent();
            TableLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Lecturersc> sl = new List<Lecturersc>();
            Lecturersc t = new Lecturersc();
            {
                t.Username = txtUsername.Text;
            };

            Service3Client service = new Service3Client();
            sl.Add(service.SearchLecturers(t));
            dataGridView1.DataSource = sl;
        }

        void TableLoad()
        {
            List<Lecturersc> modl = new List<Lecturersc>();
            Service3Client service = new Service3Client();

            dataGridView1.DataSource = service.GetBusinessLecturers();
            dataGridView2.DataSource = service.GetBusinessStudents();
        }

        private void btnStusearch_Click(object sender, EventArgs e)
        {
            List<Studentsc> stus = new List<Studentsc>();
            Studentsc ts = new Studentsc();
            {
                ts.Username = txtUsername.Text;
            };

            Service3Client service = new Service3Client();
            stus.Add(service.SearchStudents(ts));
            dataGridView2.DataSource = stus;
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Lecture and Student panel");
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusAcademic Acform = new BusFac.BusAcademic();
            Acform.ShowDialog();
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
    }
}
