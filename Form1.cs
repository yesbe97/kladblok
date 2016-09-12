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
using System.Text;
using System.Diagnostics;

namespace kladblok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            // Open the selected file to read.
            //DialogResult fileStream = openFileDialog.FileName;

            textBox1.Text = File.ReadAllText(openFileDialog.FileName);

            //using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            //{
            //    // Read the first line from the file and write it the textbox.
            //    textBox1.Text = reader.ReadAllText();
            //}
           // fileStream.Close();
        }
    }
}
