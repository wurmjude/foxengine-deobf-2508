using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CButtonLib;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class _2008 : Form
{
	private IContainer m_IContainer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Firebutton")]
	private CButton m_CButton_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("aktivalaskep")]
	private PictureBox m_PictureBox_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox m_PictureBox_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("Kepakepben")]
	private Timer m_Timer_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Bar")]
	private ProgressBar m_ProgressBar_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("sikerakt")]
	private Label m_Label_00A0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label9")]
	private Label m_Label_1680;

	[CompilerGenerated]
	[AccessedThroughProperty("nekifoghat")]
	private Label m_Label_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox m_PictureBox_2000;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox m_PictureBox_2001;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer")]
	private Timer m_Timer_1680;

	public _2008()
	{
		base.Load += void_00A0;
		void_1680(new Timer());
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_2008));
		void_00A0(new CButton());
		void_00A0(new PictureBox());
		void_1680(new PictureBox());
		void_00A0(new Timer(this.m_IContainer_00A0));
		void_00A0(new ProgressBar());
		void_00A0(new Label());
		void_1680(new Label());
		void_2000(new Label());
		void_2000(new PictureBox());
		void_2001(new PictureBox());
		((ISupportInitialize)PictureBox_2000()).BeginInit();
		((ISupportInitialize)PictureBox_2001()).BeginInit();
		((ISupportInitialize)PictureBox_2007()).BeginInit();
		((ISupportInitialize)PictureBox_2008()).BeginInit();
		SuspendLayout();
		CButton_1680().BorderColor = Color.Orange;
		val.iColor = new Color[3]
		{
			Color.FromArgb(15, 3, 41),
			Color.FromArgb(34, 4, 99),
			Color.FromArgb(15, 3, 41)
		};
		val.iPoint = new float[3] { 0f, 0.4875776f, 1f };
		CButton_1680().ColorFillBlend = val;
		CButton_1680().Corners.All = 5;
		CButton_1680().Corners.LowerLeft = 5;
		CButton_1680().Corners.LowerRight = 5;
		CButton_1680().Corners.UpperLeft = 5;
		CButton_1680().Corners.UpperRight = 5;
		CButton_1680().DesignerSelected = false;
		CButton_1680().DimFactorHover = 20;
		CButton_1680().Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 238);
		CButton_1680().ForeColor = Color.Silver;
		CButton_1680().ImageAlign = ContentAlignment.MiddleLeft;
		CButton_1680().ImageIndex = 0;
		CButton_1680().ImageSize = new Size(25, 25);
		((Control)(object)CButton_1680()).Location = new Point(240, 285);
		((Control)(object)CButton_1680()).Name = "Firebutton";
		((Control)(object)CButton_1680()).Size = new Size(191, 36);
		((Control)(object)CButton_1680()).TabIndex = 59;
		CButton_1680().Text = "FoxComm indítása";
		CButton_1680().TextImageRelation = TextImageRelation.ImageBeforeText;
		CButton_1680().TextShadow = Color.Black;
		((Control)(object)CButton_1680()).Visible = false;
		PictureBox_2000().BackColor = Color.Transparent;
		PictureBox_2000().Image = (Image)componentResourceManager.GetObject("aktivalaskep.Image");
		PictureBox_2000().Location = new Point(557, 22);
		PictureBox_2000().Name = "aktivalaskep";
		PictureBox_2000().Size = new Size(98, 78);
		PictureBox_2000().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2000().TabIndex = 60;
		PictureBox_2000().TabStop = false;
		PictureBox_2001().BackColor = Color.Transparent;
		PictureBox_2001().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox_2001().Location = new Point(557, 22);
		PictureBox_2001().Name = "PictureBox1";
		PictureBox_2001().Size = new Size(98, 78);
		PictureBox_2001().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2001().TabIndex = 62;
		PictureBox_2001().TabStop = false;
		PictureBox_2001().Visible = false;
		ProgressBar_2003().Location = new Point(630, 323);
		ProgressBar_2003().Name = "Bar";
		ProgressBar_2003().Size = new Size(10, 10);
		ProgressBar_2003().TabIndex = 63;
		ProgressBar_2003().Visible = false;
		Label_2004().AutoSize = true;
		Label_2004().BackColor = Color.Transparent;
		Label_2004().Font = new Font("Arial Narrow", 24f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2004().ForeColor = Color.Peru;
		Label_2004().Location = new Point(128, 183);
		Label_2004().Name = "sikerakt";
		Label_2004().Size = new Size(423, 37);
		Label_2004().TabIndex = 64;
		Label_2004().Text = "Az Aktiválás sikeresen megtörtént!";
		Label_2004().Visible = false;
		Label_2005().BackColor = Color.Transparent;
		Label_2005().Font = new Font("Arial Narrow", 24f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2005().ForeColor = Color.CornflowerBlue;
		Label_2005().Location = new Point(14, 125);
		Label_2005().Name = "Label9";
		Label_2005().Size = new Size(646, 37);
		Label_2005().TabIndex = 65;
		Label_2005().Text = "A beküldött licenc adatokat rendszerünk fogadta!";
		Label_2005().TextAlign = ContentAlignment.MiddleCenter;
		Label_2006().AutoSize = true;
		Label_2006().BackColor = Color.Transparent;
		Label_2006().Font = new Font("Tahoma", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 238);
		Label_2006().ForeColor = Color.SeaGreen;
		Label_2006().Location = new Point(165, 235);
		Label_2006().Name = "nekifoghat";
		Label_2006().Size = new Size(345, 25);
		Label_2006().TabIndex = 66;
		Label_2006().Text = "Minden készenáll! Máris nekifoghat!";
		Label_2006().Visible = false;
		PictureBox_2007().BackColor = Color.Transparent;
		PictureBox_2007().Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox_2007().Location = new Point(21, 22);
		PictureBox_2007().Name = "PictureBox2";
		PictureBox_2007().Size = new Size(98, 78);
		PictureBox_2007().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2007().TabIndex = 67;
		PictureBox_2007().TabStop = false;
		PictureBox_2008().BackColor = Color.Transparent;
		PictureBox_2008().Cursor = Cursors.Default;
		PictureBox_2008().Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox_2008().Location = new Point(207, 39);
		PictureBox_2008().Name = "PictureBox3";
		PictureBox_2008().Size = new Size(244, 47);
		PictureBox_2008().SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox_2008().TabIndex = 140;
		PictureBox_2008().TabStop = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ActiveCaptionText;
		BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		BackgroundImageLayout = ImageLayout.Stretch;
		base.ClientSize = new Size(670, 350);
		base.Controls.Add(PictureBox_2008());
		base.Controls.Add(PictureBox_2007());
		base.Controls.Add(Label_2006());
		base.Controls.Add(Label_2005());
		base.Controls.Add(Label_2004());
		base.Controls.Add(ProgressBar_2003());
		base.Controls.Add(PictureBox_2001());
		base.Controls.Add(PictureBox_2000());
		base.Controls.Add((Control)(object)CButton_1680());
		DoubleBuffered = true;
		base.FormBorderStyle = FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Actfinally";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Securebootinfo";
		base.TopMost = true;
		((ISupportInitialize)PictureBox_2000()).EndInit();
		((ISupportInitialize)PictureBox_2001()).EndInit();
		((ISupportInitialize)PictureBox_2007()).EndInit();
		((ISupportInitialize)PictureBox_2008()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CButton CButton_1680()
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
	internal virtual Timer Timer_2002()
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
	internal virtual ProgressBar ProgressBar_2003()
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
	internal virtual Label Label_2004()
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
	internal virtual Label Label_2005()
	{
		return this.m_Label_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(Label P_0)
	{
		EventHandler value = void_2001;
		Label label = this.m_Label_1680;
		if (label != null)
		{
			label.DoubleClick -= value;
		}
		this.m_Label_1680 = P_0;
		label = this.m_Label_1680;
		if (label != null)
		{
			label.DoubleClick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label Label_2006()
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
	internal virtual PictureBox PictureBox_2007()
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
	internal virtual PictureBox PictureBox_2008()
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
	internal virtual Timer Timer_2009()
	{
		return this.m_Timer_1680;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void void_1680(Timer P_0)
	{
		EventHandler value = void_1680;
		Timer timer = this.m_Timer_1680;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_Timer_1680 = P_0;
		timer = this.m_Timer_1680;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	private void void_00A0(object P_0, MouseEventArgs P_1)
	{
		Application.Restart();
	}

	private void void_00A0(object P_0, EventArgs P_1)
	{
		base.TransparencyKey = Color.LightBlue;
		BackColor = Color.LightBlue;
		PictureBox_2001().Image = _2001.Bitmap_2000();
		Timer_2002().Start();
	}

	private void void_1680(object P_0, EventArgs P_1)
	{
		Timer_2009().Stop();
		PictureBox_2001().Image = _2001.Bitmap_2001();
	}

	private int int_00A0(Image P_0)
	{
		return 3000;
	}

	private void void_1680(object P_0, MouseEventArgs P_1)
	{
		_2000.__00A0_2001._200A_2003().TopMost = true;
	}

	private void void_2000(object P_0, EventArgs P_1)
	{
		Timer_2002().Interval = 40;
		ProgressBar_2003().Increment(1);
		if (ProgressBar_2003().Value == 10)
		{
			PictureBox_2000().BringToFront();
			PictureBox_2001().SendToBack();
		}
		if (ProgressBar_2003().Value == 20)
		{
            PictureBox_2001().Visible = true;
			Timer_2009().Interval = int_00A0((Image)_2001.Bitmap_2000());
			Timer_2009().Start();
		}
		if (ProgressBar_2003().Value == 50)
		{
			PictureBox_2000().SendToBack();
			PictureBox_2000().Visible = false;
		}
		if (ProgressBar_2003().Value == 50)
		{
			Label_2004().Visible = true;
		}
		if (ProgressBar_2003().Value == 60)
		{
			Label_2006().Visible = true;
		}
		if (ProgressBar_2003().Value == 70)
		{
			((Control)(object)CButton_1680()).Visible = true;
			Timer_2002().Stop();
		}
	}

	private void void_2001(object P_0, EventArgs P_1)
	{
		Application.Exit();
	}
}
