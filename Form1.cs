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

        private void SetTitle()
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
        }
        public Form1()
        {
            InitializeComponent();
            SetTitle();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox1.Text = openFileDialog.FileName;
            File.WriteAllText(this.FullPath, textBox1.Text);
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
            //char myChar = Path.GetFileNameWithoutExtension(openFileDialog.Fi‌​leName);
            SetTitle();
            //openFileDialog;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult userButtonClicked = saveFileDialog.ShowDialog();
            if (userButtonClicked == DialogResult.OK)
            {
                textBox1.Text = userButtonClicked.ToString();
                //File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            }
        }
        private void 
    }
}
