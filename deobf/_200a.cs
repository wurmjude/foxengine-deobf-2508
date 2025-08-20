using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[DesignerGenerated]
public class _200A : Form
{
	private IContainer m_IContainer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox1")]
	private TextBox m_TextBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Initline")]
	private PictureBox m_PictureBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox m_CheckBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label m_Label_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("af_inet")]
	private Label m_Label_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label m_Label_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("Securebootstatus")]
	private Label m_Label_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel m_Panel_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Firebutton")]
	private CButton m_CButton_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Kisturelmet")]
	private Label m_Label_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("Initialtime")]
	private Timer m_Timer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Initbar")]
	private ProgressBar m_ProgressBar_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel2")]
	private Panel m_Panel_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox m_PictureBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox m_PictureBox_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox m_PictureBox_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("CButton2")]
	private CButton m_CButton_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox m_PictureBox_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox m_PictureBox_2003;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox6")]
	private PictureBox m_PictureBox_2004;

	private string m_string_00A0;

	private string m_string_1680;

	private string m_string_2000;

	private string m_string_2001;

	private string m_string_2002;

	private string m_string_2003;

	private string m_string_2004;

	private string m_string_2005;

	private bool m_bool_00A0;

	private bool m_bool_1680;

	public _200A()
	{
		base.Load += void_00A0;
		base.FormClosing += void_00A0;
		base.KeyDown += void_00A0;
		this.m_bool_00A0 = false;
		this.m_bool_1680 = false;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_200A));
		cBlendItems val = new cBlendItems();
		cBlendItems val2 = new cBlendItems();
		void_00A0(new TextBox());
		void_00A0(new PictureBox());
		void_00A0(new CheckBox());
		void_00A0(new Label());
		void_1680(new Label());
		void_2000(new Label());
		void_2001(new Label());
		void_00A0(new Panel());
		void_2002(new Label());
		void_00A0(new CButton());
		void_00A0(new Timer(this.m_IContainer_00A0));
		void_00A0(new ProgressBar());
		void_1680(new Panel());
		void_1680(new CButton());
		void_1680(new PictureBox());
		void_2000(new PictureBox());
		void_2001(new PictureBox());
		void_2002(new PictureBox());
		void_2003(new PictureBox());
		void_2004(new PictureBox());
		((ISupportInitialize)PictureBox_2000()).BeginInit();
		Panel_2006().SuspendLayout();
		Panel_200B().SuspendLayout();
		((ISupportInitialize)PictureBox_2010()).BeginInit();
		((ISupportInitialize)PictureBox_2011()).BeginInit();
		((ISupportInitialize)PictureBox_2012()).BeginInit();
		((ISupportInitialize)PictureBox_2014()).BeginInit();
		((ISupportInitialize)PictureBox_2015()).BeginInit();
		((ISupportInitialize)PictureBox_2022()).BeginInit();
		SuspendLayout();
		TextBox_1680().BackColor = Color.Black;
		TextBox_1680().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_1680().ForeColor = Color.Silver;
		TextBox_1680().Location = new Point(26, 21);
		TextBox_1680().Multiline = true;
		TextBox_1680().Name = "TextBox1";
		TextBox_1680().ReadOnly = true;
		TextBox_1680().ScrollBars = ScrollBars.Vertical;
		TextBox_1680().Size = new Size(634, 323);
		TextBox_1680().TabIndex = 1;
		TextBox_1680().Text = componentResourceManager.GetString("TextBox1.Text");
		TextBox_1680().TextAlign = HorizontalAlignment.Center;
		PictureBox_2000().BackColor = Color.Transparent;
		PictureBox_2000().Image = (Image)componentResourceManager.GetObject("Initline.Image");
		PictureBox_2000().Location = new Point(118, 27);
		PictureBox_2000().Name = "Initline";
		PictureBox_2000().Size = new Size(162, 31);
		PictureBox_2000().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2000().TabIndex = 47;
		PictureBox_2000().TabStop = false;
		CheckBox_2001().AutoSize = true;
		CheckBox_2001().BackColor = Color.Transparent;
		CheckBox_2001().Enabled = false;
		CheckBox_2001().Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 238);
		CheckBox_2001().ForeColor = Color.White;
		CheckBox_2001().Location = new Point(182, 353);
		CheckBox_2001().Name = "CheckBox1";
		CheckBox_2001().Size = new Size(350, 28);
		CheckBox_2001().TabIndex = 46;
		CheckBox_2001().Text = "Elfogadom a használati feltételeket";
		CheckBox_2001().UseVisualStyleBackColor = false;
		Label_2002().AutoSize = true;
		Label_2002().BackColor = Color.Transparent;
		Label_2002().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2002().ForeColor = Color.DarkGray;
		Label_2002().Location = new Point(41, 23);
		Label_2002().Name = "Label1";
		Label_2002().Size = new Size(136, 19);
		Label_2002().TabIndex = 51;
		Label_2002().Text = "Internetkapcsolat:";
		Label_2002().Visible = false;
		Label_2003().AutoSize = true;
		Label_2003().BackColor = Color.Transparent;
		Label_2003().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2003().ForeColor = Color.DarkGray;
		Label_2003().Location = new Point(188, 23);
		Label_2003().Name = "af_inet";
		Label_2003().Size = new Size(96, 19);
		Label_2003().TabIndex = 52;
		Label_2003().Text = "Kpacsolódva";
		Label_2003().Visible = false;
		Label_2004().AutoSize = true;
		Label_2004().BackColor = Color.Transparent;
		Label_2004().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2004().ForeColor = Color.DarkGray;
		Label_2004().Location = new Point(39, 70);
		Label_2004().Name = "Label2";
		Label_2004().Size = new Size(146, 19);
		Label_2004().TabIndex = 53;
		Label_2004().Text = "Secureboot állapot:";
		Label_2004().Visible = false;
		Label_2005().AutoSize = true;
		Label_2005().BackColor = Color.Transparent;
		Label_2005().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2005().ForeColor = Color.DarkGray;
		Label_2005().Location = new Point(188, 70);
		Label_2005().Name = "Securebootstatus";
		Label_2005().Size = new Size(107, 19);
		Label_2005().TabIndex = 54;
		Label_2005().Text = "Letiltva ( OK )";
		Label_2005().Visible = false;
		Panel_2006().BackgroundImage = (Image)componentResourceManager.GetObject("Panel1.BackgroundImage");
		Panel_2006().BackgroundImageLayout = ImageLayout.Stretch;
		Panel_2006().Controls.Add(PictureBox_2022());
		Panel_2006().Controls.Add(Label_2008());
		Panel_2006().Controls.Add(Label_2002());
		Panel_2006().Controls.Add(Label_2005());
		Panel_2006().Controls.Add(PictureBox_2000());
		Panel_2006().Controls.Add(Label_2004());
		Panel_2006().Controls.Add(Label_2003());
		Panel_2006().Location = new Point(149, 396);
		Panel_2006().Name = "Panel1";
		Panel_2006().Size = new Size(398, 109);
		Panel_2006().TabIndex = 57;
		Label_2008().AutoSize = true;
		Label_2008().BackColor = Color.Transparent;
		Label_2008().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2008().ForeColor = Color.DarkGray;
		Label_2008().Location = new Point(104, 66);
		Label_2008().Name = "Kisturelmet";
		Label_2008().Size = new Size(193, 19);
		Label_2008().TabIndex = 57;
		Label_2008().Text = "Előkészítés, kis türelmet...";
		CButton_2007().BorderColor = Color.Orange;
		val.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(34, 4, 99),
			Color.FromArgb(15, 3, 41)
		};
		val.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_2007().ColorFillBlend = val;
		CButton_2007().Corners.All = 5;
		CButton_2007().Corners.LowerLeft = 5;
		CButton_2007().Corners.LowerRight = 5;
		CButton_2007().Corners.UpperLeft = 5;
		CButton_2007().Corners.UpperRight = 5;
		CButton_2007().DesignerSelected = false;
		CButton_2007().DimFactorHover = 20;
		CButton_2007().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_2007().ForeColor = Color.Silver;
		CButton_2007().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_2007().ImageIndex = 0;
		CButton_2007().ImageSize = new Size(25, 25);
		((Control)(object)CButton_2007()).Location = new Point(193, 523);
		((Control)(object)CButton_2007()).Name = "Firebutton";
		((Control)(object)CButton_2007()).Size = new Size(305, 35);
		((Control)(object)CButton_2007()).TabIndex = 58;
		((Control)(object)CButton_2007()).Tag = "0";
		CButton_2007().Text = "START";
		CButton_2007().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_2007().TextShadow = Color.Black;
		ProgressBar_200A().Location = new Point(9, 10);
		ProgressBar_200A().Name = "Initbar";
		ProgressBar_200A().Size = new Size(10, 10);
		ProgressBar_200A().TabIndex = 59;
		ProgressBar_200A().Visible = false;
		Panel_200B().BackgroundImage = (Image)componentResourceManager.GetObject("Panel2.BackgroundImage");
		Panel_200B().BackgroundImageLayout = ImageLayout.Stretch;
		Panel_200B().Controls.Add((Control)(object)CButton_2013());
		Panel_200B().Controls.Add(PictureBox_2010());
		Panel_200B().Controls.Add(PictureBox_2011());
		Panel_200B().Controls.Add(PictureBox_2012());
		Panel_200B().Location = new Point(9, 26);
		Panel_200B().Name = "Panel2";
		Panel_200B().Size = new Size(10, 12);
		Panel_200B().TabIndex = 60;
		CButton_2013().BorderColor = Color.Orange;
		val2.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(34, 4, 99),
			Color.FromArgb(15, 3, 41)
		};
		val2.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_2013().ColorFillBlend = val2;
		CButton_2013().Corners.All = 5;
		CButton_2013().Corners.LowerLeft = 5;
		CButton_2013().Corners.LowerRight = 5;
		CButton_2013().Corners.UpperLeft = 5;
		CButton_2013().Corners.UpperRight = 5;
		CButton_2013().DesignerSelected = false;
		CButton_2013().DimFactorHover = 20;
		CButton_2013().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_2013().ForeColor = Color.Silver;
		CButton_2013().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_2013().ImageIndex = 0;
		CButton_2013().ImageSize = new Size(25, 25);
		((Control)(object)CButton_2013()).Location = new Point(34, 376);
		((Control)(object)CButton_2013()).Name = "CButton2";
		((Control)(object)CButton_2013()).Size = new Size(223, 47);
		((Control)(object)CButton_2013()).TabIndex = 61;
		CButton_2013().Text = "Megértettem";
		CButton_2013().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_2013().TextShadow = Color.Black;
		PictureBox_2010().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox_2010().Location = new Point(18, 22);
		PictureBox_2010().Name = "PictureBox1";
		PictureBox_2010().Size = new Size(600, 91);
		PictureBox_2010().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2010().TabIndex = 3;
		PictureBox_2010().TabStop = false;
		PictureBox_2011().Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox_2011().Location = new Point(18, 119);
		PictureBox_2011().Name = "PictureBox3";
		PictureBox_2011().Size = new Size(600, 229);
		PictureBox_2011().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2011().TabIndex = 5;
		PictureBox_2011().TabStop = false;
		PictureBox_2012().Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox_2012().Location = new Point(18, 451);
		PictureBox_2012().Name = "PictureBox2";
		PictureBox_2012().Size = new Size(600, 88);
		PictureBox_2012().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2012().TabIndex = 4;
		PictureBox_2012().TabStop = false;
		PictureBox_2014().BackColor = Color.Transparent;
		PictureBox_2014().Cursor = Cursors.Default;
		PictureBox_2014().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox_2014().Location = new Point(553, 391);
		PictureBox_2014().Name = "PictureBox4";
		PictureBox_2014().Size = new Size(122, 119);
		PictureBox_2014().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2014().TabIndex = 61;
		PictureBox_2014().TabStop = false;
		PictureBox_2015().BackColor = Color.Transparent;
		PictureBox_2015().Cursor = Cursors.Default;
		PictureBox_2015().Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox_2015().Location = new Point(6, 392);
		PictureBox_2015().Name = "PictureBox5";
		PictureBox_2015().Size = new Size(122, 119);
		PictureBox_2015().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2015().TabIndex = 62;
		PictureBox_2015().TabStop = false;
		PictureBox_2022().BackColor = Color.Transparent;
		PictureBox_2022().Cursor = Cursors.Hand;
		PictureBox_2022().Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox_2022().Location = new Point(320, 28);
		PictureBox_2022().Name = "PictureBox6";
		PictureBox_2022().Size = new Size(42, 35);
		PictureBox_2022().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2022().TabIndex = 61;
		PictureBox_2022().TabStop = false;
		PictureBox_2022().Visible = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.Black;
		BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		BackgroundImageLayout = ImageLayout.Stretch;
		base.ClientSize = new Size(684, 575);
		base.Controls.Add(Panel_200B());
		base.Controls.Add(PictureBox_2014());
		base.Controls.Add(ProgressBar_200A());
		base.Controls.Add((Control)(object)CButton_2007());
		base.Controls.Add(Panel_2006());
		base.Controls.Add(CheckBox_2001());
		base.Controls.Add(TextBox_1680());
		base.Controls.Add(PictureBox_2015());
		DoubleBuffered = true;
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Welcome";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Üdvözli önt a 2H FoxComm 4.1";
		base.TopMost = true;
		((ISupportInitialize)PictureBox_2000()).EndInit();
		Panel_2006().ResumeLayout(performLayout: false);
		Panel_2006().PerformLayout();
		Panel_200B().ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox_2010()).EndInit();
		((ISupportInitialize)PictureBox_2011()).EndInit();
		((ISupportInitialize)PictureBox_2012()).EndInit();
		((ISupportInitialize)PictureBox_2014()).EndInit();
		((ISupportInitialize)PictureBox_2015()).EndInit();
		((ISupportInitialize)PictureBox_2022()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox TextBox_1680()
	{
		return this.m_TextBox_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(TextBox P_0)
	{
		this.m_TextBox_00A0 = P_0;
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
	internal virtual CheckBox CheckBox_2001()
	{
		return this.m_CheckBox_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(CheckBox P_0)
	{
		EventHandler value = void_1680;
		CheckBox checkBox = this.m_CheckBox_00A0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_CheckBox_00A0 = P_0;
		checkBox = this.m_CheckBox_00A0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2002()
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
	internal virtual Label Label_2003()
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
	internal virtual Label Label_2004()
	{
		return this.m_Label_2000;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2000(Label P_0)
	{
		this.m_Label_2000 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2005()
	{
		return this.m_Label_2001;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2001(Label P_0)
	{
		this.m_Label_2001 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel Panel_2006()
	{
		return this.m_Panel_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(Panel P_0)
	{
		this.m_Panel_00A0 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CButton CButton_2007()
	{
		return this.m_CButton_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(CButton P_0)
	{
        CButton.ClickButtonAreaEventHandler val = new CButton.ClickButtonAreaEventHandler(void_1680);
		CButton val2 = this.m_CButton_00A0;
		if (val2 != null)
		{
			val2.ClickButtonArea -= val;
		}
		this.m_CButton_00A0 = P_0;
		val2 = this.m_CButton_00A0;
		if (val2 != null)
		{
			val2.ClickButtonArea += val;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2008()
	{
		return this.m_Label_2002;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2002(Label P_0)
	{
		this.m_Label_2002 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer Timer_2009()
	{
		return this.m_Timer_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(Timer P_0)
	{
		EventHandler value = void_2000;
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
	internal virtual ProgressBar ProgressBar_200A()
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
	internal virtual Panel Panel_200B()
	{
		return this.m_Panel_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(Panel P_0)
	{
		this.m_Panel_1680 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2010()
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
	internal virtual PictureBox PictureBox_2011()
	{
		return this.m_PictureBox_2000;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2000(PictureBox P_0)
	{
		this.m_PictureBox_2000 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2012()
	{
		return this.m_PictureBox_2001;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2001(PictureBox P_0)
	{
		this.m_PictureBox_2001 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CButton CButton_2013()
	{
		return this.m_CButton_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(CButton P_0)
	{
        CButton.ClickButtonAreaEventHandler val = new CButton.ClickButtonAreaEventHandler(void_00A0);
		CButton val2 = this.m_CButton_1680;
		if (val2 != null)
		{
			val2.ClickButtonArea -= val;
		}
		this.m_CButton_1680 = P_0;
		val2 = this.m_CButton_1680;
		if (val2 != null)
		{
			val2.ClickButtonArea += val;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2014()
	{
		return this.m_PictureBox_2002;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2002(PictureBox P_0)
	{
		this.m_PictureBox_2002 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2015()
	{
		return this.m_PictureBox_2003;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2003(PictureBox P_0)
	{
		this.m_PictureBox_2003 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2022()
	{
		return this.m_PictureBox_2004;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2004(PictureBox P_0)
	{
		EventHandler value = void_2001;
		PictureBox pictureBox = this.m_PictureBox_2004;
		if (pictureBox != null)
		{
			pictureBox.Click -= value;
		}
		this.m_PictureBox_2004 = P_0;
		pictureBox = this.m_PictureBox_2004;
		if (pictureBox != null)
		{
			pictureBox.Click += value;
		}
	}

	private void void_00A0(object P_0, EventArgs P_1)
	{
		checked
		{
			int num = (int)Math.Round((double)(Screen.PrimaryScreen.Bounds.Width - base.Width) / 2.0);
			int num2 = (int)Math.Round((double)(Screen.PrimaryScreen.Bounds.Height - base.Height) / 2.0);
			base.Location = new Point(num, num2);
			Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
			try
			{
				Process[] array = processesByName;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Id != Process.GetCurrentProcess().Id)
					{
						MessageBox.Show("A FoxComm már el van indítva!", "FoxComm Already Running!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.Exit();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			_2004.string_00A0(ref this.m_string_00A0, ref this.m_string_1680, ref this.m_string_2001, ref this.m_string_2003, ref this.m_string_2004);
			Timer_2009().Start();
			CButton_2007().Text = "Használati feltételek elfogadása!";
			((Control)(object)CButton_2007()).BackColor = Color.Crimson;
			((Control)(object)CButton_2007()).Enabled = false;
			CheckBox_2001().Select();
			void_2025();
		}
	}

	private void void_2024()
	{
		if (Operators.CompareString(this.m_string_00A0, "0", TextCompare: false) == 0)
		{
			Hide();
			_2000.__00A0_2001._2006_2001().Show();
		}
		else if (Operators.CompareString(this.m_string_00A0, "1", TextCompare: false) == 0)
		{
			Hide();
			_2000.__00A0_2001._2007_2002().Show();
		}
		else if (Operators.CompareString(this.m_string_00A0, "2", TextCompare: false) == 0)
		{
			MessageBox.Show("Fox Licenc letiltva! Hívja a forgalmazót", "2H FoxComm - The ID has been blocked", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else if (Operators.CompareString(this.m_string_00A0, "5", TextCompare: false) != 0)
		{
			MessageBox.Show("Érvénytelen registry adat! (Módosítás észlelve!)", "2H FoxComm - Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void void_1680(object P_0, EventArgs P_1)
	{
		if (CheckBox_2001().Checked)
		{
			((Control)(object)CButton_2007()).BackColor = Color.Lime;
			((Control)(object)CButton_2007()).Enabled = true;
			CButton_2007().Text = "2H FoxComm Indítása";
		}
		else
		{
			CButton_2007().Text = "Használati feltételek elfogadása!";
			((Control)(object)CButton_2007()).BackColor = Color.Crimson;
			((Control)(object)CButton_2007()).Enabled = false;
		}
	}

	public async void void_2025()
	{
		using (Ping ping = new Ping())
		{
			try
			{
				if ((await ping.SendPingAsync("google.com")).Status == IPStatus.Success)
				{
					Label_2003().Text = "Kapcsolódva";
					Label_2003().ForeColor = Color.LimeGreen;
					this.m_bool_00A0 = true;
					void_2027();
				}
				else
				{
					Label_2003().Text = "Nincs kapocsolat";
					Label_2003().ForeColor = Color.DarkRed;
					this.m_bool_00A0 = false;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Label_2003().Text = "Nincs kapocsolat";
				Label_2003().ForeColor = Color.DarkRed;
				this.m_bool_00A0 = false;
				ProjectData.ClearProjectError();
			}
		}
		this.m_string_2005 = _2009.string_2000("SYSTEM\\CurrentControlSet\\Control\\SecureBoot\\State", "UEFISecureBootEnabled");
		if (Operators.CompareString(this.m_string_2005, "0", TextCompare: false) != 0)
		{
			this.m_string_2005 = "nincs";
		}
		if (Operators.CompareString(this.m_string_2005, "0", TextCompare: false) == 0)
		{
			this.m_bool_1680 = true;
			Label_2005().Text = "Letiltva ( OK )";
			Label_2005().ForeColor = Color.LimeGreen;
		}
		else if (Operators.CompareString(this.m_string_2005, "nincs", TextCompare: false) == 0)
		{
			this.m_bool_1680 = true;
			Label_2005().Text = "MBR fájlrendszer (NSB)";
			Label_2005().ForeColor = Color.LimeGreen;
		}
		else
		{
			this.m_bool_1680 = false;
			Label_2005().Text = "Bekapcsolva (Aktív)";
			Label_2005().ForeColor = Color.DarkRed;
		}
	}

	private async void void_2027()
	{
		string xmlString = _2004.string_1680();
		RSA rSA = RSA.Create();
		rSA.FromXmlString(xmlString);
		string text = _2004.string_00A0();
		string text2 = string.Format("https://dimitris.masbate.hu/Checklua/Lichek?Lic={0}", this.m_string_1680);
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
						MessageBox.Show("A 2H Szerverek nem elérhetők, karbantartás miatt! Próbálja később!", "2H Szerverkapcsolat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.Exit();
					}
					else if (val2.StatusCode == HttpStatusCode.InternalServerError)
					{
						CheckBox_2001().Enabled = false;
					}
					else if (val2.StatusCode == HttpStatusCode.BadRequest)
					{
                        CheckBox_2001().Enabled = false;
					}
					else if (val2.StatusCode == HttpStatusCode.Unauthorized)
					{
						Hide();
						MessageBox.Show("Lejárt terméktámogatás! Hívja az üzemeltetőt!", "2H FoxComm - Rendszer-azonosítás", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
								this.m_string_00A0 = val4["szint"].ToString();
							}
							else
							{
								Hide();
								MessageBox.Show("A kapcsolatfelépítés hamisított! A válasz nem a 2H szerverétől érkezett!\r\nA szoftvert illágálisan aktiválták! Ha jogtisztán szeretné használni, vegye fel a kapcsolatot a 2H Informatika ügyfélszolgálattal!");
								Application.Exit();
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(this.m_string_00A0, "2", TextCompare: false) == 0)
						{
							CheckBox_2001().Enabled = false;
							MessageBox.Show("A licenc le van tiltva!", "2H FoxComm", MessageBoxButtons.OK);
						}
						else if (Operators.CompareString(this.m_string_00A0, "1", TextCompare: false) == 0)
						{
							Timer_2009().Start();
						}
						else
						{
							Operators.CompareString(this.m_string_00A0, "0", TextCompare: false);
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

	private void void_2000(object P_0, EventArgs P_1)
	{
		Timer_2009().Interval = 50;
		ProgressBar_200A().Increment(1);
		if (ProgressBar_200A().Value == 100)
		{
			PictureBox_2000().Visible = false;
			Label_2008().Visible = false;
			Timer_2009().Stop();
			Label_2002().Visible = true;
			Label_2004().Visible = true;
			Label_2003().Visible = true;
			Label_2005().Visible = true;
			CheckBox_2001().Enabled = true;
		}
	}

	private void void_00A0(object P_0, MouseEventArgs P_1)
	{
		Panel_200B().Visible = false;
	}

	private void void_1680(object P_0, MouseEventArgs P_1)
	{
		void_2024();
	}

	private void void_2001(object P_0, EventArgs P_1)
	{
		Interaction.MsgBox("A 2H Szerverek nem elérhetők, karbantartás miatt!\r\nA licence ellenőrzése nélkül a FoxComm rendszer nem indítható el!\r\n\r\nPróbálja később az indítást!\r\nHa a hiba tartósan fennáll, hívja a forgalmazót!");
	}

	private void void_00A0(object P_0, FormClosingEventArgs P_1)
	{
		if (P_1.CloseReason == CloseReason.UserClosing)
		{
			Application.Exit();
		}
	}

	private void void_00A0(object P_0, KeyEventArgs P_1)
	{
		if ((P_1.KeyCode == Keys.B) & P_1.Control)
		{
			Hide();
			_2000.__00A0_2001._2005_2000().Show();
		}
	}
}
