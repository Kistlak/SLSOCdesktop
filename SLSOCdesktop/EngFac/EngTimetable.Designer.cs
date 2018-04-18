namespace SLSOCdesktop.EngFac
{
    partial class EngTimetable
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
            this.btnTimetables = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lechallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slsocDataSet9 = new SLSOCdesktop.slsocDataSet9();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLechall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModecode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbLecname = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFeedbacks = new System.Windows.Forms.Button();
            this.btnAcademic = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLecstu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timetablesTableAdapter = new SLSOCdesktop.slsocDataSet9TableAdapters.timetablesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slsocDataSet9)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimetables
            // 
            this.btnTimetables.BackColor = System.Drawing.Color.Red;
            this.btnTimetables.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetables.ForeColor = System.Drawing.Color.White;
            this.btnTimetables.Location = new System.Drawing.Point(5, 3);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(96, 31);
            this.btnTimetables.TabIndex = 0;
            this.btnTimetables.Text = "Timetables";
            this.btnTimetables.UseVisualStyleBackColor = false;
            this.btnTimetables.Click += new System.EventHandler(this.btnTimetables_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1218, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "SLSOC Timetables © 2018";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1352, 643);
            this.tabControl1.TabIndex = 153;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cmbBatch);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cmbLab);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbLechall);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbModecode);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbTime);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cmbLecname);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1344, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modules";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn,
            this.modcodeDataGridViewTextBoxColumn,
            this.lecnameDataGridViewTextBoxColumn,
            this.lechallDataGridViewTextBoxColumn,
            this.labDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timetablesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1236, 343);
            this.dataGridView1.TabIndex = 165;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "batch";
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            // 
            // modcodeDataGridViewTextBoxColumn
            // 
            this.modcodeDataGridViewTextBoxColumn.DataPropertyName = "modcode";
            this.modcodeDataGridViewTextBoxColumn.HeaderText = "modcode";
            this.modcodeDataGridViewTextBoxColumn.Name = "modcodeDataGridViewTextBoxColumn";
            // 
            // lecnameDataGridViewTextBoxColumn
            // 
            this.lecnameDataGridViewTextBoxColumn.DataPropertyName = "lecname";
            this.lecnameDataGridViewTextBoxColumn.HeaderText = "lecname";
            this.lecnameDataGridViewTextBoxColumn.Name = "lecnameDataGridViewTextBoxColumn";
            // 
            // lechallDataGridViewTextBoxColumn
            // 
            this.lechallDataGridViewTextBoxColumn.DataPropertyName = "lechall";
            this.lechallDataGridViewTextBoxColumn.HeaderText = "lechall";
            this.lechallDataGridViewTextBoxColumn.Name = "lechallDataGridViewTextBoxColumn";
            // 
            // labDataGridViewTextBoxColumn
            // 
            this.labDataGridViewTextBoxColumn.DataPropertyName = "lab";
            this.labDataGridViewTextBoxColumn.HeaderText = "lab";
            this.labDataGridViewTextBoxColumn.Name = "labDataGridViewTextBoxColumn";
            // 
            // timetablesBindingSource
            // 
            this.timetablesBindingSource.DataMember = "timetables";
            this.timetablesBindingSource.DataSource = this.slsocDataSet9;
            // 
            // slsocDataSet9
            // 
            this.slsocDataSet9.DataSetName = "slsocDataSet9";
            this.slsocDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBatch
            // 
            this.cmbBatch.DisplayMember = "fname";
            this.cmbBatch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Items.AddRange(new object[] {
            "Batch 1",
            "Batch 2",
            "Batch 3",
            "Batch 4",
            "Batch 5"});
            this.cmbBatch.Location = new System.Drawing.Point(198, 83);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(431, 31);
            this.cmbBatch.TabIndex = 164;
            this.cmbBatch.ValueMember = "fname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 163;
            this.label10.Text = "Batch :";
            // 
            // cmbLab
            // 
            this.cmbLab.DisplayMember = "fname";
            this.cmbLab.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Items.AddRange(new object[] {
            "Lab001",
            "Lab002",
            "Lab003",
            "Lab004",
            "Lab005"});
            this.cmbLab.Location = new System.Drawing.Point(198, 205);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(431, 31);
            this.cmbLab.TabIndex = 162;
            this.cmbLab.ValueMember = "fname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 161;
            this.label8.Text = "Lab :";
            // 
            // cmbLechall
            // 
            this.cmbLechall.DisplayMember = "fname";
            this.cmbLechall.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLechall.FormattingEnabled = true;
            this.cmbLechall.Items.AddRange(new object[] {
            "L101",
            "L102",
            "L103",
            "B001",
            "B002"});
            this.cmbLechall.Location = new System.Drawing.Point(852, 144);
            this.cmbLechall.Name = "cmbLechall";
            this.cmbLechall.Size = new System.Drawing.Size(431, 31);
            this.cmbLechall.TabIndex = 160;
            this.cmbLechall.ValueMember = "fname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(697, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 159;
            this.label7.Text = "Lecture Hall :";
            // 
            // cmbModecode
            // 
            this.cmbModecode.DisplayMember = "fname";
            this.cmbModecode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModecode.FormattingEnabled = true;
            this.cmbModecode.Items.AddRange(new object[] {
            "9 AM - 11 AM",
            "9 AM - 12 AM",
            "9 AM - 10.30 AM",
            "1 PM - 3 PM",
            "1 PM - 4 PM",
            "1 PM - 2.30 PM",
            "2 PM - 5 PM"});
            this.cmbModecode.Location = new System.Drawing.Point(852, 83);
            this.cmbModecode.Name = "cmbModecode";
            this.cmbModecode.Size = new System.Drawing.Size(431, 31);
            this.cmbModecode.TabIndex = 158;
            this.cmbModecode.ValueMember = "fname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 157;
            this.label6.Text = "Module Code :";
            // 
            // cmbTime
            // 
            this.cmbTime.DisplayMember = "fname";
            this.cmbTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "9 AM - 11 AM",
            "9 AM - 12 AM",
            "9 AM - 10.30 AM",
            "1 PM - 3 PM",
            "1 PM - 4 PM",
            "1 PM - 2.30 PM",
            "2 PM - 5 PM"});
            this.cmbTime.Location = new System.Drawing.Point(852, 24);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(431, 31);
            this.cmbTime.TabIndex = 156;
            this.cmbTime.ValueMember = "fname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 155;
            this.label5.Text = "Time :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 32);
            this.dateTimePicker1.TabIndex = 154;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbLecname
            // 
            this.cmbLecname.DisplayMember = "fname";
            this.cmbLecname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLecname.FormattingEnabled = true;
            this.cmbLecname.Location = new System.Drawing.Point(198, 144);
            this.cmbLecname.Name = "cmbLecname";
            this.cmbLecname.Size = new System.Drawing.Size(431, 31);
            this.cmbLecname.TabIndex = 153;
            this.cmbLecname.ValueMember = "fname";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1157, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 32);
            this.btnAdd.TabIndex = 150;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 146;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 144;
            this.label3.Text = "Lecturer :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnFeedbacks);
            this.panel1.Controls.Add(this.btnAcademic);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnTimetables);
            this.panel1.Controls.Add(this.btnLecstu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 37);
            this.panel1.TabIndex = 151;
            // 
            // btnFeedbacks
            // 
            this.btnFeedbacks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbacks.Location = new System.Drawing.Point(311, 3);
            this.btnFeedbacks.Name = "btnFeedbacks";
            this.btnFeedbacks.Size = new System.Drawing.Size(96, 31);
            this.btnFeedbacks.TabIndex = 6;
            this.btnFeedbacks.Text = "Feedbacks";
            this.btnFeedbacks.UseVisualStyleBackColor = true;
            this.btnFeedbacks.Click += new System.EventHandler(this.btnFeedbacks_Click);
            // 
            // btnAcademic
            // 
            this.btnAcademic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademic.Location = new System.Drawing.Point(209, 3);
            this.btnAcademic.Name = "btnAcademic";
            this.btnAcademic.Size = new System.Drawing.Size(96, 31);
            this.btnAcademic.TabIndex = 5;
            this.btnAcademic.Text = "Academic";
            this.btnAcademic.UseVisualStyleBackColor = true;
            this.btnAcademic.Click += new System.EventHandler(this.btnAcademic_Click);
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
            // btnLecstu
            // 
            this.btnLecstu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecstu.Location = new System.Drawing.Point(107, 3);
            this.btnLecstu.Name = "btnLecstu";
            this.btnLecstu.Size = new System.Drawing.Size(96, 31);
            this.btnLecstu.TabIndex = 1;
            this.btnLecstu.Text = "Lec / Stu";
            this.btnLecstu.UseVisualStyleBackColor = true;
            this.btnLecstu.Click += new System.EventHandler(this.btnLecstu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 683);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 13);
            this.panel2.TabIndex = 152;
            // 
            // timetablesTableAdapter
            // 
            this.timetablesTableAdapter.ClearBeforeFill = true;
            // 
            // EngTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 696);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1368, 735);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "EngTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngTimetable";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slsocDataSet9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lechallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timetablesBindingSource;
        private slsocDataSet9 slsocDataSet9;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLechall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModecode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbLecname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFeedbacks;
        private System.Windows.Forms.Button btnAcademic;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLecstu;
        private System.Windows.Forms.Panel panel2;
        private slsocDataSet9TableAdapters.timetablesTableAdapter timetablesTableAdapter;
    }
}