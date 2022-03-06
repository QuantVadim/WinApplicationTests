
namespace Win_tests.UserControls
{
    partial class LiRQuestion
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
            this.text = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(9, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(52, 21);
            this.text.TabIndex = 0;
            this.text.Text = "label1";
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer.ForeColor = System.Drawing.Color.Black;
            this.answer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.answer.Location = new System.Drawing.Point(9, 35);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(328, 29);
            this.answer.TabIndex = 1;
            this.answer.Text = "answer";
            // 
            // score
            // 
            this.score.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.score.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.score.Location = new System.Drawing.Point(292, 2);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(53, 20);
            this.score.TabIndex = 2;
            this.score.Text = "label2";
            this.score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LiRQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.score);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.text);
            this.Name = "LiRQuestion";
            this.Size = new System.Drawing.Size(348, 73);
            this.Load += new System.EventHandler(this.LiRQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label score;
    }
}
