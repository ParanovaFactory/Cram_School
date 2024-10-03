namespace Cram_School
{
    partial class Schedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLecture = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLecture = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mskHour2 = new System.Windows.Forms.MaskedTextBox();
            this.mskDate2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskClass = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStdSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.mskHour);
            this.groupBox1.Controls.Add(this.mskDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTeacher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbLecture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(213, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 58);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mskHour
            // 
            this.mskHour.Location = new System.Drawing.Point(86, 125);
            this.mskHour.Mask = "00:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(121, 26);
            this.mskHour.TabIndex = 8;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(86, 93);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(121, 26);
            this.mskDate.TabIndex = 7;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(86, 59);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(236, 28);
            this.cmbTeacher.TabIndex = 3;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher";
            // 
            // cmbLecture
            // 
            this.cmbLecture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLecture.FormattingEnabled = true;
            this.cmbLecture.Location = new System.Drawing.Point(86, 25);
            this.cmbLecture.Name = "cmbLecture";
            this.cmbLecture.Size = new System.Drawing.Size(236, 28);
            this.cmbLecture.TabIndex = 1;
            this.cmbLecture.SelectedIndexChanged += new System.EventHandler(this.cmbLecture_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecture";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblId);
            this.groupBox3.Controls.Add(this.txtStudent);
            this.groupBox3.Controls.Add(this.txtTeacher);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtLecture);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.mskHour2);
            this.groupBox3.Controls.Add(this.mskDate2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(363, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(255, 92);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ıd";
            this.lblId.Visible = false;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(86, 92);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.Size = new System.Drawing.Size(120, 26);
            this.txtStudent.TabIndex = 14;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(86, 59);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(121, 26);
            this.txtTeacher.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Student";
            // 
            // txtLecture
            // 
            this.txtLecture.Location = new System.Drawing.Point(86, 25);
            this.txtLecture.Name = "txtLecture";
            this.txtLecture.ReadOnly = true;
            this.txtLecture.Size = new System.Drawing.Size(121, 26);
            this.txtLecture.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(218, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mskHour2
            // 
            this.mskHour2.Location = new System.Drawing.Point(86, 159);
            this.mskHour2.Mask = "00:00";
            this.mskHour2.Name = "mskHour2";
            this.mskHour2.ReadOnly = true;
            this.mskHour2.Size = new System.Drawing.Size(121, 26);
            this.mskHour2.TabIndex = 8;
            this.mskHour2.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate2
            // 
            this.mskDate2.Location = new System.Drawing.Point(86, 127);
            this.mskDate2.Mask = "00/00/0000";
            this.mskDate2.Name = "mskDate2";
            this.mskDate2.ReadOnly = true;
            this.mskDate2.Size = new System.Drawing.Size(121, 26);
            this.mskDate2.TabIndex = 7;
            this.mskDate2.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teacher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lecture";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbStudent);
            this.groupBox4.Controls.Add(this.btnAssign);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(678, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 118);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(85, 25);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(218, 28);
            this.cmbStudent.TabIndex = 16;
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Location = new System.Drawing.Point(10, 59);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(234, 49);
            this.btnAssign.TabIndex = 10;
            this.btnAssign.Text = "Assign Course";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Student";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMail);
            this.groupBox5.Controls.Add(this.mskPhone);
            this.groupBox5.Controls.Add(this.mskClass);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtPicture);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtSurname);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtName);
            this.groupBox5.Controls.Add(this.btnStdSave);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(678, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 285);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(93, 188);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(210, 26);
            this.txtMail.TabIndex = 24;
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(93, 156);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(210, 26);
            this.mskPhone.TabIndex = 23;
            // 
            // mskClass
            // 
            this.mskClass.Location = new System.Drawing.Point(93, 124);
            this.mskClass.Mask = "00";
            this.mskClass.Name = "mskClass";
            this.mskClass.Size = new System.Drawing.Size(210, 26);
            this.mskClass.TabIndex = 22;
            this.mskClass.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Phone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Class";
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(93, 89);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(210, 26);
            this.txtPicture.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Picture";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(93, 57);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(210, 26);
            this.txtSurname.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 12;
            // 
            // btnStdSave
            // 
            this.btnStdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdSave.Location = new System.Drawing.Point(10, 220);
            this.btnStdSave.Name = "btnStdSave";
            this.btnStdSave.Size = new System.Drawing.Size(143, 49);
            this.btnStdSave.TabIndex = 10;
            this.btnStdSave.Text = "Save Student";
            this.btnStdSave.UseVisualStyleBackColor = true;
            this.btnStdSave.Click += new System.EventHandler(this.btnStdSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(999, 539);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Schedule";
            this.Text = "Schedule Management";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLecture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox mskHour2;
        private System.Windows.Forms.MaskedTextBox mskDate2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbLecture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.MaskedTextBox mskClass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStdSave;
        private System.Windows.Forms.Label label12;
    }
}

