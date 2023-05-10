
namespace EnglishApp
{
    partial class Training1Form
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
            this.Training1Title = new System.Windows.Forms.Label();
            this.Task1 = new System.Windows.Forms.Label();
            this.Variant1 = new System.Windows.Forms.Button();
            this.Variant3 = new System.Windows.Forms.Button();
            this.Variant4 = new System.Windows.Forms.Button();
            this.Variant2 = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.WordCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Training1Title
            // 
            this.Training1Title.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Training1Title.Location = new System.Drawing.Point(12, 9);
            this.Training1Title.Name = "Training1Title";
            this.Training1Title.Size = new System.Drawing.Size(725, 62);
            this.Training1Title.TabIndex = 0;
            this.Training1Title.Text = "Training 1";
            this.Training1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task1
            // 
            this.Task1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Task1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Task1.Location = new System.Drawing.Point(12, 71);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(725, 32);
            this.Task1.TabIndex = 1;
            this.Task1.Text = "Выберите правильный перевод слова";
            this.Task1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Variant1
            // 
            this.Variant1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Variant1.Location = new System.Drawing.Point(39, 272);
            this.Variant1.Name = "Variant1";
            this.Variant1.Size = new System.Drawing.Size(286, 86);
            this.Variant1.TabIndex = 2;
            this.Variant1.Text = "button1";
            this.Variant1.UseVisualStyleBackColor = true;
            this.Variant1.Click += new System.EventHandler(this.Variant1_Click);
            // 
            // Variant3
            // 
            this.Variant3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Variant3.Location = new System.Drawing.Point(39, 423);
            this.Variant3.Name = "Variant3";
            this.Variant3.Size = new System.Drawing.Size(286, 86);
            this.Variant3.TabIndex = 2;
            this.Variant3.Text = "button1";
            this.Variant3.UseVisualStyleBackColor = true;
            this.Variant3.Click += new System.EventHandler(this.Variant3_Click);
            // 
            // Variant4
            // 
            this.Variant4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Variant4.Location = new System.Drawing.Point(416, 423);
            this.Variant4.Name = "Variant4";
            this.Variant4.Size = new System.Drawing.Size(286, 86);
            this.Variant4.TabIndex = 2;
            this.Variant4.Text = "button1";
            this.Variant4.UseVisualStyleBackColor = true;
            this.Variant4.Click += new System.EventHandler(this.Variant4_Click);
            // 
            // Variant2
            // 
            this.Variant2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Variant2.Location = new System.Drawing.Point(416, 272);
            this.Variant2.Name = "Variant2";
            this.Variant2.Size = new System.Drawing.Size(286, 86);
            this.Variant2.TabIndex = 2;
            this.Variant2.Text = "button1";
            this.Variant2.UseVisualStyleBackColor = true;
            this.Variant2.Click += new System.EventHandler(this.Variant2_Click);
            // 
            // Word
            // 
            this.Word.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Word.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Word.Location = new System.Drawing.Point(155, 146);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(438, 81);
            this.Word.TabIndex = 3;
            this.Word.Text = "trip";
            this.Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(23, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 36);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // WordCount
            // 
            this.WordCount.AutoSize = true;
            this.WordCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordCount.Location = new System.Drawing.Point(513, 126);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(158, 30);
            this.WordCount.TabIndex = 5;
            this.WordCount.Text = "Осталось слов:";
            // 
            // Training1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 598);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Variant2);
            this.Controls.Add(this.Variant4);
            this.Controls.Add(this.Variant3);
            this.Controls.Add(this.Variant1);
            this.Controls.Add(this.Task1);
            this.Controls.Add(this.Training1Title);
            this.Name = "Training1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training1Form";
            this.Load += new System.EventHandler(this.Training1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Training1Title;
        private System.Windows.Forms.Label Task1;
        private System.Windows.Forms.Button Variant1;
        private System.Windows.Forms.Button Variant3;
        private System.Windows.Forms.Button Variant4;
        private System.Windows.Forms.Button Variant2;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label WordCount;
    }
}