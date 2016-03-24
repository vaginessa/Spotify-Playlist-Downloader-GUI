namespace Spotify_Downloader
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsrTxtbox = new System.Windows.Forms.TextBox();
            this.PssTxtbox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Loginbtnlist = new System.Windows.Forms.ImageList(this.components);
            this.exitbtn = new System.Windows.Forms.Button();
            this.Minbtn = new System.Windows.Forms.Button();
            this.Dragpanel = new System.Windows.Forms.Panel();
            this.Emptywarning = new System.Windows.Forms.Label();
            this.Dragpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsrTxtbox
            // 
            this.UsrTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.UsrTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsrTxtbox.Font = new System.Drawing.Font("Roboto Black", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.UsrTxtbox.Location = new System.Drawing.Point(123, 250);
            this.UsrTxtbox.Name = "UsrTxtbox";
            this.UsrTxtbox.Size = new System.Drawing.Size(355, 68);
            this.UsrTxtbox.TabIndex = 2;
            this.UsrTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsrTxtbox.TextChanged += new System.EventHandler(this.UsrTxtbox_TextChanged);
            // 
            // PssTxtbox
            // 
            this.PssTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.PssTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PssTxtbox.Font = new System.Drawing.Font("Roboto Black", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PssTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PssTxtbox.Location = new System.Drawing.Point(123, 339);
            this.PssTxtbox.Name = "PssTxtbox";
            this.PssTxtbox.Size = new System.Drawing.Size(355, 68);
            this.PssTxtbox.TabIndex = 3;
            this.PssTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PssTxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Loginbtn.ImageIndex = 0;
            this.Loginbtn.ImageList = this.Loginbtnlist;
            this.Loginbtn.Location = new System.Drawing.Point(526, 434);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(50, 50);
            this.Loginbtn.TabIndex = 1;
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            this.Loginbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginbtn_MouseDown_1);
            this.Loginbtn.MouseLeave += new System.EventHandler(this.Loginbtn_MouseLeave);
            this.Loginbtn.MouseHover += new System.EventHandler(this.Loginbtn_MouseHover);
            this.Loginbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Loginbtn_MouseMove);
            this.Loginbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Loginbtn_MouseUp);
            // 
            // Loginbtnlist
            // 
            this.Loginbtnlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Loginbtnlist.ImageStream")));
            this.Loginbtnlist.TransparentColor = System.Drawing.Color.Transparent;
            this.Loginbtnlist.Images.SetKeyName(0, "normal.png");
            this.Loginbtnlist.Images.SetKeyName(1, "hover.png");
            this.Loginbtnlist.Images.SetKeyName(2, "pressed.png");
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.BackgroundImage = global::Spotify_Downloader.Properties.Resources.close;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.Location = new System.Drawing.Point(571, 13);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(17, 17);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.TabStop = false;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Minbtn
            // 
            this.Minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.FlatAppearance.BorderSize = 0;
            this.Minbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.Image = global::Spotify_Downloader.Properties.Resources.minimize__3_;
            this.Minbtn.Location = new System.Drawing.Point(535, 12);
            this.Minbtn.Name = "Minbtn";
            this.Minbtn.Size = new System.Drawing.Size(17, 17);
            this.Minbtn.TabIndex = 0;
            this.Minbtn.TabStop = false;
            this.Minbtn.UseVisualStyleBackColor = false;
            this.Minbtn.Click += new System.EventHandler(this.Minbtn_Click);
            // 
            // Dragpanel
            // 
            this.Dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dragpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dragpanel.Controls.Add(this.exitbtn);
            this.Dragpanel.Location = new System.Drawing.Point(0, -1);
            this.Dragpanel.Name = "Dragpanel";
            this.Dragpanel.Size = new System.Drawing.Size(602, 224);
            this.Dragpanel.TabIndex = 4;
            this.Dragpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Dragpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragpanel_MouseDown);
            this.Dragpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dragpanel_MouseMove);
            this.Dragpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dragpanel_MouseUp);
            // 
            // Emptywarning
            // 
            this.Emptywarning.AutoSize = true;
            this.Emptywarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Emptywarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emptywarning.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emptywarning.Location = new System.Drawing.Point(155, 448);
            this.Emptywarning.Name = "Emptywarning";
            this.Emptywarning.Size = new System.Drawing.Size(295, 20);
            this.Emptywarning.TabIndex = 5;
            this.Emptywarning.Text = "You must enter your Username/Password!";
            this.Emptywarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Emptywarning.Visible = false;
            this.Emptywarning.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.Emptywarning);
            this.Controls.Add(this.Minbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PssTxtbox);
            this.Controls.Add(this.UsrTxtbox);
            this.Controls.Add(this.Dragpanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.Dragpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsrTxtbox;
        private System.Windows.Forms.TextBox PssTxtbox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button Minbtn;
        private System.Windows.Forms.Panel Dragpanel;
        private System.Windows.Forms.Label Emptywarning;
        private System.Windows.Forms.ImageList Loginbtnlist;
    }
}