using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beef.exe
{
    public partial class NAME : Form
    {
        public NAME()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fn = { $"{textBox1.Text}" };
            System.IO.File.WriteAllLines(@"DATA\FN", fn);
            MessageBox.Show("Please save and reload");
            this.Close();
        }
    }
}
