using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GreenStarMaster;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        bool FileOpened;
        uint UserResult;
        decimal UserChoice;

        private void Form1_Load(object sender, EventArgs e)
        {
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
            if (FileOpened == true)
            {
                UserChoice = numericUpDown1.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x1417;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level 1 (SideWaveDesertStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calc()
        {
            if (UserChoice == 1)
            {
                UserResult = 0x00000001;
            }
            if (UserChoice == 2)
            {
                UserResult = 0x00000002;
            }
            if (UserChoice == 3)
            {
                UserResult = 0x00000003;
            }
            if (UserChoice == 4)
            {
                UserResult = 0x00000004;
            }
            if (UserChoice == 5)
            {
                UserResult = 0x00000005;
            }
            if (UserChoice == 6)
            {
                UserResult = 0x00000006;
            }
            if (UserChoice == 7)
            {
                UserResult = 0x00000007;
            }
            if (UserChoice == 8)
            {
                UserResult = 0x00000008;
            }
            if (UserChoice == 9)
            {
                UserResult = 0x00000009;
            }
            if (UserChoice == 10)
            {
                UserResult = 0x0000000A;
            }
            if (UserChoice == 11)
            {
                UserResult = 0x0000000B;
            }
            if (UserChoice == 12)
            {
                UserResult = 0x0000000C;
            }
            if (UserChoice == 13)
            {
                UserResult = 0x0000000D;
            }
            if (UserChoice == 14)
            {
                UserResult = 0x0000000E;
            }
            if (UserChoice == 15)
            {
                UserResult = 0x0000000F;
            }
            if (UserChoice == 16)
            {
                UserResult = 0x00000010;
            }
            if (UserChoice == 17)
            {
                UserResult = 0x00000011;
            }
            if (UserChoice == 18)
            {
                UserResult = 0x00000012;
            }
            if (UserChoice == 19)
            {
                UserResult = 0x00000013;
            }
            if (UserChoice == 20)
            {
                UserResult = 0x00000014;
            }
            if (UserChoice == 21)
            {
                UserResult = 0x00000015;
            }
            if (UserChoice == 22)
            {
                UserResult = 0x00000016;
            }
            if (UserChoice == 23)
            {
                UserResult = 0x00000017;
            }
            if (UserChoice == 24)
            {
                UserResult = 0x00000018;
            }
            if (UserChoice == 25)
            {
                UserResult = 0x00000019;
            }
            if (UserChoice == 26)
            {
                UserResult = 0x0000001A;
            }
            if (UserChoice == 27)
            {
                UserResult = 0x0000001B;
            }
            if (UserChoice == 28)
            {
                UserResult = 0x0000001C;
            }
            if (UserChoice == 29)
            {
                UserResult = 0x0000001D;
            }
            if (UserChoice == 30)
            {
                UserResult = 0x0000001E;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            FileOpened = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void settingUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whenYoureNearAStageInTheWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gettingTheBymlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void httpavsysxyzuploadfilesWexos27s20Toolbox20v1020zipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://avsys.xyz/upload/files/Wexos%27s%20Toolbox%20v1.0.2.0.zip");
        }

        private void githubcomvgisuruexGreenStarMasterreleasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/vgisuruex/Green-Star-Master/releases/"); 
        }

        private void httpsdiscordggKVhjRzBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/KVhjRzB");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown2.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x1473;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level 2 (TouchAndMikeStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown8.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x17AF;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level ? (GateKeeperKuriboLv1Stage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown7.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x16F7;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level Tank(Castle) (KillerTankStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown6.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x169B;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level ? (MysteryHouseEnemyStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown5.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x1587;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level 5 (DoubleMarioFieldStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown4.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x152B;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level 4 (RotateFieldStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                UserChoice = numericUpDown3.Value;
                Calc();

                if (UserResult > 0)
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
                    bw.BaseStream.Position = 0x14CF;
                    bw.Write(0x06000000 + UserResult);
                    bw.Close();

                    MessageBox.Show("The Green Star Count Of Level 3 (ShadowTunnelStage) Has Been Changed!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserResult = 0;
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (FileOpened == true)
            {
                button1.PerformClick();
                if (UserResult == 0)
                {
                    button2.PerformClick();
                    if (UserResult == 0)
                    {
                        button3.PerformClick();
                        if (UserResult == 0)
                        {
                            button4.PerformClick();
                            if (UserResult == 0)
                            {
                                button5.PerformClick();
                                if (UserResult == 0)
                                {
                                    button6.PerformClick();
                                    if (UserResult == 0)
                                    {
                                        button7.PerformClick();
                                        if (UserResult == 0)
                                        {
                                            button8.PerformClick();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (FileOpened == false)
            {
                MessageBox.Show("First Open A File", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void world1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
