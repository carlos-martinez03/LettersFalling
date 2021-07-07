using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsApp
{
   public partial class frmMain : Form
   {
      int x = 1, y = 1;
      Random rand = new Random();
      string strCadena = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string strLado   = "DIIIICCCDDICIIICCCDCDDDCDDIIICCCIICI"; //I-Izquierda    C-Centro    D-Derecha
      int NumRandom = 0, NumLevel = 4, NumPlay=0;
      WMPLib.WindowsMediaPlayer simpleSound = new WMPLib.WindowsMediaPlayer();
      string exePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

      public frmMain()
      {
         InitializeComponent();         
      }

      // Handle the KeyDown event to print the type of character entered into the control.
      private void frmMain_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyValue == (int) strCadena[NumRandom])
         {
            this.pCorrecto.Visible = true;
            y = 1;
            playGame();
         }      
      }

      private void frmMain_Load(object sender, EventArgs e)
      {
         simpleSound.URL = exePath + "\\" + "LettersFallingSong.mp3";
         simpleSound.settings.setMode("loop", true);
         simpleSound.controls.play();

         reubicarObjetos();
      }

      private void frmMain_SizeChanged(object sender, EventArgs e)
      {
         reubicarObjetos();
         recalcularPosicionLetra();
      }      

      private void PlaySoundError()
      {
         if (this.soundStripMenuItem.Checked == true)
         {
            System.Media.SystemSounds.Beep.Play();
         }
      }

      private void btnStart_Click(object sender, EventArgs e)
      {
         this.btnStart.Hide();
         this.pFormBox.Hide();
         this.pBackGround.Show();
         this.pCorrecto.Parent = this.pBackGround;
         this.pCorrecto.BackColor = System.Drawing.Color.Transparent;
         this.label1.Parent = this.pBackGround;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Visible = true;
         this.pExplosion.Parent = this.pBackGround;
         this.pExplosion.BackColor = System.Drawing.Color.Transparent;

         playGame();
      }

      private void exitStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void easyStripMenuItem_Click(object sender, EventArgs e)
      {
         this.easyStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.mediumStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         this.hardStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         NumLevel = 4;
      }

      private void mediumStripMenuItem_Click(object sender, EventArgs e)
      {
         this.easyStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         this.mediumStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.hardStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         NumLevel = 7;
      }

      private void hardStripMenuItem_Click(object sender, EventArgs e)
      {
         this.easyStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         this.mediumStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         this.hardStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         NumLevel = 9;
      }

      private void lettersStripMenuItem_Click(object sender, EventArgs e)
      {
         this.lettersStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.dictionaryStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         NumPlay = 0;
      }

      private void dictionaryStripMenuItem_Click(object sender, EventArgs e)
      {
         this.lettersStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         this.dictionaryStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         NumPlay = 1;
      }

      private void soundStripMenuItem_Click(object sender, EventArgs e)
      {
         this.soundStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.nosoundStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         simpleSound.controls.play();
      }

      private void nosoundStripMenuItem_Click(object sender, EventArgs e)
      {
         this.soundStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
         this.nosoundStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         simpleSound.controls.stop();
      }

      private void aboutStripMenuItem_Click(object sender, EventArgs e)
      {
         frmAbout newForm = new frmAbout();
         newForm.ShowDialog();
      }

      private void timer1_Tick(object sender, EventArgs e)
      {

         this.label1.SetBounds(x, y, 1, 1);
         
         y += NumLevel;
         if (y >= this.Height - 110) // Solo llegar al 85% de la parte inferior y desaparecer
         {
            y = 1;
            NumRandom = rand.Next(0, 35);

            recalcularPosicionLetra();
            
            this.label1.Text = strCadena[NumRandom].ToString();
            this.pExplosion.Visible = true;
            PlaySoundError();
         }
         if (y >= 75)
         {
            this.pExplosion.Visible = false;
            this.pCorrecto.Visible = false;
         }
      }

      private void pCorrecto_Click(object sender, EventArgs e)
      {

      }

      private void playGame()
      {
         NumRandom = rand.Next(0, 35);
         this.label1.Text = strCadena[NumRandom].ToString();
         this.label1.Font = new Font(" ", 34, FontStyle.Bold);
         recalcularPosicionLetra();
         timer1.Interval = 1;
         timer1.Start();        
      }

      private void recalcularPosicionLetra()
      {
         if (strLado[NumRandom].ToString() == "D")
         {
            x = this.Width / 4 * 3;    // Colocar la letra bajando a 3/4 de la pantalla
         }
         else if (strLado[NumRandom].ToString() == "I")
         {
            x = this.Width / 4;    // Colocar la letra bajando a 1/4 de la pantalla
         }
         else
         {
            x = this.Width / 2;    // Colocar la letra bajando a la mitad de la pantalla
         }
      }

      private void reubicarObjetos()
      {
         this.btnStart.Location = new System.Drawing.Point((this.Width - this.btnStart.Width) / 2, (this.Height - this.btnStart.Height) / 2);
         this.pBox1.Location = new System.Drawing.Point(this.pBox1.Location.X, this.Height - 110);
         this.pBox1.Size = new System.Drawing.Size(this.Width, this.pBox1.Size.Height);
         this.pExplosion.Location = new System.Drawing.Point((this.Width - this.pExplosion.Size.Width) / 2, this.Height - 215);
         this.pFormBox.Location = new System.Drawing.Point((this.Width - this.pFormBox.Width - 15) / 2, (this.Height - this.pFormBox.Height) / 2);
      }
   }
}
