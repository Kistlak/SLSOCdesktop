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
    public partial class EngMenu : Form
    {
        public EngMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngLecstu form = new EngFac.EngLecstu();
            form.ShowDialog();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngAcademic form = new EngFac.EngAcademic();
            form.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngTimetable form = new EngFac.EngTimetable();
            form.ShowDialog();
        }

        private void btnStufeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngFac.EngFeedbacks form = new EngFac.EngFeedbacks();
            form.ShowDialog();
        }
    }
}
