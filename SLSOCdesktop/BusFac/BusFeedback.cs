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
    public partial class BusFeedback : Form
    {
        public BusFeedback()
        {
            InitializeComponent();
            TableLoad();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Feedbacks panel");
        }

        void TableLoad()
        {
            List<Feedbacksc> modl = new List<Feedbacksc>();
            Service3Client service = new Service3Client();

            dataGridView1.DataSource = service.GetBusFeedbacks();
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusLecstu Lecstuform = new BusFac.BusLecstu();
            Lecstuform.ShowDialog();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }
    }
}
