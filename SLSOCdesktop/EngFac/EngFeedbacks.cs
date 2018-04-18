using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLSOCdesktop.EngFac
{
    public partial class EngFeedbacks : Form
    {
        public EngFeedbacks()
        {
            InitializeComponent();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Feedback panel");
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
