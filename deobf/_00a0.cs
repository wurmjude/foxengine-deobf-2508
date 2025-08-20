using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class _00A0 : WindowsFormsApplicationBase
{
	[CompilerGenerated]
	[AccessedThroughProperty("Domain")]
	private AppDomain m_AppDomain_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Domain5")]
	private AppDomain m_AppDomain_1680;

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void Main(string[] P_0)
	{
		Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		_2000._00A0_1680.Run(P_0);
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual AppDomain AppDomain_00A0()
	{
		return this.m_AppDomain_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void void_00A0(AppDomain P_0)
	{
		ResolveEventHandler value = Assembly_1680;
		AppDomain appDomain = this.m_AppDomain_00A0;
		if (appDomain != null)
		{
			appDomain.AssemblyResolve -= value;
		}
		this.m_AppDomain_00A0 = P_0;
		appDomain = this.m_AppDomain_00A0;
		if (appDomain != null)
		{
			appDomain.AssemblyResolve += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual AppDomain AppDomain_1680()
	{
		return this.m_AppDomain_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void void_1680(AppDomain P_0)
	{
		ResolveEventHandler value = Assembly_00A0;
		AppDomain appDomain = this.m_AppDomain_1680;
		if (appDomain != null)
		{
			appDomain.AssemblyResolve -= value;
		}
		this.m_AppDomain_1680 = P_0;
		appDomain = this.m_AppDomain_1680;
		if (appDomain != null)
		{
			appDomain.AssemblyResolve += value;
		}
	}

	private Assembly Assembly_00A0(object P_0, ResolveEventArgs P_1)
	{
		if (P_1.Name.Contains("Newtonsoft.Json"))
		{
			return Assembly.Load(_2001.byteArray_2003());
		}
		return null;
	}

	private Assembly Assembly_1680(object P_0, ResolveEventArgs P_1)
	{
		if (P_1.Name.Contains("CButtonLib"))
		{
			return Assembly.Load(_2001.byteArray_2002());
		}
		return null;
	}

	[DebuggerStepThrough]
	public _00A0()
		: base(AuthenticationMode.Windows)
	{
		void_00A0(AppDomain.CurrentDomain);
		void_1680(AppDomain.CurrentDomain);
		base.IsSingleInstance = false;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = false;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = _2000.__00A0_2001._200A_2003();
	}

	[DebuggerStepThrough]
	protected override bool OnInitialize(ReadOnlyCollection<string> P_0)
	{
		base.MinimumSplashScreenDisplayTime = 0;
		return base.OnInitialize(P_0);
	}
}
