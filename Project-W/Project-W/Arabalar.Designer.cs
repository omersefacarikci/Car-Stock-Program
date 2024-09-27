namespace Project_W
{
    partial class Arabalar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arabalar));
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            aramayap = new Guna.UI2.WinForms.Guna2TextBox();
            frmliste = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges1;
            guna2ControlBox2.FillColor = Color.OrangeRed;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(1132, -1);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox2.Size = new Size(56, 45);
            guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.OrangeRed;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1188, -1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(56, 45);
            guna2ControlBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 45);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.icons8_tire_66;
            button2.Location = new Point(0, -16);
            button2.Name = "button2";
            button2.Size = new Size(97, 101);
            button2.TabIndex = 24;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(frmliste);
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1244, 634);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(aramayap);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1244, 54);
            panel3.TabIndex = 1;
            // 
            // aramayap
            // 
            aramayap.BackColor = Color.Transparent;
            aramayap.BorderColor = Color.FromArgb(192, 64, 0);
            aramayap.BorderRadius = 20;
            aramayap.CustomizableEdges = customizableEdges5;
            aramayap.DefaultText = "";
            aramayap.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            aramayap.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            aramayap.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            aramayap.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            aramayap.FillColor = Color.OrangeRed;
            aramayap.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            aramayap.Font = new Font("Segoe UI", 9F);
            aramayap.ForeColor = Color.Black;
            aramayap.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            aramayap.IconRight = Properties.Resources.Search;
            aramayap.Location = new Point(353, 8);
            aramayap.Margin = new Padding(3, 4, 3, 4);
            aramayap.Name = "aramayap";
            aramayap.PasswordChar = '\0';
            aramayap.PlaceholderForeColor = SystemColors.ControlDarkDark;
            aramayap.PlaceholderText = "Ne aramak istiyorsunuz?";
            aramayap.SelectedText = "";
            aramayap.ShadowDecoration.CustomizableEdges = customizableEdges6;
            aramayap.Size = new Size(575, 46);
            aramayap.TabIndex = 0;
            aramayap.TextChanged += aramayap_TextChanged;
            // 
            // frmliste
            // 
            frmliste.AutoScroll = true;
            frmliste.BackColor = Color.Black;
            frmliste.Location = new Point(0, 41);
            frmliste.Name = "frmliste";
            frmliste.Size = new Size(1244, 593);
            frmliste.TabIndex = 0;
            // 
            // Arabalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1244, 679);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(guna2ControlBox1);
            Controls.Add(guna2ControlBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Arabalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arabalar";
            Load += Arabalar_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private FlowLayoutPanel frmliste;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox aramayap;
    }
}