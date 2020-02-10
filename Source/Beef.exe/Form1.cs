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


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Beef.exe
{
    public partial class Form1 : Form
    {
        public long beef = 0;
        public int beeftimer = 1;
        public long workers = 0;
        long clickpower = 1;
        long bdol = 0;
        bool sa = false;
        int sq = 0;
        public string fn;

        System.Media.SoundPlayer Music = new System.Media.SoundPlayer();
        public Form1() {
            InitializeComponent();
            string[] defsav = { "0", "1", "0" };
            string[] defsa2v = { "YOUR BEEF" };
            Music.SoundLocation = "Main.wav";
            Music.PlayLooping();
            System.IO.Directory.CreateDirectory(@"DATA");
            FileInfo FI = new FileInfo(@"DATA\SAVE FILE (requires DETERMINATION)");
            FileInfo FI2 = new FileInfo(@"DATA\FN");
            if (FI.Exists == false)
            {
                    System.IO.File.WriteAllLines(@"DATA\SAVE FILE (requires DETERMINATION)", defsav);
            }
            if (FI2.Exists == false)
            {
                    System.IO.File.WriteAllLines(@"DATA\FN", defsa2v);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            beef = beef + clickpower;
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (beef >= 100)
            {
                clickpower++;
                beef = beef - 100;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";
            }
            else
            {
                MessageBox.Show("You need at least 100 beef!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (beef >= 1)
            {
                if (sa == true)
                {
                    bdol = bdol + beef;
                    beef = 0;
                    BEEFAMMOUNT.Text = $"BEEF: {beef}";
                    BEEFDOLAMM.Text = $"B$: {bdol}";
                }
                else
                {
                    if (sq > beef)
                    {
                        MessageBox.Show("You do not have enough beef!");
                    }
                    else
                    {
                        bdol = bdol + sq / 5;
                        beef = beef - sq;
                        BEEFAMMOUNT.Text = $"BEEF: {beef}";
                        BEEFDOLAMM.Text = $"B$: {bdol}";
                    }
                }
            }
            else
            {
                MessageBox.Show("you need at least 1 beef to sell!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sa == false)
            {
                sa = true;
            }
            else
            {
                sa = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sq = Convert.ToInt32(numericUpDown1.Value) * 5;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In short, by selling beef and earning b$s, which can be used in order to get discord ranks, (with a screenshot)");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DarkPortalMemez/Beef/wiki/Discord-ranks-and-requirments");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (beef >= 5000)
            {
                clickpower = clickpower + 150;
                beef = beef - 5000;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";

            }
            else
            {
                MessageBox.Show("You need at least 5,000 beef!");
            }
        }

        private void DC_Click(object sender, EventArgs e)
        {
            if (beef >= 1000)
            {
                clickpower = clickpower + 15;
                beef = beef - 1000;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";
            }
            else
            {
                MessageBox.Show("You need at least 1,000 beef!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] save = { $"{beef}", $"{clickpower}", $"{bdol}", $"{workers}" };
            System.IO.File.WriteAllLines(@"DATA\SAVE FILE (requires DETERMINATION)", save);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] load = System.IO.File.ReadAllLines(@"DATA\SAVE FILE (requires DETERMINATION)");
            beef = Convert.ToInt64(load[0]);
            clickpower = Convert.ToInt64(load[1]);
            bdol = Convert.ToInt64(load[2]);
            workers = Convert.ToInt64(load[3]);
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
            BEEFDOLAMM.Text = $"B$: {bdol}";
            slaveCounter.Text = $"SLAVES: {workers}";
            string[] FN2 = System.IO.File.ReadAllLines(@"DATA\FN");
            fn = FN2[0];
            BEEFLABEL.Text = $"{fn} FACTORY";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NAME EMAN = new NAME();
            EMAN.Show();
        }

        private void KFIREXE_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            beef = beef + workers * 10;
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bdol >= 2000 * numericUpDown2.Value)
            {
                workers = Convert.ToInt64(workers + numericUpDown2.Value);
                bdol = bdol - (2000 * Convert.ToInt64(numericUpDown2.Value));
                BEEFDOLAMM.Text = $"B$: {bdol}";
                slaveCounter.Text = $"SLAVES: {workers}";

            }
            else
            {
                MessageBox.Show("You need at least 2,000 B$ per slave!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                Music.Stop();
            }
            else
            {
                Music.PlayLooping();
            }
        }
    }
}

