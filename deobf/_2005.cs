using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class _2005 : Form
{
	private IContainer m_IContainer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("info1")]
	private Label m_Label_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox1")]
	private TextBox m_TextBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox2")]
	private TextBox m_TextBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox3")]
	private TextBox m_TextBox_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox4")]
	private TextBox m_TextBox_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label m_Label_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label m_Label_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	private Label m_Label_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox m_PictureBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox m_PictureBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Firebutton")]
	private CButton m_CButton_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("UACOFF")]
	private PictureBox m_PictureBox_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("UACON")]
	private PictureBox m_PictureBox_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("FIGYELM_OFF")]
	private PictureBox m_PictureBox_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("FIGYELM_ON")]
	private PictureBox m_PictureBox_2003;

	[CompilerGenerated]
	[AccessedThroughProperty("ONVED_OFF")]
	private PictureBox m_PictureBox_2004;

	[CompilerGenerated]
	[AccessedThroughProperty("ONVED_ON")]
	private PictureBox m_PictureBox_2005;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	private Label m_Label_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	private Label m_Label_2003;

	[CompilerGenerated]
	[AccessedThroughProperty("CButton1")]
	private CButton m_CButton_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Label6")]
	private Label m_Label_2004;

	[CompilerGenerated]
	[AccessedThroughProperty("WinHazon")]
	private Label m_Label_2005;

	[CompilerGenerated]
	[AccessedThroughProperty("WinOSversion")]
	private TextBox m_TextBox_2002;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	private Label m_Label_2006;

	[CompilerGenerated]
	[AccessedThroughProperty("Sbstate")]
	private TextBox m_TextBox_2003;

	[CompilerGenerated]
	[AccessedThroughProperty("TPMState")]
	private TextBox m_TextBox_2004;

	[CompilerGenerated]
	[AccessedThroughProperty("Label8")]
	private Label m_Label_2007;

	private string m_string_00A0;

	public _2005()
	{
		base.Load += void_00A0;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_2005));
		cBlendItems val = new cBlendItems();
		cBlendItems val2 = new cBlendItems();
        void_00A0(new Label());
		void_00A0(new TextBox());
		void_1680(new TextBox());
		void_2000(new TextBox());
        void_2001(new TextBox());
		void_1680(new Label());
		void_2000(new Label());
		void_2001(new Label());
		void_00A0(new PictureBox());
		void_1680(new PictureBox());
		void_00A0(new CButton());
		void_2000(new PictureBox());
		void_2001(new PictureBox());
		void_2002(new PictureBox());
		void_2003(new PictureBox());
		void_2004(new PictureBox());
		void_2005(new PictureBox());
		void_2002(new Label());
		void_2003(new Label());
		void_1680(new CButton());
		void_2004(new Label());
		void_2005(new Label());
		void_2002(new TextBox());
		void_2006(new Label());
		void_2003(new TextBox());
		void_2004(new TextBox());
		void_2007(new Label());
		((ISupportInitialize)PictureBox_2007()).BeginInit();
		((ISupportInitialize)PictureBox_2008()).BeginInit();
		((ISupportInitialize)PictureBox_200A()).BeginInit();
		((ISupportInitialize)PictureBox_200B()).BeginInit();
		((ISupportInitialize)PictureBox_2010()).BeginInit();
		((ISupportInitialize)PictureBox_2011()).BeginInit();
		((ISupportInitialize)PictureBox_2012()).BeginInit();
		((ISupportInitialize)PictureBox_2013()).BeginInit();
		SuspendLayout();
		Label_1680().AutoSize = true;
		Label_1680().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_1680().ForeColor = Color.White;
		Label_1680().Location = new Point(25, 186);
		Label_1680().Name = "info1";
		Label_1680().Size = new Size(97, 18);
		Label_1680().TabIndex = 1;
		Label_1680().Text = "SoC Serial ID:";
		TextBox_2000().BackColor = Color.Black;
		TextBox_2000().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2000().ForeColor = Color.Chartreuse;
		TextBox_2000().Location = new Point(167, 183);
		TextBox_2000().Name = "TextBox1";
		TextBox_2000().ReadOnly = true;
		TextBox_2000().Size = new Size(268, 23);
		TextBox_2000().TabIndex = 2;
		TextBox_2001().BackColor = Color.Black;
		TextBox_2001().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2001().ForeColor = Color.Chartreuse;
		TextBox_2001().Location = new Point(167, 219);
		TextBox_2001().Name = "TextBox2";
		TextBox_2001().ReadOnly = true;
		TextBox_2001().Size = new Size(268, 23);
		TextBox_2001().TabIndex = 3;
		TextBox_2002().BackColor = Color.Black;
		TextBox_2002().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2002().ForeColor = Color.Chartreuse;
		TextBox_2002().Location = new Point(167, 255);
		TextBox_2002().Name = "TextBox3";
		TextBox_2002().ReadOnly = true;
		TextBox_2002().Size = new Size(268, 23);
		TextBox_2002().TabIndex = 4;
		TextBox_2003().BackColor = Color.Black;
		TextBox_2003().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2003().ForeColor = Color.Chartreuse;
		TextBox_2003().Location = new Point(167, 291);
		TextBox_2003().Name = "TextBox4";
		TextBox_2003().ReadOnly = true;
		TextBox_2003().Size = new Size(268, 23);
		TextBox_2003().TabIndex = 5;
		Label_2004().AutoSize = true;
		Label_2004().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2004().ForeColor = Color.White;
		Label_2004().Location = new Point(25, 222);
		Label_2004().Name = "Label1";
		Label_2004().Size = new Size(105, 18);
		Label_2004().TabIndex = 7;
		Label_2004().Text = "Drive Serial ID:";
		Label_2005().AutoSize = true;
		Label_2005().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2005().ForeColor = Color.White;
		Label_2005().Location = new Point(25, 258);
		Label_2005().Name = "Label2";
		Label_2005().Size = new Size(70, 18);
		Label_2005().TabIndex = 8;
		Label_2005().Text = "Gpart ID:";
		Label_2006().AutoSize = true;
		Label_2006().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2006().ForeColor = Color.White;
		Label_2006().Location = new Point(25, 293);
		Label_2006().Name = "Label3";
		Label_2006().Size = new Size(136, 18);
		Label_2006().TabIndex = 9;
		Label_2006().Text = "MBD Manufacturer:";
		PictureBox_2007().BackColor = Color.Transparent;
		PictureBox_2007().Cursor = Cursors.Default;
		PictureBox_2007().Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox_2007().Location = new Point(671, 537);
		PictureBox_2007().Name = "PictureBox4";
		PictureBox_2007().Size = new Size(87, 79);
		PictureBox_2007().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2007().TabIndex = 62;
		PictureBox_2007().TabStop = false;
		PictureBox_2008().BackColor = Color.Transparent;
		PictureBox_2008().Cursor = Cursors.Default;
		PictureBox_2008().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox_2008().Location = new Point(107, 21);
		PictureBox_2008().Name = "PictureBox1";
		PictureBox_2008().Size = new Size(560, 58);
		PictureBox_2008().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2008().TabIndex = 63;
		PictureBox_2008().TabStop = false;
		CButton_2009().BorderColor = Color.Orange;
		val.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(34, 4, 99),
			Color.FromArgb(15, 3, 41)
		};
		val.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_2009().ColorFillBlend = val;
		CButton_2009().Corners.All = 5;
		CButton_2009().Corners.LowerLeft = 5;
		CButton_2009().Corners.LowerRight = 5;
		CButton_2009().Corners.UpperLeft = 5;
		CButton_2009().Corners.UpperRight = 5;
		CButton_2009().DesignerSelected = false;
		CButton_2009().DimFactorHover = 20;
		CButton_2009().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_2009().ForeColor = Color.Silver;
		CButton_2009().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_2009().ImageIndex = 0;
		CButton_2009().ImageSize = new Size(25, 25);
		((Control)(object)CButton_2009()).Location = new Point(490, 222);
		((Control)(object)CButton_2009()).Name = "Firebutton";
		((Control)(object)CButton_2009()).Size = new Size(268, 35);
		((Control)(object)CButton_2009()).TabIndex = 64;
		((Control)(object)CButton_2009()).Tag = "0";
		CButton_2009().Text = "Save CMOS and restart";
		CButton_2009().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_2009().TextShadow = Color.Black;
		PictureBox_200A().BackColor = Color.Transparent;
		PictureBox_200A().Image = (Image)componentResourceManager.GetObject("UACOFF.Image");
		PictureBox_200A().Location = new Point(175, 492);
		PictureBox_200A().Name = "UACOFF";
		PictureBox_200A().Size = new Size(88, 39);
		PictureBox_200A().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_200A().TabIndex = 153;
		PictureBox_200A().TabStop = false;
		PictureBox_200A().Visible = false;
		PictureBox_200B().BackColor = Color.Transparent;
		PictureBox_200B().Image = (Image)componentResourceManager.GetObject("UACON.Image");
		PictureBox_200B().Location = new Point(175, 492);
		PictureBox_200B().Name = "UACON";
		PictureBox_200B().Size = new Size(88, 39);
		PictureBox_200B().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_200B().TabIndex = 152;
		PictureBox_200B().TabStop = false;
		PictureBox_200B().Visible = false;
		PictureBox_2010().BackColor = Color.Transparent;
		PictureBox_2010().Image = (Image)componentResourceManager.GetObject("FIGYELM_OFF.Image");
		PictureBox_2010().Location = new Point(342, 492);
		PictureBox_2010().Name = "FIGYELM_OFF";
		PictureBox_2010().Size = new Size(88, 39);
		PictureBox_2010().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2010().TabIndex = 155;
		PictureBox_2010().TabStop = false;
		PictureBox_2010().Visible = false;
		PictureBox_2011().BackColor = Color.Transparent;
		PictureBox_2011().Image = (Image)componentResourceManager.GetObject("FIGYELM_ON.Image");
		PictureBox_2011().Location = new Point(342, 492);
		PictureBox_2011().Name = "FIGYELM_ON";
		PictureBox_2011().Size = new Size(88, 39);
		PictureBox_2011().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2011().TabIndex = 154;
		PictureBox_2011().TabStop = false;
		PictureBox_2011().Visible = false;
		PictureBox_2012().BackColor = Color.Transparent;
		PictureBox_2012().Image = (Image)componentResourceManager.GetObject("ONVED_OFF.Image");
		PictureBox_2012().Location = new Point(518, 492);
		PictureBox_2012().Name = "ONVED_OFF";
		PictureBox_2012().Size = new Size(88, 39);
		PictureBox_2012().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2012().TabIndex = 157;
		PictureBox_2012().TabStop = false;
		PictureBox_2012().Visible = false;
		PictureBox_2013().BackColor = Color.Transparent;
		PictureBox_2013().Image = (Image)componentResourceManager.GetObject("ONVED_ON.Image");
		PictureBox_2013().Location = new Point(518, 492);
		PictureBox_2013().Name = "ONVED_ON";
		PictureBox_2013().Size = new Size(88, 39);
		PictureBox_2013().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2013().TabIndex = 156;
		PictureBox_2013().TabStop = false;
		PictureBox_2013().Visible = false;
		Label_2014().AutoSize = true;
		Label_2014().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2014().ForeColor = Color.White;
		Label_2014().Location = new Point(172, 460);
		Label_2014().Name = "Label4";
		Label_2014().Size = new Size(86, 18);
		Label_2014().TabIndex = 158;
		Label_2014().Text = "UAC Disable";
		Label_2015().AutoSize = true;
		Label_2015().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2015().ForeColor = Color.White;
		Label_2015().Location = new Point(340, 460);
		Label_2015().Name = "Label5";
		Label_2015().Size = new Size(93, 18);
		Label_2015().TabIndex = 159;
		Label_2015().Text = "File Warnings";
		CButton_2022().BorderColor = Color.Orange;
		val2.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(205, 92, 92),
			Color.FromArgb(15, 3, 41)
		};
		val2.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_2022().ColorFillBlend = val2;
		CButton_2022().Corners.All = 5;
		CButton_2022().Corners.LowerLeft = 5;
		CButton_2022().Corners.LowerRight = 5;
		CButton_2022().Corners.UpperLeft = 5;
		CButton_2022().Corners.UpperRight = 5;
		CButton_2022().DesignerSelected = false;
		CButton_2022().DimFactorHover = 20;
		CButton_2022().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_2022().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_2022().ImageIndex = 0;
		CButton_2022().ImageSize = new Size(25, 25);
		((Control)(object)CButton_2022()).Location = new Point(490, 148);
		((Control)(object)CButton_2022()).Name = "CButton1";
		((Control)(object)CButton_2022()).Size = new Size(268, 35);
		((Control)(object)CButton_2022()).TabIndex = 162;
		((Control)(object)CButton_2022()).Tag = "0";
		CButton_2022().Text = "Wipe FoxData (Factory Reset)";
		CButton_2022().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_2022().TextShadow = Color.Black;
		Label_2024().AutoSize = true;
		Label_2024().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2024().ForeColor = Color.White;
		Label_2024().Location = new Point(515, 460);
		Label_2024().Name = "Label6";
		Label_2024().Size = new Size(100, 18);
		Label_2024().TabIndex = 160;
		Label_2024().Text = "Self Defension";
		Label_2025().AutoSize = true;
		Label_2025().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2025().ForeColor = Color.White;
		Label_2025().Location = new Point(25, 148);
		Label_2025().Name = "WinHazon";
		Label_2025().Size = new Size(105, 18);
		Label_2025().TabIndex = 163;
		Label_2025().Text = "Host Windows:";
		TextBox_2027().BackColor = Color.Black;
		TextBox_2027().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2027().ForeColor = Color.Chartreuse;
		TextBox_2027().Location = new Point(167, 148);
		TextBox_2027().Name = "WinOSversion";
		TextBox_2027().ReadOnly = true;
		TextBox_2027().Size = new Size(268, 23);
		TextBox_2027().TabIndex = 164;
		Label_2028().AutoSize = true;
		Label_2028().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2028().ForeColor = Color.White;
		Label_2028().Location = new Point(23, 328);
		Label_2028().Name = "Label7";
		Label_2028().Size = new Size(125, 18);
		Label_2028().TabIndex = 166;
		Label_2028().Text = "Secureboot State:";
		TextBox_2029().BackColor = Color.Black;
		TextBox_2029().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_2029().ForeColor = Color.Chartreuse;
		TextBox_2029().Location = new Point(167, 327);
		TextBox_2029().Name = "Sbstate";
		TextBox_2029().ReadOnly = true;
		TextBox_2029().Size = new Size(268, 23);
		TextBox_2029().TabIndex = 167;
		TextBox_202A().BackColor = Color.Black;
		TextBox_202A().Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		TextBox_202A().ForeColor = Color.Chartreuse;
		TextBox_202A().Location = new Point(167, 361);
		TextBox_202A().Name = "TPMState";
		TextBox_202A().ReadOnly = true;
		TextBox_202A().Size = new Size(268, 23);
		TextBox_202A().TabIndex = 169;
		Label_202B().AutoSize = true;
		Label_202B().Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_202B().ForeColor = Color.White;
		Label_202B().Location = new Point(25, 362);
		Label_202B().Name = "Label8";
		Label_202B().Size = new Size(123, 18);
		Label_202B().TabIndex = 170;
		Label_202B().Text = "TrustedPM State:";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.MediumBlue;
		BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		BackgroundImageLayout = ImageLayout.Stretch;
		base.ClientSize = new Size(782, 641);
		base.Controls.Add(Label_202B());
		base.Controls.Add(TextBox_202A());
		base.Controls.Add(TextBox_2029());
		base.Controls.Add(Label_2028());
		base.Controls.Add(TextBox_2027());
		base.Controls.Add(Label_2025());
		base.Controls.Add((Control)(object)CButton_2022());
		base.Controls.Add(Label_2024());
		base.Controls.Add(Label_2015());
		base.Controls.Add(Label_2014());
		base.Controls.Add(PictureBox_2012());
		base.Controls.Add(PictureBox_2013());
		base.Controls.Add(PictureBox_2010());
		base.Controls.Add(PictureBox_2011());
		base.Controls.Add(PictureBox_200A());
		base.Controls.Add(PictureBox_200B());
		base.Controls.Add((Control)(object)CButton_2009());
		base.Controls.Add(PictureBox_2008());
		base.Controls.Add(PictureBox_2007());
		base.Controls.Add(Label_2006());
		base.Controls.Add(Label_2005());
		base.Controls.Add(Label_2004());
		base.Controls.Add(TextBox_2003());
		base.Controls.Add(TextBox_2002());
		base.Controls.Add(TextBox_2001());
		base.Controls.Add(TextBox_2000());
		base.Controls.Add(Label_1680());
		DoubleBuffered = true;
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Bios";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "2H FoxComm Biosrom";
		base.TopMost = true;
		((ISupportInitialize)PictureBox_2007()).EndInit();
		((ISupportInitialize)PictureBox_2008()).EndInit();
		((ISupportInitialize)PictureBox_200A()).EndInit();
		((ISupportInitialize)PictureBox_200B()).EndInit();
		((ISupportInitialize)PictureBox_2010()).EndInit();
		((ISupportInitialize)PictureBox_2011()).EndInit();
		((ISupportInitialize)PictureBox_2012()).EndInit();
		((ISupportInitialize)PictureBox_2013()).EndInit();
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
	internal virtual TextBox TextBox_2000()
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
	internal virtual TextBox TextBox_2001()
	{
		return this.m_TextBox_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(TextBox P_0)
	{
		this.m_TextBox_1680 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox TextBox_2002()
	{
		return this.m_TextBox_2000;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2000(TextBox P_0)
	{
		this.m_TextBox_2000 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox TextBox_2003()
	{
		return this.m_TextBox_2001;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2001(TextBox P_0)
	{
		this.m_TextBox_2001 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2004()
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
	internal virtual Label Label_2005()
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
	internal virtual PictureBox PictureBox_2008()
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
	internal virtual CButton CButton_2009()
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
	internal virtual PictureBox PictureBox_200A()
	{
		return this.m_PictureBox_2000;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2000(PictureBox P_0)
	{
		EventHandler value = void_1680;
		PictureBox pictureBox = this.m_PictureBox_2000;
		if (pictureBox != null)
		{
			pictureBox.Click -= value;
		}
		this.m_PictureBox_2000 = P_0;
		pictureBox = this.m_PictureBox_2000;
		if (pictureBox != null)
		{
			pictureBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_200B()
	{
		return this.m_PictureBox_2001;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2001(PictureBox P_0)
	{
		EventHandler value = void_2000;
		PictureBox pictureBox = this.m_PictureBox_2001;
		if (pictureBox != null)
		{
			pictureBox.Click -= value;
		}
		this.m_PictureBox_2001 = P_0;
		pictureBox = this.m_PictureBox_2001;
		if (pictureBox != null)
		{
			pictureBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2010()
	{
		return this.m_PictureBox_2002;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2002(PictureBox P_0)
	{
		EventHandler value = void_2002;
		PictureBox pictureBox = this.m_PictureBox_2002;
		if (pictureBox != null)
		{
			pictureBox.Click -= value;
		}
		this.m_PictureBox_2002 = P_0;
		pictureBox = this.m_PictureBox_2002;
		if (pictureBox != null)
		{
			pictureBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2011()
	{
		return this.m_PictureBox_2003;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2003(PictureBox P_0)
	{
		EventHandler value = void_2001;
		PictureBox pictureBox = this.m_PictureBox_2003;
		if (pictureBox != null)
		{
			pictureBox.Click -= value;
		}
		this.m_PictureBox_2003 = P_0;
		pictureBox = this.m_PictureBox_2003;
		if (pictureBox != null)
		{
			pictureBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2012()
	{
		return this.m_PictureBox_2004;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2004(PictureBox P_0)
	{
		EventHandler value = void_2003;
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

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox PictureBox_2013()
	{
		return this.m_PictureBox_2005;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2005(PictureBox P_0)
	{
		EventHandler value = void_2004;
		PictureBox pictureBox = this.m_PictureBox_2005;
		if (pictureBox != null)
		{
			pictureBox.Click -= value;
		}
		this.m_PictureBox_2005 = P_0;
		pictureBox = this.m_PictureBox_2005;
		if (pictureBox != null)
		{
			pictureBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2014()
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
	internal virtual Label Label_2015()
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
	internal virtual CButton CButton_2022()
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
	internal virtual Label Label_2024()
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

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2025()
	{
		return this.m_Label_2005;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2005(Label P_0)
	{
		this.m_Label_2005 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox TextBox_2027()
	{
		return this.m_TextBox_2002;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2002(TextBox P_0)
	{
		this.m_TextBox_2002 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2028()
	{
		return this.m_Label_2006;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2006(Label P_0)
	{
		this.m_Label_2006 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox TextBox_2029()
	{
		return this.m_TextBox_2003;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2003(TextBox P_0)
	{
		this.m_TextBox_2003 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox TextBox_202A()
	{
		return this.m_TextBox_2004;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2004(TextBox P_0)
	{
		this.m_TextBox_2004 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_202B()
	{
		return this.m_Label_2007;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_2007(Label P_0)
	{
		this.m_Label_2007 = P_0;
	}

	private void void_00A0(object P_0, EventArgs P_1)
	{
		TextBox textBox;
		string text = (textBox = TextBox_2000()).Text;
		TextBox textBox2;
		string text2 = (textBox2 = TextBox_2001()).Text;
		TextBox textBox3;
		string text3 = (textBox3 = TextBox_2002()).Text;
		TextBox textBox4;
		string text4 = (textBox4 = TextBox_2003()).Text;
		_2004.string_00A0(ref text, ref text2, ref text3, ref text4);
		textBox4.Text = text4;
		textBox3.Text = text3;
		textBox2.Text = text2;
		textBox.Text = text;
		void_202C();
	}

	private void void_202C()
	{
		PictureBox_2007().Select();
		string left = _2009.string_2000("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableSmartScreen");
		string left2 =_2009.string_2000("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA");
		if (Operators.CompareString(left, "0", TextCompare: false) == 0 && Operators.CompareString(left2, "0", TextCompare: false) == 0)
		{
			PictureBox_200B().Visible = true;
			PictureBox_200A().Visible = false;
		}
		else
		{
            PictureBox_200B().Visible = false;
            PictureBox_200A().Visible = true;
		}
		string right = ".exe;.vbs;.bat;.msi;.ini;.inf;.com;.lnk;.scr;.cs;.jar;.jad;.java;.php;.html;.lib;.obj;.txt;.dat;.xls;.xlsx;.doc;.docx;.pdf;.pls;.m3u;.psd;.sln;.zip;.rar;.arj;.dbf;.ttf;.fon;.7z;.wav;.wma;.cmd";
		if (Operators.CompareString(_2009.string_2000("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Association", "LowRiskFileTypes"), right, TextCompare: false) == 0)
		{
            PictureBox_2010().Visible = false;
            PictureBox_2011().Visible = true;
		}
		else
		{
            PictureBox_2011().Visible = false;
            PictureBox_2010().Visible = true;
		}
		string text = _2009.string_2000("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "DisplayVersion");
		string text2 = _2009.string_2000("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentMajorVersionNumber");
		string text3 = _2009.string_2000("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentMinorVersionNumber");
		string text4 = _2009.string_2000("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuild");
		string text5 = _2009.string_2000("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "UBR");
		string text6 = text2 + "." + text3 + "." + text4 + "." + text5;
		TextBox_2027().Text = text6 + "  Ver: " + text;
		string obj = "SOFTWARE\\Microsoft\\Windows Defender\\Exclusions\\Paths";
		string text7 = "C:\\Windows\\Branding\\Masbate";
		if (Operators.CompareString(_2009.string_2000(obj, text7), "0", TextCompare: false) == 0)
		{
			PictureBox_2013().Visible = true;
            PictureBox_2012().Visible = false;
		}
		else
		{
            PictureBox_2013().Visible = false;
            PictureBox_2012().Visible = true;
		}
		void_202D();
	}

	private void void_202D()
	{
		this.m_string_00A0 =_2009.string_2000("SYSTEM\\CurrentControlSet\\Control\\SecureBoot\\State", "UEFISecureBootEnabled");
		if (Operators.CompareString(this.m_string_00A0, "0", TextCompare: false) != 0)
		{
			this.m_string_00A0 = "nincs";
		}
		if (Operators.CompareString(this.m_string_00A0, "0", TextCompare: false) == 0)
		{
			TextBox_2029().Text = "Secureboot: OFF";
			TextBox_2029().ForeColor = Color.Chartreuse;
		}
		else if (Operators.CompareString(this.m_string_00A0, "nincs", TextCompare: false) == 0)
		{
            TextBox_2029().Text = "Secureboot: OFF (MBR)";
            TextBox_2029().ForeColor = Color.Chartreuse;
		}
		else
		{
            TextBox_2029().Text = "Secureboot: ON";
            TextBox_2029().ForeColor = Color.Crimson;
		}
		if (bool_202F())
		{
            TextBox_202A().Text = "Trusted Platform Chip: ON";
            TextBox_202A().ForeColor = Color.Crimson;
		}
		else
		{
            TextBox_202A().Text = "Trusted Platform Chip: OFF";
            TextBox_2029().ForeColor = Color.Chartreuse;
		}
	}

	private void void_1680(object P_0, EventArgs P_1)
	{
		string obj = "SOFTWARE\\Policies\\Microsoft\\Windows\\System";
		_2009.void_2000(obj, "EnableSmartScreen", "0", "dword");
		_2009.void_2000(obj, "EnableLUA", "0", "dword");
		_2009.void_2000(obj, "EnableVirtualization", "0", "dword");
		string obj2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer";
		_2009.void_2000(obj2, "EnableSmartScreen", "Off", "string");
		_2009.void_2000(obj2, "SmartScreenEnabled", "Off", "string");
		string obj3 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
		_2009.void_2000(obj3, "EnableLUA", "0", "dword");
		_2009.void_2000(obj3, "EnableLinkedConnections", "1", "dword");
		_2009.void_2000(obj3, "ConsentPromptBehaviorAdmin", "0", "dword");
		_2009.void_2000(obj3, "EnableInstallerDetection", "0", "dword");
		string obj4 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost";
		_2009.void_2000(obj4, "EnableWebContentEvaluation", "0", "dword");
		_2009.void_2000(obj4, "PreventOverride", "0", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\Browser\\AllowSmartScreen", "value", "0", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\SmartScreen\\EnableSmartScreenInShell", "value", "0", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\SmartScreen\\EnableAppInstallControl", "value", "0", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\SmartScreen\\PreventOverrideForFilesInShell", "value", "0", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments", "SaveZoneInformation", "0", "dword");
		_2009.void_2000("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\SmartScreen", "ConfigureAppInstallControlEnabled", "0", "dword");
		void_202C();
	}

	private void void_2000(object P_0, EventArgs P_1)
	{
		_2009.void_2000("SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableSmartScreen", "1", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", "1", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableSmartScreen", "Warn", "string");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\Browser\\AllowSmartScreen", "value", "1", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\SmartScreen\\EnableSmartScreenInShell", "value", "1", "dword");
		_2009.void_2000("SOFTWARE\\Microsoft\\PolicyManager\\default\\SmartScreen\\EnableAppInstallControl", "value", "1", "dword");
		void_202C();
	}

	private void void_2001(object P_0, EventArgs P_1)
	{
		_2009.void_2003("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Association", "LowRiskFileTypes");
		_2009.void_2002("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Association", "LowRiskFileTypes");
		void_202C();
	}

	private void void_2002(object P_0, EventArgs P_1)
	{
		_2009.void_2000("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", "dword");
		string obj = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments";
		_2009.void_2000(obj, "ScanWithAntiVirus", "0", "dword");
		_2009.void_2000(obj, "SaveZoneInformation", "0", "dword");
		string obj2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Association";
		string text = ".exe;.vbs;.bat;.msi;.ini;.inf;.com;.lnk;.scr;.cs;.jar;.jad;.java;.php;.html;.lib;.obj;.txt;.dat;.xls;.xlsx;.doc;.docx;.pdf;.pls;.m3u;.psd;.sln;.zip;.rar;.arj;.dbf;.ttf;.fon;.7z;.wav;.wma;.cmd";
		_2009.void_2000(obj2, "LowRiskFileTypes", text, "string");
		string obj3 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Association";
		string text2 = ".exe;.vbs;.bat;.msi;.ini;.inf;.com;.lnk;.scr;.cs;.jar;.jad;.java;.php;.html;.lib;.obj;.txt;.dat;.xls;.xlsx;.doc;.docx;.pdf;.pls;.m3u;.psd;.sln;.zip;.rar;.arj;.dbf;.ttf;.fon;.7z;.wav;.wma;.cmd";
		_2009.void_1680(obj3, "LowRiskFileTypes", text2, "string");
		string obj4 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments";
		_2009.void_1680(obj4, "ScanWithAntiVirus", "0", "dword");
		_2009.void_1680(obj4, "SaveZoneInformation", "0", "dword");
		string obj5 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
		_2009.void_1680(obj5, "NoCDBurning", "0", "dword");
		_2009.void_1680(obj5, "ConfirmFileDelete", "0", "dword");
		_2009.void_1680(obj5, "NoNetConnectDisconnect", "0", "dword");
		void_202C();
	}

	private void void_00A0(object P_0, MouseEventArgs P_1)
	{
		int num = (int)MessageBox.Show("Az összes FoxComm licenc adat eltávolítása a rendszerből?\r\nEzzel a FoxComm alrendszer aktiválatlanná válik! Biztos benne?", "2H FoxComm Licenc gyári visszaálítása", MessageBoxButtons.YesNo);
		if (num == 6)
		{
			_2009.void_2000("SOFTWARE\\Masbate\\License");
			Interaction.MsgBox("Licence adatok törölve! A FoxComm aktiválatlan! A licence tartalom üres!");
		}
		else
		{
			_ = 7;
		}
	}

	private void void_2003(object P_0, EventArgs P_1)
	{
		string text = "SOFTWARE\\Microsoft\\Windows Defender\\Exclusions\\Paths";
		string text2 = "C:\\Windows\\Branding\\Masbate";
		string text3 = "C:\\.ETM_Reserved";
		if (bool_202E())
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = "powershell";
				process.StartInfo.Arguments = "-Command Add-MpPreference -ExclusionPath '" + text2 + "' -Force";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
			using Process process2 = new Process();
			process2.StartInfo.FileName = "powershell";
			process2.StartInfo.Arguments = "-Command Add-MpPreference -ExclusionPath '" + text3 + "' -Force";
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.Start();
			process2.WaitForExit();
		}
		else
		{
			try
			{
				_2009.void_2000(text, text2, "0", "dword");
				_2009.void_2000(text, text3, "0", "dword");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Hiba történt: " + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		void_202C();
	}

	private void void_2004(object P_0, EventArgs P_1)
	{
		string text = "SOFTWARE\\Microsoft\\Windows Defender\\Exclusions\\Paths";
		string text2 = "C:\\Windows\\Branding\\Masbate";
		string text3 = "C:\\.ETM_Reserved";
		if (bool_202E())
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = "powershell";
				process.StartInfo.Arguments = "-Command Remove-MpPreference -ExclusionPath '" + text2 + "' -Force";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
			using Process process2 = new Process();
			process2.StartInfo.FileName = "powershell";
			process2.StartInfo.Arguments = "-Command Remove-MpPreference -ExclusionPath '" + text3 + "' -Force";
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.Start();
			process2.WaitForExit();
		}
		else
		{
			try
			{
				_2009.void_2003(text, text2);
				_2009.void_2003(text, text3);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Hiba történt: " + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		void_202C();
	}

	public bool bool_202E()
	{
		if (Process.GetProcessesByName("SecurityHealthSystray").Length > 0)
		{
			return true;
		}
		return false;
	}

	private void void_1680(object P_0, MouseEventArgs P_1)
	{
		Application.Restart();
	}

	private bool bool_202F()
	{
		try
		{
			if (new ManagementObjectSearcher("root\\CIMV2\\Security\\MicrosoftTpm", "SELECT * FROM Win32_Tpm").Get().Count > 0)
			{
				return true;
			}
		}
		catch (ManagementException ex)
		{
			ProjectData.SetProjectError(ex);
			ManagementException ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return false;
	}
}
