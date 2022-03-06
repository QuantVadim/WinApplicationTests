
namespace Win_tests.Wins
{
    partial class Group
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
            this.groupName = new System.Windows.Forms.Label();
            this.countUsers = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupName.ForeColor = System.Drawing.SystemColors.Info;
            this.groupName.Location = new System.Drawing.Point(72, 3);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(139, 30);
            this.groupName.TabIndex = 0;
            this.groupName.Text = "Group Name";
            // 
            // countUsers
            // 
            this.countUsers.AutoSize = true;
            this.countUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countUsers.ForeColor = System.Drawing.Color.Silver;
            this.countUsers.Location = new System.Drawing.Point(72, 52);
            this.countUsers.Name = "countUsers";
            this.countUsers.Size = new System.Drawing.Size(52, 21);
            this.countUsers.TabIndex = 0;
            this.countUsers.Text = "Класс:";
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacher.ForeColor = System.Drawing.Color.Silver;
            this.teacher.Location = new System.Drawing.Point(72, 32);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(71, 21);
            this.teacher.TabIndex = 0;
            this.teacher.Text = "Учитель:";
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.AutoScroll = true;
            this.content.BackColor = System.Drawing.Color.DarkGray;
            this.content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content.Location = new System.Drawing.Point(0, 79);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(706, 371);
            this.content.TabIndex = 1;
            this.content.WrapContents = false;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_tests.Properties.Resources.group_default;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(705, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.countUsers);
            this.Controls.Add(this.groupName);
            this.Name = "Group";
            this.Text = "Группа";
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupName;
        private System.Windows.Forms.Label countUsers;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.FlowLayoutPanel content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}