using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLSOCdesktop.ServiceReference4;

namespace SLSOCdesktop.EngFac
{
    public partial class EngLecstu : Form
    {
        public EngLecstu()
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

            Service4Client service = new Service4Client();
            sl.Add(service.SearchLecturers(t));
            dataGridView1.DataSource = sl;
        }

        void TableLoad()
        {
            List<Lecturersc> modl = new List<Lecturersc>();
            Service4Client service = new Service4Client();

            dataGridView1.DataSource = service.GetEngineeringLecturers();
            dataGridView2.DataSource = service.GetEngineeringStudents();
        }

        private void btnStusearch_Click(object sender, EventArgs e)
        {
            List<Studentsc> stus = new List<Studentsc>();
            Studentsc ts = new Studentsc();
            {
                ts.Username = txtUsername.Text;
            };

            Service4Client service = new Service4Client();
            stus.Add(service.SearchStudents(ts));
            dataGridView2.DataSource = stus;
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Lecture and Student panel");
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
            EngFac.EngAcademic Acform = new EngFac.EngAcademic();
            Acform.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngTimetable Tform = new EngFac.EngTimetable();
            Tform.ShowDialog();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngFeedbacks Fbform = new EngFac.EngFeedbacks();
            Fbform.ShowDialog();
        }
    }
}
