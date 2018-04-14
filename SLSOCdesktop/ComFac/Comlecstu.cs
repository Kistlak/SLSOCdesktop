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
            Studentsc t = new Studentsc();
            {
                t.Username = txtUsername.Text;
            };

            Service1Client service = new Service1Client();
            stus.Add(service.SearchStudents(t));
            dataGridView1.DataSource = stus;
        }
    }
}
