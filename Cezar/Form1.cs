using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_codeword_TextChanged(object sender, EventArgs e)
        {
            int lenth = textBox1_codeword.Text.Length;
            numericUpDown1_key.Maximum = 84 - lenth;

            if(lenth  > 0)
            {
                richTextBox1.Enabled = true;
                richTextBox2.Enabled = true;
                richTextBox3.Enabled = true;
            } else 
            {
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox3.Enabled = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cezar.createNewAlpha(textBox1_codeword.Text, ((int)numericUpDown1_key.Value));
            richTextBox2.Text = Cezar.encrypt(richTextBox1.Text);
            richTextBox3.Text = Cezar.decrypt(richTextBox2.Text);
        }
    }
}
