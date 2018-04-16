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
using System.Data.SqlClient;

namespace SLSOCdesktop.ComFac
{
    public partial class ComAcademic : Form
    {
        public ComAcademic()
        {
            InitializeComponent();
            ComLecs();
        }

        private void ComAcademic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slsocDataSet5.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter3.Fill(this.slsocDataSet5.lecturers);
            // TODO: This line of code loads data into the 'slsocDataSet4.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter2.Fill(this.slsocDataSet4.lecturers);
            // TODO: This line of code loads data into the 'slsocDataSet3.modules' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.slsocDataSet3.modules);
            // TODO: This line of code loads data into the 'slsocDataSet2.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter1.Fill(this.slsocDataSet2.lecturers);
            // TODO: This line of code loads data into the 'slsocDataSet.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.slsocDataSet.lecturers);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modulesc mdc = new Modulesc();

            mdc.Modcode = txtModcode.Text;
            mdc.Modname = txtModname.Text;
            mdc.Lecname = cmbLecname.Text;

            Service2Client service = new Service2Client();

            if (service.AddModules(mdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        void ComLecs()
        {
 
            SqlConnection con = new SqlConnection(@"Data Source=KISTLAK;Initial Catalog=slsoc;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT fname FROM lecturers WHERE fac='Computing';", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cmbLecname.ValueMember = "fname";
            cmbLecname.DisplayMember = "fname";
            cmbLecname.DataSource = dt;

            con.Close();
        }

        void TableLoad()
        {
            List<Modulesc> modl = new List<Modulesc>();
            Service2Client service = new Service2Client();

            dataGridView1.DataSource = service.GetComModules();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Modulesc u = new Modulesc();

            Service2Client service = new Service2Client();
            u = service.SearchModules(txtModcode.Text);
            if (u != null)
            {
                txtModcode.Text = u.Modcode;
                txtModname.Text = u.Modname;
                cmbLecname.Text = u.Lecname;
            }

            else
            {
                MessageBox.Show("Invalid Mode Code !! Try Again !!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Modulesc ucm = new Modulesc();
            {
                ucm.Modcode = txtModcode.Text;
                ucm.Modname = txtModname.Text;
                ucm.Lecname = cmbLecname.Text;
            };

            Service2Client service = new Service2Client();
            if (service.UpdateComModules(ucm) == 1)
            {
                MessageBox.Show("Successfully Updated");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Modulesc dcm = new Modulesc();
            {
                dcm.Modcode = txtModcode.Text;
            };

            Service2Client service = new Service2Client();
            if (service.DeleteComModules(dcm) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }
    }
}
