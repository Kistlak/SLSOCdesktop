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
    public partial class ComFeedbacks : Form
    {
        public ComFeedbacks()
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
            Service2Client service = new Service2Client();

            dataGridView1.DataSource = service.GetComFeedbacks();
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.Comlecstu Lecstuform = new ComFac.Comlecstu();
            Lecstuform.ShowDialog();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }
    }
}
