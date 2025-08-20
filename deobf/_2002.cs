using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class _2002 : ApplicationSettingsBase
{
	private static _2002 m_2002_00A0 = (_2002)SettingsBase.Synchronized(new _2002());

	private static bool m_bool_00A0;

	private static object m_object_00A0 = RuntimeHelpers.GetObjectValue(new object());

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void void_00A0(object P_0, EventArgs P_1)
	{
		if (_2000._00A0_1680.SaveMySettingsOnExit)
		{
			_2003._00A0.Save();
		}
	}

	[SpecialName]
	public static _2002 _00A0()
	{
		if (!m_bool_00A0)
		{
			object obj = _2002.m_object_00A0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				if (!m_bool_00A0)
				{
					_2000._00A0_1680.Shutdown += void_00A0;
					m_bool_00A0 = true;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
		return m_2002_00A0;
	}
}
