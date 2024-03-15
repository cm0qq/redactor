using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace redtext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.text)|*.txt|All Files (*.*)|*.*";
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, fastColoredTextBox1.Text);
            MessageBox.Show("Файл сохранен");

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            fastColoredTextBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.Cut();
            }
        }

        private void настройкиШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            fastColoredTextBox1.Font = fontDialog1.Font;
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.SelectAll();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fastColoredTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.Cut();
            }
        }

        private void выделитьВсёToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                fastColoredTextBox1.SelectAll();
            }
        }

        private void поискToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
