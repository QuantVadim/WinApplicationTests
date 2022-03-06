
namespace Win_tests.Wins
{
    partial class Testing
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
            this.testName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sendTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testName.ForeColor = System.Drawing.SystemColors.Info;
            this.testName.Location = new System.Drawing.Point(52, 4);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(96, 25);
            this.testName.TabIndex = 0;
            this.testName.Text = "testName";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.ForeColor = System.Drawing.SystemColors.Info;
            this.description.Location = new System.Drawing.Point(52, 29);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(66, 15);
            this.description.TabIndex = 0;
            this.description.Text = "description";
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.AutoScroll = true;
            this.content.BackColor = System.Drawing.Color.DarkGray;
            this.content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content.Location = new System.Drawing.Point(0, 52);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(680, 443);
            this.content.TabIndex = 1;
            this.content.WrapContents = false;
            // 
            // btn_sendTest
            // 
            this.btn_sendTest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sendTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sendTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sendTest.Location = new System.Drawing.Point(584, 8);
            this.btn_sendTest.Name = "btn_sendTest";
            this.btn_sendTest.Size = new System.Drawing.Size(89, 34);
            this.btn_sendTest.TabIndex = 2;
            this.btn_sendTest.Text = "Завершить";
            this.btn_sendTest.UseVisualStyleBackColor = true;
            this.btn_sendTest.Click += new System.EventHandler(this.btn_sendTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_tests.Properties.Resources.test_default;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(680, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sendTest);
            this.Controls.Add(this.content);
            this.Controls.Add(this.description);
            this.Controls.Add(this.testName);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Testing";
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.Testing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testName;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.FlowLayoutPanel content;
        private System.Windows.Forms.Button btn_sendTest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}