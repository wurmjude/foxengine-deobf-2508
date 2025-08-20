using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class _2009
{
	public static string string_00A0(string P_0, string P_1)
	{
		string text = "";
		string result;
		try
		{
			using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(P_0);
			if (registryKey != null)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(P_1));
				if (objectValue != null)
				{
					switch (registryKey.GetValueKind(P_1))
					{
					case RegistryValueKind.DWord:
						text = objectValue.ToString();
						break;
					case RegistryValueKind.String:
					case RegistryValueKind.ExpandString:
						text = objectValue.ToString();
						break;
					default:
						throw new ArgumentException("Ismeretlen értéktípus.");
					}
					goto IL_01b4;
				}
				result = text;
			}
			else
			{
				result = text;
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		goto IL_01b6;
		IL_01b4:
		result = text;
		goto IL_01b6;
		IL_01b6:
		return result;
	}

	public static string string_1680(string P_0, string P_1)
	{
		string text = "";
		string result;
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(P_0);
			if (registryKey != null)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(P_1));
				if (objectValue != null)
				{
					switch (registryKey.GetValueKind(P_1))
					{
					case RegistryValueKind.DWord:
						text = objectValue.ToString();
						break;
					case RegistryValueKind.String:
					case RegistryValueKind.ExpandString:
						text = objectValue.ToString();
						break;
					default:
						throw new ArgumentException("Ismeretlen értéktípus.");
					}
					goto IL_01b4;
				}
				result = text;
			}
			else
			{
				result = text;
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		goto IL_01b6;
		IL_01b4:
		result = text;
		goto IL_01b6;
		IL_01b6:
		return result;
	}

	public static string string_2000(string P_0, string P_1)
	{
		string text = "";
		string result;
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(P_0);
			if (registryKey != null)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(P_1));
				if (objectValue != null)
				{
					switch (registryKey.GetValueKind(P_1))
					{
					case RegistryValueKind.DWord:
						text = objectValue.ToString();
						break;
					case RegistryValueKind.String:
					case RegistryValueKind.ExpandString:
						text = objectValue.ToString();
						break;
					default:
						throw new ArgumentException("Ismeretlen értéktípus.");
					}
					goto IL_01b4;
				}
				result = text;
			}
			else
			{
				result = text;
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			result = text;
			ProjectData.ClearProjectError();
		}
		goto IL_01b6;
		IL_01b4:
		result = text;
		goto IL_01b6;
		IL_01b6:
		return result;
	}

	public static void void_00A0(string P_0, string P_1, string P_2, string P_3)
	{
		try
		{
			using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(P_0, writable: true) ?? Registry.ClassesRoot.CreateSubKey(P_0);
			string left = P_3.ToLower();
			if (Operators.CompareString(left, "dword", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "string", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, "expandstring", TextCompare: false) != 0)
					{
						throw new ArgumentException("Ismeretlen típus: " + P_3);
					}
					registryKey.SetValue(P_1, P_2, RegistryValueKind.ExpandString);
				}
				else
				{
					registryKey.SetValue(P_1, P_2, RegistryValueKind.String);
				}
			}
			else
			{
				registryKey.SetValue(P_1, Convert.ToInt32(P_2), RegistryValueKind.DWord);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_1680(string P_0, string P_1, string P_2, string P_3)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(P_0, writable: true) ?? Registry.CurrentUser.CreateSubKey(P_0);
			string left = P_3.ToLower();
			if (Operators.CompareString(left, "dword", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "string", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, "expandstring", TextCompare: false) != 0)
					{
						throw new ArgumentException("Ismeretlen típus: " + P_3);
					}
					registryKey.SetValue(P_1, P_2, RegistryValueKind.ExpandString);
				}
				else
				{
					registryKey.SetValue(P_1, P_2, RegistryValueKind.String);
				}
			}
			else
			{
				registryKey.SetValue(P_1, Convert.ToInt32(P_2), RegistryValueKind.DWord);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_2000(string P_0, string P_1, string P_2, string P_3)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(P_0, writable: true) ?? Registry.LocalMachine.CreateSubKey(P_0);
			string left = P_3.ToLower();
			if (Operators.CompareString(left, "dword", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "string", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, "expandstring", TextCompare: false) != 0)
					{
						throw new ArgumentException("Ismeretlen típus: " + P_3);
					}
					registryKey.SetValue(P_1, P_2, RegistryValueKind.ExpandString);
				}
				else
				{
					registryKey.SetValue(P_1, P_2, RegistryValueKind.String);
				}
			}
			else
			{
				registryKey.SetValue(P_1, Convert.ToInt32(P_2), RegistryValueKind.DWord);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_2001(string P_0, string P_1)
	{
		try
		{
			using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(P_0, writable: true);
			if (registryKey != null && registryKey.GetValueNames().Contains(P_1))
			{
				registryKey.DeleteValue(P_1);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_2002(string P_0, string P_1)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(P_0, writable: true);
			if (registryKey != null && registryKey.GetValueNames().Contains(P_1))
			{
				registryKey.DeleteValue(P_1);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_2003(string P_0, string P_1)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(P_0, writable: true);
			if (registryKey != null && registryKey.GetValueNames().Contains(P_1))
			{
				registryKey.DeleteValue(P_1);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0 + "\\" + P_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_00A0(string P_0)
	{
		try
		{
			using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(P_0, writable: true);
			if (registryKey != null)
			{
				Registry.ClassesRoot.DeleteSubKeyTree(P_0);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_1680(string P_0)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(P_0, writable: true);
			if (registryKey != null)
			{
				Registry.CurrentUser.DeleteSubKeyTree(P_0);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void void_2000(string P_0)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(P_0, writable: true);
			if (registryKey != null)
			{
				Registry.LocalMachine.DeleteSubKeyTree(P_0);
			}
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			Interaction.MsgBox("Hozzáférési hiba: " + ex2.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (SecurityException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SecurityException ex4 = ex3;
			Interaction.MsgBox("Biztonsági hiba: " + ex4.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (IOException ex5)
		{
			ProjectData.SetProjectError(ex5);
			IOException ex6 = ex5;
			Interaction.MsgBox("I/O hiba: " + ex6.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox("Általános hiba: " + ex8.Message + "\r\n" + P_0);
			ProjectData.ClearProjectError();
		}
	}
}
