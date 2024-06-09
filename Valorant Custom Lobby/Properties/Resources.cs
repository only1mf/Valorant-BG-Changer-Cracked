using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Valorant_Custom_Lobby.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002CEC File Offset: 0x00000EEC
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002CF4 File Offset: 0x00000EF4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Valorant_Custom_Lobby.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002D20 File Offset: 0x00000F20
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002D27 File Offset: 0x00000F27
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002D2F File Offset: 0x00000F2F
		internal static Bitmap _1250635
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("1250635", Resources.resourceCulture);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002D4A File Offset: 0x00000F4A
		internal static Bitmap _6590965
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("6590965", Resources.resourceCulture);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002D65 File Offset: 0x00000F65
		internal static Bitmap Valorant_Credits_Font
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Valorant Credits Font", Resources.resourceCulture);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002D80 File Offset: 0x00000F80
		internal static Bitmap Valorant_Lobby_Font
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Valorant Lobby Font", Resources.resourceCulture);
			}
		}

		// Token: 0x0400000E RID: 14
		private static ResourceManager resourceMan;

		// Token: 0x0400000F RID: 15
		private static CultureInfo resourceCulture;
	}
}
