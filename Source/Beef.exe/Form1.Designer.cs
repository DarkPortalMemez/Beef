namespace Beef.exe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BEEFAMMOUNT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BEEFLABEL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BEEFDOLAMM = new System.Windows.Forms.Label();
            this.DC = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.slaveCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.superButton1 = new System.Windows.Forms.Button();
            this.upgSlaveIButton = new System.Windows.Forms.Button();
            this.upgSlaveIIButton = new System.Windows.Forms.Button();
            this.upgSlaveIIIButton = new System.Windows.Forms.Button();
            this.marketingButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.notifCheckBox = new System.Windows.Forms.CheckBox();
            this.superButton2 = new System.Windows.Forms.Button();
            this.marketingTeamButton = new System.Windows.Forms.Button();
            this.marketingTeamRatesLabel = new System.Windows.Forms.Label();
            this.marketingTeamSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // BEEFAMMOUNT
            // 
            this.BEEFAMMOUNT.AutoSize = true;
            this.BEEFAMMOUNT.Location = new System.Drawing.Point(362, 385);
            this.BEEFAMMOUNT.Name = "BEEFAMMOUNT";
            this.BEEFAMMOUNT.Size = new System.Drawing.Size(69, 20);
            this.BEEFAMMOUNT.TabIndex = 1;
            this.BEEFAMMOUNT.Text = "BEEF: 0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(322, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "MAKE BEEF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BEEFLABEL
            // 
            this.BEEFLABEL.AutoEllipsis = true;
            this.BEEFLABEL.AutoSize = true;
            this.BEEFLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEEFLABEL.Location = new System.Drawing.Point(231, 55);
            this.BEEFLABEL.Name = "BEEFLABEL";
            this.BEEFLABEL.Size = new System.Drawing.Size(364, 37);
            this.BEEFLABEL.TabIndex = 3;
            this.BEEFLABEL.Text = "YOUR BEEF FACTORY";
            this.BEEFLABEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(663, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "UPGRADE CLICK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "SELL BEEF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sell all";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount of B$";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 292);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // BEEFDOLAMM
            // 
            this.BEEFDOLAMM.AutoSize = true;
            this.BEEFDOLAMM.Location = new System.Drawing.Point(370, 422);
            this.BEEFDOLAMM.Name = "BEEFDOLAMM";
            this.BEEFDOLAMM.Size = new System.Drawing.Size(46, 20);
            this.BEEFDOLAMM.TabIndex = 10;
            this.BEEFDOLAMM.Text = "B$: 0";
            // 
            // DC
            // 
            this.DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC.Location = new System.Drawing.Point(663, 192);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(134, 60);
            this.DC.TabIndex = 13;
            this.DC.Text = "SUPGRADE CLICK";
            this.DC.UseVisualStyleBackColor = true;
            this.DC.Click += new System.EventHandler(this.DC_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(663, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 60);
            this.button4.TabIndex = 14;
            this.button4.Text = "OPGRADE CLICK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(584, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 45);
            this.button5.TabIndex = 15;
            this.button5.Text = "SAVE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "FILE AREA";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(696, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 45);
            this.button6.TabIndex = 17;
            this.button6.Text = "LOAD";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(280, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(225, 37);
            this.button7.TabIndex = 18;
            this.button7.Text = "Change factory name";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(663, 8);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 35);
            this.button8.TabIndex = 19;
            this.button8.Text = "Buy slaves";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(676, 86);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Amount";
            // 
            // slaveCounter
            // 
            this.slaveCounter.AutoSize = true;
            this.slaveCounter.Location = new System.Drawing.Point(672, 43);
            this.slaveCounter.Name = "slaveCounter";
            this.slaveCounter.Size = new System.Drawing.Size(90, 20);
            this.slaveCounter.TabIndex = 23;
            this.slaveCounter.Text = "SLAVES: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "1 BEEF = 0.2 B$";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 24);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Music";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // superButton1
            // 
            this.superButton1.Location = new System.Drawing.Point(819, 5);
            this.superButton1.Name = "superButton1";
            this.superButton1.Size = new System.Drawing.Size(120, 58);
            this.superButton1.TabIndex = 26;
            this.superButton1.Text = "Buy buttons";
            this.superButton1.UseVisualStyleBackColor = true;
            this.superButton1.Click += new System.EventHandler(this.superButton1_Click);
            // 
            // upgSlaveIButton
            // 
            this.upgSlaveIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgSlaveIButton.Location = new System.Drawing.Point(512, 123);
            this.upgSlaveIButton.Name = "upgSlaveIButton";
            this.upgSlaveIButton.Size = new System.Drawing.Size(134, 60);
            this.upgSlaveIButton.TabIndex = 27;
            this.upgSlaveIButton.Text = "UPGRADE SLAVES";
            this.upgSlaveIButton.UseVisualStyleBackColor = true;
            this.upgSlaveIButton.Visible = false;
            this.upgSlaveIButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // upgSlaveIIButton
            // 
            this.upgSlaveIIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgSlaveIIButton.Location = new System.Drawing.Point(512, 192);
            this.upgSlaveIIButton.Name = "upgSlaveIIButton";
            this.upgSlaveIIButton.Size = new System.Drawing.Size(134, 60);
            this.upgSlaveIIButton.TabIndex = 28;
            this.upgSlaveIIButton.Text = "SUPGRADE SLAVES";
            this.upgSlaveIIButton.UseVisualStyleBackColor = true;
            this.upgSlaveIIButton.Visible = false;
            this.upgSlaveIIButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // upgSlaveIIIButton
            // 
            this.upgSlaveIIIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgSlaveIIIButton.Location = new System.Drawing.Point(512, 258);
            this.upgSlaveIIIButton.Name = "upgSlaveIIIButton";
            this.upgSlaveIIIButton.Size = new System.Drawing.Size(134, 60);
            this.upgSlaveIIIButton.TabIndex = 29;
            this.upgSlaveIIIButton.Text = "OPGRADE SLAVES";
            this.upgSlaveIIIButton.UseVisualStyleBackColor = true;
            this.upgSlaveIIIButton.Visible = false;
            this.upgSlaveIIIButton.Click += new System.EventHandler(this.button12_Click);
            // 
            // marketingButton
            // 
            this.marketingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketingButton.Location = new System.Drawing.Point(12, 145);
            this.marketingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marketingButton.Name = "marketingButton";
            this.marketingButton.Size = new System.Drawing.Size(134, 35);
            this.marketingButton.TabIndex = 30;
            this.marketingButton.Text = "Market BEEF";
            this.marketingButton.UseVisualStyleBackColor = true;
            this.marketingButton.Visible = false;
            this.marketingButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "News Feed: Empty.";
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(143, 135);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(0, 0);
            this.musicPlayer.TabIndex = 32;
            // 
            // notifCheckBox
            // 
            this.notifCheckBox.AutoSize = true;
            this.notifCheckBox.Checked = true;
            this.notifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifCheckBox.Location = new System.Drawing.Point(19, 379);
            this.notifCheckBox.Name = "notifCheckBox";
            this.notifCheckBox.Size = new System.Drawing.Size(122, 24);
            this.notifCheckBox.TabIndex = 33;
            this.notifCheckBox.Text = "Notifications";
            this.notifCheckBox.UseVisualStyleBackColor = true;
            // 
            // superButton2
            // 
            this.superButton2.Location = new System.Drawing.Point(819, 69);
            this.superButton2.Name = "superButton2";
            this.superButton2.Size = new System.Drawing.Size(120, 55);
            this.superButton2.TabIndex = 34;
            this.superButton2.Text = "Buy computers";
            this.superButton2.UseVisualStyleBackColor = true;
            this.superButton2.Visible = false;
            this.superButton2.Click += new System.EventHandler(this.superButton2_Click);
            // 
            // marketingTeamButton
            // 
            this.marketingTeamButton.Location = new System.Drawing.Point(584, 485);
            this.marketingTeamButton.Name = "marketingTeamButton";
            this.marketingTeamButton.Size = new System.Drawing.Size(100, 80);
            this.marketingTeamButton.TabIndex = 35;
            this.marketingTeamButton.Text = "Hire Marketing Employee";
            this.marketingTeamButton.UseVisualStyleBackColor = true;
            this.marketingTeamButton.Visible = false;
            this.marketingTeamButton.Click += new System.EventHandler(this.marketingTeamButton_Click);
            // 
            // marketingTeamRatesLabel
            // 
            this.marketingTeamRatesLabel.AutoSize = true;
            this.marketingTeamRatesLabel.Location = new System.Drawing.Point(580, 442);
            this.marketingTeamRatesLabel.Name = "marketingTeamRatesLabel";
            this.marketingTeamRatesLabel.Size = new System.Drawing.Size(123, 40);
            this.marketingTeamRatesLabel.TabIndex = 36;
            this.marketingTeamRatesLabel.Text = "Employee rates:\r\n1000B$/s\r\n";
            this.marketingTeamRatesLabel.Visible = false;
            // 
            // marketingTeamSizeLabel
            // 
            this.marketingTeamSizeLabel.AutoSize = true;
            this.marketingTeamSizeLabel.Location = new System.Drawing.Point(704, 485);
            this.marketingTeamSizeLabel.Name = "marketingTeamSizeLabel";
            this.marketingTeamSizeLabel.Size = new System.Drawing.Size(104, 20);
            this.marketingTeamSizeLabel.TabIndex = 37;
            this.marketingTeamSizeLabel.Text = "Employees: 0";
            this.marketingTeamSizeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 449);
            this.Controls.Add(this.marketingTeamSizeLabel);
            this.Controls.Add(this.marketingTeamRatesLabel);
            this.Controls.Add(this.marketingTeamButton);
            this.Controls.Add(this.superButton2);
            this.Controls.Add(this.notifCheckBox);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marketingButton);
            this.Controls.Add(this.upgSlaveIIIButton);
            this.Controls.Add(this.upgSlaveIIButton);
            this.Controls.Add(this.upgSlaveIButton);
            this.Controls.Add(this.superButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.slaveCounter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.BEEFDOLAMM);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BEEFLABEL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BEEFAMMOUNT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Beef";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BEEFAMMOUNT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BEEFLABEL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BEEFDOLAMM;
        private System.Windows.Forms.Button DC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label slaveCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button superButton1;
        private System.Windows.Forms.Button upgSlaveIButton;
        private System.Windows.Forms.Button upgSlaveIIButton;
        private System.Windows.Forms.Button upgSlaveIIIButton;
        private System.Windows.Forms.Button marketingButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.CheckBox notifCheckBox;
        private System.Windows.Forms.Button superButton2;
        private System.Windows.Forms.Button marketingTeamButton;
        private System.Windows.Forms.Label marketingTeamRatesLabel;
        private System.Windows.Forms.Label marketingTeamSizeLabel;
    }
}

