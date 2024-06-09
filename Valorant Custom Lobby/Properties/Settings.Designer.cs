using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Valorant_Custom_Lobby.Properties
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002D9B File Offset: 0x00000F9B
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002DA2 File Offset: 0x00000FA2
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002DB4 File Offset: 0x00000FB4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Enter Wallpaper Path...")]
		public string VideoPath
		{
			get
			{
				return (string)this["VideoPath"];
			}
			set
			{
				this["VideoPath"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002DC2 File Offset: 0x00000FC2
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Enter Valorant Game Folder...")]
		public string ValoGamePath
		{
			get
			{
				return (string)this["ValoGamePath"];
			}
			set
			{
				this["ValoGamePath"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002DE2 File Offset: 0x00000FE2
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002DF4 File Offset: 0x00000FF4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ValoPath
		{
			get
			{
				return (string)this["ValoPath"];
			}
			set
			{
				this["ValoPath"] = value;
			}
		}

		// Token: 0x04000010 RID: 16
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
