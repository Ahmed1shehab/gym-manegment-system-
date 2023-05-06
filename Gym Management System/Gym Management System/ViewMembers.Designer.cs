namespace Gym_Management_System
{
    partial class ViewMembers
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.btbback = new System.Windows.Forms.Button();
            this.MemberSDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(343, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "FITNESS GYM";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.IndianRed;
            this.lblView.Location = new System.Drawing.Point(339, 55);
            this.lblView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(142, 23);
            this.lblView.TabIndex = 7;
            this.lblView.Text = "Members List";
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Black;
            this.lblexit.Location = new System.Drawing.Point(776, 9);
            this.lblexit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(24, 23);
            this.lblexit.TabIndex = 59;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(260, 112);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 23);
            this.txtName.TabIndex = 60;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.IndianRed;
            this.btnreset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnreset.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(368, 105);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(86, 33);
            this.btnreset.TabIndex = 61;
            this.btnreset.Text = "Search";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.IndianRed;
            this.refresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.refresh.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(458, 105);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(86, 33);
            this.refresh.TabIndex = 62;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btbback
            // 
            this.btbback.BackColor = System.Drawing.Color.IndianRed;
            this.btbback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btbback.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbback.Location = new System.Drawing.Point(343, 541);
            this.btbback.Margin = new System.Windows.Forms.Padding(2);
            this.btbback.Name = "btbback";
            this.btbback.Size = new System.Drawing.Size(86, 33);
            this.btbback.TabIndex = 63;
            this.btbback.Text = "Back";
            this.btbback.UseVisualStyleBackColor = false;
            this.btbback.Click += new System.EventHandler(this.btbback_Click);
            // 
            // MemberSDGV
            // 
            this.MemberSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberSDGV.Location = new System.Drawing.Point(55, 151);
            this.MemberSDGV.Name = "MemberSDGV";
            this.MemberSDGV.Size = new System.Drawing.Size(707, 385);
            this.MemberSDGV.TabIndex = 64;
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 572);
            this.Controls.Add(this.MemberSDGV);
            this.Controls.Add(this.btbback);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMembers";
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button btbback;
        private System.Windows.Forms.DataGridView MemberSDGV;
    }
}