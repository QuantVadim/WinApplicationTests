
namespace Win_tests.Wins
{
    partial class Result
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
            this.procent = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testName.ForeColor = System.Drawing.SystemColors.Info;
            this.testName.Location = new System.Drawing.Point(49, 3);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(103, 25);
            this.testName.TabIndex = 0;
            this.testName.Text = "testName";
            this.testName.Click += new System.EventHandler(this.testName_Click);
            // 
            // procent
            // 
            this.procent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.procent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.procent.ForeColor = System.Drawing.SystemColors.Info;
            this.procent.Location = new System.Drawing.Point(422, 7);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(88, 40);
            this.procent.TabIndex = 1;
            this.procent.Text = "100%";
            this.procent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.ForeColor = System.Drawing.SystemColors.Info;
            this.score.Location = new System.Drawing.Point(54, 28);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(40, 17);
            this.score.TabIndex = 2;
            this.score.Text = "score";
            this.score.Click += new System.EventHandler(this.score_Click);
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
            this.content.Size = new System.Drawing.Size(508, 359);
            this.content.TabIndex = 3;
            this.content.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_tests.Properties.Resources.test_default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(508, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.score);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.testName);
            this.Name = "Result";
            this.Text = "Решение";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testName;
        private System.Windows.Forms.Label procent;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.FlowLayoutPanel content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}