using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DiscordRPC;
using Newtonsoft.Json.Linq;
using Valorant_Custom_Lobby.Properties;
using YamlDotNet.RepresentationModel;

namespace Valorant_Custom_Lobby
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void InitializeRPC()
		{
			Form1.client = new DiscordRpcClient("997890963227807764");
			Form1.client.Initialize();
		}

		// Token: 0x06000002 RID: 2
		public static void setState()
		{
			new WebClient();
			DiscordRPC.Button[] buttons = new DiscordRPC.Button[]
			{
				new DiscordRPC.Button
				{
					Label = "Discord",
					Url = "https://github.com/only1mf"
				},
				new DiscordRPC.Button
				{
					Label = "Download",
					Url = "https://github.com/only1mf"
				}
			};
			Form1.client.SetPresence(new RichPresence
			{
				Details = "Cracked, only1mf {?} https://github.com/only1mf",
				Buttons = buttons,
				Timestamps = new Timestamps
				{
					Start = new DateTime?(DateTime.UtcNow)
				},
				Assets = new Assets
				{
					LargeImageKey = "valorant_cl_icon",
					LargeImageText = "Valorant Custom Lobby"
				}
			});
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000211F File Offset: 0x0000031F
		private static string GetRiotDirectory()
		{
			if (Directory.Exists("C:\\ProgramData\\Riot Games"))
			{
				return "C:\\ProgramData\\Riot Games";
			}
			if (Directory.Exists("D:\\ProgramData\\Riot Games"))
			{
				return "D:\\ProgramData\\Riot Games";
			}
			if (!Directory.Exists("E:\\ProgramData\\Riot Games"))
			{
				return "F:\\ProgramData\\Riot Games";
			}
			return "E:\\ProgramData\\Riot Games";
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000215C File Offset: 0x0000035C
		private static bool DatFileExists()
		{
			return File.Exists(Form1.GetRiotDirectory() + "\\RiotClientInstalls.json");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002174 File Offset: 0x00000374
		private void AutoValorantFinder()
		{
			string s = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Riot Games\\Metadata\\valorant.live" + "\\valorant.live.product_settings.yaml");
			YamlStream yamlStream = new YamlStream();
			TextReader input = new StringReader(s);
			yamlStream.Load(input);
			string text = "";
			foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in ((YamlMappingNode)yamlStream.Documents[0].RootNode).Children)
			{
				if (keyValuePair.Key.ToString() == "product_install_full_path")
				{
					text = keyValuePair.Value.ToString();
				}
			}
			text += "\\ShooterGame\\Content\\Movies\\Menu\\VCT_24_809_Homescreen.mp4";
			string valoGamePath = text + "\\ShooterGame\\Binaries\\Win64\\VALORANT-Win64-Shipping.exe";
			Settings.Default.ValoPath = text;
			Settings.Default.ValoGamePath = valoGamePath;
			Settings.Default.Save();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000226C File Offset: 0x0000046C
		public Form1()
		{
			this.InitializeComponent();
			Form1.InitializeRPC();
			Form1.setState();
			this.AutoValorantFinder();
			if (Settings.Default.VideoPath == "Enter Wallpaper Path...")
			{
				this.WallpaperInput.Text = "Enter Wallpaper Path...";
				return;
			}
			this.WallpaperInput.Text = Settings.Default.VideoPath;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022D4 File Offset: 0x000004D4
		public static void ReplaceMenu(string videoPath, string valorantPath)
		{
			string destFileName = Settings.Default.ValoGamePath + "/live/ShooterGame/Content/Movies/Menu/VCT_24_809_Homescreen.mp4";
			if (Form1.IsValorantRunning())
			{
				MessageBox.Show("Please close Valorant!");
				return;
			}
			try
			{
				File.Copy(videoPath, destFileName, true);
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002330 File Offset: 0x00000530
		public static bool IsValorantRunning()
		{
			return Process.GetProcessesByName("VALORANT").Length != 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002340 File Offset: 0x00000540
		private void WallpaperInput_Enter(object sender, EventArgs e)
		{
			if (Settings.Default.VideoPath == "Enter Wallpaper Path...")
			{
				this.WallpaperInput.Text = string.Empty;
				return;
			}
			this.WallpaperInput.Text = Settings.Default.VideoPath;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002380 File Offset: 0x00000580
		private void WallpaperInput_Leave(object sender, EventArgs e)
		{
			if (this.WallpaperInput.Text != string.Empty)
			{
				Settings.Default.VideoPath = this.WallpaperInput.Text;
				Settings.Default.Save();
				return;
			}
			this.WallpaperInput.Text = "Enter Wallpaper Path...";
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023D4 File Offset: 0x000005D4
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.WallpaperInput.Text == "Enter Wallpaper Path...")
			{
				MessageBox.Show("Please enter a valid Wallpaper Path!");
				return;
			}
			this.timer.Enabled = true;
			MessageBox.Show("Your Custom Lobby Background was set successful! \nFeel free to Launch Valorant now!");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002410 File Offset: 0x00000610
		private void timer_Tick(object sender, EventArgs e)
		{
			string valoPath = Settings.Default.ValoPath;
			File.Copy(Settings.Default.VideoPath, valoPath, true);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002439 File Offset: 0x00000639
		private void label1_Click_1(object sender, EventArgs e)
		{
			base.Hide();
			base.ShowInTaskbar = false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002448 File Offset: 0x00000648
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.timer.Enabled)
			{
				string fileName = JObject.Parse(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Riot Games\\RiotClientInstalls.json"))["rc_default"].ToString();
				new Process
				{
					StartInfo = 
					{
						FileName = fileName,
						Arguments = "--launch-product=valorant --launch-patchline=live"
					}
				}.Start();
				return;
			}
			DialogResult dialogResult = MessageBox.Show("You have not changed your Lobby Background yet! \nDo you still wanna launch the game?", "Valorant Custom Lobby by FrostChanger.de", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				string fileName2 = JObject.Parse(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Riot Games\\RiotClientInstalls.json"))["rc_default"].ToString();
				new Process
				{
					StartInfo = 
					{
						FileName = fileName2,
						Arguments = "--launch-product=valorant --launch-patchline=live"
					}
				}.Start();
				return;
			}
		}

		// Token: 0x04000001 RID: 1
		public static DiscordRpcClient client;
	}
}
