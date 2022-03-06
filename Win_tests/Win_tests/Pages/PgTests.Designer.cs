
namespace Win_tests.Pages
{
    partial class PgTests
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
            this.content = new System.Windows.Forms.FlowLayoutPanel();
            this.addTest = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.tb_finder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.AutoScroll = true;
            this.content.BackColor = System.Drawing.Color.DarkGray;
            this.content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content.Location = new System.Drawing.Point(0, 29);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(556, 329);
            this.content.TabIndex = 3;
            this.content.WrapContents = false;
            // 
            // addTest
            // 
            this.addTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTest.ForeColor = System.Drawing.SystemColors.Info;
            this.addTest.Location = new System.Drawing.Point(2, 2);
            this.addTest.Name = "addTest";
            this.addTest.Size = new System.Drawing.Size(104, 25);
            this.addTest.TabIndex = 4;
            this.addTest.Text = "+ Создать тест";
            this.addTest.UseVisualStyleBackColor = true;
            this.addTest.Click += new System.EventHandler(this.addTest_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(302, 3);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(53, 23);
            this.btn_find.TabIndex = 5;
            this.btn_find.Text = "Найти";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // tb_finder
            // 
            this.tb_finder.Location = new System.Drawing.Point(112, 3);
            this.tb_finder.Name = "tb_finder";
            this.tb_finder.PlaceholderText = "Поиск";
            this.tb_finder.Size = new System.Drawing.Size(189, 23);
            this.tb_finder.TabIndex = 6;
            this.tb_finder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_finder_KeyUp);
            // 
            // PgTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tb_finder);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.addTest);
            this.Controls.Add(this.content);
            this.Name = "PgTests";
            this.Size = new System.Drawing.Size(556, 358);
            this.Load += new System.EventHandler(this.PgTests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel content;
        private System.Windows.Forms.Button addTest;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox tb_finder;
    }
}
