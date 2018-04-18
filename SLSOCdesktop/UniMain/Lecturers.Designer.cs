namespace SLSOCdesktop.UniMain
{
    partial class Lecturers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddtwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.slsocDataSet = new SLSOCdesktop.slsocDataSet();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersTableAdapter = new SLSOCdesktop.slsocDataSetTableAdapters.lecturersTableAdapter();
            this.txtModtwo = new System.Windows.Forms.TextBox();
            this.txtModone = new System.Windows.Forms.TextBox();
            this.txtModthree = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adtwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modtwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modthreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.compositeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slsocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Faculty :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLecturers);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 37);
            this.panel1.TabIndex = 34;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1249, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 31);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.BackColor = System.Drawing.Color.Red;
            this.btnLecturers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturers.ForeColor = System.Drawing.Color.White;
            this.btnLecturers.Location = new System.Drawing.Point(5, 3);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(96, 31);
            this.btnLecturers.TabIndex = 0;
            this.btnLecturers.Text = "Lecturers";
            this.btnLecturers.UseVisualStyleBackColor = false;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(107, 3);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(96, 31);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(875, 188);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(431, 32);
            this.txtNum.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Mobile Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "City :";
            // 
            // txtAddtwo
            // 
            this.txtAddtwo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddtwo.Location = new System.Drawing.Point(875, 124);
            this.txtAddtwo.Name = "txtAddtwo";
            this.txtAddtwo.Size = new System.Drawing.Size(431, 32);
            this.txtAddtwo.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Address Line 2 :";
            // 
            // txtAdone
            // 
            this.txtAdone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdone.Location = new System.Drawing.Point(206, 124);
            this.txtAdone.Name = "txtAdone";
            this.txtAdone.Size = new System.Drawing.Size(431, 32);
            this.txtAdone.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Address Line 1 :";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(206, 65);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(431, 32);
            this.txtFname.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(704, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Modules :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 683);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 13);
            this.panel2.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1230, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "SLSOC Lectures © 2018";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(837, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 44);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(206, 362);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(431, 32);
            this.txtUsername.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 56;
            this.label10.Text = "Username :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(875, 362);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(431, 32);
            this.txtPassword.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(704, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Password :";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(875, 65);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(431, 32);
            this.txtLname.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(704, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 23);
            this.label12.TabIndex = 60;
            this.label12.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "City :";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(206, 185);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(431, 32);
            this.txtCity.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 23);
            this.label13.TabIndex = 62;
            this.label13.Text = "Joined Date :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(703, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 23);
            this.label14.TabIndex = 64;
            this.label14.Text = "Resigned Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 32);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 13, 15, 29, 51, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " ";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(875, 303);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(431, 32);
            this.dateTimePicker2.TabIndex = 67;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cmbFac
            // 
            this.cmbFac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Items.AddRange(new object[] {
            "Computing",
            "Business",
            "Engineering"});
            this.cmbFac.Location = new System.Drawing.Point(206, 246);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(431, 29);
            this.cmbFac.TabIndex = 68;
            // 
            // slsocDataSet
            // 
            this.slsocDataSet.DataSetName = "slsocDataSet";
            this.slsocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "lecturers";
            this.lecturersBindingSource.DataSource = this.slsocDataSet;
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // txtModtwo
            // 
            this.txtModtwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModtwo.Location = new System.Drawing.Point(1022, 246);
            this.txtModtwo.Name = "txtModtwo";
            this.txtModtwo.Size = new System.Drawing.Size(138, 26);
            this.txtModtwo.TabIndex = 69;
            // 
            // txtModone
            // 
            this.txtModone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModone.Location = new System.Drawing.Point(875, 246);
            this.txtModone.Name = "txtModone";
            this.txtModone.Size = new System.Drawing.Size(138, 26);
            this.txtModone.TabIndex = 70;
            // 
            // txtModthree
            // 
            this.txtModthree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModthree.Location = new System.Drawing.Point(1168, 246);
            this.txtModthree.Name = "txtModthree";
            this.txtModthree.Size = new System.Drawing.Size(138, 26);
            this.txtModthree.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.adoneDataGridViewTextBoxColumn,
            this.adtwoDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.facDataGridViewTextBoxColumn,
            this.modoneDataGridViewTextBoxColumn,
            this.modtwoDataGridViewTextBoxColumn,
            this.modthreeDataGridViewTextBoxColumn,
            this.jdateDataGridViewTextBoxColumn,
            this.rdateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(39, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1267, 207);
            this.dataGridView1.TabIndex = 72;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // adoneDataGridViewTextBoxColumn
            // 
            this.adoneDataGridViewTextBoxColumn.DataPropertyName = "adone";
            this.adoneDataGridViewTextBoxColumn.HeaderText = "adone";
            this.adoneDataGridViewTextBoxColumn.Name = "adoneDataGridViewTextBoxColumn";
            // 
            // adtwoDataGridViewTextBoxColumn
            // 
            this.adtwoDataGridViewTextBoxColumn.DataPropertyName = "adtwo";
            this.adtwoDataGridViewTextBoxColumn.HeaderText = "adtwo";
            this.adtwoDataGridViewTextBoxColumn.Name = "adtwoDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // facDataGridViewTextBoxColumn
            // 
            this.facDataGridViewTextBoxColumn.DataPropertyName = "fac";
            this.facDataGridViewTextBoxColumn.HeaderText = "fac";
            this.facDataGridViewTextBoxColumn.Name = "facDataGridViewTextBoxColumn";
            // 
            // modoneDataGridViewTextBoxColumn
            // 
            this.modoneDataGridViewTextBoxColumn.DataPropertyName = "modone";
            this.modoneDataGridViewTextBoxColumn.HeaderText = "modone";
            this.modoneDataGridViewTextBoxColumn.Name = "modoneDataGridViewTextBoxColumn";
            // 
            // modtwoDataGridViewTextBoxColumn
            // 
            this.modtwoDataGridViewTextBoxColumn.DataPropertyName = "modtwo";
            this.modtwoDataGridViewTextBoxColumn.HeaderText = "modtwo";
            this.modtwoDataGridViewTextBoxColumn.Name = "modtwoDataGridViewTextBoxColumn";
            // 
            // modthreeDataGridViewTextBoxColumn
            // 
            this.modthreeDataGridViewTextBoxColumn.DataPropertyName = "modthree";
            this.modthreeDataGridViewTextBoxColumn.HeaderText = "modthree";
            this.modthreeDataGridViewTextBoxColumn.Name = "modthreeDataGridViewTextBoxColumn";
            // 
            // jdateDataGridViewTextBoxColumn
            // 
            this.jdateDataGridViewTextBoxColumn.DataPropertyName = "jdate";
            this.jdateDataGridViewTextBoxColumn.HeaderText = "jdate";
            this.jdateDataGridViewTextBoxColumn.Name = "jdateDataGridViewTextBoxColumn";
            // 
            // rdateDataGridViewTextBoxColumn
            // 
            this.rdateDataGridViewTextBoxColumn.DataPropertyName = "rdate";
            this.rdateDataGridViewTextBoxColumn.HeaderText = "rdate";
            this.rdateDataGridViewTextBoxColumn.Name = "rdateDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // lecturersBindingSource2
            // 
            this.lecturersBindingSource2.DataMember = "lecturers";
            this.lecturersBindingSource2.DataSource = this.slsocDataSet;
            // 
            // lecturersBindingSource1
            // 
            this.lecturersBindingSource1.DataMember = "lecturers";
            this.lecturersBindingSource1.DataSource = this.slsocDataSet;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(677, 410);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 44);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(997, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 44);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1157, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 44);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // compositeTypeBindingSource
            // 
            this.compositeTypeBindingSource.DataSource = typeof(SLSOCdesktop.ServiceReference1.CompositeType);
            // 
            // Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 696);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtModthree);
            this.Controls.Add(this.txtModone);
            this.Controls.Add(this.txtModtwo);
            this.Controls.Add(this.cmbFac);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddtwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1368, 735);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Lecturers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturers";
            this.Load += new System.EventHandler(this.Lecturers_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slsocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddtwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.BindingSource compositeTypeBindingSource;
        private slsocDataSet slsocDataSet;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private slsocDataSetTableAdapters.lecturersTableAdapter lecturersTableAdapter;
        private System.Windows.Forms.TextBox txtModtwo;
        private System.Windows.Forms.TextBox txtModone;
        private System.Windows.Forms.TextBox txtModthree;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lecturersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adtwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modtwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modthreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lecturersBindingSource2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}