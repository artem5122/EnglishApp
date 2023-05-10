
namespace EnglishApp
{
    partial class ResultOfTraining
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
            this.ResultTitle = new System.Windows.Forms.Label();
            this.DancingDogGif = new System.Windows.Forms.PictureBox();
            this.WordList = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DancingDogGif)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTitle
            // 
            this.ResultTitle.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultTitle.Location = new System.Drawing.Point(12, 9);
            this.ResultTitle.Name = "ResultTitle";
            this.ResultTitle.Size = new System.Drawing.Size(725, 62);
            this.ResultTitle.TabIndex = 1;
            this.ResultTitle.Text = "Awesome!!!";
            this.ResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DancingDogGif
            // 
            this.DancingDogGif.Image = global::EnglishApp.Properties.Resources.Dancing_dog;
            this.DancingDogGif.Location = new System.Drawing.Point(227, 74);
            this.DancingDogGif.Name = "DancingDogGif";
            this.DancingDogGif.Size = new System.Drawing.Size(283, 199);
            this.DancingDogGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DancingDogGif.TabIndex = 2;
            this.DancingDogGif.TabStop = false;
            // 
            // WordList
            // 
            this.WordList.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordList.Location = new System.Drawing.Point(12, 335);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(725, 148);
            this.WordList.TabIndex = 3;
            this.WordList.Text = "label1";
            this.WordList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(23, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 36);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ResultOfTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 598);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.DancingDogGif);
            this.Controls.Add(this.ResultTitle);
            this.Name = "ResultOfTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultOfTraining";
            this.Load += new System.EventHandler(this.ResultOfTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DancingDogGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ResultTitle;
        private System.Windows.Forms.PictureBox DancingDogGif;
        private System.Windows.Forms.Label WordList;
        private System.Windows.Forms.Button backButton;
    }
}