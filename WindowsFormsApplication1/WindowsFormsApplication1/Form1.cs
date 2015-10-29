using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text =  "\nCharacter count is: " + richTextBox1.Text.Length;
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox1.Text.Length >= 140)
            {
                if (e.KeyChar == (char)8)
                {

                }
                else
                {
                    richTextBox1.BackColor = Color.Maroon;
                   // var player2 = new WMPLib.WindowsMediaPlayer(Properties.Resources.Scream); 
                   // player2.Play();

                }

            }
            else if(richTextBox1.Text.Length <= 140)
            {
                richTextBox1.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.music5);
                player.PlayLooping();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream openStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((openStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox1.Text = filetext;
                }
            }
        }
    }
}
