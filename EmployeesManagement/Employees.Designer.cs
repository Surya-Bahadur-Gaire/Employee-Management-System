namespace EmployeesManagement
{
    partial class Employees
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridEmployeeDB = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtEphone = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.GridEmployeeDB);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbEducation);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateDOB);
            this.panel1.Controls.Add(this.cmbPosition);
            this.panel1.Controls.Add(this.txtEphone);
            this.panel1.Controls.Add(this.txtEname);
            this.panel1.Controls.Add(this.txtEaddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 577);
            this.panel1.TabIndex = 0;
            // 
            // GridEmployeeDB
            // 
            this.GridEmployeeDB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridEmployeeDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployeeDB.Location = new System.Drawing.Point(631, 0);
            this.GridEmployeeDB.Name = "GridEmployeeDB";
            this.GridEmployeeDB.RowHeadersWidth = 62;
            this.GridEmployeeDB.RowTemplate.Height = 28;
            this.GridEmployeeDB.Size = new System.Drawing.Size(781, 580);
            this.GridEmployeeDB.TabIndex = 32;
            this.GridEmployeeDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmployeeDB_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(157, 491);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 71);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(318, 491);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 71);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(469, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 71);
            this.button2.TabIndex = 29;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 71);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbEducation
            // 
            this.cmbEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Items.AddRange(new object[] {
            "BScIT",
            "BIT",
            "MSIT",
            "BBA"});
            this.cmbEducation.Location = new System.Drawing.Point(282, 366);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(343, 37);
            this.cmbEducation.TabIndex = 27;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(282, 116);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(343, 37);
            this.cmbGender.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Employee Gender:";
            // 
            // dateDOB
            // 
            this.dateDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDOB.Location = new System.Drawing.Point(282, 213);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(343, 35);
            this.dateDOB.TabIndex = 24;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Intern",
            "Junior Developer",
            "Senior Developer",
            "Supervisor",
            "Manager",
            "Accountant",
            "Receptionist",
            "Director",
            "Vice President",
            "President"});
            this.cmbPosition.Location = new System.Drawing.Point(282, 164);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(343, 37);
            this.cmbPosition.TabIndex = 23;
            // 
            // txtEphone
            // 
            this.txtEphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEphone.Location = new System.Drawing.Point(282, 265);
            this.txtEphone.Name = "txtEphone";
            this.txtEphone.Size = new System.Drawing.Size(343, 35);
            this.txtEphone.TabIndex = 22;
            // 
            // txtEname
            // 
            this.txtEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEname.Location = new System.Drawing.Point(282, 65);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(343, 35);
            this.txtEname.TabIndex = 21;
            // 
            // txtEaddress
            // 
            this.txtEaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEaddress.Location = new System.Drawing.Point(282, 316);
            this.txtEaddress.Name = "txtEaddress";
            this.txtEaddress.Size = new System.Drawing.Size(343, 35);
            this.txtEaddress.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Education:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Employee Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Employee Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Employee Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee DOB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee Phone:";
            // 
            // txtEid
            // 
            this.txtEid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEid.Location = new System.Drawing.Point(282, 15);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(343, 35);
            this.txtEid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(93, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Manage Employees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1212, 671);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "SuryaBhadurGaire 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeesManagement.Properties.Resources.icons8_employee_64__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EmployeesManagement.Properties.Resources.icons8_copyright_48;
            this.pictureBox5.Location = new System.Drawing.Point(1157, 662);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1411, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtEphone;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridEmployeeDB;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}