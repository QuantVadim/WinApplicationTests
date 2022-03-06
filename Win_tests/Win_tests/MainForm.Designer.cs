
namespace Win_tests
{
    partial class MainForm
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
            this.Nav_Home = new System.Windows.Forms.Button();
            this.Navbar = new System.Windows.Forms.FlowLayoutPanel();
            this.Nav_Tests = new System.Windows.Forms.Button();
            this.Nav_Results = new System.Windows.Forms.Button();
            this.Nav_Groups = new System.Windows.Forms.Button();
            this.Nav_Users = new System.Windows.Forms.Button();
            this.Nav_Classes = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PageName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Navbar.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nav_Home
            // 
            this.Nav_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nav_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nav_Home.FlatAppearance.BorderSize = 0;
            this.Nav_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nav_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nav_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nav_Home.Image = global::Win_tests.Properties.Resources.nb_home_40;
            this.Nav_Home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nav_Home.Location = new System.Drawing.Point(3, 3);
            this.Nav_Home.Name = "Nav_Home";
            this.Nav_Home.Size = new System.Drawing.Size(66, 60);
            this.Nav_Home.TabIndex = 1;
            this.Nav_Home.Text = "Главная";
            this.Nav_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nav_Home.UseVisualStyleBackColor = false;
            this.Nav_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Navbar
            // 
            this.Navbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Navbar.Controls.Add(this.Nav_Home);
            this.Navbar.Controls.Add(this.Nav_Tests);
            this.Navbar.Controls.Add(this.Nav_Results);
            this.Navbar.Controls.Add(this.Nav_Groups);
            this.Navbar.Controls.Add(this.Nav_Users);
            this.Navbar.Controls.Add(this.Nav_Classes);
            this.Navbar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Navbar.Location = new System.Drawing.Point(-3, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(70, 443);
            this.Navbar.TabIndex = 2;
            this.Navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.Navbar_Paint);
            // 
            // Nav_Tests
            // 
            this.Nav_Tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav_Tests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nav_Tests.FlatAppearance.BorderSize = 0;
            this.Nav_Tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nav_Tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nav_Tests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nav_Tests.Image = global::Win_tests.Properties.Resources.nb_tests_40;
            this.Nav_Tests.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nav_Tests.Location = new System.Drawing.Point(3, 69);
            this.Nav_Tests.Name = "Nav_Tests";
            this.Nav_Tests.Size = new System.Drawing.Size(66, 60);
            this.Nav_Tests.TabIndex = 2;
            this.Nav_Tests.Text = "Тесты";
            this.Nav_Tests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nav_Tests.UseVisualStyleBackColor = false;
            this.Nav_Tests.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nav_Results
            // 
            this.Nav_Results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav_Results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nav_Results.FlatAppearance.BorderSize = 0;
            this.Nav_Results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nav_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nav_Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nav_Results.Image = global::Win_tests.Properties.Resources.nb_results_40;
            this.Nav_Results.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nav_Results.Location = new System.Drawing.Point(3, 135);
            this.Nav_Results.Name = "Nav_Results";
            this.Nav_Results.Size = new System.Drawing.Size(66, 60);
            this.Nav_Results.TabIndex = 3;
            this.Nav_Results.Text = "Решения";
            this.Nav_Results.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nav_Results.UseVisualStyleBackColor = false;
            this.Nav_Results.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nav_Groups
            // 
            this.Nav_Groups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav_Groups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nav_Groups.FlatAppearance.BorderSize = 0;
            this.Nav_Groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nav_Groups.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nav_Groups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nav_Groups.Image = global::Win_tests.Properties.Resources.nb_groups_40;
            this.Nav_Groups.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nav_Groups.Location = new System.Drawing.Point(3, 201);
            this.Nav_Groups.Name = "Nav_Groups";
            this.Nav_Groups.Size = new System.Drawing.Size(66, 60);
            this.Nav_Groups.TabIndex = 4;
            this.Nav_Groups.Text = "Группы";
            this.Nav_Groups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nav_Groups.UseVisualStyleBackColor = false;
            this.Nav_Groups.Click += new System.EventHandler(this.button4_Click);
            // 
            // Nav_Users
            // 
            this.Nav_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav_Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nav_Users.FlatAppearance.BorderSize = 0;
            this.Nav_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nav_Users.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nav_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nav_Users.Image = global::Win_tests.Properties.Resources.nb_users_40;
            this.Nav_Users.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nav_Users.Location = new System.Drawing.Point(3, 267);
            this.Nav_Users.Name = "Nav_Users";
            this.Nav_Users.Size = new System.Drawing.Size(66, 60);
            this.Nav_Users.TabIndex = 5;
            this.Nav_Users.Text = "Люди";
            this.Nav_Users.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nav_Users.UseVisualStyleBackColor = false;
            this.Nav_Users.Click += new System.EventHandler(this.Nav_Users_Click);
            // 
            // Nav_Classes
            // 
            this.Nav_Classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav_Classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nav_Classes.FlatAppearance.BorderSize = 0;
            this.Nav_Classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nav_Classes.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nav_Classes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nav_Classes.Image = global::Win_tests.Properties.Resources.nb_class_40;
            this.Nav_Classes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nav_Classes.Location = new System.Drawing.Point(3, 333);
            this.Nav_Classes.Name = "Nav_Classes";
            this.Nav_Classes.Size = new System.Drawing.Size(66, 60);
            this.Nav_Classes.TabIndex = 6;
            this.Nav_Classes.Text = "Классы";
            this.Nav_Classes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nav_Classes.UseVisualStyleBackColor = false;
            this.Nav_Classes.Click += new System.EventHandler(this.Nav_Classes_Click);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.Color.DimGray;
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.label1);
            this.content.Location = new System.Drawing.Point(67, 32);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(754, 481);
            this.content.TabIndex = 3;
            this.content.Resize += new System.EventHandler(this.content_Resize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6);
            this.label2.Size = new System.Drawing.Size(190, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите раздел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(373, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // PageName
            // 
            this.PageName.AutoSize = true;
            this.PageName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageName.ForeColor = System.Drawing.SystemColors.Info;
            this.PageName.Location = new System.Drawing.Point(70, -3);
            this.PageName.Name = "PageName";
            this.PageName.Size = new System.Drawing.Size(254, 32);
            this.PageName.TabIndex = 0;
            this.PageName.Text = "Страртовая страница";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Win_tests.Properties.Resources.user_edit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(793, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // user_name
            // 
            this.user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_name.ForeColor = System.Drawing.SystemColors.Info;
            this.user_name.Location = new System.Drawing.Point(487, 4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(303, 23);
            this.user_name.TabIndex = 5;
            this.user_name.Text = "user_name";
            this.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.user_name.Click += new System.EventHandler(this.user_name_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 71);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = global::Win_tests.Properties.Resources.about_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "О программе";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.PageName);
            this.MinimumSize = new System.Drawing.Size(836, 548);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Navbar.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Nav_Home;
        private System.Windows.Forms.FlowLayoutPanel Navbar;
        private System.Windows.Forms.Button Nav_Tests;
        private System.Windows.Forms.Button Nav_Results;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button Nav_Groups;
        private System.Windows.Forms.Button Nav_Users;
        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nav_Classes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}