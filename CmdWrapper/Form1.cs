using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CmdWrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = "Icon File (*.ico)|*.ico";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            
        }
    }
}
