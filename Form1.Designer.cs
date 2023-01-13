using System.Windows.Forms;

namespace SortingAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timedisplaybar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timeLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.record500000Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.record100000Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.record10000Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.record1000Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Record100Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sortBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.recordGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.basisComBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.algorComBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbluserRole = new System.Windows.Forms.Label();
            this.closebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.miniButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.maxButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbar = new Guna.UI2.WinForms.Guna2TextBox();
            this.elipseControl5 = new SortingAlgorithm.ElipseControl();
            this.elipseControl6 = new SortingAlgorithm.ElipseControl();
            this.elipseControl1 = new SortingAlgorithm.ElipseControl();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pic.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.ImageOffset = new System.Drawing.Point(0, 0);
            this.pic.ImageRotate = 0F;
            this.pic.ImageSize = new System.Drawing.Size(50, 50);
            this.pic.Location = new System.Drawing.Point(0, 18);
            this.pic.Name = "pic";
            this.pic.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.pic.Size = new System.Drawing.Size(84, 59);
            this.pic.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.menuPanel.BorderRadius = 20;
            this.menuPanel.Controls.Add(this.guna2PictureBox1);
            this.menuPanel.Controls.Add(this.timedisplaybar);
            this.menuPanel.Controls.Add(this.timeLbl);
            this.menuPanel.Controls.Add(this.record500000Btn);
            this.menuPanel.Controls.Add(this.record100000Btn);
            this.menuPanel.Controls.Add(this.record10000Btn);
            this.menuPanel.Controls.Add(this.record1000Btn);
            this.menuPanel.Controls.Add(this.Record100Btn);
            this.menuPanel.Controls.Add(this.guna2HtmlLabel2);
            this.menuPanel.Controls.Add(this.guna2HtmlLabel1);
            this.menuPanel.Controls.Add(this.pic);
            this.menuPanel.Location = new System.Drawing.Point(12, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(281, 896);
            this.menuPanel.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 727);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(31, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 33;
            this.guna2PictureBox1.TabStop = false;
            // 
            // timedisplaybar
            // 
            this.timedisplaybar.Animated = true;
            this.timedisplaybar.AutoScroll = true;
            this.timedisplaybar.FillColor = System.Drawing.Color.White;
            this.timedisplaybar.FillThickness = 15;
            this.timedisplaybar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.timedisplaybar.ForeColor = System.Drawing.Color.White;
            this.timedisplaybar.ImeMode = System.Windows.Forms.ImeMode.On;
            this.timedisplaybar.Location = new System.Drawing.Point(77, 571);
            this.timedisplaybar.Maximum = 400000;
            this.timedisplaybar.Minimum = 0;
            this.timedisplaybar.Name = "timedisplaybar";
            this.timedisplaybar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.timedisplaybar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.timedisplaybar.ShadowDecoration.Depth = 20;
            this.timedisplaybar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.timedisplaybar.ShowText = true;
            this.timedisplaybar.Size = new System.Drawing.Size(130, 130);
            this.timedisplaybar.TabIndex = 31;
            this.timedisplaybar.Text = "timeprogreeBar";
            this.timedisplaybar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.timedisplaybar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.timedisplaybar.Value = 100;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = false;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(44, 727);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(296, 51);
            this.timeLbl.TabIndex = 30;
            this.timeLbl.Text = "Time Complexity(ms)";
            // 
            // record500000Btn
            // 
            this.record500000Btn.Animated = true;
            this.record500000Btn.AutoRoundedCorners = true;
            this.record500000Btn.BorderRadius = 21;
            this.record500000Btn.DisabledState.BorderColor = System.Drawing.Color.White;
            this.record500000Btn.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record500000Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record500000Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record500000Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record500000Btn.FillColor = System.Drawing.Color.White;
            this.record500000Btn.FillColor2 = System.Drawing.Color.White;
            this.record500000Btn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.record500000Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.record500000Btn.Image = ((System.Drawing.Image)(resources.GetObject("record500000Btn.Image")));
            this.record500000Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.record500000Btn.ImageSize = new System.Drawing.Size(25, 25);
            this.record500000Btn.Location = new System.Drawing.Point(18, 457);
            this.record500000Btn.Name = "record500000Btn";
            this.record500000Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record500000Btn.PressedDepth = 50;
            this.record500000Btn.Size = new System.Drawing.Size(308, 45);
            this.record500000Btn.TabIndex = 28;
            this.record500000Btn.Text = "  Load 500000 Record";
            this.record500000Btn.Click += new System.EventHandler(this.record500000Btn_Click);
            // 
            // record100000Btn
            // 
            this.record100000Btn.Animated = true;
            this.record100000Btn.AutoRoundedCorners = true;
            this.record100000Btn.BorderRadius = 21;
            this.record100000Btn.DisabledState.BorderColor = System.Drawing.Color.White;
            this.record100000Btn.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record100000Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record100000Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record100000Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record100000Btn.FillColor = System.Drawing.Color.White;
            this.record100000Btn.FillColor2 = System.Drawing.Color.White;
            this.record100000Btn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.record100000Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.record100000Btn.Image = ((System.Drawing.Image)(resources.GetObject("record100000Btn.Image")));
            this.record100000Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.record100000Btn.ImageSize = new System.Drawing.Size(25, 25);
            this.record100000Btn.Location = new System.Drawing.Point(18, 384);
            this.record100000Btn.Name = "record100000Btn";
            this.record100000Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record100000Btn.PressedDepth = 50;
            this.record100000Btn.Size = new System.Drawing.Size(308, 45);
            this.record100000Btn.TabIndex = 28;
            this.record100000Btn.Text = "  Load 100000 Record";
            this.record100000Btn.Click += new System.EventHandler(this.record100000Btn_Click);
            // 
            // record10000Btn
            // 
            this.record10000Btn.Animated = true;
            this.record10000Btn.AutoRoundedCorners = true;
            this.record10000Btn.BorderRadius = 21;
            this.record10000Btn.DisabledState.BorderColor = System.Drawing.Color.White;
            this.record10000Btn.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record10000Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record10000Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record10000Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record10000Btn.FillColor = System.Drawing.Color.White;
            this.record10000Btn.FillColor2 = System.Drawing.Color.White;
            this.record10000Btn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.record10000Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.record10000Btn.Image = ((System.Drawing.Image)(resources.GetObject("record10000Btn.Image")));
            this.record10000Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.record10000Btn.ImageSize = new System.Drawing.Size(25, 25);
            this.record10000Btn.Location = new System.Drawing.Point(18, 309);
            this.record10000Btn.Name = "record10000Btn";
            this.record10000Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record10000Btn.PressedDepth = 50;
            this.record10000Btn.Size = new System.Drawing.Size(308, 45);
            this.record10000Btn.TabIndex = 28;
            this.record10000Btn.Text = "Load 10000 Records";
            this.record10000Btn.Click += new System.EventHandler(this.record10000Btn_Click);
            // 
            // record1000Btn
            // 
            this.record1000Btn.Animated = true;
            this.record1000Btn.AutoRoundedCorners = true;
            this.record1000Btn.BorderRadius = 21;
            this.record1000Btn.DisabledState.BorderColor = System.Drawing.Color.White;
            this.record1000Btn.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record1000Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record1000Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record1000Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record1000Btn.FillColor = System.Drawing.Color.White;
            this.record1000Btn.FillColor2 = System.Drawing.Color.White;
            this.record1000Btn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.record1000Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.record1000Btn.Image = ((System.Drawing.Image)(resources.GetObject("record1000Btn.Image")));
            this.record1000Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.record1000Btn.ImageSize = new System.Drawing.Size(25, 25);
            this.record1000Btn.Location = new System.Drawing.Point(18, 236);
            this.record1000Btn.Name = "record1000Btn";
            this.record1000Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.record1000Btn.PressedDepth = 50;
            this.record1000Btn.Size = new System.Drawing.Size(308, 45);
            this.record1000Btn.TabIndex = 28;
            this.record1000Btn.Text = "Load 1000 Records";
            this.record1000Btn.Click += new System.EventHandler(this.record1000Btn_Click);
            // 
            // Record100Btn
            // 
            this.Record100Btn.Animated = true;
            this.Record100Btn.AnimatedGIF = true;
            this.Record100Btn.AutoRoundedCorners = true;
            this.Record100Btn.BorderRadius = 21;
            this.Record100Btn.DisabledState.BorderColor = System.Drawing.Color.White;
            this.Record100Btn.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.Record100Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.Record100Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.Record100Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.Record100Btn.FillColor = System.Drawing.Color.White;
            this.Record100Btn.FillColor2 = System.Drawing.Color.White;
            this.Record100Btn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record100Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.Record100Btn.Image = ((System.Drawing.Image)(resources.GetObject("Record100Btn.Image")));
            this.Record100Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Record100Btn.ImageSize = new System.Drawing.Size(25, 25);
            this.Record100Btn.Location = new System.Drawing.Point(18, 161);
            this.Record100Btn.Name = "Record100Btn";
            this.Record100Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.Record100Btn.PressedDepth = 50;
            this.Record100Btn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(13)))), ((int)(((byte)(235)))));
            this.Record100Btn.Size = new System.Drawing.Size(308, 45);
            this.Record100Btn.TabIndex = 28;
            this.Record100Btn.Text = "Load 100 Records";
            this.Record100Btn.Click += new System.EventHandler(this.Record100Btn_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(13)))), ((int)(((byte)(235)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(141, 61);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(112, 22);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Algorithm";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(90, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(150, 44);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Sorting";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.guna2Panel1.Controls.Add(this.sortBtn);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.basisComBox);
            this.guna2Panel1.Controls.Add(this.algorComBox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton4);
            this.guna2Panel1.Location = new System.Drawing.Point(299, 87);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1474, 813);
            this.guna2Panel1.TabIndex = 28;
            // 
            // sortBtn
            // 
            this.sortBtn.Animated = true;
            this.sortBtn.AnimatedGIF = true;
            this.sortBtn.AutoRoundedCorners = true;
            this.sortBtn.BorderRadius = 17;
            this.sortBtn.DisabledState.BorderColor = System.Drawing.Color.White;
            this.sortBtn.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.sortBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.sortBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.sortBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.sortBtn.FillColor = System.Drawing.Color.White;
            this.sortBtn.FillColor2 = System.Drawing.Color.White;
            this.sortBtn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sortBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.sortBtn.Image = ((System.Drawing.Image)(resources.GetObject("sortBtn.Image")));
            this.sortBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sortBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.sortBtn.Location = new System.Drawing.Point(1346, 19);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.sortBtn.PressedDepth = 50;
            this.sortBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(13)))), ((int)(((byte)(235)))));
            this.sortBtn.Size = new System.Drawing.Size(120, 36);
            this.sortBtn.TabIndex = 32;
            this.sortBtn.Text = "   Sort";
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.recordGrid);
            this.guna2Panel3.Location = new System.Drawing.Point(3, 78);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1468, 723);
            this.guna2Panel3.TabIndex = 31;
            // 
            // recordGrid
            // 
            this.recordGrid.AllowUserToAddRows = false;
            this.recordGrid.AllowUserToDeleteRows = false;
            this.recordGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.recordGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.recordGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.recordGrid.ColumnHeadersHeight = 25;
            this.recordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.recordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recordGrid.Location = new System.Drawing.Point(0, 0);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.ReadOnly = true;
            this.recordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.recordGrid.RowHeadersVisible = false;
            this.recordGrid.RowHeadersWidth = 51;
            this.recordGrid.RowTemplate.Height = 24;
            this.recordGrid.Size = new System.Drawing.Size(1468, 723);
            this.recordGrid.TabIndex = 0;
            this.recordGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.recordGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.recordGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.recordGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.recordGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.recordGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recordGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.recordGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.recordGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.recordGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.recordGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.recordGrid.ThemeStyle.ReadOnly = true;
            this.recordGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.recordGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.recordGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.recordGrid.ThemeStyle.RowsStyle.Height = 24;
            this.recordGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(175)))));
            this.recordGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.recordGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordGrid_CellContentClick);
            // 
            // basisComBox
            // 
            this.basisComBox.AutoRoundedCorners = true;
            this.basisComBox.BackColor = System.Drawing.Color.Transparent;
            this.basisComBox.BorderColor = System.Drawing.Color.Transparent;
            this.basisComBox.BorderRadius = 17;
            this.basisComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.basisComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basisComBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.basisComBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.basisComBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.basisComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.basisComBox.ItemHeight = 30;
            this.basisComBox.Items.AddRange(new object[] {
            "Basis On Index",
            "Basis On No.Of Employees"});
            this.basisComBox.Location = new System.Drawing.Point(968, 19);
            this.basisComBox.Name = "basisComBox";
            this.basisComBox.Size = new System.Drawing.Size(357, 36);
            this.basisComBox.Sorted = true;
            this.basisComBox.TabIndex = 0;
            this.basisComBox.Tag = "Select ";
            // 
            // algorComBox
            // 
            this.algorComBox.AutoRoundedCorners = true;
            this.algorComBox.BackColor = System.Drawing.Color.Transparent;
            this.algorComBox.BorderColor = System.Drawing.Color.Transparent;
            this.algorComBox.BorderRadius = 17;
            this.algorComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.algorComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorComBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.algorComBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.algorComBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.algorComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.algorComBox.ItemHeight = 30;
            this.algorComBox.Items.AddRange(new object[] {
            "Bubble Sort",
            "Bucket Sort",
            "Counting Sort",
            "Heap Sort",
            "Insertion Sort",
            "Merge Sort",
            "Quick Sort",
            "Radix Sort",
            "Selection Sort"});
            this.algorComBox.Location = new System.Drawing.Point(20, 19);
            this.algorComBox.Name = "algorComBox";
            this.algorComBox.Size = new System.Drawing.Size(357, 36);
            this.algorComBox.Sorted = true;
            this.algorComBox.TabIndex = 0;
            this.algorComBox.Tag = "Select ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(595, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "All Oragnization Data";
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Location = new System.Drawing.Point(535, 19);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Size = new System.Drawing.Size(54, 42);
            this.guna2ImageButton4.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1568, 24);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(56, 44);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(169)))), ((int)(((byte)(239)))));
            this.lblUserName.Location = new System.Drawing.Point(1631, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(134, 16);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "Muhammad Danish";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.AnimatedGIF = true;
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.IndicateFocus = true;
            this.guna2ImageButton2.Location = new System.Drawing.Point(1484, 21);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Size = new System.Drawing.Size(63, 47);
            this.guna2ImageButton2.TabIndex = 26;
            this.guna2ImageButton2.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.AnimatedGIF = true;
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1415, 21);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(63, 47);
            this.guna2ImageButton1.TabIndex = 26;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.AnimatedGIF = true;
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.IndicateFocus = true;
            this.guna2ImageButton3.Location = new System.Drawing.Point(1355, 21);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.Size = new System.Drawing.Size(63, 47);
            this.guna2ImageButton3.TabIndex = 26;
            this.guna2ImageButton3.UseTransparentBackground = true;
            // 
            // lbluserRole
            // 
            this.lbluserRole.AutoSize = true;
            this.lbluserRole.BackColor = System.Drawing.Color.White;
            this.lbluserRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbluserRole.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(13)))), ((int)(((byte)(235)))));
            this.lbluserRole.Location = new System.Drawing.Point(1713, 49);
            this.lbluserRole.Name = "lbluserRole";
            this.lbluserRole.Size = new System.Drawing.Size(52, 16);
            this.lbluserRole.TabIndex = 25;
            this.lbluserRole.Text = "ADMIN";
            // 
            // closebutton
            // 
            this.closebutton.AnimatedGIF = true;
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closebutton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.closebutton.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.ImageOffset = new System.Drawing.Point(0, 0);
            this.closebutton.ImageRotate = 0F;
            this.closebutton.ImageSize = new System.Drawing.Size(15, 15);
            this.closebutton.IndicateFocus = true;
            this.closebutton.Location = new System.Drawing.Point(1743, 9);
            this.closebutton.Name = "closebutton";
            this.closebutton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.closebutton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.closebutton.Size = new System.Drawing.Size(22, 24);
            this.closebutton.TabIndex = 27;
            this.closebutton.UseTransparentBackground = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // miniButton
            // 
            this.miniButton.AnimatedGIF = true;
            this.miniButton.BackColor = System.Drawing.Color.Transparent;
            this.miniButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.miniButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.miniButton.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.miniButton.Image = ((System.Drawing.Image)(resources.GetObject("miniButton.Image")));
            this.miniButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.miniButton.ImageRotate = 0F;
            this.miniButton.ImageSize = new System.Drawing.Size(15, 15);
            this.miniButton.IndicateFocus = true;
            this.miniButton.Location = new System.Drawing.Point(1650, 9);
            this.miniButton.Name = "miniButton";
            this.miniButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            this.miniButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.miniButton.Size = new System.Drawing.Size(22, 24);
            this.miniButton.TabIndex = 27;
            this.miniButton.UseTransparentBackground = true;
            this.miniButton.Click += new System.EventHandler(this.miniButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.AnimatedGIF = true;
            this.maxButton.BackColor = System.Drawing.Color.Transparent;
            this.maxButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.maxButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            this.maxButton.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.maxButton.Image = ((System.Drawing.Image)(resources.GetObject("maxButton.Image")));
            this.maxButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.maxButton.ImageRotate = 0F;
            this.maxButton.ImageSize = new System.Drawing.Size(15, 15);
            this.maxButton.IndicateFocus = true;
            this.maxButton.Location = new System.Drawing.Point(1696, 9);
            this.maxButton.Name = "maxButton";
            this.maxButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image11")));
            this.maxButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.maxButton.Size = new System.Drawing.Size(22, 24);
            this.maxButton.TabIndex = 27;
            this.maxButton.UseTransparentBackground = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(345, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "welcome back!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(314, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hello!";
            // 
            // searchbar
            // 
            this.searchbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.searchbar.BorderRadius = 15;
            this.searchbar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbar.DefaultText = "";
            this.searchbar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.searchbar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.searchbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(13)))), ((int)(((byte)(235)))));
            this.searchbar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(13)))), ((int)(((byte)(117)))));
            this.searchbar.IconRight = ((System.Drawing.Image)(resources.GetObject("searchbar.IconRight")));
            this.searchbar.IconRightSize = new System.Drawing.Size(23, 23);
            this.searchbar.Location = new System.Drawing.Point(574, 18);
            this.searchbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchbar.Name = "searchbar";
            this.searchbar.PasswordChar = '\0';
            this.searchbar.PlaceholderText = "Search here..";
            this.searchbar.SelectedText = "";
            this.searchbar.Size = new System.Drawing.Size(580, 38);
            this.searchbar.TabIndex = 31;
            // 
            // elipseControl5
            // 
            this.elipseControl5.CronerRedius = 30;
            this.elipseControl5.TargetControl = this.menuPanel;
            // 
            // elipseControl6
            // 
            this.elipseControl6.CronerRedius = 50;
            this.elipseControl6.TargetControl = this;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CronerRedius = 30;
            this.elipseControl1.TargetControl = this.guna2Panel1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1777, 900);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.miniButton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.lbluserRole);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ElipseControl elipseControl2;
        private ElipseControl elipseControl3;
        private ElipseControl elipseControl4;
        private ElipseControl elipseControl5;
        private ElipseControl elipseControl6;
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton pic;
        private Guna.UI2.WinForms.Guna2GradientButton record500000Btn;
        private Guna.UI2.WinForms.Guna2GradientButton record100000Btn;
        private Guna.UI2.WinForms.Guna2GradientButton record10000Btn;
        private Guna.UI2.WinForms.Guna2GradientButton record1000Btn;
        private Guna.UI2.WinForms.Guna2GradientButton Record100Btn;
        private ElipseControl elipseControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton maxButton;
        private Guna.UI2.WinForms.Guna2ImageButton miniButton;
        private Guna.UI2.WinForms.Guna2ImageButton closebutton;
        private Label lbluserRole;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Label lblUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox searchbar;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox algorComBox;
        private Guna.UI2.WinForms.Guna2ComboBox basisComBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2GradientButton sortBtn;
        private Guna.UI2.WinForms.Guna2DataGridView recordGrid;
        private Guna.UI2.WinForms.Guna2CircleProgressBar timedisplaybar;
        private Guna.UI2.WinForms.Guna2HtmlLabel timeLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

