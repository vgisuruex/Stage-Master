using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        int ECM;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ECM == 0)
            {
                ECM = 0x06000001;
            }
        }
        private void tYToolStripMenuItem_Click(object sender, EventArgs e)
        {

         }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
            bw.BaseStream.Position = 0xFD3;
            bw.Write(ECM);
            bw.Close();

            MessageBox.Show("The Green Star Count Of Level 1 (EnterCatMario) Has Been Changed!" , "Done!" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 1)
            {
                ECM = 0x06000001;
            }
            if (numericUpDown2.Value == 2)
            {
                ECM = 0x06000002;
            }
            if (numericUpDown2.Value == 3)
            {
                ECM = 0x06000003;
            }
            if (numericUpDown2.Value == 4)
            {
                ECM = 0x06000004;
            }
            if (numericUpDown2.Value == 5)
            {
                ECM = 0x06000005;
            }
            if (numericUpDown2.Value == 6)
            {
                ECM = 0x06000006;
            }
            if (numericUpDown2.Value == 7)
            {
                ECM = 0x06000007;
            }
            if (numericUpDown2.Value == 8)
            {
                ECM = 0x06000008;
            }
            if (numericUpDown2.Value == 9)
            {
                ECM = 0x06000009;
            }
        }
    }
}
