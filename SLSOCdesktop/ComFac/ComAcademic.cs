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
            // TODO: This line of code loads data into the 'slsocDataSet8.labs' table. You can move, or remove it, as needed.
            this.labsTableAdapter1.Fill(this.slsocDataSet8.labs);
            // TODO: This line of code loads data into the 'slsocDataSet7.labs' table. You can move, or remove it, as needed.
            this.labsTableAdapter.Fill(this.slsocDataSet7.labs);
            // TODO: This line of code loads data into the 'slsocDataSet6.lechalls' table. You can move, or remove it, as needed.
            this.lechallsTableAdapter.Fill(this.slsocDataSet6.lechalls);
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
            dataGridView2.DataSource = service.GetComLecHalls();
            dataGridView3.DataSource = service.GetComLabs();
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

        private void btnLecHallUpdate_Click(object sender, EventArgs e)
        {
            Lechallsc uclh = new Lechallsc();
            {
                uclh.Lechallcode = txtHcode.Text;
                uclh.Numstu = txtNumstu.Text;
            };

            Service2Client service = new Service2Client();
            if (service.UpdateComlecHalls(uclh) == 1)
            {
                MessageBox.Show("Successfully Updated");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnLechallSearch_Click(object sender, EventArgs e)
        {
            Lechallsc u = new Lechallsc();

            Service2Client service = new Service2Client();
            u = service.SearchLecHalls(txtHcode.Text);
            if (u != null)
            {
                txtHcode.Text = u.Lechallcode;
                txtNumstu.Text = u.Numstu;
            }

            else
            {
                MessageBox.Show("Invalid Mode Code !! Try Again !!");
            }
        }

        private void btnLechallAdd_Click(object sender, EventArgs e)
        {
            Lechallsc lhdc = new Lechallsc();

            lhdc.Lechallcode = txtHcode.Text;
            lhdc.Numstu = txtNumstu.Text;

            Service2Client service = new Service2Client();

            if (service.AddLecHalls(lhdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void btnLechallDelete_Click(object sender, EventArgs e)
        {
            Lechallsc dclh = new Lechallsc();
            {
                dclh.Lechallcode = txtHcode.Text;
            };

            Service2Client service = new Service2Client();
            if (service.DeleteComLecHalls(dclh) == 1)
            {
                MessageBox.Show("Successfully Deleted");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtHcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modulesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLecname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecturersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lecturersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtModname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtModcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComFeedbacks Fbform = new ComFac.ComFeedbacks();
            Fbform.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComTimetable Tform = new ComFac.ComTimetable();
            Tform.ShowDialog();
        }

        private void btnLecstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.Comlecstu Lecstuform = new ComFac.Comlecstu();
            Lecstuform.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Academic panel");
        }

        private void lecturersBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lecturersBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumstu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lechallsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Labsc u = new Labsc();

            Service2Client service = new Service2Client();
            u = service.SearchLabs(txtLabcode.Text);
            if (u != null)
            {
                txtLabcode.Text = u.Labcode;
                txtLabnumstu.Text = u.Numstu;
            }

            else
            {
                MessageBox.Show("Invalid Mode Code !! Try Again !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Labsc lbdc = new Labsc();

            lbdc.Labcode = txtLabcode.Text;
            lbdc.Numstu = txtLabnumstu.Text;

            Service2Client service = new Service2Client();

            if (service.AddLabs(lbdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Labsc uclb = new Labsc();
            {
                uclb.Labcode = txtLabcode.Text;
                uclb.Numstu = txtLabnumstu.Text;
            };

            Service2Client service = new Service2Client();
            if (service.UpdateComLabs(uclb) == 1)
            {
                MessageBox.Show("Successfully Updated");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Labsc dclb = new Labsc();
            {
                dclb.Labcode = txtLabcode.Text;
            };

            Service2Client service = new Service2Client();
            if (service.DeleteComLabs(dclb) == 1)
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
