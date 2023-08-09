namespace galnet_prototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoginButton=new Button();
            startonboot=new CheckBox();
            checkBox1=new CheckBox();
            checkBox2=new CheckBox();
            username=new TextBox();
            textBox1=new TextBox();
            statusBox=new ComboBox();
            statusStrip1=new StatusStrip();
            toolStripStatusLabel3=new ToolStripStatusLabel();
            toolStripStatusLabel1=new ToolStripStatusLabel();
            toolStripStatusLabel2=new ToolStripStatusLabel();
            toolStripStatusLabel4=new ToolStripStatusLabel();
            logo=new PictureBox();
            banner=new PictureBox();
            galaxy=new PictureBox();
            panel1=new Panel();
            label1=new Label();
            taskbarIcon=new NotifyIcon(components);
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)banner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)galaxy).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor=Color.White;
            LoginButton.BackgroundImageLayout=ImageLayout.Center;
            LoginButton.FlatStyle=FlatStyle.System;
            LoginButton.Location=new Point(36, 257);
            LoginButton.Name="LoginButton";
            LoginButton.Size=new Size(128, 23);
            LoginButton.TabIndex=0;
            LoginButton.Text="Sign In";
            LoginButton.UseVisualStyleBackColor=false;
            LoginButton.Click+=button1_Click;
            // 
            // startonboot
            // 
            startonboot.AccessibleDescription="enable this to make galaxynet";
            startonboot.AutoSize=true;
            startonboot.ForeColor=Color.FromArgb(255, 192, 255);
            startonboot.Location=new Point(36, 232);
            startonboot.Name="startonboot";
            startonboot.Size=new Size(134, 19);
            startonboot.TabIndex=6;
            startonboot.Text="Start GalNet on boot";
            startonboot.UseVisualStyleBackColor=true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.BackColor=Color.Transparent;
            checkBox1.ForeColor=Color.FromArgb(255, 192, 255);
            checkBox1.Location=new Point(36, 207);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(137, 19);
            checkBox1.TabIndex=5;
            checkBox1.Text="Sign in automatically";
            checkBox1.UseVisualStyleBackColor=false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize=true;
            checkBox2.ForeColor=Color.FromArgb(255, 192, 255);
            checkBox2.Location=new Point(36, 182);
            checkBox2.Name="checkBox2";
            checkBox2.Size=new Size(128, 19);
            checkBox2.TabIndex=4;
            checkBox2.Text="Remember my info";
            checkBox2.UseVisualStyleBackColor=true;
            // 
            // username
            // 
            username.AccessibleDescription="enter username here";
            username.AccessibleName="username";
            username.BorderStyle=BorderStyle.None;
            username.Font=new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            username.ForeColor=Color.FromArgb(64, 0, 64);
            username.Location=new Point(27, 96);
            username.Name="username";
            username.PlaceholderText="Username...";
            username.Size=new Size(146, 16);
            username.TabIndex=1;
            username.TextChanged+=username_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle=BorderStyle.None;
            textBox1.Font=new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location=new Point(27, 118);
            textBox1.Name="textBox1";
            textBox1.PasswordChar='*';
            textBox1.PlaceholderText="Password...";
            textBox1.Size=new Size(146, 16);
            textBox1.TabIndex=2;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // statusBox
            // 
            statusBox.BackColor=Color.Black;
            statusBox.DropDownStyle=ComboBoxStyle.DropDownList;
            statusBox.FlatStyle=FlatStyle.Flat;
            statusBox.Font=new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            statusBox.ForeColor=Color.White;
            statusBox.FormattingEnabled=true;
            statusBox.Items.AddRange(new object[] { "Available", "Busy", "Away", "Invisible" });
            statusBox.Location=new Point(84, 140);
            statusBox.Name="statusBox";
            statusBox.Size=new Size(91, 21);
            statusBox.TabIndex=3;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor=Color.White;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel3, toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel4 });
            statusStrip1.Location=new Point(0, 425);
            statusStrip1.Name="statusStrip1";
            statusStrip1.Size=new Size(632, 24);
            statusStrip1.TabIndex=7;
            statusStrip1.Text="statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BorderSides=ToolStripStatusLabelBorderSides.Left|ToolStripStatusLabelBorderSides.Top|ToolStripStatusLabelBorderSides.Right|ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel3.BorderStyle=Border3DStyle.Sunken;
            toolStripStatusLabel3.DisplayStyle=ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel3.ForeColor=SystemColors.GrayText;
            toolStripStatusLabel3.Name="toolStripStatusLabel3";
            toolStripStatusLabel3.Size=new Size(97, 19);
            toolStripStatusLabel3.Text="Press F1 for help";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BorderSides=ToolStripStatusLabelBorderSides.Left|ToolStripStatusLabelBorderSides.Top|ToolStripStatusLabelBorderSides.Right|ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel1.BorderStyle=Border3DStyle.Sunken;
            toolStripStatusLabel1.DisplayStyle=ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel1.Name="toolStripStatusLabel1";
            toolStripStatusLabel1.Size=new Size(104, 19);
            toolStripStatusLabel1.Text="RAM usage: 0 MB";
            toolStripStatusLabel1.Click+=toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BorderSides=ToolStripStatusLabelBorderSides.Left|ToolStripStatusLabelBorderSides.Top|ToolStripStatusLabelBorderSides.Right|ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel2.BorderStyle=Border3DStyle.Sunken;
            toolStripStatusLabel2.DisplayStyle=ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel2.Name="toolStripStatusLabel2";
            toolStripStatusLabel2.Size=new Size(155, 19);
            toolStripStatusLabel2.Text="Server status: Disconnected";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BorderSides=ToolStripStatusLabelBorderSides.Left|ToolStripStatusLabelBorderSides.Top|ToolStripStatusLabelBorderSides.Right|ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel4.BorderStyle=Border3DStyle.Sunken;
            toolStripStatusLabel4.DisplayStyle=ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel4.Name="toolStripStatusLabel4";
            toolStripStatusLabel4.Size=new Size(41, 19);
            toolStripStatusLabel4.Text="v0.0.3";
            toolStripStatusLabel4.Click+=toolStripStatusLabel4_Click;
            // 
            // logo
            // 
            logo.Anchor=AnchorStyles.Top;
            logo.BackColor=Color.Transparent;
            logo.BackgroundImage=(Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout=ImageLayout.Zoom;
            logo.Location=new Point(74, 0);
            logo.Name="logo";
            logo.Size=new Size(480, 120);
            logo.TabIndex=9;
            logo.TabStop=false;
            // 
            // banner
            // 
            banner.BackgroundImage=Properties.Resources.Client_Banner;
            banner.BackgroundImageLayout=ImageLayout.Stretch;
            banner.Dock=DockStyle.Top;
            banner.Location=new Point(0, 0);
            banner.Name="banner";
            banner.Size=new Size(632, 120);
            banner.TabIndex=10;
            banner.TabStop=false;
            // 
            // galaxy
            // 
            galaxy.BackColor=Color.Transparent;
            galaxy.BackgroundImage=Properties.Resources.Client_Banner_Galaxy;
            galaxy.BackgroundImageLayout=ImageLayout.Zoom;
            galaxy.Location=new Point(0, 0);
            galaxy.Name="galaxy";
            galaxy.Size=new Size(200, 120);
            galaxy.TabIndex=11;
            galaxy.TabStop=false;
            // 
            // panel1
            // 
            panel1.Controls.Add(statusBox);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(startonboot);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(username);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock=DockStyle.Right;
            panel1.Location=new Point(431, 120);
            panel1.Name="panel1";
            panel1.Size=new Size(201, 305);
            panel1.TabIndex=12;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Transparent;
            label1.ForeColor=SystemColors.ButtonHighlight;
            label1.Location=new Point(18, 142);
            label1.Name="label1";
            label1.Size=new Size(60, 15);
            label1.TabIndex=7;
            label1.Text="Sign in as:";
            label1.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // taskbarIcon
            // 
            taskbarIcon.Icon=(Icon)resources.GetObject("taskbarIcon.Icon");
            taskbarIcon.Text="GalaxyNet Client - Disconnected";
            taskbarIcon.Visible=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Black;
            BackgroundImageLayout=ImageLayout.Zoom;
            ClientSize=new Size(632, 449);
            Controls.Add(panel1);
            Controls.Add(logo);
            Controls.Add(galaxy);
            Controls.Add(statusStrip1);
            Controls.Add(banner);
            DoubleBuffered=true;
            HelpButton=true;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MinimumSize=new Size(320, 200);
            Name="Form1";
            Text="GalaxyNet";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)banner).EndInit();
            ((System.ComponentModel.ISupportInitialize)galaxy).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private CheckBox startonboot;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox username;
        private TextBox textBox1;
        private ComboBox statusBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox logo;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private PictureBox banner;
        private PictureBox galaxy;
        private Panel panel1;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private NotifyIcon taskbarIcon;
    }
}