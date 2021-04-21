using System;
using System.Windows.Forms;
using System.IO;

namespace mfk2lua
{
    public partial class Form1 : Form
    {
        string commands = "";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string file = Mfk.GetFile(openFileDialog1.FileName);

                textBox2.Text = Mfk.ConvertCommands(file);
                textBox1.Text = file;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, textBox2.Text);
        }
    }
}
