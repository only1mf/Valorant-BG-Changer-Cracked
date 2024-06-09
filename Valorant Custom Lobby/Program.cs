using System;
using System.Windows.Forms;

namespace Valorant_Custom_Lobby
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002C63 File Offset: 0x00000E63
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
