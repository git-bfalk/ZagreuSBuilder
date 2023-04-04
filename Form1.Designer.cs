using System.Windows.Forms;
namespace ZagreuS
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
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

		// Token: 0x0600002B RID: 43 RVA: 0x00002C78 File Offset: 0x00000E78
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RmVved = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(291, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "I Decline";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = " I Agree";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RmVved);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 468);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(487, 42);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // RmVved
            // 
            this.RmVved.AutoSize = true;
            this.RmVved.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RmVved.ForeColor = System.Drawing.Color.Blue;
            this.RmVved.Location = new System.Drawing.Point(164, 16);
            this.RmVved.Name = "RmVved";
            this.RmVved.Size = new System.Drawing.Size(19, 13);
            this.RmVved.TabIndex = 3;
            this.RmVved.Text = "20";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.RichTextBox1);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(487, 450);
            this.Panel1.TabIndex = 0;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox1.Location = new System.Drawing.Point(-1, -1);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.RichTextBox1.Size = new System.Drawing.Size(487, 450);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = resources.GetString("RichTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 522);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCLAIMER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private Label RmVved;
        private Timer Timer1;
        private GroupBox GroupBox1;
        private Panel Panel1;
        private RichTextBox RichTextBox1;
        private Button button1, button2;
    }
}
