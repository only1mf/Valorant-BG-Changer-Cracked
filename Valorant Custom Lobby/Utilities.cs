using System;
using Newtonsoft.Json.Linq;

namespace Valorant_Custom_Lobby
{
	// Token: 0x02000004 RID: 4
	internal static class Utilities
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002C7C File Offset: 0x00000E7C
		public static bool IsValidJson(string strInput)
		{
			strInput = strInput.Trim();
			if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || (strInput.StartsWith("[") && strInput.EndsWith("]")))
			{
				try
				{
					JToken.Parse(strInput);
					return true;
				}
				catch (Exception)
				{
					return false;
				}
				return false;
			}
			return false;
		}
	}
}
