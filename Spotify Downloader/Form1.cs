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
using System.IO;
using System.Text.RegularExpressions;

namespace Spotify_Downloader
{
    public partial class Form1 : Form
    {
        public object Tools { get; private set; }
        public int c { get; private set; }
        public object cmd { get; private set; }
        public int C { get; private set; }
        public object pause { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("readmegui.txt");
            
     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_2(object sender, EventArgs e)
        {

            Process npm = new Process();
            npm.StartInfo.FileName = @"C:\Program Files\nodejs\npm.cmd";
            npm.StartInfo.Arguments = "install";
            npm.StartInfo.UseShellExecute = false;
            npm.StartInfo.RedirectStandardOutput = true;
            npm.Start();
            richTextBox1.Text = npm.StandardOutput.ReadToEnd();
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("main.js");
            lines[23] = string.Format("USERNAME = \"{0}\"" , textBox1.Text);
            lines[25] = string.Format("PASSWORD = \"{0}\"", textBox5.Text);
            File.WriteAllLines("main.js", lines);
            textBox5.Text = String.Empty;
            MessageBox.Show("Login Saved", "Login", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("readmegui.txt");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text))

            {
                string text = textBox6.Text;
                Match match = Regex.Match(text, @"https://play.spotify.com/user/([A-Za-z0-9\-]+)/playlist/([A-Za-z0-9\-]+)");
                string user = match.Groups[1].Value;
                string playlist = match.Groups[2].Value;

                if (checkBox1.Checked)

                {
                    Process dnlf = new Process();
                    dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                    dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user, playlist);
                    dnlf.StartInfo.UseShellExecute = false;
                    dnlf.StartInfo.RedirectStandardOutput = false;
                    dnlf.Start();
                    dnlf.WaitForExit();
                }

                else if (!checkBox1.Checked)
                {
                    Process dnl = new Process();
                    dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                    dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user, playlist);
                    dnl.StartInfo.UseShellExecute = false;
                    dnl.StartInfo.RedirectStandardOutput = false;
                    dnl.Start();
                    dnl.WaitForExit();

                }
            

            else
            {


            }

        }

            if (!string.IsNullOrWhiteSpace(textBox2.Text))

            {
                string text2 = textBox2.Text;
                Match match2 = Regex.Match(text2, @"https://play.spotify.com/user/([A-Za-z0-9\-]+)/playlist/([A-Za-z0-9\-]+)");
                string user2 = match2.Groups[1].Value;
                string playlist2 = match2.Groups[2].Value;

                if (checkBox1.Checked)

                {
                    Process dnlf = new Process();
                    dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                    dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user2, playlist2);
                    dnlf.StartInfo.UseShellExecute = false;
                    dnlf.StartInfo.RedirectStandardOutput = false;
                    dnlf.Start();
                    dnlf.WaitForExit();

                }

                else if (!checkBox1.Checked)
                {
                    Process dnl = new Process();
                    dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                    dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user2, playlist2);
                    dnl.StartInfo.UseShellExecute = false;
                    dnl.StartInfo.RedirectStandardOutput = false;
                    dnl.Start();
                    dnl.WaitForExit();
                }
                else
                {

                }

           if (!string.IsNullOrWhiteSpace(textBox3.Text))

                    {
                        string text3 = textBox3.Text;
                        Match match3 = Regex.Match(text3, @"https://play.spotify.com/user/([A-Za-z0-9\-]+)/playlist/([A-Za-z0-9\-]+)");
                        string user3 = match3.Groups[1].Value;
                        string playlist3 = match3.Groups[2].Value;

                        if (checkBox1.Checked)

                        {
                            Process dnlf = new Process();
                            dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                            dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user3, playlist3);
                            dnlf.StartInfo.UseShellExecute = false;
                            dnlf.StartInfo.RedirectStandardOutput = false;
                            dnlf.Start();
                            dnlf.WaitForExit();

                        }

                        else if (!checkBox1.Checked)
                        {
                            Process dnl = new Process();
                            dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                            dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user3, playlist3);
                            dnl.StartInfo.UseShellExecute = false;
                            dnl.StartInfo.RedirectStandardOutput = false;
                            dnl.Start();
                            dnl.WaitForExit();


                        }

                        else

                        {


                        
                    }
                }
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
