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

namespace SLSOCdesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users udc = new Users();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            { MessageBox.Show("fill all fields and try again"); }

            else
            {
                udc.Username = txtUsername.Text;
                udc.Password = txtPassword.Text;

                Service1Client service = new Service1Client();
                if (service.Login(udc) == 1)
                {
                    if (txtUsername.Text == "uniadmin")
                    {
                        this.Hide();
                        UniMain.UniMenu uniregform = new UniMain.UniMenu();
                        uniregform.ShowDialog();
                    }
                    else if (txtUsername.Text == "foc")
                    {
                        this.Hide();
                        ComFac.ComMenu comform = new ComFac.ComMenu();
                        comform.ShowDialog();
                    }
                    else if (txtUsername.Text == "fob")
                    {
                        this.Hide();
                        BusFac.BusMenu busform = new BusFac.BusMenu();
                        busform.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        EngFac.EngMenu engform = new EngFac.EngMenu();
                        engform.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Your Username and Password !!");
                }
            }
        }


    }
}
