using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System.Security.Principal;


namespace ZagreuS
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class frmHWID : Form
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002726 File Offset: 0x00000926
		public frmHWID()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007A08 File Offset: 0x00005C08
		public string dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(string TheText)
		{
			string text = "";
			int num = Strings.Len(TheText);
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					string text2 = Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(Strings.StrReverse(TheText), i, 1)) + 1));
					text += text2;
				}
				return Strings.Trim(text);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007A6C File Offset: 0x00005C6C
		private object cqZcjtUFrXXKYNvNoTYltwK(string ChYgMjXoEEShdoRoK, string EMTwsGVgKuuHHVWdb)
		{
			string text = "";
			int num = Strings.Asc(EMTwsGVgKuuHHVWdb);
			short num2 = checked((short)Strings.Len(ChYgMjXoEEShdoRoK));
			for (short num3 = 1; num3 <= num2; num3 += 1)
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(ChYgMjXoEEShdoRoK, (int)num3, 1))));
			}
			return text;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public bool IsAdmin()
		{
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007A6C File Offset: 0x00005C6C
		private object gfucUokgDmMRMocusOrgsPZ(string PbdNtiitFowAgYhqQ, string SGYdcFglKhaYKFlfg)
		{
			string text = "";
			int num = Strings.Asc(SGYdcFglKhaYKFlfg);
			short num2 = checked((short)Strings.Len(PbdNtiitFowAgYhqQ));
			for (short num3 = 1; num3 <= num2; num3 += 1)
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(PbdNtiitFowAgYhqQ, (int)num3, 1))));
			}
			return text;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007B24 File Offset: 0x00005D24
		public string SimpleDEncrypt(string TheText)
		{
			string text = "";
			int num = Strings.Len(TheText);
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					string text2 = Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(Strings.StrReverse(TheText), i, 1)) - 1));
					text += text2;
				}
				return Strings.Trim(text);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007A6C File Offset: 0x00005C6C
		private object mwOskFBDRtbvawPTQDkHpVG(string aUrHotljdkrWfsOvN, string cwmXXQjbidWtJZTkd)
		{
			string text = "";
			int num = Strings.Asc(cwmXXQjbidWtJZTkd);
			short num2 = checked((short)Strings.Len(aUrHotljdkrWfsOvN));
			for (short num3 = 1; num3 <= num2; num3 += 1)
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(aUrHotljdkrWfsOvN, (int)num3, 1))));
			}
			return text;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007B88 File Offset: 0x00005D88
		public string HexToString(string hex)
		{
			StringBuilder stringBuilder = new StringBuilder(hex.Length / 2);
			checked
			{
				int num = hex.Length - 2;
				for (int i = 0; i <= num; i += 2)
				{
					stringBuilder.Append(Strings.Chr((int)Convert.ToByte(hex.Substring(i, 2), 0x10)));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007A6C File Offset: 0x00005C6C
		private object IHZdNDsOBQTjaJgKpwtMWCD(string VroCnlEWTZWvPeRTK, string YWjSWHCOZSAWrLVIa)
		{
			string text = "";
			int num = Strings.Asc(YWjSWHCOZSAWrLVIa);
			short num2 = checked((short)Strings.Len(VroCnlEWTZWvPeRTK));
			for (short num3 = 1; num3 <= num2; num3 += 1)
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(VroCnlEWTZWvPeRTK, (int)num3, 1))));
			}
			return text;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007BE0 File Offset: 0x00005DE0
		public string StringToHex(string text)
		{
			checked
			{
				int num = text.Length - 1;
				string text2 = "";
				for (int i = 0; i <= num; i++)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, NewLateBinding.LateGet(NewLateBinding.LateGet(Strings.Asc(text.Substring(i, 1)), null, "ToString", new object[] { this.HwYRJPDeUsIPwotbAMNuCpb("2", "JbThpjBWaljnaVBQQFlaBfq") }, null, null, null), null, "ToUpper", new object[0], null, null, null)));
				}
				return text2;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007A6C File Offset: 0x00005C6C
		private object HwYRJPDeUsIPwotbAMNuCpb(string MFOAYGwPfeNOECGFh, string OhJQHZtHlXpmggKrA)
		{
			string text = "";
			int num = Strings.Asc(OhJQHZtHlXpmggKrA);
			short num2 = checked((short)Strings.Len(MFOAYGwPfeNOECGFh));
			for (short num3 = 1; num3 <= num2; num3 += 1)
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(MFOAYGwPfeNOECGFh, (int)num3, 1))));
			}
			return text;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007C64 File Offset: 0x00005E64
		private string getUniqueID(string drive)
		{
			bool flag = Operators.CompareString(drive, string.Empty, false) == 0;
			if (flag)
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					bool isReady = driveInfo.IsReady;
					if (isReady)
					{
						drive = driveInfo.RootDirectory.ToString();
						break;
					}
				}
			}
			bool flag2 = drive.EndsWith(Conversions.ToString(this.DUtKARBaGcYrjGvQbkDBLsZ("}\u001b", "GwoagkwTMVCROkCFsdceKio")));
			if (flag2)
			{
				drive = drive.Substring(0, checked(drive.Length - 2));
			}
			string volumeSerial = this.getVolumeSerial(drive);
			string cpuid = this.getCPUID();
			string serialNumber = frmHWID.getSerialNumber();
			string macaddress = this.GetMACAddress();
			return string.Concat(new string[]
			{
				cpuid.Substring(0, 2),
				volumeSerial.Substring(0, 2),
				cpuid.Substring(9, 4),
				serialNumber.Substring(0, 4),
				cpuid.Substring(2, 4),
				volumeSerial.Substring(2, 4),
				cpuid.Substring(0xC),
				volumeSerial.Substring(3, 4),
				serialNumber.Substring(0xA, 4),
				this.GetMACAddress().Substring(2, 4)
			});
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007A6C File Offset: 0x00005C6C
		private object DUtKARBaGcYrjGvQbkDBLsZ(string IbjqPHtLROdppRHsL, string LFdJvarDXHIQTvMhb)
		{
			string text = "";
			int num = Strings.Asc(LFdJvarDXHIQTvMhb);
			short num2 = checked((short)Strings.Len(IbjqPHtLROdppRHsL));
			for (short num3 = 1; num3 <= num2; num3 += 1)
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(IbjqPHtLROdppRHsL, (int)num3, 1))));
			}
			return text;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007DA8 File Offset: 0x00005FA8
		internal string GetMACAddress()
		{
			ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string text = string.Empty;
			try
			{
				foreach (ManagementBaseObject managementBaseObject in instances)
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (text.Equals(string.Empty))
					{
						if (Convert.ToBoolean(managementObject["IPEnabled"]))
						{
							text = managementObject["MacAddress"].ToString();
						}
						managementObject.Dispose();
					}
					text = text.Replace(":", string.Empty);
				}
			}
			catch { }
			return text;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007E70 File Offset: 0x00006070
		public static string getSerialNumber()
		{
			string text = string.Empty;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_OperatingSystem");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text = managementObject["SerialNumber"].ToString();
				}
			}
			catch{ }
			return text;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007EF4 File Offset: 0x000060F4
		private string getVolumeSerial(string drive)
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
			managementObject.Get();
			string text = managementObject["VolumeSerialNumber"].ToString();
			managementObject.Dispose();
			return text;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007F3C File Offset: 0x0000613C
		private string getCPUID()
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			try
			{
				foreach (ManagementBaseObject managementBaseObject in instances)
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (text == "")
					{
						text = managementObject.Properties["processorID"].Value.ToString();
						break;
					}
				}
			}
			catch { }
			return text;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007FE0 File Offset: 0x000061E0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void btnReg_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.txtPass.Text.ToString();
				text = this.HexToString(text);
				byte[] array = Convert.FromBase64String(text);
				string text2 = Encoding.UTF8.GetString(array);
				text2 = Strings.StrReverse(text2);
				byte[] array2 = Convert.FromBase64String(text2);
				string text3 = Encoding.UTF8.GetString(array2);
				text3 = this.SimpleDEncrypt(text3);
				text3 = Strings.StrReverse(text3);
				string text4 = this.txtHWID.Text.ToString() + this.txtUser.Text.ToString();
				string text5 = this.txtHWID.Text.ToString();
				string text6 = "-Yes.It-Is.Registered";
				string text7 = text5 + text6;
				if (text3 == text4)
				{
					Interaction.MsgBox("Registration Successfully", MsgBoxStyle.Information, "ZagreuS Builder");
					bool flag2 = Form1.IsAdmin();
					if (flag2)
					{
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", true);
						registryKey.SetValue(this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse("Is Registered")), Strings.StrReverse(this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse(text7))), RegistryValueKind.String);
						registryKey.Close();
						registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion", true);
						registryKey.SetValue(this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse("RegisteredName")), Strings.StrReverse(this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse(this.txtUser.Text.ToString()))), RegistryValueKind.String);
						registryKey.Close();
					}
					else
					{
						bool flag3 = !Form1.IsAdmin();
						if (flag3)
						{
							string text8 = this.hwidX.ToString() + "-Yes.It-Is.Registered";
							if (File.Exists(Application.StartupPath.ToString() + "\\WindowsSettings.ini"))
							{
								FileSystem.Kill(Application.StartupPath.ToString() + "\\WindowsSettings.ini");
								new Form1().Show();
								base.Hide();
							}
							StreamWriter streamWriter = new StreamWriter(Application.StartupPath.ToString() + "\\WindowsSettings.ini");
							string text9 = this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse("13377"));
							string text10 = this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse(this.hwidX));
							string text11 = string.Concat(new string[]
							{
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("Port"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("="),
								text9,
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("<DI>"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("HardwareID"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("="),
								text10,
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("<DI>"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("IsReg"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("="),
								Strings.StrReverse(this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse(text7))),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("<DI>"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("RegName"),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("="),
								Strings.StrReverse(this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf(Strings.StrReverse(this.txtUser.Text.ToString()))),
								this.dppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdfdppRHssLddfddHsLPHtLROdppRdf("<DI>")
							});
							byte[] bytes = Encoding.UTF8.GetBytes(text11);
							string text12 = Convert.ToBase64String(bytes);
							text12 = this.StringToHex(text12);
							streamWriter.WriteLine(text12);
							streamWriter.Close();
						}
					}
				}
				else
				{
					Interaction.MsgBox("Wrong password", MsgBoxStyle.Exclamation, "ZagreuS Builder");
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Wrong password", MsgBoxStyle.Exclamation, "ZagreuS Builder");
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000027FA File Offset: 0x000009FA
		private void frmHWID_Load(object sender, EventArgs e)
		{
			this.hwidX = this.getUniqueID("C");
			this.txtHWID.Text = this.hwidX;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000022DD File Offset: 0x000004DD
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void frmHWID_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x04000077 RID: 119
		private string hwidX;
	}
}
