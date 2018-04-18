using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLSOCdesktop.ServiceReference2;

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
            Service2Client service = new Service2Client();

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

            Service2Client service = new Service2Client();
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

            Service2Client service = new Service2Client();
            stus.Add(service.SearchStudents(ts));
            dataGridView2.DataSource = stus;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComAcademic Acform = new ComFac.ComAcademic();
            Acform.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComTimetable Tform = new ComFac.ComTimetable();
            Tform.ShowDialog();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComFeedbacks Fbform = new ComFac.ComFeedbacks();
            Fbform.ShowDialog();
        }
    }
}
