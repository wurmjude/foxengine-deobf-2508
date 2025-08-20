using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class _2000
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class __00A0
	{
		[ThreadStatic]
		private static Hashtable m_Hashtable_00A0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public _2008 _2008_00A0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public _2005 _2005_00A0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public _2006 _2006_00A0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public _2007 _2007_00A0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public _200A _200A_00A0;

		[DebuggerHidden]
		private static _00A0 _00A0_00A0<_00A0>(_00A0 P_0) where _00A0 : Form, new()
		{
			if (P_0 == null || P_0.IsDisposed)
			{
				if (m_Hashtable_00A0 != null)
				{
					if (m_Hashtable_00A0.ContainsKey(typeof(_00A0)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_Hashtable_00A0 = new Hashtable();
				}
				m_Hashtable_00A0.Add(typeof(_00A0), null);
				try
				{
					return new _00A0();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
				}
				finally
				{
					m_Hashtable_00A0.Remove(typeof(_00A0));
				}
			}
			return P_0;
		}

		[DebuggerHidden]
		private void void_00A0<_00A0>(ref _00A0 P_0) where _00A0 : Form
		{
			P_0.Dispose();
			P_0 = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public __00A0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object P_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Type_00A0()
		{
			return typeof(_00A0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[SpecialName]
		public _2008 _2008_1680()
		{
			this._2008_00A0 = _00A0_00A0<_2008>(this._2008_00A0);
			return this._2008_00A0;
		}

		[SpecialName]
		public _2005 _2005_2000()
		{
			this._2005_00A0 = _00A0_00A0<_2005>(this._2005_00A0);
			return this._2005_00A0;
		}

		[SpecialName]
		public _2006 _2006_2001()
		{
			this._2006_00A0 = _00A0_00A0<_2006>(this._2006_00A0);
			return this._2006_00A0;
		}

		[SpecialName]
		public _2007 _2007_2002()
		{
			this._2007_00A0 = _00A0_00A0<_2007>(this._2007_00A0);
			return this._2007_00A0;
		}

		[SpecialName]
		public _200A _200A_2003()
		{
			this._200A_00A0 = _00A0_00A0<_200A>(this._200A_00A0);
			return this._200A_00A0;
		}

		[SpecialName]
		public void void_00A0(_2008 P_0)
		{
			if (P_0 != this._2008_00A0)
			{
				if (P_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				void_00A0(ref this._2008_00A0);
			}
		}

		[SpecialName]
		public void void_00A0(_2005 P_0)
		{
			if (P_0 != this._2005_00A0)
			{
				if (P_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				void_00A0(ref this._2005_00A0);
			}
		}

		[SpecialName]
		public void void_00A0(_2006 P_0)
		{
			if (P_0 != this._2006_00A0)
			{
				if (P_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				void_00A0(ref this._2006_00A0);
			}
		}

		[SpecialName]
		public void void_00A0(_2007 P_0)
		{
			if (P_0 != this._2007_00A0)
			{
				if (P_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				void_00A0(ref this._2007_00A0);
			}
		}

		[SpecialName]
		public void void_00A0(_200A P_0)
		{
			if (P_0 != this._200A_00A0)
			{
				if (P_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				void_00A0(ref this._200A_00A0);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class __1680
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object P_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type _00A0()
		{
			return typeof(__1680);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static _00A0 _00A0<_00A0>(_00A0 P_0) where _00A0 : new()
		{
			if (P_0 == null)
			{
				return new _00A0();
			}
			return P_0;
		}

		[DebuggerHidden]
		private void void_00A0<_00A0>(ref _00A0 P_0)
		{
			P_0 = default(_00A0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public __1680()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class __2000<_00A0> where _00A0 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static _00A0 m_00A0_00A0;

		[SpecialName]
		[DebuggerHidden]
		internal _00A0 _00A0_00A0()
		{
			if (m_00A0_00A0 == null)
			{
				m_00A0_00A0 = new _00A0();
			}
			return m_00A0_00A0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public __2000()
		{
		}
	}

	private static readonly __2000<_1680> m_2000_1680_00A0 = new __2000<_1680>();

	private static readonly __2000<_00A0> m_2000_00A0_00A0 = new __2000<_00A0>();

	private static readonly __2000<User> m_2000_User_00A0 = new __2000<User>();

	private static __2000<__00A0> m_2000_00A0_00A0_2 = new __2000<__00A0>();

	private static readonly __2000<__1680> m_2000_1680_00A0_2 = new __2000<__1680>();

	[HelpKeyword("My.Computer")]
	internal static _1680 _1680_00A0
    {
		[DebuggerHidden]
		get
		{
			return m_2000_1680_00A0._00A0_00A0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static _00A0 _00A0_1680
    {
		[DebuggerHidden]
		get
		{
			return m_2000_00A0_00A0._00A0_00A0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_2000
    {
		[DebuggerHidden]
		get
		{
			return m_2000_User_00A0._00A0_00A0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static __00A0 __00A0_2001
    {
		[DebuggerHidden]
		get
		{
			return m_2000_00A0_00A0_2._00A0_00A0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static __1680 __1680_2002
    {
		[DebuggerHidden]
		get
		{
			return m_2000_1680_00A0_2._00A0_00A0();
		}
	}
}
