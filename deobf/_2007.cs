
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[DesignerGenerated]
public class _2007 : Form
{
	private IContainer m_IContainer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label m_Label_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Initline")]
	private PictureBox m_PictureBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox m_PictureBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadStatus")]
	private Label m_Label_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Loadengine")]
	private Timer m_Timer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Bar")]
	private ProgressBar m_ProgressBar_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label m_Label_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("FoxTaskIcon")]
	private NotifyIcon m_NotifyIcon_00A0;

	private string m_string_00A0;

	private string m_string_1680;

	private string m_string_2000;

	private string m_string_2001;

	private string m_string_2002;

	private string m_string_2003;

	private string m_string_2004;

	private string m_string_2005;

	public _2007()
	{
		base.Load += void_00A0;
		base.FormClosing += void_00A0;
		void_00A0();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool P_0)
	{
		try
		{
			if (P_0 && this.m_IContainer_00A0 != null)
			{
				this.m_IContainer_00A0.Dispose();
			}
		}
		finally
		{
			base.Dispose(P_0);
		}
	}

	[DebuggerStepThrough]
	private void void_00A0()
	{
		this.m_IContainer_00A0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_2007));
		void_00A0(new Label());
		void_00A0(new PictureBox());
		void_1680(new PictureBox());
		void_1680(new Label());
		void_00A0(new Timer(this.m_IContainer_00A0));
		void_00A0(new ProgressBar());
		void_2000(new Label());
		void_00A0(new NotifyIcon(this.m_IContainer_00A0));
		((ISupportInitialize)PictureBox_2000()).BeginInit();
		((ISupportInitialize)PictureBox_2001()).BeginInit();
		SuspendLayout();
		Label_1680().AutoSize = true;
		Label_1680().BackColor = Color.Transparent;
		Label_1680().Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_1680().ForeColor = SystemColors.AppWorkspace;
		Label_1680().Location = new Point(134, 120);
		Label_1680().Name = "Label1";
		Label_1680().Size = new Size(141, 25);
		Label_1680().TabIndex = 0;
		Label_1680().Text = "PRELOADER";
		PictureBox_2000().BackColor = Color.Transparent;
		PictureBox_2000().Image = (Image)componentResourceManager.GetObject("Initline.Image");
		PictureBox_2000().Location = new Point(124, 148);
		PictureBox_2000().Name = "Initline";
		PictureBox_2000().Size = new Size(162, 31);
		PictureBox_2000().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2000().TabIndex = 48;
		PictureBox_2000().TabStop = false;
		PictureBox_2001().BackColor = Color.Transparent;
		PictureBox_2001().Cursor = Cursors.Default;
		PictureBox_2001().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox_2001().Location = new Point(150, 21);
		PictureBox_2001().Name = "PictureBox4";
		PictureBox_2001().Size = new Size(109, 93);
		PictureBox_2001().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2001().TabIndex = 62;
		PictureBox_2001().TabStop = false;
		Label_2002().BackColor = Color.Transparent;
		Label_2002().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2002().ForeColor = SystemColors.AppWorkspace;
		Label_2002().Location = new Point(12, 180);
		Label_2002().Name = "LoadStatus";
		Label_2002().Size = new Size(383, 28);
		Label_2002().TabIndex = 63;
		Label_2002().Text = "- - -";
		Label_2002().TextAlign = ContentAlignment.MiddleCenter;
		ProgressBar_2004().Location = new Point(401, 181);
		ProgressBar_2004().Name = "Bar";
		ProgressBar_2004().Size = new Size(10, 10);
		ProgressBar_2004().TabIndex = 64;
		ProgressBar_2004().Visible = false;
		Label_2005().AutoSize = true;
		Label_2005().BackColor = Color.Transparent;
		Label_2005().Cursor = Cursors.Hand;
		Label_2005().Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2005().ForeColor = Color.DarkRed;
		Label_2005().Location = new Point(389, 12);
		Label_2005().Name = "Label2";
		Label_2005().Size = new Size(14, 14);
		Label_2005().TabIndex = 65;
		Label_2005().Text = "X";
        NotifyIcon_2006().Icon = (Icon)componentResourceManager.GetObject("FoxTaskIcon.Icon");
        NotifyIcon_2006().Text = "2H FoxComm En-Dilla Licence Management System";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.Black;
		BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		base.ClientSize = new Size(416, 227);
		base.Controls.Add(Label_2005());
		base.Controls.Add(ProgressBar_2004());
		base.Controls.Add(Label_2002());
		base.Controls.Add(PictureBox_2001());
		base.Controls.Add(PictureBox_2000());
		base.Controls.Add(Label_1680());
		DoubleBuffered = true;
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Preloader";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "2H FoxComm Preloader";
		base.TopMost = true;
		((ISupportInitialize)PictureBox_2000()).EndInit();
		((ISupportInitialize)PictureBox_2001()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_1680()
	{
		return this.m_Label_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(Label P_0)
	{
		this.m_Label_00A0 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2000()
	{
		return this.m_PictureBox_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(PictureBox P_0)
	{
		this.m_PictureBox_00A0 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2001()
	{
		return this.m_PictureBox_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(PictureBox P_0)
	{
		this.m_PictureBox_1680 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2002()
	{
		return this.m_Label_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(Label P_0)
	{
		this.m_Label_1680 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer Timer_2003()
	{
		return this.m_Timer_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(Timer P_0)
	{
		EventHandler value = void_1680;
		Timer timer = this.m_Timer_00A0;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_Timer_00A0 = P_0;
		timer = this.m_Timer_00A0;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar ProgressBar_2004()
	{
		return this.m_ProgressBar_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(ProgressBar P_0)
	{
		this.m_ProgressBar_00A0 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2005()
	{
		return this.m_Label_2000;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2000(Label P_0)
	{
		EventHandler value = void_2000;
		Label label = this.m_Label_2000;
		if (label != null)
		{
			label.Click -= value;
		}
		this.m_Label_2000 = P_0;
		label = this.m_Label_2000;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual NotifyIcon NotifyIcon_2006()
	{
		return this.m_NotifyIcon_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(NotifyIcon P_0)
	{
		this.m_NotifyIcon_00A0 = P_0;
	}

	private void void_00A0(object P_0, EventArgs P_1)
	{
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		base.TransparencyKey = Color.LightBlue;
		BackColor = Color.LightBlue;
		int num = Screen.PrimaryScreen.WorkingArea.Width;
		checked
		{
			int num2 = Screen.PrimaryScreen.WorkingArea.Height - base.Height;
			while (num != Screen.PrimaryScreen.WorkingArea.Width - base.Width)
			{
				num--;
				base.Location = new Point(num, num2);
			}
			this.m_string_00A0 = _2004.string_2000();
			_2004.string_00A0(ref this.m_string_1680, ref this.m_string_2000, ref this.m_string_2002, ref this.m_string_2003, ref this.m_string_2005);
			void_2007();
			Timer_2003().Start();
		}
	}

	private void void_1680(object P_0, EventArgs P_1)
	{
		Timer_2003().Interval = 65;
        ProgressBar_2004().Increment(1);
		if (ProgressBar_2004().Value == 1)
		{
			Label_2002().Text = "Processing parameterized data...";
		}
		if (ProgressBar_2004().Value == 15)
		{
			Label_2002().Text = "FoxComm Audit checking...";
		}
		if (ProgressBar_2004().Value == 30)
		{
            Label_2002().Text = "Checking userdata query...";
		}
		if (ProgressBar_2004().Value == 55)
		{
            Label_2002().Text = "Checking username and passwd...";
		}
		if (ProgressBar_2004().Value == 75)
		{
            Label_2002().Text = "User registerning on the system...";
		}
		if (ProgressBar_2004().Value == 85)
		{
            Label_2002().Text = "All check completed preparoing boot to os...";
		}
		if (ProgressBar_2004().Value == 100)
		{
			Timer_2003().Stop();
			base.TopMost = false;
			base.ShowInTaskbar = false;
			Hide();
			NotifyIcon_2006().Visible = true;
			if (File.Exists("C:\\Windows\\Branding\\Masbate\\boot\\2hbootx64.efi"))
			{
				_2004.void_00A0(this.m_string_2004);
				return;
			}
			Hide();
			Interaction.MsgBox("Hiányzó 2H Bootloader! hívja a forgalmazót!");
			Application.Exit();
		}
	}

	private async void void_2007()
	{
		string xmlString = _2004.string_1680();
		RSA rSA = RSA.Create();
		rSA.FromXmlString(xmlString);
		string text = _2004.string_00A0();
		string text2 = string.Format("https://dimitris.masbate.hu/Digital/Digload?Systemid={0}", this.m_string_00A0);
		HttpClient val = new HttpClient();
		try
		{
			((HttpHeaders)val.DefaultRequestHeaders).Add("Authorization", "Bearer " + text);
			val.Timeout = TimeSpan.FromSeconds(5.0);
			try
			{
				HttpResponseMessage val2 = await val.GetAsync(text2);
				try
				{
					if (val2.StatusCode == HttpStatusCode.GatewayTimeout)
					{
						Hide();
						Timer_2003().Stop();
						MessageBox.Show("A 2H Szerverek nem elérhetők, karbantartás miatt! Próbálja később!", "2H Szerverkapcsolat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.Exit();
					}
					else if (val2.StatusCode == HttpStatusCode.InternalServerError)
					{
						Hide();
                        Timer_2003().Stop();
						MessageBox.Show("Hiba a folyamatban! IS. Err.", "2H Authentikációs folyamat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.ExitThread();
						Application.Exit();
					}
					else if (val2.StatusCode == HttpStatusCode.BadRequest)
					{
						Hide();
						string result = val2.Content.ReadAsStringAsync().Result;
                        Timer_2003().Stop();
						MessageBox.Show(result, "2H FoxComm - Br. Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.ExitThread();
						Application.Exit();
					}
					else if (val2.StatusCode == HttpStatusCode.Unauthorized)
					{
                        Timer_2003().Stop();
						MessageBox.Show("Lejárt terméktámogatás! Hívja az üzemeltetőt!", "2H FoxComm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.Exit();
					}
					else
					{
						if (val2.StatusCode != HttpStatusCode.OK)
						{
							return;
						}
						JObject val3 = JObject.Parse(await val2.Content.ReadAsStringAsync());
						try
						{
							JObject val4 = val3["data"].ToObject<JObject>();
							string text3 = val3["signo"].ToString();
							if (_2004.bool_00A0(JsonConvert.SerializeObject((object)val4), text3, rSA))
							{
								this.m_string_2003 = val4["token"].ToString();
								this.m_string_2002 = val4["fel"].ToString();
								void_2008();
							}
							else
							{
								Hide();
								MessageBox.Show("A kapcsolatfelépítés hamisított! A válasz nem a 2H szerverétől érkezett!\r\nA szoftvert illágálisan aktiválták! Ha jogtisztán szeretné használni, vegye fel a kapcsolatot a 2H Informatika ügyfélszolgálattal!");
								Application.Exit();
							}
							return;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Hide();
				MessageBox.Show("Hálózati hiba történt! Próbálja később!", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
				ProjectData.ClearProjectError();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void void_2008()
	{
		string subkey = "SOFTWARE\\Masbate\\License";
		using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(subkey))
		{
			registryKey.SetValue("Vihar", this.m_string_2002, RegistryValueKind.String);
			registryKey.SetValue("Barel", this.m_string_2003, RegistryValueKind.String);
			registryKey.Close();
		}
		byte[] bytes = Encoding.UTF8.GetBytes(_2004.string_2000());
		try
		{
			byte[] bytes2 = _2004.byteArray_1680(Convert.FromBase64String(this.m_string_2002), bytes);
			string text = Encoding.UTF8.GetString(bytes2).Substring(5);
			string text2 = text.Substring(0, checked(text.Length - 11));
			this.m_string_2004 = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void void_00A0(object P_0, FormClosingEventArgs P_1)
	{
		Application.Exit();
	}

	private void void_2000(object P_0, EventArgs P_1)
	{
		Application.Exit();
	}
}
