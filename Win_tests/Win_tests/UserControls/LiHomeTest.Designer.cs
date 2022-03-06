
namespace Win_tests.UserControls
{
    partial class LiHomeTest
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.testName = new System.Windows.Forms.Label();
            this.testDescription = new System.Windows.Forms.Label();
            this.wallDescription = new System.Windows.Forms.Label();
            this.panelTest = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelGroup.SuspendLayout();
            this.panelTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupName.Location = new System.Drawing.Point(50, 2);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(98, 21);
            this.groupName.TabIndex = 0;
            this.groupName.Text = "groupName";
            this.groupName.Click += new System.EventHandler(this.groupName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_tests.Properties.Resources.group_default;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullName.Location = new System.Drawing.Point(52, 25);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(60, 17);
            this.fullName.TabIndex = 2;
            this.fullName.Text = "fullName";
            this.fullName.Click += new System.EventHandler(this.fullName_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Win_tests.Properties.Resources.test_default;
            this.pictureBox2.Location = new System.Drawing.Point(5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelGroup.Controls.Add(this.pictureBox1);
            this.panelGroup.Controls.Add(this.groupName);
            this.panelGroup.Controls.Add(this.fullName);
            this.panelGroup.Location = new System.Drawing.Point(0, -1);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(415, 49);
            this.panelGroup.TabIndex = 4;
            this.panelGroup.Click += new System.EventHandler(this.panelGroup_Click);
            this.panelGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGroup_Paint);
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testName.Location = new System.Drawing.Point(78, 21);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(109, 30);
            this.testName.TabIndex = 5;
            this.testName.Text = "testName";
            this.testName.Click += new System.EventHandler(this.testName_Click);
            // 
            // testDescription
            // 
            this.testDescription.AutoSize = true;
            this.testDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testDescription.Location = new System.Drawing.Point(81, 51);
            this.testDescription.Name = "testDescription";
            this.testDescription.Size = new System.Drawing.Size(95, 17);
            this.testDescription.TabIndex = 6;
            this.testDescription.Text = "testDescription";
            this.testDescription.Click += new System.EventHandler(this.testDescription_Click);
            // 
            // wallDescription
            // 
            this.wallDescription.AutoSize = true;
            this.wallDescription.Location = new System.Drawing.Point(81, 6);
            this.wallDescription.Name = "wallDescription";
            this.wallDescription.Size = new System.Drawing.Size(88, 15);
            this.wallDescription.TabIndex = 7;
            this.wallDescription.Text = "wallDescription";
            this.wallDescription.Click += new System.EventHandler(this.wallDescription_Click);
            // 
            // panelTest
            // 
            this.panelTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTest.Controls.Add(this.pictureBox2);
            this.panelTest.Controls.Add(this.wallDescription);
            this.panelTest.Controls.Add(this.testName);
            this.panelTest.Controls.Add(this.testDescription);
            this.panelTest.Location = new System.Drawing.Point(0, 48);
            this.panelTest.Margin = new System.Windows.Forms.Padding(0);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(415, 79);
            this.panelTest.TabIndex = 8;
            this.panelTest.Click += new System.EventHandler(this.panelTest_Click);
            this.panelTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTest_MouseClick);
            // 
            // LiHomeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.panelGroup);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LiHomeTest";
            this.Size = new System.Drawing.Size(415, 126);
            this.Load += new System.EventHandler(this.LiHomeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label groupName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Label testName;
        private System.Windows.Forms.Label testDescription;
        private System.Windows.Forms.Label wallDescription;
        private System.Windows.Forms.Panel panelTest;
    }
}
