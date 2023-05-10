
namespace EnglishApp
{
    partial class TrainingForm
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
            this.Training = new System.Windows.Forms.Label();
            this.Dictionary = new System.Windows.Forms.Label();
            this.buttonTraining2 = new System.Windows.Forms.Button();
            this.buttonTraining3 = new System.Windows.Forms.Button();
            this.buttonTraining4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Training
            // 
            this.Training.AutoSize = true;
            this.Training.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Training.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Training.Location = new System.Drawing.Point(515, 17);
            this.Training.Name = "Training";
            this.Training.Size = new System.Drawing.Size(112, 37);
            this.Training.TabIndex = 7;
            this.Training.Text = "Training";
            this.Training.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Training_MouseDown);
            this.Training.MouseEnter += new System.EventHandler(this.Training_MouseEnter);
            this.Training.MouseLeave += new System.EventHandler(this.Training_MouseLeave);
            this.Training.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Training_MouseUp);
            // 
            // Dictionary
            // 
            this.Dictionary.AutoSize = true;
            this.Dictionary.BackColor = System.Drawing.SystemColors.Control;
            this.Dictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dictionary.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dictionary.Location = new System.Drawing.Point(134, 17);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(138, 37);
            this.Dictionary.TabIndex = 6;
            this.Dictionary.Text = "Dictionary";
            this.Dictionary.Click += new System.EventHandler(this.Dictionary_Click);
            this.Dictionary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dictionary_MouseDown);
            this.Dictionary.MouseEnter += new System.EventHandler(this.Dictionary_MouseEnter);
            this.Dictionary.MouseLeave += new System.EventHandler(this.Dictionary_MouseLeave);
            this.Dictionary.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dictionary_MouseUp_1);
            // 
            // buttonTraining2
            // 
            this.buttonTraining2.Location = new System.Drawing.Point(206, 86);
            this.buttonTraining2.Name = "buttonTraining2";
            this.buttonTraining2.Size = new System.Drawing.Size(138, 45);
            this.buttonTraining2.TabIndex = 8;
            this.buttonTraining2.Text = "Training 2";
            this.buttonTraining2.UseVisualStyleBackColor = true;
            // 
            // buttonTraining3
            // 
            this.buttonTraining3.Location = new System.Drawing.Point(386, 86);
            this.buttonTraining3.Name = "buttonTraining3";
            this.buttonTraining3.Size = new System.Drawing.Size(138, 45);
            this.buttonTraining3.TabIndex = 8;
            this.buttonTraining3.Text = "Training 3";
            this.buttonTraining3.UseVisualStyleBackColor = true;
            // 
            // buttonTraining4
            // 
            this.buttonTraining4.Location = new System.Drawing.Point(566, 86);
            this.buttonTraining4.Name = "buttonTraining4";
            this.buttonTraining4.Size = new System.Drawing.Size(138, 45);
            this.buttonTraining4.TabIndex = 8;
            this.buttonTraining4.Text = "Training 4";
            this.buttonTraining4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Training 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 598);
            this.Controls.Add(this.buttonTraining4);
            this.Controls.Add(this.buttonTraining3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonTraining2);
            this.Controls.Add(this.Training);
            this.Controls.Add(this.Dictionary);
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingForm";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Training;
        private System.Windows.Forms.Label Dictionary;
        private System.Windows.Forms.Button buttonTraining2;
        private System.Windows.Forms.Button buttonTraining3;
        private System.Windows.Forms.Button buttonTraining4;
        private System.Windows.Forms.Button button3;
    }
}