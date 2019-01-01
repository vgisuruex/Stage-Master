using System;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication3;

namespace StageMaster
{
    public partial class Form6 : Form
    {
        int Lvl1Choice;
        OpenFileDialog ofd = new OpenFileDialog();
        bool FileOpened;

        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LV1BOX0_CheckedChanged(object sender, EventArgs e)
        {
            if (LV1BOX0.Checked == true)
            {
                Lvl1Choice = 0;
                LV1BOX1.Checked = false;
                LV1BOX2.Checked = false;
                LV1BOX3.Checked = false;
                LV1BOX4.Checked = false;
            }
        }

        private void line1_Click(object sender, EventArgs e)
        {
            if (LV1BOX1.Checked == true)
            {
                Lvl1Choice = 1;
                LV1BOX0.Checked = false;
                LV1BOX2.Checked = false;
                LV1BOX3.Checked = false;
                LV1BOX4.Checked = false;
            }
        }
        private void LV1BOX4_CheckedChanged(object sender, EventArgs e)
        {
            if (LV1BOX4.Checked == true)
            {
                Lvl1Choice = 4;
                LV1BOX1.Checked = false;
                LV1BOX2.Checked = false;
                LV1BOX3.Checked = false;
                LV1BOX0.Checked = false;
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (FileOpened == true)
            {
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                bw.BaseStream.Position = 0xFB3;
                bw.Write(0x02000000 + Lvl1Choice);
                bw.Close();
                MessageBox.Show("The Double Cherry Count of Level 1 (EnterCatMario) is Changed to " + Lvl1Choice + "!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please Select A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LV1BOX3_CheckedChanged(object sender, EventArgs e)
        {
            if (LV1BOX3.Checked == true)
            {
                Lvl1Choice = 3;
                LV1BOX1.Checked = false;
                LV1BOX2.Checked = false;
                LV1BOX0.Checked = false;
                LV1BOX4.Checked = false;
            }
        }

        private void LV1BOX2_CheckedChanged(object sender, EventArgs e)
        {
            if (LV1BOX2.Checked == true)
            {
                Lvl1Choice = 2;
                LV1BOX1.Checked = false;
                LV1BOX0.Checked = false;
                LV1BOX3.Checked = false;
                LV1BOX4.Checked = false;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            FileOpened = true;
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void greenStarMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
