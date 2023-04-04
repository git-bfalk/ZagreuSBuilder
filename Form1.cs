using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Security.Principal;


namespace ZagreuS
{
	// Token: 0x0200000B RID: 11
	public partial class Form1 : Form
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000220B File Offset: 0x0000040B
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000022BA File Offset: 0x000004BA
		private void Button1_Click(object sender, EventArgs e)
		{
			new fRCWQdUOPAClUJZZPQmd().Show();
			base.Hide();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022D4 File Offset: 0x000004D4
		private void Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000022DD File Offset: 0x000004DD
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022E6 File Offset: 0x000004E6
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Timer1.Start();
			this.button1.Enabled = false;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003310 File Offset: 0x00001510
		private void Timer1_Tick(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(this.RmVved.Text);
			int num2 = 1;
			this.RmVved.Text = Conversions.ToString(checked(num - num2));
			bool flag = Operators.CompareString(this.RmVved.Text, "0", false) == 0;
			if (flag)
			{
				this.button1.Enabled = true;
				this.Timer1.Stop();
				this.RmVved.Text = "";
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003390 File Offset: 0x00001590
		public static bool IsAdmin()
		{
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
		}
	}
}
