using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Spotify_Downloader
{
   

    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }


        public Login()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            byte[] fontData = Properties.Resources.Roboto_Black;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Roboto_Black.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Roboto_Black.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 38.0F);
            



            this.Activate();
            this.Focus();
            UsrTxtbox.ForeColor = Color.FromArgb(90, 90, 90);
            UsrTxtbox.Text = "USERNAME";
            this.UsrTxtbox.Leave += new System.EventHandler(this.UsrTxtbox_Leave);
            this.UsrTxtbox.Enter += new System.EventHandler(this.UsrTxtbox_Enter);


            PssTxtbox.PasswordChar = (char)0;
            PssTxtbox.ForeColor = Color.FromArgb(90, 90, 90);
            PssTxtbox.Text = "PASSWORD";
            this.PssTxtbox.Leave += new System.EventHandler(this.PssTxtbox_Leave);
            this.PssTxtbox.Enter += new System.EventHandler(this.PssTxtbox_Enter);
        }

        private void UsrTxtbox_Enter(object sender, EventArgs e)
        {
            if (UsrTxtbox.Text.Contains("USERNAME") == true)
            {
                UsrTxtbox.Clear();
            }
            UsrTxtbox.ForeColor = Color.FromArgb(224, 242, 241);
        }

        private void PssTxtbox_Enter(object sender, EventArgs e)
        {
            if (PssTxtbox.Text.Contains("PASSWORD") == true)
            {
                PssTxtbox.Clear();
            }
            PssTxtbox.PasswordChar = '●';
            PssTxtbox.ForeColor = Color.FromArgb(224, 242, 241);
        }

        private void UsrTxtbox_Leave(object sender, EventArgs e)
        {
            if (UsrTxtbox.Text == "")
            {
                UsrTxtbox.Text = "USERNAME";
                UsrTxtbox.ForeColor = Color.FromArgb(90, 90, 90);
            }
        }

        private void PssTxtbox_Leave(object sender, EventArgs e)
        {
            if (PssTxtbox.Text == "")
            {
                PssTxtbox.PasswordChar = (char)0;
                PssTxtbox.Text = "PASSWORD";
                PssTxtbox.ForeColor = Color.FromArgb(90, 90, 90);
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Loginbtn.ImageIndex = 2;
            if ((UsrTxtbox.Text.Contains("USERNAME") == false) & (PssTxtbox.Text.Contains("PASSWORD") == false))
            {
                string[] lines = File.ReadAllLines("main.js");
                lines[23] = string.Format("USERNAME = \"{0}\"", UsrTxtbox.Text);
                lines[25] = string.Format("PASSWORD = \"{0}\"", PssTxtbox.Text);
                File.WriteAllLines("main.js", lines);
                this.Hide();
                RefToForm1.Visible = true;
                RefToForm1.TopMost = true;
                RefToForm1.Show(); 
                RefToForm1.BringToFront();
                RefToForm1.Focus();
                RefToForm1.TopMost = false;
            }

            else
            {

                Emptywarning.Visible = true;

            }
        }

        public Form RefToForm1 { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {

            UsrTxtbox.Font = myFont;
            PssTxtbox.Font = myFont;
            Emptywarning.Font = myFont = new Font(fonts.Families[0], 11, FontStyle.Regular);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsrTxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }


        private bool dragging;
        private Point startPoint2 = new Point(0, 0);

        private void Dragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (!dragging) return;
            Point p = PointToScreen(e.Location);
            Location = new Point(p.X - startPoint2.X, p.Y - startPoint2.Y);
        
        }

        private void Dragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Dragpanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
            dragging = true;
            startPoint2 = new Point(e.X, e.Y);

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToForm1.Close();
            this.Close();

        }

        
        private void Loginbtn_MouseHover(object sender, EventArgs e)
        {
            Loginbtn.ImageIndex = 1;
        }

        private void Loginbtn_MouseLeave(object sender, EventArgs e)
        {
            Loginbtn.ImageIndex = 0;
        }

        private void Loginbtn_MouseUp(object sender, MouseEventArgs e)
        {
            Loginbtn.ImageIndex = 0;
        }

        private void Loginbtn_MouseMove(object sender, MouseEventArgs e)
        {
            Loginbtn.ImageIndex = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginbtn_MouseDown_1(object sender, MouseEventArgs e)
        {
            Loginbtn.ImageIndex = 2;
        }
    }
}
