using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLSOCdesktop.ComFac
{
    public partial class ComMenu : Form
    {
        public ComMenu()
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
            ComFac.Comlecstu form = new ComFac.Comlecstu();
            form.ShowDialog();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComAcademic form = new ComFac.ComAcademic();
            form.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComTimetable form = new ComFac.ComTimetable();
            form.ShowDialog();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComFeedbacks form = new ComFac.ComFeedbacks();
            form.ShowDialog();
        }
    }
}
