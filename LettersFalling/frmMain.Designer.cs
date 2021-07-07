
namespace WinFormsApp
{
   partial class frmMain
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      /// 
      
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         this.btnStart = new System.Windows.Forms.Button();
         this.menuMain = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.easyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mediumStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.hardStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.lettersStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dictionaryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.soundStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.nosoundStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.label1 = new System.Windows.Forms.Label();
         this.pBackGround = new System.Windows.Forms.PictureBox();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.pExplosion = new System.Windows.Forms.PictureBox();
         this.pBox1 = new System.Windows.Forms.PictureBox();
         this.pFormBox = new System.Windows.Forms.PictureBox();
         this.pCorrecto = new System.Windows.Forms.PictureBox();
         this.menuMain.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pBackGround)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pExplosion)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pFormBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pCorrecto)).BeginInit();
         this.SuspendLayout();
         // 
         // btnStart
         // 
         this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.btnStart.FlatAppearance.BorderSize = 5;
         this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnStart.ForeColor = System.Drawing.SystemColors.Highlight;
         this.btnStart.Location = new System.Drawing.Point(341, 335);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(200, 51);
         this.btnStart.TabIndex = 0;
         this.btnStart.Text = "Start";
         this.btnStart.UseVisualStyleBackColor = false;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // menuMain
         // 
         this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.playToolStripMenuItem,
            this.soundToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuMain.Location = new System.Drawing.Point(0, 0);
         this.menuMain.Name = "menuMain";
         this.menuMain.Size = new System.Drawing.Size(876, 28);
         this.menuMain.TabIndex = 2;
         this.menuMain.Text = "menuMain";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
         // 
         // exitStripMenuItem
         // 
         this.exitStripMenuItem.Name = "exitStripMenuItem";
         this.exitStripMenuItem.Size = new System.Drawing.Size(116, 26);
         this.exitStripMenuItem.Text = "E&xit";
         this.exitStripMenuItem.Click += new System.EventHandler(this.exitStripMenuItem_Click);
         // 
         // levelToolStripMenuItem
         // 
         this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyStripMenuItem,
            this.mediumStripMenuItem,
            this.hardStripMenuItem});
         this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
         this.levelToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
         this.levelToolStripMenuItem.Text = "&Level";
         // 
         // easyStripMenuItem
         // 
         this.easyStripMenuItem.Checked = true;
         this.easyStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.easyStripMenuItem.Name = "easyStripMenuItem";
         this.easyStripMenuItem.Size = new System.Drawing.Size(147, 26);
         this.easyStripMenuItem.Text = "E&asy";
         this.easyStripMenuItem.Click += new System.EventHandler(this.easyStripMenuItem_Click);
         // 
         // mediumStripMenuItem
         // 
         this.mediumStripMenuItem.Name = "mediumStripMenuItem";
         this.mediumStripMenuItem.Size = new System.Drawing.Size(147, 26);
         this.mediumStripMenuItem.Text = "&Medium";
         this.mediumStripMenuItem.Click += new System.EventHandler(this.mediumStripMenuItem_Click);
         // 
         // hardStripMenuItem
         // 
         this.hardStripMenuItem.Name = "hardStripMenuItem";
         this.hardStripMenuItem.Size = new System.Drawing.Size(147, 26);
         this.hardStripMenuItem.Text = "&Hard";
         this.hardStripMenuItem.Click += new System.EventHandler(this.hardStripMenuItem_Click);
         // 
         // playToolStripMenuItem
         // 
         this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lettersStripMenuItem,
            this.dictionaryStripMenuItem});
         this.playToolStripMenuItem.Name = "playToolStripMenuItem";
         this.playToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
         this.playToolStripMenuItem.Text = "&Play";
         // 
         // lettersStripMenuItem
         // 
         this.lettersStripMenuItem.Checked = true;
         this.lettersStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.lettersStripMenuItem.Name = "lettersStripMenuItem";
         this.lettersStripMenuItem.Size = new System.Drawing.Size(160, 26);
         this.lettersStripMenuItem.Text = "Le&tters";
         this.lettersStripMenuItem.Click += new System.EventHandler(this.lettersStripMenuItem_Click);
         // 
         // dictionaryStripMenuItem
         // 
         this.dictionaryStripMenuItem.Name = "dictionaryStripMenuItem";
         this.dictionaryStripMenuItem.Size = new System.Drawing.Size(160, 26);
         this.dictionaryStripMenuItem.Text = "&Dictionary";
         this.dictionaryStripMenuItem.Click += new System.EventHandler(this.dictionaryStripMenuItem_Click);
         // 
         // soundToolStripMenuItem
         // 
         this.soundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundStripMenuItem,
            this.nosoundStripMenuItem});
         this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
         this.soundToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
         this.soundToolStripMenuItem.Text = "&Sound";
         // 
         // soundStripMenuItem
         // 
         this.soundStripMenuItem.Checked = true;
         this.soundStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.soundStripMenuItem.Name = "soundStripMenuItem";
         this.soundStripMenuItem.Size = new System.Drawing.Size(142, 26);
         this.soundStripMenuItem.Text = "&Enable";
         this.soundStripMenuItem.Click += new System.EventHandler(this.soundStripMenuItem_Click);
         // 
         // nosoundStripMenuItem
         // 
         this.nosoundStripMenuItem.Name = "nosoundStripMenuItem";
         this.nosoundStripMenuItem.Size = new System.Drawing.Size(142, 26);
         this.nosoundStripMenuItem.Text = "&Disable";
         this.nosoundStripMenuItem.Click += new System.EventHandler(this.nosoundStripMenuItem_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.aboutStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
         // 
         // aboutStripMenuItem
         // 
         this.aboutStripMenuItem.Name = "aboutStripMenuItem";
         this.aboutStripMenuItem.Size = new System.Drawing.Size(142, 26);
         this.aboutStripMenuItem.Text = "&About...";
         this.aboutStripMenuItem.Click += new System.EventHandler(this.aboutStripMenuItem_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(47, 63);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(184, 76);
         this.label1.TabIndex = 3;
         this.label1.Text = "label1";
         this.label1.Visible = false;
         this.label1.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
         // 
         // pBackGround
         // 
         this.pBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pBackGround.Image")));
         this.pBackGround.Location = new System.Drawing.Point(0, 31);
         this.pBackGround.Name = "pBackGround";
         this.pBackGround.Size = new System.Drawing.Size(892, 901);
         this.pBackGround.TabIndex = 10;
         this.pBackGround.TabStop = false;
         this.pBackGround.Visible = false;
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // pExplosion
         // 
         this.pExplosion.Image = ((System.Drawing.Image)(resources.GetObject("pExplosion.Image")));
         this.pExplosion.InitialImage = null;
         this.pExplosion.Location = new System.Drawing.Point(357, 583);
         this.pExplosion.Name = "pExplosion";
         this.pExplosion.Size = new System.Drawing.Size(169, 137);
         this.pExplosion.TabIndex = 5;
         this.pExplosion.TabStop = false;
         this.pExplosion.Visible = false;
         // 
         // pBox1
         // 
         this.pBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
         this.pBox1.Enabled = false;
         this.pBox1.InitialImage = null;
         this.pBox1.Location = new System.Drawing.Point(0, 661);
         this.pBox1.Name = "pBox1";
         this.pBox1.Size = new System.Drawing.Size(940, 5);
         this.pBox1.TabIndex = 4;
         this.pBox1.TabStop = false;
         // 
         // pFormBox
         // 
         this.pFormBox.Image = ((System.Drawing.Image)(resources.GetObject("pFormBox.Image")));
         this.pFormBox.InitialImage = null;
         this.pFormBox.Location = new System.Drawing.Point(14, 107);
         this.pFormBox.Name = "pFormBox";
         this.pFormBox.Size = new System.Drawing.Size(853, 480);
         this.pFormBox.TabIndex = 7;
         this.pFormBox.TabStop = false;
         // 
         // pCorrecto
         // 
         this.pCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pCorrecto.Image")));
         this.pCorrecto.Location = new System.Drawing.Point(12, 423);
         this.pCorrecto.Name = "pCorrecto";
         this.pCorrecto.Size = new System.Drawing.Size(245, 253);
         this.pCorrecto.TabIndex = 9;
         this.pCorrecto.TabStop = false;
         this.pCorrecto.Visible = false;
         this.pCorrecto.Click += new System.EventHandler(this.pCorrecto_Click);
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(876, 741);
         this.Controls.Add(this.pCorrecto);
         this.Controls.Add(this.pBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnStart);
         this.Controls.Add(this.menuMain);
         this.Controls.Add(this.pExplosion);
         this.Controls.Add(this.pFormBox);
         this.Controls.Add(this.pBackGround);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.MaximumSize = new System.Drawing.Size(898, 916);
         this.MinimumSize = new System.Drawing.Size(798, 774);
         this.Name = "frmMain";
         this.Opacity = 0.95D;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Letters Falling";
         this.Load += new System.EventHandler(this.frmMain_Load);
         this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
         this.menuMain.ResumeLayout(false);
         this.menuMain.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pBackGround)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pExplosion)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pFormBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pCorrecto)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.MenuStrip menuMain;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem  exitStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  easyStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  mediumStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  hardStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  lettersStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  dictionaryStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  soundStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem  nosoundStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem  aboutStripMenuItem;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Timer timer1;      
      private System.Windows.Forms.PictureBox pExplosion;
      private System.Windows.Forms.PictureBox pBox1;
      private System.Windows.Forms.PictureBox pFormBox;
      private System.Windows.Forms.PictureBox pCorrecto;
      private System.Windows.Forms.PictureBox pBackGround;
   }
}

