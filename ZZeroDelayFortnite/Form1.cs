using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZZeroDelayFortnite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            // Enable
        {
            string batchFilePath = @"Registry\Enable.bat";

            if (System.IO.File.Exists(batchFilePath))
            {
                Process.Start(batchFilePath);
            }
            else
            {
                MessageBox.Show("Batch file not found!");
            }
            label1.Text = "Current: Enable";
        }
        

        private void button2_Click(object sender, EventArgs e)
        // Disable
        {
            string batchFilePath = @"Registry\Disable.bat";

            if (System.IO.File.Exists(batchFilePath))
            {
                Process.Start(batchFilePath);
            }
            else
            {
                MessageBox.Show("Batch file not found!");
            }
            label1.Text = "Current: Disable";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Github.url");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("FortniteLauncher.url");
        }
    }
}
