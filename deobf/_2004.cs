using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class _2004
{
	[CompilerGenerated]
	internal sealed class __1680
	{
		public Process _00A0;

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_00A0.WaitForExit();
		}
	}

	public static string string_00A0(ref string P_0, ref string P_1, ref string P_2, ref string P_3)
	{
		try
		{
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get();
			foreach (ManagementObject item in managementObjectCollection)
			{
				P_0 = item["ProcessorId"].ToString();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			P_0 = "Nincs_Cpu_id";
			ProjectData.ClearProjectError();
		}
		try
		{
			ManagementObjectCollection managementObjectCollection2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get();
			foreach (ManagementObject item2 in managementObjectCollection2)
			{
				string text = item2["SerialNumber"].ToString();
				text = text.Replace(" ", "B");
				string queryString = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='", item2["DeviceID"]), "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition"));
				ManagementObjectCollection managementObjectCollection3 = new ManagementObjectSearcher(queryString).Get();
				foreach (ManagementObject item3 in managementObjectCollection3)
				{
					string queryString2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='", item3["DeviceID"]), "'} WHERE AssocClass = Win32_LogicalDiskToPartition"));
					ManagementObjectCollection managementObjectCollection4 = new ManagementObjectSearcher(queryString2).Get();
					foreach (ManagementObject item4 in managementObjectCollection4)
					{
						if (Operators.CompareString(item4["DeviceID"].ToString(), "C:", TextCompare: false) == 0)
						{
							P_1 = text;
						}
					}
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			P_1 = "SerialNo:09194477WOLO4DN56";
			ProjectData.ClearProjectError();
		}
		string text2 = "C";
		ManagementObject managementObject4 = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + text2 + ":\"");
		managementObject4.Get();
		P_2 = managementObject4["VolumeSerialNumber"].ToString();
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Product FROM Win32_BaseBoard");
		foreach (ManagementObject item5 in managementObjectSearcher.Get())
		{
			try
			{
				string text3 = item5.GetPropertyValue("Product").ToString();
				text3 = text3.Replace(" ", "B");
				P_3 = text3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				P_3 = "2hetmnoreadabledata";
				ProjectData.ClearProjectError();
			}
		}
		return string.Concat(string.Concat(P_0 + P_1, P_2), P_3);
	}

	public static string string_00A0(ref string P_0, ref string P_1, ref string P_2, ref string P_3, ref string P_4)
	{
		string text = "SOFTWARE\\Masbate\\License";
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey(text, writable: true) ?? Registry.LocalMachine.CreateSubKey(text);
			if (registryKey.GetValue("Serial") != null)
			{
				byte[] bytes = (byte[])registryKey.GetValue("Serial");
				string text2 = Encoding.UTF8.GetString(bytes);
				P_1 = text2;
			}
			else
			{
				string s = "0";
				byte[] bytes2 = Encoding.UTF8.GetBytes(s);
				registryKey.SetValue("Serial", bytes2, RegistryValueKind.Binary);
				P_1 = null;
			}
			if (registryKey.GetValue("Vevoid") != null)
			{
				byte[] bytes3 = (byte[])registryKey.GetValue("Vevoid");
				string text3 = Encoding.UTF8.GetString(bytes3);
				P_4 = text3;
			}
			else
			{
				string s2 = "0";
				byte[] bytes4 = Encoding.UTF8.GetBytes(s2);
				registryKey.SetValue("Vevoid", bytes4, RegistryValueKind.Binary);
				P_4 = null;
			}
			if (registryKey.GetValue("Status") != null)
			{
				P_0 = Conversions.ToString(registryKey.GetValue("Status"));
			}
			else
			{
				registryKey.SetValue("Status", "0", RegistryValueKind.DWord);
				P_0 = "0";
			}
			if (registryKey.GetValue("Vihar") != null)
			{
				P_2 = Conversions.ToString(registryKey.GetValue("Vihar"));
			}
			else
			{
				registryKey.SetValue("Vihar", "0", RegistryValueKind.String);
				P_2 = "0";
			}
			if (registryKey.GetValue("Barel") != null)
			{
				P_3 = Conversions.ToString(registryKey.GetValue("Barel"));
			}
			else
			{
				registryKey.SetValue("Barel", "0", RegistryValueKind.String);
				P_3 = "0";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Hiba történt: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey?.Close();
			}
		}
		return string.Concat(string.Concat(string.Concat(P_0 + P_1, P_2), P_3), P_4);
	}

	public static byte[] byteArray_00A0(byte[] P_0, byte[] P_1)
	{
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		int iterations = 1000;
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(P_1, salt, iterations, HashAlgorithmName.SHA256);
		using Aes aes = Aes.Create();
		aes.Key = rfc2898DeriveBytes.GetBytes(checked((int)Math.Round((double)aes.KeySize / 8.0)));
		aes.Mode = CipherMode.ECB;
		aes.Padding = PaddingMode.PKCS7;
		ICryptoTransform transform = aes.CreateEncryptor();
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			cryptoStream.Write(P_0, 0, P_0.Length);
		}
		return memoryStream.ToArray();
	}

	public static byte[] byteArray_1680(byte[] P_0, byte[] P_1)
	{
		byte[] result;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			int iterations = 1000;
			byte[] array;
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(P_1, salt, iterations, HashAlgorithmName.SHA256))
			{
				using Aes aes = Aes.Create();
				aes.Key = rfc2898DeriveBytes.GetBytes(checked((int)Math.Round((double)aes.KeySize / 8.0)));
				aes.Mode = CipherMode.ECB;
				aes.Padding = PaddingMode.PKCS7;
				ICryptoTransform transform = aes.CreateDecryptor();
				using MemoryStream stream = new MemoryStream(P_0);
				using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				using MemoryStream memoryStream = new MemoryStream();
				cryptoStream.CopyTo(memoryStream);
				array = memoryStream.ToArray();
			}
			result = array;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = new byte[0];
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static async void void_00A0(string P_0)
	{
		byte[] array = _2000._1680_00A0.FileSystem.ReadAllBytes("c:\\Windows\\Branding\\Masbate\\boot\\2hbootx64.efi");
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		byte[] bytes2 = byteArray_1680(array, bytes);
		string text = Path.Combine(path2: Guid.NewGuid().ToString() + ".exe", path1: "c:\\Windows\\Branding\\Masbate\\temp\\");
		File.WriteAllBytes(text, bytes2);
		Process process = new Process();
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			FileName = text
		};
		process.StartInfo = startInfo;
		process.Start();
		await Task.Run([SpecialName] () =>
		{
			process.WaitForExit();
		});
		await Task.Delay(3000);
		try
		{
			File.Delete(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Application.Exit();
	}

	public static string string_00A0()
	{
		return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJlMzk5MTRjMC0yZTM0LTQ0NzktYTJiOS04NjNhZWIwN2E4MTciLCJuYW1lIjoiMkgtTWFzYmF0ZSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFrdFJlZyIsImV4cCI6MTg3MzA2MDUzNCwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo1MDAwIiwiYXVkIjoiRm94Q29tbS1NYXNiYXRlIn0.XuNC7pvYVmpZmL-_huCpPBkYtRzvhQo7-1LcDqFpEZY";
	}

	public static bool bool_00A0(string P_0, string P_1, RSA P_2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		byte[] signature = Convert.FromBase64String(P_1);
		return P_2.VerifyData(bytes, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
	}

	public static string string_1680()
	{
		return "<RSAKeyValue><Modulus>ogMFZ7pkgQuHWYRR3JLrwhKQeMRuBTHaRjiYktIxItaLtUwYgxFGZYXK5iNBUKryoORVDMLVw2azWGqPleu7r2FCB+ljPmhxtJNiV170YVABqa3AQVs9z0RyZ4dih7RUW1etQvfPutboiEqN5tM5g4GjR3rtD+f/r/4dkQFdNcKAosURTGt19wygSVhetIqv7raYZ3gntjkLl+LqfCIorXf7zRJkF5fC5hWPTJe7A1ooqX5sjaI7k+X0h6xlMvll2UBDptDx1pc5tNT94vplWPbe9PYkWOR2uEOtExe6iJD6pqAiUF5Fv6ji2OYGmJZu0bO04ypnYkuImmhyqzF9kQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
	}

	public static string string_2000()
	{
		string text = string_00A0("Win32_Processor", "ProcessorId");
		string text2 = string_00A0("Win32_BaseBoard", "SerialNumber");
		string text3 = string_00A0("Win32_ComputerSystemProduct", "UUID");
		string text4 = string_00A0("Win32_BaseBoard", "Product");
		return string_1680((text + text2 + text3 + text4).Replace(" ", "B").Replace("+", "C").Replace("-", "D"));
	}

	private static string string_00A0(string P_0, string P_1)
	{
		string result;
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(string.Format("SELECT {0} FROM {1}", P_1, P_0));
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				string text = item[P_1]?.ToString();
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				result = text;
				goto IL_0080;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "N/A";
			ProjectData.ClearProjectError();
			goto IL_0080;
		}
		result = "N/A";
		goto IL_0080;
		IL_0080:
		return result;
	}

	private static string string_1680(string P_0)
	{
		using SHA256 sHA = SHA256.Create();
		byte[] array = sHA.ComputeHash(Encoding.UTF8.GetBytes(P_0));
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
