using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                }

            }
            else if(richTextBox1.Text.Length <= 140)
            {
                richTextBox1.BackColor = Color.White;
            }
        }
    }
}
