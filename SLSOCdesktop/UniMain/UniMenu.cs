using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLSOCdesktop.UniMain
{
    public partial class UniMenu : Form
    {
        public UniMenu()
        {
            InitializeComponent();
        }

        private void btnLectures_Click(object sender, EventArgs e)
        {
            this.Hide();
            UniMain.Lecturers unimenuform = new UniMain.Lecturers();
            unimenuform.ShowDialog();
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
    }
}
