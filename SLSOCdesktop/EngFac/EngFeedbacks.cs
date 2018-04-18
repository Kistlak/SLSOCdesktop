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
    public partial class EngFeedbacks : Form
    {
        public EngFeedbacks()
        {
            InitializeComponent();
            TableLoad();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Feedback panel");
        }

        void TableLoad()
        {
            List<Feedbacksc> modl = new List<Feedbacksc>();
            Service4Client service = new Service4Client();

            dataGridView1.DataSource = service.GetEngFeedbacks();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngLecstu Lecstuform = new EngFac.EngLecstu();
            Lecstuform.ShowDialog();
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
    }
}
