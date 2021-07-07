
namespace WinFormsApp
{
   partial class frmAbout
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
         this.label1 = new System.Windows.Forms.Label();
         this.txtAbout = new System.Windows.Forms.TextBox();
         this.btnAboutClose = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(395, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(342, 49);
         this.label1.TabIndex = 0;
         this.label1.Text = "Letters Falling";
         // 
         // txtAbout
         // 
         this.txtAbout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.txtAbout.Enabled = false;
         this.txtAbout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtAbout.Location = new System.Drawing.Point(363, 85);
         this.txtAbout.Multiline = true;
         this.txtAbout.Name = "txtAbout";
         this.txtAbout.ReadOnly = true;
         this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtAbout.Size = new System.Drawing.Size(425, 282);
         this.txtAbout.TabIndex = 1;
         this.txtAbout.Text = "You can practice your typing in this application. \r\nLetters will be falling and y" +
    "ou\'ll have to type the keys that will appear on the screen.\r\n\r\n\r\nGeniux\r\n  v " + typeof(frmMain).Assembly.GetName().Version +
    "\r\n Carlos M Mtz";
         // 
         // btnAboutClose
         // 
         this.btnAboutClose.Location = new System.Drawing.Point(678, 392);
         this.btnAboutClose.Name = "btnAboutClose";
         this.btnAboutClose.Size = new System.Drawing.Size(93, 28);
         this.btnAboutClose.TabIndex = 2;
         this.btnAboutClose.Text = "Close";
         this.btnAboutClose.UseVisualStyleBackColor = true;
         this.btnAboutClose.Click += new System.EventHandler(this.btnAboutClose_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.InitialImage = null;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(345, 426);
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // frmAbout
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnAboutClose);
         this.Controls.Add(this.txtAbout);
         this.Controls.Add(this.label1);
         this.Name = "frmAbout";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "About";
         this.Load += new System.EventHandler(this.frmAbout_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtAbout;
      private System.Windows.Forms.Button btnAboutClose;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
} 