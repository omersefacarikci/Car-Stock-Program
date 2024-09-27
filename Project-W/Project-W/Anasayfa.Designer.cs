namespace Project_W
{
    partial class Anasayfa
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            siderbar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menubutonu = new PictureBox();
            panel2 = new Panel();
            buttonhome = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            button1 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            hometimer = new System.Windows.Forms.Timer(components);
            panel6 = new Panel();
            guna2ControlBox6 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox5 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            siderbar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutonu).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siderbar
            // 
            siderbar.BackColor = Color.Transparent;
            siderbar.Controls.Add(panel1);
            siderbar.Controls.Add(panel2);
            siderbar.Controls.Add(panel4);
            siderbar.Controls.Add(panel5);
            siderbar.Controls.Add(panel3);
            siderbar.Controls.Add(panel7);
            siderbar.Controls.Add(panel8);
            siderbar.Dock = DockStyle.Left;
            siderbar.Location = new Point(0, 0);
            siderbar.MaximumSize = new Size(250, 607);
            siderbar.MinimumSize = new Size(46, 607);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(250, 607);
            siderbar.TabIndex = 0;
            siderbar.Paint += siderbar_Paint_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubutonu);
            panel1.ForeColor = Color.RosyBrown;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 42);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Menü";
            // 
            // menubutonu
            // 
            menubutonu.BackColor = Color.Transparent;
            menubutonu.Cursor = Cursors.Hand;
            menubutonu.Image = Properties.Resources._3547976_200;
            menubutonu.Location = new Point(0, 2);
            menubutonu.Name = "menubutonu";
            menubutonu.Size = new Size(45, 40);
            menubutonu.SizeMode = PictureBoxSizeMode.Zoom;
            menubutonu.TabIndex = 1;
            menubutonu.TabStop = false;
            menubutonu.Click += menubutonu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonhome);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 55);
            panel2.TabIndex = 1;
            // 
            // buttonhome
            // 
            buttonhome.BackColor = Color.OrangeRed;
            buttonhome.FlatStyle = FlatStyle.Flat;
            buttonhome.ForeColor = Color.Black;
            buttonhome.Image = Properties.Resources.racing;
            buttonhome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonhome.Location = new Point(-19, -8);
            buttonhome.Name = "buttonhome";
            buttonhome.Padding = new Padding(18, 0, 0, 0);
            buttonhome.Size = new Size(284, 70);
            buttonhome.TabIndex = 2;
            buttonhome.Text = "                      Arabalar";
            buttonhome.TextAlign = ContentAlignment.MiddleLeft;
            buttonhome.UseVisualStyleBackColor = false;
            buttonhome.Click += buttonhome_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(3, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 55);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Image = Properties.Resources.save;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-30, -10);
            button3.Name = "button3";
            button3.Padding = new Padding(28, 0, 0, 0);
            button3.Size = new Size(284, 71);
            button3.TabIndex = 2;
            button3.Text = "                     Araba Kaydı";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(3, 173);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 55);
            panel5.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.info_6319149;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-28, -11);
            button4.Name = "button4";
            button4.Padding = new Padding(28, 0, 0, 0);
            button4.Size = new Size(284, 77);
            button4.TabIndex = 2;
            button4.Text = "                     Hakkımızda";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(3, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 55);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.chat;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-28, -11);
            button2.Name = "button2";
            button2.Padding = new Padding(28, 0, 0, 0);
            button2.Size = new Size(284, 77);
            button2.TabIndex = 2;
            button2.Text = "                     İletişim";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(3, 295);
            panel7.Name = "panel7";
            panel7.Size = new Size(241, 0);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Controls.Add(button1);
            panel8.ForeColor = Color.White;
            panel8.Location = new Point(3, 301);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 55);
            panel8.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.setting;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-19, -8);
            button1.Name = "button1";
            button1.Padding = new Padding(18, 0, 0, 0);
            button1.Size = new Size(284, 70);
            button1.TabIndex = 2;
            button1.Text = "                      Ayarlar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // hometimer
            // 
            hometimer.Interval = 10;
            hometimer.Tick += hometimer_Tick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(guna2ControlBox6);
            panel6.Controls.Add(guna2ControlBox5);
            panel6.Controls.Add(guna2ControlBox4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(250, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1670, 45);
            panel6.TabIndex = 2;
            // 
            // guna2ControlBox6
            // 
            guna2ControlBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox6.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBox6.CustomizableEdges = customizableEdges1;
            guna2ControlBox6.FillColor = Color.OrangeRed;
            guna2ControlBox6.IconColor = Color.White;
            guna2ControlBox6.Location = new Point(1558, 0);
            guna2ControlBox6.Name = "guna2ControlBox6";
            guna2ControlBox6.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox6.Size = new Size(56, 45);
            guna2ControlBox6.TabIndex = 2;
            // 
            // guna2ControlBox5
            // 
            guna2ControlBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox5.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox5.CustomizableEdges = customizableEdges3;
            guna2ControlBox5.FillColor = Color.OrangeRed;
            guna2ControlBox5.IconColor = Color.White;
            guna2ControlBox5.Location = new Point(1502, 0);
            guna2ControlBox5.Name = "guna2ControlBox5";
            guna2ControlBox5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox5.Size = new Size(56, 45);
            guna2ControlBox5.TabIndex = 1;
            // 
            // guna2ControlBox4
            // 
            guna2ControlBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox4.BackColor = Color.YellowGreen;
            guna2ControlBox4.CustomizableEdges = customizableEdges5;
            guna2ControlBox4.FillColor = Color.OrangeRed;
            guna2ControlBox4.IconColor = Color.White;
            guna2ControlBox4.Location = new Point(1614, 0);
            guna2ControlBox4.Name = "guna2ControlBox4";
            guna2ControlBox4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox4.Size = new Size(56, 45);
            guna2ControlBox4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.lamborghini_urus_se_3840x2160_16588;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(250, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1670, 1035);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Perpetua", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(1747, 45);
            label2.Name = "label2";
            label2.Size = new Size(173, 21);
            label2.TabIndex = 0;
            label2.Text = "Lamborghini Urus SE Süper";
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(siderbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            WindowState = FormWindowState.Maximized;
            siderbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutonu).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel siderbar;
        private Panel panel1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Label label1;
        private PictureBox menubutonu;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Timer hometimer;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Label label2;
        private Panel panel2;
        private Button buttonhome;
        private Panel panel8;
        private Button button1;
        public PictureBox pictureBox1;
    }
}