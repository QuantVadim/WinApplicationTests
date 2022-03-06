
namespace Win_tests.UserControls
{
    partial class LiGTest
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
            this.name = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.testDescription = new System.Windows.Forms.Label();
            this.btn_results = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(71, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 25);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(8, 8);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(66, 15);
            this.description.TabIndex = 1;
            this.description.Text = "description";
            // 
            // testDescription
            // 
            this.testDescription.AutoSize = true;
            this.testDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.testDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.testDescription.Location = new System.Drawing.Point(74, 47);
            this.testDescription.Name = "testDescription";
            this.testDescription.Size = new System.Drawing.Size(86, 15);
            this.testDescription.TabIndex = 1;
            this.testDescription.Text = "testDescription";
            this.testDescription.Click += new System.EventHandler(this.testDescription_Click);
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(74, 68);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(75, 23);
            this.btn_results.TabIndex = 2;
            this.btn_results.Text = "Решения";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(429, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(24, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "X";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_tests.Properties.Resources.test_default;
            this.pictureBox1.Location = new System.Drawing.Point(8, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LiGTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.testDescription);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LiGTest";
            this.Size = new System.Drawing.Size(462, 96);
            this.Load += new System.EventHandler(this.LiGTest_Load);
            this.Click += new System.EventHandler(this.LiGTest_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label testDescription;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
