using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLSOCdesktop.BusFac
{
    public partial class BusMenu : Form
    {
        public BusMenu()
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

        private void btnLectures_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusLecstu form = new BusFac.BusLecstu();
            form.ShowDialog();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusAcademic form = new BusFac.BusAcademic();
            form.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusTimetable form = new BusFac.BusTimetable();
            form.ShowDialog();
        }

        private void btnStufeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusFac.BusFeedback form = new BusFac.BusFeedback();
            form.ShowDialog();
        }
    }
}
