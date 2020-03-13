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
        public long slaves = 0;
        long clickpower = 1;
        long bdol = 0;
        public string fn;
        bool slavebutton = false;
        long slavepower = 1;
        double beefprice = 0.2;

        System.Media.SoundPlayer Music = new System.Media.SoundPlayer();
        public Form1() {
            InitializeComponent();
            string[] defsav = { "0", "1", "0", "0", "false", "1", "0.2" };
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (beef + clickpower > beef)
                beef = beef + clickpower;
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (beef >= 100 && clickpower + 1 > clickpower)
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
                if (checkBox1.Checked == true && bdol + beef > bdol)
                {
                    bdol = Convert.ToInt64(Convert.ToDouble(bdol) + Convert.ToDouble(beef) * beefprice);
                    beef = 0;
                    BEEFAMMOUNT.Text = $"BEEF: {beef}";
                    BEEFDOLAMM.Text = $"B$: {bdol}";
                }
                else if (numericUpDown1.Value > Convert.ToInt64(Convert.ToDouble(beef) * beefprice))
                {
                    MessageBox.Show("You do not have enough beef!");
                }
                else if (bdol + Convert.ToInt64(numericUpDown1.Value) > bdol)
                {
                    bdol = Convert.ToInt64(Convert.ToDouble(bdol) + Convert.ToDouble(numericUpDown1.Value));
                    beef = beef - Convert.ToInt64(Convert.ToDouble(numericUpDown1.Value) / beefprice);
                    BEEFAMMOUNT.Text = $"BEEF: {beef}";
                    BEEFDOLAMM.Text = $"B$: {bdol}";
                }
            }
            else
            {
                MessageBox.Show("you need at least 1 beef to sell!");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (beef >= 5000 && clickpower + 150 > clickpower)
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
            if (beef >= 1000 && clickpower + 15 > clickpower)
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
            string[] save = { $"{beef}", $"{clickpower}", $"{bdol}", $"{slaves}", $"{slavebutton}", $"{slavepower}", $"{beefprice}" };
            System.IO.File.WriteAllLines(@"DATA\SAVE FILE (requires DETERMINATION)", save);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] load = System.IO.File.ReadAllLines(@"DATA\SAVE FILE (requires DETERMINATION)");
            beef = Convert.ToInt64(load[0]);
            clickpower = Convert.ToInt64(load[1]);
            bdol = Convert.ToInt64(load[2]);
            slaves = Convert.ToInt64(load[3]);
            slavebutton = Convert.ToBoolean(load[4]);
            slavepower = Convert.ToInt64(load[5]);
            beefprice = Convert.ToDouble(load[6]);
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
            BEEFDOLAMM.Text = $"B$: {bdol}";
            slaveCounter.Text = $"SLAVES: {slaves}";
            label5.Text = $"1 BEEF = {beefprice} B$";
            string[] FN2 = System.IO.File.ReadAllLines(@"DATA\FN");
            fn = FN2[0];
            BEEFLABEL.Text = $"{fn} FACTORY";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NAME EMAN = new NAME();
            EMAN.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (beef + slaves * slavepower * 10 > beef)
                beef = beef + slaves * slavepower * 10;
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
            if (slavebutton == true)
            {
                button9.Visible = false;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bdol >= 2000 * numericUpDown2.Value && slaves + numericUpDown2.Value > slaves)
            {
                slaves = Convert.ToInt64(slaves + numericUpDown2.Value);
                bdol = bdol - (2000 * Convert.ToInt64(numericUpDown2.Value));
                BEEFDOLAMM.Text = $"B$: {bdol}";
                slaveCounter.Text = $"SLAVES: {slaves}";

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

        private void button9_Click(object sender, EventArgs e)
        {
            if (beef >= 100000)
            {
                slavebutton = true;
                beef = beef - 100000;
            }
            else
            {
                MessageBox.Show("You need at least 100,000 beef!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (beef >= 10000 && slavepower + 1 > slavepower)
            {
                slavepower++;
                beef = beef - 10000;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";
            }
            else
            {
                MessageBox.Show("You need at least 10,000 beef!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (beef >= 100000 && slavepower + 150 > slavepower)
            {
                slavepower = slavepower + 150;
                beef = beef - 100000;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";
            }
            else
            {
                MessageBox.Show("You need at least 100,000 beef!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (beef >= 500000 && slavepower + 1000 > slavepower)
            {
                slavepower = slavepower + 1000;
                beef = beef - 500000;
                BEEFAMMOUNT.Text = $"BEEF: {beef}";
            }
            else
            {
                MessageBox.Show("You need at least 500,000 beef!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (beef >= 50000)
            {
                beefprice = beefprice + 0.2;
                label5.Text = $"1 BEEF = {beefprice} B$";
            }
            else
            {
                MessageBox.Show("You need at least 50,000 beef!");
            }
        }
    }
}

