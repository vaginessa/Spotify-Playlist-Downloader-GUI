using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing.Text;


namespace Spotify_Downloader
{

   

    public partial class Form1 : Form
    {
        public object Tools { get; private set; }
        public int c { get; private set; }
        public object cmd { get; private set; }
        public int C { get; private set; }
        public object pause { get; private set; }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        
        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;

        int TogMove;
        int MValX;
        int MValY;


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;  
                return handleParam;
            }
        }

        public Form1()
        {
            InitializeComponent();

            

            byte[] fontData = Properties.Resources.Roboto_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Roboto_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Roboto_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 15.75F);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;


        }

        string OutputData;
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
            string path = @"node_modules";
            if (!Directory.Exists(path))
            {
                Process npm = new Process();
                npm.StartInfo.FileName = @"C:\Program Files\nodejs\npm.cmd";
                npm.StartInfo.Arguments = "install";
                npm.StartInfo.UseShellExecute = false;
                npm.StartInfo.RedirectStandardOutput = true;
                npm.Start();
                richTextBox1.Text = npm.StandardOutput.ReadToEnd();
            }


            Dnlbtn.ImageIndex = 0;
            ListTextBox1.Font = myFont;
            ListTextBox2.Font = myFont;
            ListTextBox3.Font = myFont;
            ListTextBox4.Font = myFont;
            ListTextBox5.Font = myFont;
            richTextBox1.Font = myFont = new Font(fonts.Families[0], 8, FontStyle.Regular);
            Titlelabel.Font = myFont = new Font(fonts.Families[0], 16, FontStyle.Regular);
            Prgslabel.Font = myFont = new Font(fonts.Families[0], 12, FontStyle.Regular);
            Playlistlabel.Font = myFont = new Font(fonts.Families[0], 12, FontStyle.Regular);
            Checkboxformat.Font = myFont = new Font(fonts.Families[0], 8, FontStyle.Regular);
            Credits.Font = myFont = new Font(fonts.Families[0], 9, FontStyle.Regular);



        }


        private void Npmbtn_Click_2(object sender, EventArgs e)
        {

           

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

       
        private void Helpbtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://imgur.com/a/tAFo3");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }




        private void Dnlbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            if (File.ReadAllText("main.js").Contains("USERNAME = \"USERNAME\""))
            {
                Dnlbtn.ImageIndex = 0;
                this.Hide();
                Login login = new Login();
                login.RefToForm1 = this;
                this.Visible = false;
                login.ShowDialog();
                login.TopMost = true;
                login.BringToFront();
                login.Focus();
                login.TopMost = false;
                Dnlbtn.ImageIndex = 0;


            }

            else

            {

                if (!string.IsNullOrWhiteSpace(ListTextBox1.Text))

                {
                    string text = ListTextBox1.Text;
                    Match match = Regex.Match(text, @"https://play.spotify.com/user/([A-Za-z0-9_\.\-]+)/playlist/([A-Za-z0-9_\-]+)");
                    string user = match.Groups[1].Value;
                    string playlist = match.Groups[2].Value;

                    if (Checkboxformat.Checked)

                    {
                        Process dnlf = new Process();
                        dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user, playlist);
                        dnlf.StartInfo.UseShellExecute = false;
                        dnlf.StartInfo.RedirectStandardOutput = true;
                        dnlf.EnableRaisingEvents = true;
                        dnlf.StartInfo.CreateNoWindow = true;
                        dnlf.OutputDataReceived += OnOutputDataReceived;
                        dnlf.Start();
                        dnlf.BeginOutputReadLine();

                        while (!dnlf.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                    }

                    else if (!Checkboxformat.Checked)
                    {

                        Process dnl = new Process();
                        dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user, playlist);
                        dnl.StartInfo.UseShellExecute = false;
                        dnl.StartInfo.RedirectStandardOutput = true;
                        dnl.EnableRaisingEvents = true;
                        dnl.StartInfo.CreateNoWindow = true;
                        dnl.Exited += new EventHandler(process_Exited);
                        dnl.OutputDataReceived += OnOutputDataReceived;
                        dnl.Start();
                        dnl.BeginOutputReadLine();

                        while (!dnl.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                    }
                    
                    else
                    {
                        MessageBox.Show("You must at least fill in 1 playlist", "Playlist ERROR", MessageBoxButtons.OK);


                    }
                }


                if (!string.IsNullOrWhiteSpace(ListTextBox2.Text))

                {
                    string text2 = ListTextBox2.Text;
                    Match match2 = Regex.Match(text2, @"https://play.spotify.com/user/([A-Za-z0-9_\.\-]+)/playlist/([A-Za-z0-9_\-]+)");
                    string user2 = match2.Groups[1].Value;
                    string playlist2 = match2.Groups[2].Value;

                    if (Checkboxformat.Checked)

                    {
                        Process dnlf = new Process();
                        dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user2, playlist2);
                        dnlf.StartInfo.UseShellExecute = false;
                        dnlf.StartInfo.RedirectStandardOutput = true;
                        dnlf.EnableRaisingEvents = true;
                        dnlf.StartInfo.CreateNoWindow = true;
                        dnlf.OutputDataReceived += OnOutputDataReceived;
                        dnlf.Start();
                        dnlf.BeginOutputReadLine();

                        while (!dnlf.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }


                    }

                    else if (!Checkboxformat.Checked)
                    {
                        Process dnl = new Process();
                        dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user2, playlist2);
                        dnl.StartInfo.UseShellExecute = false;
                        dnl.StartInfo.RedirectStandardOutput = true;
                        dnl.EnableRaisingEvents = true;
                        dnl.StartInfo.CreateNoWindow = true;
                        dnl.OutputDataReceived += OnOutputDataReceived;
                        dnl.Start();
                        dnl.BeginOutputReadLine();

                        while (!dnl.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }


                    }
                    else
                    {

                    }

                }
                if (!string.IsNullOrWhiteSpace(ListTextBox3.Text))

                {
                    string text3 = ListTextBox3.Text;
                    Match match3 = Regex.Match(text3, @"https://play.spotify.com/user/([A-Za-z0-9_\.\-]+)/playlist/([A-Za-z0-9_\-]+)");
                    string user3 = match3.Groups[1].Value;
                    string playlist3 = match3.Groups[2].Value;

                    if (Checkboxformat.Checked)

                    {
                        Process dnlf = new Process();
                        dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user3, playlist3);
                        dnlf.StartInfo.UseShellExecute = false;
                        dnlf.StartInfo.RedirectStandardOutput = true;
                        dnlf.EnableRaisingEvents = true;
                        dnlf.StartInfo.CreateNoWindow = true;
                        dnlf.OutputDataReceived += OnOutputDataReceived;
                        dnlf.Start();
                        dnlf.BeginOutputReadLine();

                        while (!dnlf.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                    }

                    else if (!Checkboxformat.Checked)
                    {
                        Process dnl = new Process();
                        dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user3, playlist3);
                        dnl.StartInfo.UseShellExecute = false;
                        dnl.StartInfo.RedirectStandardOutput = true;
                        dnl.EnableRaisingEvents = true;
                        dnl.StartInfo.CreateNoWindow = true;
                        dnl.OutputDataReceived += OnOutputDataReceived;
                        dnl.Start();
                        dnl.BeginOutputReadLine();

                        while (!dnl.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }




                    }

                    else
                    {


                    }

                }

                if (!string.IsNullOrWhiteSpace(ListTextBox4.Text))

                {
                    string text4 = ListTextBox4.Text;
                    Match match4 = Regex.Match(text4, @"https://play.spotify.com/user/([A-Za-z0-9_\.\-]+)/playlist/([A-Za-z0-9_\-]+)");
                    string user4 = match4.Groups[1].Value;
                    string playlist4 = match4.Groups[2].Value;

                    if (Checkboxformat.Checked)

                    {
                        Process dnlf = new Process();
                        dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user4, playlist4);
                        dnlf.StartInfo.UseShellExecute = false;
                        dnlf.StartInfo.RedirectStandardOutput = true;
                        dnlf.EnableRaisingEvents = true;
                        dnlf.StartInfo.CreateNoWindow = true;
                        dnlf.OutputDataReceived += OnOutputDataReceived;
                        dnlf.Start();
                        dnlf.BeginOutputReadLine();

                        while (!dnlf.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                    }

                    else if (!Checkboxformat.Checked)
                    {
                        Process dnl = new Process();
                        dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user4, playlist4);
                        dnl.StartInfo.UseShellExecute = false;
                        dnl.StartInfo.RedirectStandardOutput = true;
                        dnl.EnableRaisingEvents = true;
                        dnl.StartInfo.CreateNoWindow = true;
                        dnl.OutputDataReceived += OnOutputDataReceived;
                        dnl.Start();
                        dnl.BeginOutputReadLine();

                        while (!dnl.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }
                    }
                    else

                    {



                    }

                }

                if (!string.IsNullOrWhiteSpace(ListTextBox5.Text))

                {
                    string text5 = ListTextBox5.Text;
                    Match match5 = Regex.Match(text5, @"https://play.spotify.com/user/([A-Za-z0-9_\.\-]+)/playlist/([A-Za-z0-9_\-]+)");
                    string user5 = match5.Groups[1].Value;
                    string playlist5 = match5.Groups[2].Value;

                    if (Checkboxformat.Checked)

                    {
                        Process dnlf = new Process();
                        dnlf.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnlf.StartInfo.Arguments = string.Format("main.js -f -u {0} -p {1}", user5, playlist5);
                        dnlf.StartInfo.UseShellExecute = false;
                        dnlf.StartInfo.RedirectStandardOutput = true;
                        dnlf.EnableRaisingEvents = true;
                        dnlf.StartInfo.CreateNoWindow = true;
                        dnlf.OutputDataReceived += OnOutputDataReceived;
                        dnlf.Start();
                        dnlf.BeginOutputReadLine();

                        while (!dnlf.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                    }

                    else if (!Checkboxformat.Checked)
                    {
                        Process dnl = new Process();
                        dnl.StartInfo.FileName = @"C:\Program Files\nodejs\node.exe";
                        dnl.StartInfo.Arguments = string.Format("main.js -u {0} -p {1}", user5, playlist5);
                        dnl.StartInfo.UseShellExecute = false;
                        dnl.StartInfo.RedirectStandardOutput = true;
                        dnl.EnableRaisingEvents = true;
                        dnl.StartInfo.CreateNoWindow = true;
                        dnl.OutputDataReceived += OnOutputDataReceived;
                        dnl.Start();
                        dnl.BeginOutputReadLine();

                        while (!dnl.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }
                    }
                    else

                    {



                    }


                }
            }
        }
        void process_Exited(object sender, EventArgs e)
        {
            Process dnl = (Process)sender;
            int exitCode = dnl.ExitCode;
        }

        void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.OutputData += e.Data + Environment.NewLine;
                SetText(this.OutputData);
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.Text = text;
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            
            richTextBox1.ScrollToCaret();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            if (File.ReadAllText("main.js").Contains("USERNAME = \"USERNAME\""))
            {
                this.Hide();
                Login login = new Login();
                login.RefToForm1 = this;
                this.Visible = false;
                login.ShowDialog();
                login.TopMost = true;
                login.BringToFront();
                login.Focus();
                login.TopMost = false;

            }
            Dnlbtn.ImageIndex = 0;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.TopMost = true;
            this.BringToFront();
            this.Focus();
            this.TopMost = false;
            
        }

        private void Dnlbtn_MouseHover(object sender, EventArgs e)
        {
           Dnlbtn.ImageIndex = 1;
        }

        private void Dnlbtn_MouseDown(object sender, MouseEventArgs e)
        {
            Dnlbtn.ImageIndex = 2;
        }
 
        private void Dnlbtn_MouseUp(object sender, MouseEventArgs e)
        {
            Dnlbtn.ImageIndex = 0;
        }

        private void Dnlbtn_MouseLeave(object sender, EventArgs e)
        {
            Dnlbtn.ImageIndex = 0;
        }

        private void Dnlbtn_MouseMove(object sender, MouseEventArgs e)
        {
            Dnlbtn.ImageIndex = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Process[] prs = Process.GetProcesses();


            foreach (Process pr in prs)
            {
                if (pr.ProcessName == "node")
                {

                    pr.Kill();

                }
            }
        }

        private void Minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void Dragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
                    
        }

        private void Dragpanel_MouseDown(object sender, MouseEventArgs e)
        {

            this.ActiveControl = null;
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Dragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Titlelabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }

        }

        private void Titlelabel_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Titlelabel_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Titlelabel_MouseDown_1(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Titlelabel_MouseUp_1(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Titlelabel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }


        private void Musicbtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=EuQLMXyGQOE");
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("main.js");
            lines[23] = string.Format("USERNAME = \"USERNAME\"");
            lines[25] = string.Format("PASSWORD = \"PASSWORD\"");
            File.WriteAllLines("main.js", lines);
            this.Hide();
            Login login = new Login();
            login.RefToForm1 = this;
            this.Visible = false;
            login.ShowDialog();
            login.TopMost = true;
            login.BringToFront();
            login.Focus();
            login.TopMost = false;
        }

        private void Logoutbtn_MouseDown(object sender, MouseEventArgs e)
        {
            Logoutbtn.ImageIndex = 2;
        }

        private void Logoutbtn_MouseLeave(object sender, EventArgs e)
        {
            Logoutbtn.ImageIndex = 0;
        }

        private void Logoutbtn_MouseMove(object sender, MouseEventArgs e)
        {
            Logoutbtn.ImageIndex = 1;
        }

        private void Logoutbtn_MouseUp(object sender, MouseEventArgs e)
        {
            Logoutbtn.ImageIndex = 0;
        }

        private void Helpbtn_MouseDown(object sender, MouseEventArgs e)
        {
            Helpbtn.ImageIndex = 2;
        }

        private void Helpbtn_MouseLeave(object sender, EventArgs e)
        {
            Helpbtn.ImageIndex = 0;
        }

        private void Helpbtn_MouseMove(object sender, MouseEventArgs e)
        {
            Helpbtn.ImageIndex = 1;
        }

        private void Helpbtn_MouseUp(object sender, MouseEventArgs e)
        {
            Helpbtn.ImageIndex = 0;
        }

        private void Credits_Click(object sender, EventArgs e)
        {

        }
    }
}
