using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class _2001
{
	private static ResourceManager m_ResourceManager_00A0;

	private static CultureInfo m_CultureInfo_00A0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_00A0
    {
		get
		{
			if (object.ReferenceEquals(m_ResourceManager_00A0, null))
			{
				m_ResourceManager_00A0 = new ResourceManager("Foxengine.Resources", typeof(_2001).Assembly);
			}
			return m_ResourceManager_00A0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_1680
    {
		get
		{
			return m_CultureInfo_00A0;
		}
		set
		{
			//m_CultureInfo_00A0 = cultureInfo;
		}
	}

	[SpecialName]
	internal static Bitmap Bitmap_2000()
	{
		return (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager_00A0.GetObject("_1X1PIPA", m_CultureInfo_00A0));
	}

	[SpecialName]
	internal static Bitmap Bitmap_2001()
	{
		return (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager_00A0.GetObject("_1X1PIPA_allando", m_CultureInfo_00A0));
	}

	[SpecialName]
	internal static byte[] byteArray_2002()
	{
		return (byte[])RuntimeHelpers.GetObjectValue(ResourceManager_00A0.GetObject("CButtonLib", m_CultureInfo_00A0));
	}

	[SpecialName]
	internal static byte[] byteArray_2003()
	{
		return (byte[])RuntimeHelpers.GetObjectValue(ResourceManager_00A0.GetObject("Newtonsoft_Json", m_CultureInfo_00A0));
	}

	[SpecialName]
	internal static byte[] byteArray_2004()
	{
		return (byte[])RuntimeHelpers.GetObjectValue(ResourceManager_00A0.GetObject("WinFormAnimation", m_CultureInfo_00A0));
	}
}
