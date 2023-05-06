namespace Gym_Management_System
{
    partial class MainForm
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdatedelete = new System.Windows.Forms.Button();
            this.btntrainers = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblexit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.picmain = new System.Windows.Forms.PictureBox();
            this.viewmember = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.IndianRed;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(204, 6);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 42);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add Member";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdatedelete
            // 
            this.btnupdatedelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnupdatedelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdatedelete.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatedelete.Location = new System.Drawing.Point(476, 6);
            this.btnupdatedelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdatedelete.Name = "btnupdatedelete";
            this.btnupdatedelete.Size = new System.Drawing.Size(125, 42);
            this.btnupdatedelete.TabIndex = 2;
            this.btnupdatedelete.Text = "Update-Delete";
            this.btnupdatedelete.UseVisualStyleBackColor = false;
            this.btnupdatedelete.Click += new System.EventHandler(this.btnupdatedelete_Click);
            // 
            // btntrainers
            // 
            this.btntrainers.BackColor = System.Drawing.Color.IndianRed;
            this.btntrainers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrainers.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrainers.Location = new System.Drawing.Point(734, 6);
            this.btntrainers.Margin = new System.Windows.Forms.Padding(2);
            this.btntrainers.Name = "btntrainers";
            this.btntrainers.Size = new System.Drawing.Size(114, 42);
            this.btntrainers.TabIndex = 3;
            this.btntrainers.Text = "Trainers";
            this.btntrainers.UseVisualStyleBackColor = false;
            this.btntrainers.Click += new System.EventHandler(this.btntrainers_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.BackColor = System.Drawing.Color.IndianRed;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpayment.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.Location = new System.Drawing.Point(605, 6);
            this.btnpayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(114, 42);
            this.btnpayment.TabIndex = 4;
            this.btnpayment.Text = "Payment";
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.viewmember);
            this.panel1.Controls.Add(this.lblexit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btntrainers);
            this.panel1.Controls.Add(this.btnpayment);
            this.panel1.Controls.Add(this.btnupdatedelete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 53);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Black;
            this.lblexit.Location = new System.Drawing.Point(866, 14);
            this.lblexit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(24, 23);
            this.lblexit.TabIndex = 49;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management_System.Properties.Resources.download2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Black;
            this.lblwelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblwelcome.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.IndianRed;
            this.lblwelcome.Location = new System.Drawing.Point(243, 531);
            this.lblwelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(407, 41);
            this.lblwelcome.TabIndex = 7;
            this.lblwelcome.Text = "Welcome to fitness gym";
            // 
            // picmain
            // 
            this.picmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picmain.Image = global::Gym_Management_System.Properties.Resources.istockphoto_1322158059_612x612;
            this.picmain.Location = new System.Drawing.Point(0, 0);
            this.picmain.Margin = new System.Windows.Forms.Padding(2);
            this.picmain.Name = "picmain";
            this.picmain.Size = new System.Drawing.Size(924, 572);
            this.picmain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmain.TabIndex = 0;
            this.picmain.TabStop = false;
            this.picmain.Click += new System.EventHandler(this.picmain_Click);
            // 
            // viewmember
            // 
            this.viewmember.BackColor = System.Drawing.Color.IndianRed;
            this.viewmember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewmember.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewmember.Location = new System.Drawing.Point(333, 6);
            this.viewmember.Margin = new System.Windows.Forms.Padding(2);
            this.viewmember.Name = "viewmember";
            this.viewmember.Size = new System.Drawing.Size(139, 42);
            this.viewmember.TabIndex = 50;
            this.viewmember.Text = "View Member";
            this.viewmember.UseVisualStyleBackColor = false;
            this.viewmember.Click += new System.EventHandler(this.viewmember_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 572);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picmain;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdatedelete;
        private System.Windows.Forms.Button btntrainers;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Button viewmember;
    }
}