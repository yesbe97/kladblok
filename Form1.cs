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

namespace kladblok
{
    public partial class Form1 : Form
    {
        string FullPath = "";

        private void SetTitle(bool asterix)
        {
            if (FullPath == null | FullPath == "")
            {
                this.Text = "Nieuw document - C# Kladblok";
            }
            else
            {
                string OnlyFilename = System.IO.Path.GetFileNameWithoutExtension(FullPath);
                this.Text = OnlyFilename + " - C# Kladblok";
            }

            string form_text = this.Text;

            string check_string = "*";

            bool b = form_text.Contains(check_string);

            if (!asterix)
            {
                this.Text = form_text + "*";
            }
        }

        public Form1()
        {
            InitializeComponent();
            SetTitle(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox1.Text = openFileDialog.FileName;
            File.WriteAllText(this.FullPath, textBox1.Text);
            SetTitle(true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© Nicky van Driel - MBiC14A0 - 2016");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            var userClickedOK = openFileDialog.ShowDialog();

            textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            this.FullPath = openFileDialog.FileName;
            SetTitle(true);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult userButtonClicked = saveFileDialog.ShowDialog();
            if (userButtonClicked == DialogResult.OK)
            { 
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            }
            SetTitle(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keydown_textbox1(object sender, KeyEventArgs e)
        {
            SetTitle(false);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            this.FullPath = "";

            SetTitle(true);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.WordWrap == true)
            {
                textBox1.WordWrap = false;
            }
            else
            {
                textBox1.WordWrap = true;
            }
        }
    }
}
