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
using System.Media;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Beef.exe
{
    public partial class Form1 : Form
    {
        Random generalRandom = new Random();
        public double beef = 0;
        public double slaves = 0;
        double clickpower = 1;
        double bdol = 0;
        public string fn;
        bool slavebutton = false;
        double slavepower = 1;
        double beefprice = 0.2;
        int timeUntilEmptyNews = -1;
        SoundPlayer notifier = new SoundPlayer();
        public Form1() {
            InitializeComponent();
            string[] defsav = { "0", "1", "0", "0", "false", "1", "0.2" };
            string[] defsa2v = { "YOUR BEEF" };
            notifier.SoundLocation = @"sounds\notif.wav";
            musicPlayer.settings.setMode("loop", true);
            startMusic();
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
        void startMusic()
        {
            if (slavebutton)
            {
                musicPlayer.URL = @"sounds\Secondary.wav";
            }
            else
            {
                musicPlayer.URL = @"sounds\Main.wav";
            }
        }
        /*void PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                //music ended
                startMusic();
            }
        }*/
        public void UpdateCounters()
        {
            BEEFAMMOUNT.Text = $"BEEF: {beef}";
            label5.Text = $"1 BEEF = {beefprice} B$";
            slaveCounter.Text = $"SLAVES: {slaves}";
        }
        public void UpdateNews(string news, Color color)
        {
            label3.Text = "News Feed: " + news;
            label3.ForeColor = color;
            if (notifCheckBox.Checked && news != "Empty.")
                notifier.Play();
            timeUntilEmptyNews = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (beef + clickpower > beef)
                beef = beef + clickpower;
            UpdateCounters();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (beef >= 100 && clickpower + 1 > clickpower)
            {
                clickpower++;
                beef = beef - 100;
                UpdateCounters();
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
                    bdol = Convert.ToDouble(Convert.ToDouble(bdol) + Convert.ToDouble(beef) * beefprice);
                    beef = 0;
                    UpdateCounters();
                    BEEFDOLAMM.Text = $"B$: {bdol}";
                }
                else if (numericUpDown1.Value > Convert.ToDecimal(Convert.ToDouble(Convert.ToDouble(beef) * beefprice)))
                {
                    MessageBox.Show("You do not have enough beef!");
                }
                else if (bdol + Convert.ToDouble(numericUpDown1.Value) > bdol)
                {
                    bdol = Convert.ToDouble(Convert.ToDouble(bdol) + Convert.ToDouble(numericUpDown1.Value));
                    beef = beef - Convert.ToDouble(Convert.ToDouble(numericUpDown1.Value) / beefprice);
                    UpdateCounters();
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
                UpdateCounters();

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
                UpdateCounters();
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
            beef = Convert.ToDouble(load[0]);
            clickpower = Convert.ToDouble(load[1]);
            bdol = Convert.ToDouble(load[2]);
            slaves = Convert.ToDouble(load[3]);
            slavebutton = Convert.ToBoolean(load[4]);
            slavepower = Convert.ToDouble(load[5]);
            beefprice = Convert.ToDouble(load[6]);
            slaveCheck();
            UpdateCounters();
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
            if (slaves > 10)
            {
                if (generalRandom.Next(0, 800) == 0)
                {
                    double percentLost = ((double)generalRandom.Next(20, 70)) / 100;
                    slaves -= Math.Ceiling(slaves * percentLost);
                    UpdateCounters();
                    UpdateNews($"{percentLost * 100}% of your slaves have escaped!\nThat's {Math.Ceiling(slaves * percentLost)} slaves!", Color.DarkRed);
                }
            }
            if (beef + slaves * slavepower * 10 > beef)
                beef = beef + slaves * slavepower * 10;
            if (timeUntilEmptyNews > 0)
            {
                timeUntilEmptyNews--;
                if (timeUntilEmptyNews == 0)
                {
                    UpdateNews("Empty.", Color.Black);
                }
            }
            UpdateCounters();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(bdol) >= 2000 * numericUpDown2.Value && Convert.ToDecimal(slaves) + numericUpDown2.Value > Convert.ToDecimal(slaves))
            {
                slaves = Convert.ToDouble(Convert.ToDecimal(slaves) + numericUpDown2.Value);
                bdol = bdol - (2000 * Convert.ToDouble(numericUpDown2.Value));
                BEEFDOLAMM.Text = $"B$: {bdol}";
                UpdateCounters();

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
                musicPlayer.URL = null;
            }
            else
            {
                startMusic();
            }
        }
        void slaveCheck()
        {
            if (slavebutton == true)
            {
                double position = musicPlayer.Ctlcontrols.currentPosition;
                musicPlayer.URL = @"sounds\Secondary.wav";
                musicPlayer.Ctlcontrols.currentPosition = position;
                button9.Visible = false;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                if (timer2.Enabled == false)
                {
                    timer2.Enabled = true;
                    timer2.Start();
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (beef >= 100000)
            {
                slavebutton = true;
                slaveCheck();
                beef -= 100000;
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
                UpdateCounters();
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
                UpdateCounters();
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
                UpdateCounters();
            }
            else
            {
                MessageBox.Show("You need at least 500,000 beef!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (beef >= 500000)
            {
                beefprice = beefprice + 0.2;
                beef = beef - 500000;
                UpdateCounters();
            }
            else
            {
                MessageBox.Show("You need at least 500,000 beef!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (beefprice > 0.5)
            {
                beefprice -= 0.1;
                UpdateNews("The value of beef has diminished \nby 0.1 B$.", Color.DarkOrange);
                UpdateCounters();
            }
        }
    }
}

