namespace Spotify_Downloader
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
            this.Helpbtn = new System.Windows.Forms.Button();
            this.HelpImageList = new System.Windows.Forms.ImageList(this.components);
            this.ListTextBox1 = new System.Windows.Forms.TextBox();
            this.DnlImageList = new System.Windows.Forms.ImageList(this.components);
            this.Checkboxformat = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ListTextBox2 = new System.Windows.Forms.TextBox();
            this.ListTextBox3 = new System.Windows.Forms.TextBox();
            this.ListTextBox4 = new System.Windows.Forms.TextBox();
            this.ListTextBox5 = new System.Windows.Forms.TextBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Prgslabel = new System.Windows.Forms.Label();
            this.Playlistlabel = new System.Windows.Forms.Label();
            this.Dragpanel = new System.Windows.Forms.Panel();
            this.Minbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.LgoutImageList = new System.Windows.Forms.ImageList(this.components);
            this.Musicbtn = new System.Windows.Forms.Button();
            this.Dnlbtn = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Label();
            this.Dragpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Helpbtn
            // 
            this.Helpbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Helpbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Helpbtn.FlatAppearance.BorderSize = 0;
            this.Helpbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Helpbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Helpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helpbtn.ImageIndex = 0;
            this.Helpbtn.ImageList = this.HelpImageList;
            this.Helpbtn.Location = new System.Drawing.Point(167, 112);
            this.Helpbtn.Name = "Helpbtn";
            this.Helpbtn.Size = new System.Drawing.Size(20, 20);
            this.Helpbtn.TabIndex = 8;
            this.Helpbtn.UseVisualStyleBackColor = false;
            this.Helpbtn.Click += new System.EventHandler(this.Helpbtn_Click);
            this.Helpbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Helpbtn_MouseDown);
            this.Helpbtn.MouseLeave += new System.EventHandler(this.Helpbtn_MouseLeave);
            this.Helpbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Helpbtn_MouseMove);
            this.Helpbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Helpbtn_MouseUp);
            // 
            // HelpImageList
            // 
            this.HelpImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("HelpImageList.ImageStream")));
            this.HelpImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.HelpImageList.Images.SetKeyName(0, "hnormal.png");
            this.HelpImageList.Images.SetKeyName(1, "hhover.png");
            this.HelpImageList.Images.SetKeyName(2, "hpressed.png");
            // 
            // ListTextBox1
            // 
            this.ListTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ListTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ListTextBox1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ListTextBox1.Location = new System.Drawing.Point(73, 136);
            this.ListTextBox1.Name = "ListTextBox1";
            this.ListTextBox1.Size = new System.Drawing.Size(222, 28);
            this.ListTextBox1.TabIndex = 0;
            this.ListTextBox1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // DnlImageList
            // 
            this.DnlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DnlImageList.ImageStream")));
            this.DnlImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DnlImageList.Images.SetKeyName(0, "dnormal.png");
            this.DnlImageList.Images.SetKeyName(1, "dhover.png");
            this.DnlImageList.Images.SetKeyName(2, "dpressed.png");
            // 
            // Checkboxformat
            // 
            this.Checkboxformat.AutoSize = true;
            this.Checkboxformat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Checkboxformat.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkboxformat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Checkboxformat.Location = new System.Drawing.Point(438, 217);
            this.Checkboxformat.Name = "Checkboxformat";
            this.Checkboxformat.Size = new System.Drawing.Size(114, 34);
            this.Checkboxformat.TabIndex = 5;
            this.Checkboxformat.Text = "Download playlist\r\nto single folder";
            this.Checkboxformat.UseVisualStyleBackColor = false;
            this.Checkboxformat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.richTextBox1.Location = new System.Drawing.Point(73, 308);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(479, 127);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ListTextBox2
            // 
            this.ListTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ListTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTextBox2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ListTextBox2.Location = new System.Drawing.Point(330, 136);
            this.ListTextBox2.Name = "ListTextBox2";
            this.ListTextBox2.Size = new System.Drawing.Size(222, 28);
            this.ListTextBox2.TabIndex = 1;
            this.ListTextBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // ListTextBox3
            // 
            this.ListTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ListTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTextBox3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ListTextBox3.Location = new System.Drawing.Point(73, 178);
            this.ListTextBox3.Name = "ListTextBox3";
            this.ListTextBox3.Size = new System.Drawing.Size(222, 28);
            this.ListTextBox3.TabIndex = 2;
            this.ListTextBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ListTextBox4
            // 
            this.ListTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ListTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTextBox4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ListTextBox4.Location = new System.Drawing.Point(330, 178);
            this.ListTextBox4.Name = "ListTextBox4";
            this.ListTextBox4.Size = new System.Drawing.Size(222, 28);
            this.ListTextBox4.TabIndex = 3;
            this.ListTextBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_2);
            // 
            // ListTextBox5
            // 
            this.ListTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ListTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTextBox5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ListTextBox5.Location = new System.Drawing.Point(73, 219);
            this.ListTextBox5.Name = "ListTextBox5";
            this.ListTextBox5.Size = new System.Drawing.Size(222, 28);
            this.ListTextBox5.TabIndex = 4;
            this.ListTextBox5.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titlelabel.Font = new System.Drawing.Font("Roboto", 16F);
            this.Titlelabel.ForeColor = System.Drawing.Color.White;
            this.Titlelabel.Location = new System.Drawing.Point(72, 53);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(292, 29);
            this.Titlelabel.TabIndex = 37;
            this.Titlelabel.Text = "Spotify Playlist Downloader";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titlelabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlelabel_MouseDown_1);
            this.Titlelabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titlelabel_MouseMove_1);
            this.Titlelabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titlelabel_MouseUp_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "1.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Roboto", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(49, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "3.";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label6.Location = new System.Drawing.Point(49, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "5.";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label7.Location = new System.Drawing.Point(306, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "2.";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Roboto", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label8.Location = new System.Drawing.Point(306, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "4.";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // Prgslabel
            // 
            this.Prgslabel.AutoSize = true;
            this.Prgslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Prgslabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prgslabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.Prgslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Prgslabel.Location = new System.Drawing.Point(69, 284);
            this.Prgslabel.Name = "Prgslabel";
            this.Prgslabel.Size = new System.Drawing.Size(72, 21);
            this.Prgslabel.TabIndex = 37;
            this.Prgslabel.Text = "Progress";
            this.Prgslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Playlistlabel
            // 
            this.Playlistlabel.AutoSize = true;
            this.Playlistlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Playlistlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playlistlabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.Playlistlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Playlistlabel.Location = new System.Drawing.Point(69, 112);
            this.Playlistlabel.Name = "Playlistlabel";
            this.Playlistlabel.Size = new System.Drawing.Size(98, 21);
            this.Playlistlabel.TabIndex = 37;
            this.Playlistlabel.Text = "Playlist URL";
            this.Playlistlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dragpanel
            // 
            this.Dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dragpanel.Controls.Add(this.Minbtn);
            this.Dragpanel.Controls.Add(this.Exitbtn);
            this.Dragpanel.Controls.Add(this.Logoutbtn);
            this.Dragpanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Dragpanel.Location = new System.Drawing.Point(0, 0);
            this.Dragpanel.Name = "Dragpanel";
            this.Dragpanel.Size = new System.Drawing.Size(602, 109);
            this.Dragpanel.TabIndex = 39;
            this.Dragpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Dragpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragpanel_MouseDown);
            this.Dragpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dragpanel_MouseMove);
            this.Dragpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dragpanel_MouseUp);
            // 
            // Minbtn
            // 
            this.Minbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.FlatAppearance.BorderSize = 0;
            this.Minbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minbtn.Image = global::Spotify_Downloader.Properties.Resources.minimize__3_;
            this.Minbtn.Location = new System.Drawing.Point(535, 12);
            this.Minbtn.Name = "Minbtn";
            this.Minbtn.Size = new System.Drawing.Size(17, 17);
            this.Minbtn.TabIndex = 99;
            this.Minbtn.TabStop = false;
            this.Minbtn.UseVisualStyleBackColor = true;
            this.Minbtn.Click += new System.EventHandler(this.Minbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackgroundImage = global::Spotify_Downloader.Properties.Resources.close;
            this.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exitbtn.FlatAppearance.BorderSize = 0;
            this.Exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Location = new System.Drawing.Point(571, 12);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(17, 17);
            this.Exitbtn.TabIndex = 99;
            this.Exitbtn.TabStop = false;
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logoutbtn.ImageIndex = 0;
            this.Logoutbtn.ImageList = this.LgoutImageList;
            this.Logoutbtn.Location = new System.Drawing.Point(438, 45);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(150, 50);
            this.Logoutbtn.TabIndex = 7;
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            this.Logoutbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logoutbtn_MouseDown);
            this.Logoutbtn.MouseLeave += new System.EventHandler(this.Logoutbtn_MouseLeave);
            this.Logoutbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logoutbtn_MouseMove);
            this.Logoutbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Logoutbtn_MouseUp);
            // 
            // LgoutImageList
            // 
            this.LgoutImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LgoutImageList.ImageStream")));
            this.LgoutImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LgoutImageList.Images.SetKeyName(0, "outnormal.png");
            this.LgoutImageList.Images.SetKeyName(1, "outhover.png");
            this.LgoutImageList.Images.SetKeyName(2, "outpressed.png");
            // 
            // Musicbtn
            // 
            this.Musicbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Musicbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Musicbtn.FlatAppearance.BorderSize = 0;
            this.Musicbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Musicbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Musicbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Musicbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Musicbtn.Location = new System.Drawing.Point(21, 82);
            this.Musicbtn.Name = "Musicbtn";
            this.Musicbtn.Size = new System.Drawing.Size(46, 46);
            this.Musicbtn.TabIndex = 41;
            this.Musicbtn.TabStop = false;
            this.Musicbtn.UseVisualStyleBackColor = false;
            this.Musicbtn.Click += new System.EventHandler(this.Musicbtn_Click);
            // 
            // Dnlbtn
            // 
            this.Dnlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dnlbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dnlbtn.FlatAppearance.BorderSize = 0;
            this.Dnlbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dnlbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dnlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dnlbtn.ForeColor = System.Drawing.Color.Black;
            this.Dnlbtn.ImageIndex = 0;
            this.Dnlbtn.ImageList = this.DnlImageList;
            this.Dnlbtn.Location = new System.Drawing.Point(330, 217);
            this.Dnlbtn.Name = "Dnlbtn";
            this.Dnlbtn.Size = new System.Drawing.Size(102, 30);
            this.Dnlbtn.TabIndex = 6;
            this.Dnlbtn.UseVisualStyleBackColor = false;
            this.Dnlbtn.Click += new System.EventHandler(this.Dnlbtn_Click);
            this.Dnlbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dnlbtn_MouseDown);
            this.Dnlbtn.MouseLeave += new System.EventHandler(this.Dnlbtn_MouseLeave);
            this.Dnlbtn.MouseHover += new System.EventHandler(this.Dnlbtn_MouseHover);
            this.Dnlbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dnlbtn_MouseMove);
            this.Dnlbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dnlbtn_MouseUp);
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Credits.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Credits.Location = new System.Drawing.Point(183, 473);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(258, 18);
            this.Credits.TabIndex = 42;
            this.Credits.Text = "GUI V2 By Dekiller82. Designed by PixelLab.";
            this.Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Musicbtn);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Helpbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Playlistlabel);
            this.Controls.Add(this.Prgslabel);
            this.Controls.Add(this.ListTextBox5);
            this.Controls.Add(this.ListTextBox4);
            this.Controls.Add(this.ListTextBox3);
            this.Controls.Add(this.ListTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Checkboxformat);
            this.Controls.Add(this.Dnlbtn);
            this.Controls.Add(this.ListTextBox1);
            this.Controls.Add(this.Dragpanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Dragpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Helpbtn;
        private System.Windows.Forms.TextBox ListTextBox1;
        private System.Windows.Forms.CheckBox Checkboxformat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ListTextBox2;
        private System.Windows.Forms.TextBox ListTextBox3;
        private System.Windows.Forms.TextBox ListTextBox4;
        private System.Windows.Forms.TextBox ListTextBox5;
        private System.Windows.Forms.ImageList DnlImageList;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Prgslabel;
        private System.Windows.Forms.Label Playlistlabel;
        private System.Windows.Forms.Panel Dragpanel;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Minbtn;
        private System.Windows.Forms.Button Musicbtn;
        private System.Windows.Forms.Button Dnlbtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.ImageList LgoutImageList;
        private System.Windows.Forms.ImageList HelpImageList;
        private System.Windows.Forms.Label Credits;
    }
}

