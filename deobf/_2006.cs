using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[DesignerGenerated]
public class _2006 : Form
{
	private IContainer m_IContainer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label m_Label_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("usernuminput")]
	private TextBox m_TextBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("maillabelle")]
	private Label m_Label_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("liclcabelle")]
	private Label m_Label_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("licencekeyinput")]
	private TextBox m_TextBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Firebutton")]
	private CButton m_CButton_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Initline")]
	private PictureBox m_PictureBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Kisturelmet")]
	private Label m_Label_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox m_PictureBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel2")]
	private Panel m_Panel_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	private Panel m_Panel_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("CButton3")]
	private CButton m_CButton_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("CButton4")]
	private CButton m_CButton_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox m_PictureBox_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox m_PictureBox_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox m_PictureBox_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("Chrono")]
	private Timer m_Timer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Bar")]
	private ProgressBar m_ProgressBar_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Reinstalldetected")]
	private Label m_Label_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("Beolvasotteljesnev")]
	private Label m_Label_2003;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox m_PictureBox_2003;

	[CompilerGenerated]
	[AccessedThroughProperty("digitvanjelen")]
	private Label m_Label_2004;

	private string m_string_00A0;

	private string m_string_1680;

	private string m_string_2000;

	private string m_string_2001;

	private string m_string_2002;

	private string m_string_2003;

	private string m_string_2004;

	private string m_string_2005;

	private string m_string_2006;

	private string m_string_2007;

	private string m_string_2008;

	private string m_string_2009;

	private string m_string_200A;

	private string m_string_200B;

	private string m_string_2010;

	public _2006()
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
		cBlendItems val = new cBlendItems();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_2006));
		cBlendItems val2 = new cBlendItems();
		cBlendItems val3 = new cBlendItems();
        void_00A0(new Label());
        void_00A0(new TextBox());
        void_1680(new Label());
        void_2000(new Label());
        void_1680(new TextBox());
        void_00A0(new CButton());
        void_00A0(new PictureBox());
        void_2001(new Label());
        void_1680(new PictureBox());
        void_00A0(new Panel());
        void_2004(new Label());
        void_2003(new Label());
        void_1680(new Panel());
        void_1680(new CButton());
        void_2000(new CButton());
        void_2000(new PictureBox());
        void_2001(new PictureBox());
        void_2002(new PictureBox());
        void_00A0(new Timer(this.m_IContainer_00A0));
        void_00A0(new ProgressBar());
        void_2002(new Label());
        void_2003(new PictureBox());
		((ISupportInitialize)PictureBox_2005()).BeginInit();
		((ISupportInitialize)PictureBox_2007()).BeginInit();
		Panel_2008().SuspendLayout();
		Panel_2009().SuspendLayout();
		((ISupportInitialize)PictureBox_2010()).BeginInit();
		((ISupportInitialize)PictureBox_2011()).BeginInit();
		((ISupportInitialize)PictureBox_2012()).BeginInit();
		((ISupportInitialize)PictureBox_2024()).BeginInit();
		SuspendLayout();
		Label_1680().BackColor = Color.Transparent;
		Label_1680().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_1680().ForeColor = Color.White;
		Label_1680().Location = new Point(157, 167);
		Label_1680().Name = "Label1";
		Label_1680().Size = new Size(394, 18);
		Label_1680().TabIndex = 119;
		Label_1680().Text = "Vásárlói azonosító";
		Label_1680().TextAlign = ContentAlignment.MiddleCenter;
		TextBox_2000().BackColor = Color.Black;
		TextBox_2000().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2000().ForeColor = Color.Coral;
		TextBox_2000().Location = new Point(157, 188);
		TextBox_2000().Name = "usernuminput";
		TextBox_2000().Size = new Size(394, 21);
		TextBox_2000().TabIndex = 118;
		TextBox_2000().TextAlign = HorizontalAlignment.Center;
		Label_2001().BackColor = Color.Transparent;
		Label_2001().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2001().ForeColor = Color.White;
		Label_2001().Location = new Point(157, 21);
		Label_2001().Name = "maillabelle";
		Label_2001().Size = new Size(394, 18);
		Label_2001().TabIndex = 116;
		Label_2001().Text = "Az ön teljes neve";
		Label_2001().TextAlign = ContentAlignment.MiddleCenter;
		Label_2002().BackColor = Color.Transparent;
		Label_2002().Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2002().ForeColor = Color.White;
		Label_2002().Location = new Point(157, 111);
		Label_2002().Name = "liclcabelle";
		Label_2002().Size = new Size(394, 18);
		Label_2002().TabIndex = 114;
		Label_2002().Text = "Termékkulcs";
		Label_2002().TextAlign = ContentAlignment.MiddleCenter;
		TextBox_2003().BackColor = Color.Black;
		TextBox_2003().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2003().ForeColor = Color.Plum;
		TextBox_2003().Location = new Point(157, 132);
		TextBox_2003().Name = "licencekeyinput";
		TextBox_2003().Size = new Size(394, 21);
		TextBox_2003().TabIndex = 112;
		TextBox_2003().TextAlign = HorizontalAlignment.Center;
		CButton_2004().BorderColor = Color.Orange;
		val.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(34, 4, 99),
			Color.FromArgb(15, 3, 41)
		};
		val.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_2004().ColorFillBlend = val;
		CButton_2004().Corners.All = 5;
		CButton_2004().Corners.LowerLeft = 5;
		CButton_2004().Corners.LowerRight = 5;
		CButton_2004().Corners.UpperLeft = 5;
		CButton_2004().Corners.UpperRight = 5;
		CButton_2004().DesignerSelected = false;
		CButton_2004().DimFactorHover = 20;
		CButton_2004().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_2004().ForeColor = Color.Silver;
		CButton_2004().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_2004().ImageIndex = 0;
		CButton_2004().ImageSize = new Size(25, 25);
		((Control)(object)CButton_2004()).Location = new Point(202, 270);
		((Control)(object)CButton_2004()).Name = "Firebutton";
		((Control)(object)CButton_2004()).Size = new Size(305, 39);
		((Control)(object)CButton_2004()).TabIndex = 130;
		((Control)(object)CButton_2004()).Tag = "0";
		CButton_2004().Text = "Aktiválás megkezdése";
		CButton_2004().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_2004().TextShadow = Color.Black;
		PictureBox_2005().BackColor = Color.Transparent;
		PictureBox_2005().Image = (Image)componentResourceManager.GetObject("Initline.Image");
		PictureBox_2005().Location = new Point(342, 497);
		PictureBox_2005().Name = "Initline";
		PictureBox_2005().Size = new Size(305, 31);
		PictureBox_2005().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2005().TabIndex = 131;
		PictureBox_2005().TabStop = false;
		PictureBox_2005().Visible = false;
		Label_2006().BackColor = Color.Transparent;
		Label_2006().Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2006().ForeColor = Color.DarkGray;
		Label_2006().Location = new Point(342, 535);
		Label_2006().Name = "Kisturelmet";
		Label_2006().Size = new Size(305, 19);
		Label_2006().TabIndex = 132;
		Label_2006().Text = "Kapcsolódás a 2H Szerverhez...";
		Label_2006().TextAlign = ContentAlignment.MiddleCenter;
		Label_2006().Visible = false;
		PictureBox_2007().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		PictureBox_2007().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox_2007().Location = new Point(20, 24);
		PictureBox_2007().Name = "PictureBox1";
		PictureBox_2007().Size = new Size(741, 266);
		PictureBox_2007().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2007().TabIndex = 136;
		PictureBox_2007().TabStop = false;
		Panel_2008().BackColor = Color.Transparent;
		Panel_2008().BackgroundImage = (Image)componentResourceManager.GetObject("Panel2.BackgroundImage");
		Panel_2008().BackgroundImageLayout = ImageLayout.Stretch;
		Panel_2008().Controls.Add(Label_2025());
		Panel_2008().Controls.Add(Label_2022());
		Panel_2008().Controls.Add(TextBox_2003());
		Panel_2008().Controls.Add(Label_2002());
		Panel_2008().Controls.Add(Label_2001());
		Panel_2008().Controls.Add((Control)(object)CButton_2004());
		Panel_2008().Controls.Add(TextBox_2000());
		Panel_2008().Controls.Add(Label_1680());
		Panel_2008().Location = new Point(140, 95);
		Panel_2008().Name = "Panel2";
		Panel_2008().Size = new Size(705, 366);
		Panel_2008().TabIndex = 135;
		Panel_2008().Visible = false;
		Label_2025().BackColor = Color.Transparent;
		Label_2025().Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2025().ForeColor = Color.Orange;
		Label_2025().Location = new Point(49, 72);
		Label_2025().Name = "digitvanjelen";
		Label_2025().Size = new Size(617, 31);
		Label_2025().TabIndex = 143;
		Label_2025().Text = "A Fox Rendszert korábban már digitális licencel aktiválták!";
		Label_2025().TextAlign = ContentAlignment.MiddleCenter;
		Label_2025().Visible = false;
		Label_2022().BackColor = Color.Transparent;
		Label_2022().Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2022().ForeColor = Color.Goldenrod;
		Label_2022().Location = new Point(74, 41);
		Label_2022().Name = "Beolvasotteljesnev";
		Label_2022().Size = new Size(564, 31);
		Label_2022().TabIndex = 142;
		Label_2022().Text = "- - - ";
		Label_2022().TextAlign = ContentAlignment.MiddleCenter;
		Panel_2009().BackColor = Color.Transparent;
		Panel_2009().BackgroundImage = (Image)componentResourceManager.GetObject("Panel3.BackgroundImage");
		Panel_2009().BackgroundImageLayout = ImageLayout.Stretch;
		Panel_2009().Controls.Add((Control)(object)CButton_200A());
		Panel_2009().Controls.Add((Control)(object)CButton_200B());
		Panel_2009().Controls.Add(PictureBox_2007());
		Panel_2009().Location = new Point(107, 91);
		Panel_2009().Name = "Panel3";
		Panel_2009().Size = new Size(777, 375);
		Panel_2009().TabIndex = 136;
		((Control)(object)CButton_200A()).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		CButton_200A().BorderColor = Color.Orange;
		val2.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(128, 0, 0),
			Color.FromArgb(15, 3, 41)
		};
		val2.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_200A().ColorFillBlend = val2;
		CButton_200A().Corners.All = 5;
		CButton_200A().Corners.LowerLeft = 5;
		CButton_200A().Corners.LowerRight = 5;
		CButton_200A().Corners.UpperLeft = 5;
		CButton_200A().Corners.UpperRight = 5;
		CButton_200A().DesignerSelected = false;
		CButton_200A().DimFactorHover = 20;
		CButton_200A().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_200A().ForeColor = Color.Silver;
		CButton_200A().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_200A().ImageIndex = 0;
		CButton_200A().ImageSize = new Size(25, 25);
		((Control)(object)CButton_200A()).Location = new Point(45, 315);
		((Control)(object)CButton_200A()).Name = "CButton3";
		((Control)(object)CButton_200A()).Size = new Size(305, 39);
		((Control)(object)CButton_200A()).TabIndex = 138;
		((Control)(object)CButton_200A()).Tag = "0";
		CButton_200A().Text = "Nem értek egyet! (kilépés)";
		CButton_200A().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_200A().TextShadow = Color.Black;
		((Control)(object)CButton_200B()).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		CButton_200B().BorderColor = Color.Orange;
		val3.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(34, 4, 99),
			Color.FromArgb(15, 3, 41)
		};
		val3.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_200B().ColorFillBlend = val3;
		CButton_200B().Corners.All = 5;
		CButton_200B().Corners.LowerLeft = 5;
		CButton_200B().Corners.LowerRight = 5;
		CButton_200B().Corners.UpperLeft = 5;
		CButton_200B().Corners.UpperRight = 5;
		CButton_200B().DesignerSelected = false;
		CButton_200B().DimFactorHover = 20;
		CButton_200B().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_200B().ForeColor = Color.Silver;
		CButton_200B().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_200B().ImageIndex = 0;
		CButton_200B().ImageSize = new Size(25, 25);
		((Control)(object)CButton_200B()).Location = new Point(429, 315);
		((Control)(object)CButton_200B()).Name = "CButton4";
		((Control)(object)CButton_200B()).Size = new Size(305, 39);
		((Control)(object)CButton_200B()).TabIndex = 137;
		((Control)(object)CButton_200B()).Tag = "0";
		CButton_200B().Text = "Megértettem! Folytathatjuk!";
		CButton_200B().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_200B().TextShadow = Color.Black;
		PictureBox_2010().BackColor = Color.Transparent;
		PictureBox_2010().Cursor = Cursors.Default;
		PictureBox_2010().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox_2010().Location = new Point(868, 442);
		PictureBox_2010().Name = "PictureBox4";
		PictureBox_2010().Size = new Size(109, 93);
		PictureBox_2010().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2010().TabIndex = 137;
		PictureBox_2010().TabStop = false;
		PictureBox_2011().BackColor = Color.Transparent;
		PictureBox_2011().Cursor = Cursors.Default;
		PictureBox_2011().Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox_2011().Location = new Point(3, 442);
		PictureBox_2011().Name = "PictureBox5";
		PictureBox_2011().Size = new Size(109, 93);
		PictureBox_2011().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2011().TabIndex = 138;
		PictureBox_2011().TabStop = false;
		PictureBox_2012().BackColor = Color.Transparent;
		PictureBox_2012().Cursor = Cursors.Default;
		PictureBox_2012().Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox_2012().Location = new Point(371, 7);
		PictureBox_2012().Name = "PictureBox2";
		PictureBox_2012().Size = new Size(244, 47);
		PictureBox_2012().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2012().TabIndex = 139;
		PictureBox_2012().TabStop = false;
		ProgressBar_2014().Location = new Point(988, 12);
		ProgressBar_2014().Name = "Bar";
		ProgressBar_2014().Size = new Size(10, 10);
		ProgressBar_2014().TabIndex = 140;
		ProgressBar_2014().Visible = false;
		Label_2015().BackColor = Color.Transparent;
		Label_2015().Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2015().ForeColor = Color.Orange;
		Label_2015().Location = new Point(125, 469);
		Label_2015().Name = "Reinstalldetected";
		Label_2015().Size = new Size(738, 31);
		Label_2015().TabIndex = 141;
		Label_2015().Text = "Azonosított licenc! A számítógépet felismertük! Újratelepítés észlelve! Üdvözöljük ismét!";
		Label_2015().TextAlign = ContentAlignment.MiddleCenter;
		Label_2015().Visible = false;
		PictureBox_2024().BackColor = Color.Transparent;
		PictureBox_2024().Cursor = Cursors.Default;
		PictureBox_2024().Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox_2024().Location = new Point(240, 50);
		PictureBox_2024().Name = "PictureBox3";
		PictureBox_2024().Size = new Size(509, 47);
		PictureBox_2024().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2024().TabIndex = 142;
		PictureBox_2024().TabStop = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ActiveCaptionText;
		BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		base.ClientSize = new Size(979, 562);
		base.Controls.Add(PictureBox_2012());
		base.Controls.Add(Label_2015());
		base.Controls.Add(ProgressBar_2014());
		base.Controls.Add(Panel_2008());
		base.Controls.Add(Label_2006());
		base.Controls.Add(PictureBox_2005());
		base.Controls.Add(Panel_2009());
		base.Controls.Add(PictureBox_2010());
		base.Controls.Add(PictureBox_2011());
		base.Controls.Add(PictureBox_2024());
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "Licencing";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "2H FoxComm - Licencelés";
		((ISupportInitialize)PictureBox_2005()).EndInit();
		((ISupportInitialize)PictureBox_2007()).EndInit();
		Panel_2008().ResumeLayout(performLayout: false);
		Panel_2008().PerformLayout();
		Panel_2009().ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox_2010()).EndInit();
		((ISupportInitialize)PictureBox_2011()).EndInit();
		((ISupportInitialize)PictureBox_2012()).EndInit();
		((ISupportInitialize)PictureBox_2024()).EndInit();
		ResumeLayout(performLayout: false);
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
	internal virtual TextBox TextBox_2000()
	{
		return this.m_TextBox_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(TextBox P_0)
	{
		MouseEventHandler value = void_20001;
		TextBox textBox = this.m_TextBox_00A0;
		if (textBox != null)
		{
			textBox.MouseClick -= value;
		}
		this.m_TextBox_00A0 = P_0;
		textBox = this.m_TextBox_00A0;
		if (textBox != null)
		{
			textBox.MouseClick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2001()
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
	internal virtual Label Label_2002()
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
	internal virtual TextBox TextBox_2003()
	{
		return this.m_TextBox_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(TextBox P_0)
	{
		MouseEventHandler value = void_16801;
		TextBox textBox = this.m_TextBox_1680;
		if (textBox != null)
		{
			textBox.MouseClick -= value;
		}
		this.m_TextBox_1680 = P_0;
		textBox = this.m_TextBox_1680;
		if (textBox != null)
		{
			textBox.MouseClick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CButton CButton_2004()
	{
		return this.m_CButton_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(CButton P_0)
	{
        CButton.ClickButtonAreaEventHandler val = new CButton.ClickButtonAreaEventHandler(void_00A0);
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
	internal virtual PictureBox PictureBox_2005()
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
	internal virtual Label Label_2006()
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
	internal virtual PictureBox PictureBox_2007()
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
	internal virtual Panel Panel_2008()
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
	internal virtual Panel Panel_2009()
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
	internal virtual CButton CButton_200A()
	{
		return this.m_CButton_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(CButton P_0)
	{
        CButton.ClickButtonAreaEventHandler val = new CButton.ClickButtonAreaEventHandler(void_1680);
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
	internal virtual CButton CButton_200B()
	{
		return this.m_CButton_2000;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2000(CButton P_0)
	{
        CButton.ClickButtonAreaEventHandler val = new CButton.ClickButtonAreaEventHandler(void_2000);
		CButton val2 = this.m_CButton_2000;
		if (val2 != null)
		{
			val2.ClickButtonArea -= val;
		}
		this.m_CButton_2000 = P_0;
		val2 = this.m_CButton_2000;
		if (val2 != null)
		{
			val2.ClickButtonArea += val;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2010()
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
	internal virtual PictureBox PictureBox_2011()
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
	internal virtual PictureBox PictureBox_2012()
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
	internal virtual Timer Timer_2013()
	{
		return this.m_Timer_00A0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_00A0(Timer P_0)
	{
		EventHandler value = void_2001;
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
	internal virtual ProgressBar ProgressBar_2014()
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
	internal virtual Label Label_2015()
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
	internal virtual Label Label_2022()
	{
		return this.m_Label_2003;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2003(Label P_0)
	{
		this.m_Label_2003 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2024()
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
	internal virtual Label Label_2025()
	{
		return this.m_Label_2004;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2004(Label P_0)
	{
		this.m_Label_2004 = P_0;
	}

	private void void_00A0(object P_0, EventArgs P_1)
	{
		this.m_string_00A0 = _2004.string_2000();
		Panel_2009().Size = new Size(777, 375);
		Panel_2009().Location = new Point(100, 92);
		this.m_string_200B = Conversions.ToString(DateAndTime.Now);
		_2004.string_00A0(ref this.m_string_1680, ref this.m_string_2000, ref this.m_string_2002, ref this.m_string_2003, ref this.m_string_2004);
	}

	private void void_2027()
	{
		if ((Operators.CompareString(this.m_string_2006, "1", TextCompare: false) == 0) | (Operators.CompareString(this.m_string_2006, "5", TextCompare: false) == 0))
		{
			string subkey = "SOFTWARE\\Masbate\\License";
			byte[] bytes = Encoding.UTF8.GetBytes(TextBox_2003().Text);
			byte[] bytes2 = Encoding.UTF8.GetBytes(TextBox_2000().Text);
			using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(subkey))
			{
				registryKey.SetValue("Serial", bytes, RegistryValueKind.Binary);
				registryKey.SetValue("Vevoid", bytes2, RegistryValueKind.Binary);
				registryKey.SetValue("Status", 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
			Label_2022().Text = this.m_string_2008;
		}
		else if (Operators.CompareString(this.m_string_2006, "2", TextCompare: false) == 0)
		{
			Timer_2013().Stop();
			Hide();
			MessageBox.Show("Ez a licenc le van tiltva! Hívja a forgalmazót!", "2H - The ID has been blocked!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.ExitThread();
			Application.Exit();
		}
		else if (Operators.CompareString(this.m_string_2006, "0", TextCompare: false) == 0)
		{
			Timer_2013().Stop();
			Hide();
			MessageBox.Show("Ez a licenc másik számítógéphez tartozik! Ezen a gépen nem használható!", "2H - Other machine binded licence!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Application.ExitThread();
			Application.Exit();
		}
		else
		{
			Timer_2013().Stop();
			Hide();
			MessageBox.Show("Registry kulcs-szabotázs észlelve! Hívja a forgalmazót!", "2H - Registry key tamper detected!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.ExitThread();
			Application.Exit();
		}
	}

	private void void_00A0(object P_0, MouseEventArgs P_1)
	{
		void_202A();
		void_2028();
		((Control)(object)CButton_2004()).Enabled = false;
	}

	private void void_1680(object P_0, MouseEventArgs P_1)
	{
		Application.Exit();
	}

	private void void_16801(object P_0, EventArgs P_1)
	{
		TextBox_2003().Text = "";
	}

	private void void_20001(object P_0, EventArgs P_1)
	{
		TextBox_2000().Text = "";
	}

	private void void_2028()
	{
        TextBox_2003().Enabled = false;
        TextBox_2000().Enabled = false;
	}

	private void void_2029()
	{
        TextBox_2003().Enabled = true;
        TextBox_2000().Enabled = true;
	}

	private void void_202A()
	{
		if (Operators.CompareString(TextBox_2003().Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("A Licenckulcs megadása kötelező! A mező nem lehet üres!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			((Control)(object)CButton_2004()).Enabled = true;
			void_2029();
		}
		else if (Operators.CompareString(TextBox_2000().Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("A vásárlóazonosító megadása kötelező! A mező nem lehet üres!", "FoxComm 4 Licencelés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			((Control)(object)CButton_2004()).Enabled = true;
			void_2029();
		}
		else
		{
			Timer_2013().Start();
		}
	}

	private async void void_202B()
	{
		string xmlString = _2004.string_1680();
		RSA rSA = RSA.Create();
		rSA.FromXmlString(xmlString);
		string text = _2004.string_00A0();
		string arg = TextBox_2003().Text;
		string arg2 = TextBox_2000().Text;
		string text2 = string.Format("https://dimitris.masbate.hu/Digital/Digact?Systemid={0}&Serialid={1}&Usernum={2}", this.m_string_00A0, arg, arg2);
		HttpClient val = new HttpClient();
		try
		{
			((HttpHeaders)val.DefaultRequestHeaders).Add("Authorization", "Bearer " + text);
			val.Timeout = TimeSpan.FromSeconds(5.0);
			try
			{
				HttpResponseMessage val2 = await val.GetAsync(text2);
				if (val2.StatusCode == HttpStatusCode.GatewayTimeout)
				{
					Hide();
					MessageBox.Show("A FoxComm Szerver nem elérhető! Próbálja később!", "Server Connection Fail...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Application.Exit();
				}
				else if (val2.StatusCode == HttpStatusCode.InternalServerError)
				{
					Application.ExitThread();
					Application.Exit();
					Interaction.MsgBox("Szerver nem elérhető !");
				}
				else if (val2.StatusCode == HttpStatusCode.BadRequest)
				{
					Hide();
					MessageBox.Show(val2.Content.ReadAsStringAsync().Result, "2H FoxComm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Application.ExitThread();
					Application.Exit();
				}
				else
				{
					if (val2.StatusCode != HttpStatusCode.OK)
					{
						return;
					}
					JObject val3 = JObject.Parse(val2.Content.ReadAsStringAsync().Result);
					try
					{
						JObject val4 = val3["data"].ToObject<JObject>();
						string text3 = val3["signo"].ToString();
						if (_2004.bool_00A0(JsonConvert.SerializeObject((object)val4), text3, rSA))
						{
							this.m_string_2006 = val4["status"].ToString();
							this.m_string_2008 = val4["uname"].ToString();
							Label_2022().Text = this.m_string_2008;
							void_2027();
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

	private void void_2001(object P_0, EventArgs P_1)
	{
		Timer_2013().Interval = 100;
		ProgressBar_2014().Increment(1);
		_ = ProgressBar_2014().Value;
		_ = 1;
		if (ProgressBar_2014().Value == 3)
		{
			Label_2006().Visible = true;
			PictureBox_2005().Visible = true;
			Label_2006().Text = "Kapcsolódás a 2H kiszolgálóhoz...";
		}
		if (ProgressBar_2014().Value == 10)
		{
			//!!! void_202B();
            Label_2006().Text = "Licencadatok ellenőrzése...";
		}
		if (ProgressBar_2014().Value == 30)
		{
            Label_2006().Text = "HWID beküldése...";
		}
		if (ProgressBar_2014().Value == 40)
		{
			Label_2006().Text = "HWID beküldése...";
		}
		if (ProgressBar_2014().Value == 50)
		{
            Label_2006().Text = "Válaszra várva...";
		}
		if (ProgressBar_2014().Value == 70)
		{
            Label_2006().Text = "Feldolgozás...";
		}
		if (ProgressBar_2014().Value == 70)
		{
            Label_2006().Text = "Zamboanga művelet indul...";
		}
		if (ProgressBar_2014().Value == 100)
		{
			Timer_2013().Stop();
            Label_2006().Visible = false;
			PictureBox_2005().Visible = false;
			_2000.__00A0_2001._2008_1680().Show();
			Hide();
		}
	}

	private void void_2000(object P_0, MouseEventArgs P_1)
	{
		Panel_2009().Visible = false;
		Panel_2008().Visible = true;
		//!!! void_202C();
	}

	private void void_202C()
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
				HttpResponseMessage result = val.GetAsync(text2).Result;
				try
				{
					if (result.StatusCode == HttpStatusCode.GatewayTimeout)
					{
						Hide();
						MessageBox.Show("A 2H Szerverek nem elérhetők, karbantartás miatt! Próbálja később!", "2H Szerverkapcsolat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.Exit();
					}
					else if (result.StatusCode == HttpStatusCode.InternalServerError)
					{
						Hide();
						MessageBox.Show("Hiba a folyamatban! IS. Err.", "2H Authentikációs folyamat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Application.ExitThread();
						Application.Exit();
					}
					else
					{
						if (result.StatusCode == HttpStatusCode.BadRequest)
						{
							return;
						}
						if (result.StatusCode == HttpStatusCode.OK)
						{
							JObject val2 = JObject.Parse(result.Content.ReadAsStringAsync().Result);
							try
							{
								JObject val3 = val2["data"].ToObject<JObject>();
								string text3 = val2["signo"].ToString();
								if (_2004.bool_00A0(JsonConvert.SerializeObject((object)val3), text3, rSA))
								{
									this.m_string_2006 = val3["szint"].ToString();
									byte[] array = Convert.FromBase64String(val3["serial"].ToString());
									byte[] bytes = Encoding.UTF8.GetBytes(this.m_string_00A0);
									byte[] bytes2 = _2004.byteArray_1680(array, bytes);
									string text4 = Encoding.UTF8.GetString(bytes2);
									TextBox_2003().Text = text4;
									byte[] array2 = Convert.FromBase64String(val3["usernum"].ToString());
									byte[] bytes3 = Encoding.UTF8.GetBytes(this.m_string_00A0);
									byte[] bytes4 = _2004.byteArray_1680(array2, bytes3);
									string text5 = Encoding.UTF8.GetString(bytes4);
									TextBox_2000().Text = text5;
									Label_2022().Text = val3["ownername"].ToString();
									this.m_string_2008 = Label_2022().Text;
									((Control)(object)CButton_2004()).Enabled = false;
									void_202A();
									void_2028();
									Label_2025().Visible = true;
									Label_2015().Visible = true;
								}
								else
								{
									Hide();
									MessageBox.Show("A kapcsolatfelépítés hamisított! A válasz nem a 2H szerverétől érkezett!\r\nA szoftvert illágálisan aktiválták! Ha jogtisztán szeretné használni, vegye fel a kapcsolatot a 2H Informatika ügyfélszolgálattal!");
									Application.Exit();
								}
								return;
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
								return;
							}
						}
						if (result.StatusCode == HttpStatusCode.Unauthorized)
						{
							MessageBox.Show("Lejárt terméktámogatás! Hívja az üzemeltetőt!", "2H FoxComm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
				}
				finally
				{
					((IDisposable)result)?.Dispose();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
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

	private void void_00A0(object P_0, FormClosingEventArgs P_1)
	{
		if (P_1.CloseReason == CloseReason.UserClosing)
		{
			Application.Exit();
		}
	}
}
