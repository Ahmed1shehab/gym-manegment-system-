namespace Gym_Management_System
{
    partial class UpdateDelete
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
            this.btnreset = new System.Windows.Forms.Button();
            this.btbback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbTiming = new System.Windows.Forms.ComboBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.lbltiming = new System.Windows.Forms.Label();
            this.lblplan = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblphoneno = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MemberSDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.IndianRed;
            this.btnreset.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(28, 546);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(86, 33);
            this.btnreset.TabIndex = 40;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btbback
            // 
            this.btbback.BackColor = System.Drawing.Color.IndianRed;
            this.btbback.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbback.Location = new System.Drawing.Point(138, 546);
            this.btbback.Margin = new System.Windows.Forms.Padding(2);
            this.btbback.Name = "btbback";
            this.btbback.Size = new System.Drawing.Size(86, 33);
            this.btbback.TabIndex = 39;
            this.btbback.Text = "Back";
            this.btbback.UseVisualStyleBackColor = false;
            this.btbback.Click += new System.EventHandler(this.btbback_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.IndianRed;
            this.btnadd.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(28, 500);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(86, 33);
            this.btnadd.TabIndex = 38;
            this.btnadd.Text = "UPDATE";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbTiming
            // 
            this.cmbTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiming.FormattingEnabled = true;
            this.cmbTiming.Items.AddRange(new object[] {
            "6AM-8AM",
            "8AM-10AM",
            "10AM-12PM",
            "12PM-2PM",
            "2PM-4PM",
            "4PM-6PM",
            "6PM-8PM"});
            this.cmbTiming.Location = new System.Drawing.Point(120, 441);
            this.cmbTiming.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTiming.Name = "cmbTiming";
            this.cmbTiming.Size = new System.Drawing.Size(92, 24);
            this.cmbTiming.TabIndex = 37;
            // 
            // cmbPlan
            // 
            this.cmbPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Items.AddRange(new object[] {
            "1Month",
            "2Months",
            "3Months",
            "1Year"});
            this.cmbPlan.Location = new System.Drawing.Point(96, 391);
            this.cmbPlan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(92, 24);
            this.cmbPlan.TabIndex = 36;
            // 
            // lbltiming
            // 
            this.lbltiming.AutoSize = true;
            this.lbltiming.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiming.ForeColor = System.Drawing.Color.Black;
            this.lbltiming.Location = new System.Drawing.Point(30, 437);
            this.lbltiming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltiming.Name = "lbltiming";
            this.lbltiming.Size = new System.Drawing.Size(83, 23);
            this.lbltiming.TabIndex = 35;
            this.lbltiming.Text = "timing";
            // 
            // lblplan
            // 
            this.lblplan.AutoSize = true;
            this.lblplan.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplan.ForeColor = System.Drawing.Color.Black;
            this.lblplan.Location = new System.Drawing.Point(30, 387);
            this.lblplan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplan.Name = "lblplan";
            this.lblplan.Size = new System.Drawing.Size(61, 23);
            this.lblplan.TabIndex = 34;
            this.lblplan.Text = "plan";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(150, 239);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(104, 23);
            this.txtPhone.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(106, 193);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 23);
            this.txtName.TabIndex = 32;
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(145, 338);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(79, 23);
            this.txtAge.TabIndex = 31;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(30, 189);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 23);
            this.lblname.TabIndex = 30;
            this.lblname.Text = "NAME";
            // 
            // lblphoneno
            // 
            this.lblphoneno.AutoSize = true;
            this.lblphoneno.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneno.ForeColor = System.Drawing.Color.Black;
            this.lblphoneno.Location = new System.Drawing.Point(30, 235);
            this.lblphoneno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphoneno.Name = "lblphoneno";
            this.lblphoneno.Size = new System.Drawing.Size(113, 23);
            this.lblphoneno.TabIndex = 29;
            this.lblphoneno.Text = "phone no";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.Black;
            this.lblage.Location = new System.Drawing.Point(42, 334);
            this.lblage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(49, 23);
            this.lblage.TabIndex = 28;
            this.lblage.Text = "age";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.Black;
            this.lblgender.Location = new System.Drawing.Point(30, 292);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(90, 23);
            this.lblgender.TabIndex = 27;
            this.lblgender.Text = "gender";
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(150, 292);
            this.cmbgender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(92, 24);
            this.cmbgender.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(330, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "UPDATE OR DELETE MEMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(395, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "FITNESS GYM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management_System.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(399, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(138, 500);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(875, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MemberSDGV
            // 
            this.MemberSDGV.AllowUserToOrderColumns = true;
            this.MemberSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberSDGV.Location = new System.Drawing.Point(279, 179);
            this.MemberSDGV.Name = "MemberSDGV";
            this.MemberSDGV.Size = new System.Drawing.Size(620, 385);
            this.MemberSDGV.TabIndex = 65;
            this.MemberSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberSDGV_CellContentClick);
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 606);
            this.Controls.Add(this.MemberSDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btbback);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbTiming);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.lbltiming);
            this.Controls.Add(this.lblplan);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblphoneno);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateDelete";
            this.Text = "UpdateDelete";
            this.Load += new System.EventHandler(this.UpdateDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btbback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbTiming;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Label lbltiming;
        private System.Windows.Forms.Label lblplan;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblphoneno;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MemberSDGV;
    }
}