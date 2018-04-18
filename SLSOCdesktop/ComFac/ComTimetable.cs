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
    public partial class ComTimetable : Form
    {
        public ComTimetable()
        {
            InitializeComponent();
            ComLecs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Timetablesc tdc = new Timetablesc();

            tdc.Date = dateTimePicker1.Text;
            tdc.Time = cmbTime.Text;
            tdc.Batch = cmbBatch.Text;
            tdc.Modcode = cmbModecode.Text;
            tdc.Lecname = cmbLecname.Text;
            tdc.Lechall = cmbLechall.Text;
            tdc.Lab = cmbLab.Text;

            Service2Client service = new Service2Client();

            if (service.AddTimetables(tdc) == 1)
            {
                MessageBox.Show("Successfully Saved");
                TableLoad();
            }
            else
            {
                MessageBox.Show("Error.. Please Try Again");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        void TableLoad()
        {
            List<Timetablesc> modl = new List<Timetablesc>();
            Service2Client service = new Service2Client();

            dataGridView1.DataSource = service.GetComTimetables();
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

            SqlCommand cdmode = new SqlCommand("SELECT modcode FROM modules WHERE fac='Computing';", con);
            SqlDataAdapter sdar = new SqlDataAdapter(cdmode);
            DataTable dtr = new DataTable();
            sdar.Fill(dtr);

            cmbModecode.ValueMember = "modcode";
            cmbModecode.DisplayMember = "modcode";
            cmbModecode.DataSource = dtr;

            con.Close();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are in Timetables panel");
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void ComTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slsocDataSet9.timetables' table. You can move, or remove it, as needed.
            this.timetablesTableAdapter.Fill(this.slsocDataSet9.timetables);

        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComFac.ComFeedbacks Fbform = new ComFac.ComFeedbacks();
            Fbform.ShowDialog();
        }
    }
}
