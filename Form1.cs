using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace gaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Runner can't be trying to run nothing! Give it something to do.",
                                "Whoops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string filePath = textBox1.Text;
                if (checkBox1.Checked)
                {
                    runasAdmin();
                }
                else runas();
            }
        }
        private void runasAdmin()
        {
            string filePath = textBox1.Text;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = filePath;
            startInfo.Verb = "runas";

            try
            {
                Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Runner couldn't launch this resource! Have you typed it in correctly?",
                                "Whoops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void runas()
        {
            string filePath = textBox1.Text;
            try
            {
                Process.Start(filePath);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Runner couldn't launch this resource! Have you typed it in correctly?",
                                "Whoops!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button2.PerformClick();
            } else if (e.KeyCode == Keys.E && e.Alt)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                checkBox1.Checked = !checkBox1.Checked;
            }
        }
    }
}
