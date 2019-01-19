using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Beef.exe
{
    public partial class Form1 : Form
    {
        public int beef = 0;
        public int beeftimer = 1;
        public int workers = 0;
        int clickpower = 1;
        int bdol = 0;
        bool sa = false;
        int sq = 0;
        System.Media.SoundPlayer Music = new System.Media.SoundPlayer();


        public Form1()
         
        {
            InitializeComponent();
            Music.SoundLocation = "Main.wav";
            Music.PlayLooping();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            workers = workers + 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (beef >= 100)
            {
                clickpower = clickpower + 1;
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
                        bdol = bdol + sq;
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
            sq = Convert.ToInt32(numericUpDown1.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In short, by selling beef and earning b$s, which can be used in order to get discord ranks, (with a screenshot)");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/15wIwBU4sO73e19Va-4WdQXtmEOwc-sGeMiNz-0x1K4c/edit?usp=sharing");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (beef >= 10000)
            {
                clickpower = clickpower * 10;
                beef = beef - 10000;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";

            }
            else
            {
                MessageBox.Show("You need at least 10,000 beef!");
            }
        }

        private void DC_Click(object sender, EventArgs e)
        {
            if (beef >= 1000)
            {
                clickpower = clickpower * 2;
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
            string[] save = { $"{beef}", $"{clickpower}", $"{bdol}" };
            System.IO.File.WriteAllLines(@"SAVE FILE (requires DETERMINATION)", save);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] load = System.IO.File.ReadAllLines("SAVE FILE (requires DETERMINATION)");
            beef = Convert.ToInt32(load[0]);
            clickpower = Convert.ToInt32(load[1]);
            bdol = Convert.ToInt32(load[2]);
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
            BEEFDOLAMM.Text = $"B$: {bdol}";
        }
    }
}
