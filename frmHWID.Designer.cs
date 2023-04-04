using System.Windows.Forms;
namespace ZagreuS
{
	// Token: 0x0200000D RID: 13
	public partial class frmHWID : global::System.Windows.Forms.Form
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

		// Token: 0x060000D1 RID: 209 RVA: 0x00007334 File Offset: 0x00005534
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHWID));
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHWID = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.GroupBox7.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.GroupBox3);
            this.GroupBox7.Controls.Add(this.GroupBox2);
            this.GroupBox7.Controls.Add(this.GroupBox1);
            this.GroupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox7.ForeColor = System.Drawing.Color.Black;
            this.GroupBox7.Location = new System.Drawing.Point(12, 157);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(300, 274);
            this.GroupBox7.TabIndex = 202;
            this.GroupBox7.TabStop = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtPass);
            this.GroupBox3.Location = new System.Drawing.Point(12, 138);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(277, 130);
            this.GroupBox3.TabIndex = 200;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.Location = new System.Drawing.Point(20, 33);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(242, 74);
            this.txtPass.TabIndex = 192;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtHWID);
            this.GroupBox2.Location = new System.Drawing.Point(12, 19);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(277, 48);
            this.GroupBox2.TabIndex = 200;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = " HWID";
            // 
            // txtHWID
            // 
            this.txtHWID.Location = new System.Drawing.Point(20, 19);
            this.txtHWID.Name = "txtHWID";
            this.txtHWID.ReadOnly = true;
            this.txtHWID.Size = new System.Drawing.Size(242, 20);
            this.txtHWID.TabIndex = 188;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtUser);
            this.GroupBox1.Location = new System.Drawing.Point(12, 84);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(277, 48);
            this.GroupBox1.TabIndex = 191;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.Location = new System.Drawing.Point(20, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(242, 20);
            this.txtUser.TabIndex = 190;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(116, 438);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 28);
            this.btnReg.TabIndex = 201;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Black;
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(-52, 1);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(431, 150);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 203;
            this.PictureBox2.TabStop = false;
            // 
            // frmHWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 473);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.GroupBox7);
            this.Controls.Add(this.btnReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHWID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHWID_FormClosing);
            this.Load += new System.EventHandler(this.frmHWID_Load);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

        private GroupBox GroupBox7, GroupBox3, GroupBox2, GroupBox1;
        private TextBox txtPass, txtHWID, txtUser;
        private Button btnReg;
        private PictureBox PictureBox2;
	}
}
