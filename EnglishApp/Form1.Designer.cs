namespace EnglishApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dictionary = new System.Windows.Forms.Label();
            this.Training = new System.Windows.Forms.Label();
            this.WordField = new System.Windows.Forms.TextBox();
            this.TranslationField = new System.Windows.Forms.TextBox();
            this.picturePlusLogo = new System.Windows.Forms.PictureBox();
            this.DictionaryTable = new System.Windows.Forms.DataGridView();
            this.wordSound = new System.Windows.Forms.PictureBox();
            this.translationSound = new System.Windows.Forms.PictureBox();
            this.pictureMinusLogo = new System.Windows.Forms.PictureBox();
            this.TranslationSource = new System.Windows.Forms.Label();
            this.SwitchOn = new System.Windows.Forms.PictureBox();
            this.SwitchOff = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchOff)).BeginInit();
            this.SuspendLayout();
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
            this.Dictionary.TabIndex = 0;
            this.Dictionary.Text = "Dictionary";
            this.Dictionary.Click += new System.EventHandler(this.Dictionary_Click);
            this.Dictionary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dictionary_MouseDown);
            this.Dictionary.MouseEnter += new System.EventHandler(this.Dictionary_MouseEnter);
            this.Dictionary.MouseLeave += new System.EventHandler(this.Dictionary_MouseLeave);
            this.Dictionary.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dictionary_MouseUp_1);
            // 
            // Training
            // 
            this.Training.AutoSize = true;
            this.Training.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Training.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Training.Location = new System.Drawing.Point(515, 17);
            this.Training.Name = "Training";
            this.Training.Size = new System.Drawing.Size(112, 37);
            this.Training.TabIndex = 1;
            this.Training.Text = "Training";
            this.Training.Click += new System.EventHandler(this.Training_Click);
            this.Training.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Training_MouseDown);
            this.Training.MouseEnter += new System.EventHandler(this.Training_MouseEnter);
            this.Training.MouseLeave += new System.EventHandler(this.Training_MouseLeave);
            this.Training.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Training_MouseUp);
            // 
            // WordField
            // 
            this.WordField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordField.Location = new System.Drawing.Point(134, 80);
            this.WordField.Multiline = true;
            this.WordField.Name = "WordField";
            this.WordField.Size = new System.Drawing.Size(245, 49);
            this.WordField.TabIndex = 3;
            this.WordField.Enter += new System.EventHandler(this.WordField_Enter);
            this.WordField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WordField_KeyUp);
            this.WordField.Leave += new System.EventHandler(this.WordField_Leave);
            // 
            // TranslationField
            // 
            this.TranslationField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslationField.Location = new System.Drawing.Point(385, 80);
            this.TranslationField.Multiline = true;
            this.TranslationField.Name = "TranslationField";
            this.TranslationField.ReadOnly = true;
            this.TranslationField.Size = new System.Drawing.Size(230, 49);
            this.TranslationField.TabIndex = 3;
            // 
            // picturePlusLogo
            // 
            this.picturePlusLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePlusLogo.Image = global::EnglishApp.Properties.Resources.PlusLogo;
            this.picturePlusLogo.Location = new System.Drawing.Point(621, 79);
            this.picturePlusLogo.Name = "picturePlusLogo";
            this.picturePlusLogo.Size = new System.Drawing.Size(50, 50);
            this.picturePlusLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlusLogo.TabIndex = 4;
            this.picturePlusLogo.TabStop = false;
            this.picturePlusLogo.Click += new System.EventHandler(this.picturePlusLogo_Click);
            // 
            // DictionaryTable
            // 
            this.DictionaryTable.AllowUserToAddRows = false;
            this.DictionaryTable.AllowUserToDeleteRows = false;
            this.DictionaryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DictionaryTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DictionaryTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DictionaryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DictionaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DictionaryTable.Location = new System.Drawing.Point(134, 145);
            this.DictionaryTable.Name = "DictionaryTable";
            this.DictionaryTable.ReadOnly = true;
            this.DictionaryTable.RowTemplate.Height = 25;
            this.DictionaryTable.Size = new System.Drawing.Size(493, 310);
            this.DictionaryTable.TabIndex = 5;
            // 
            // wordSound
            // 
            this.wordSound.BackColor = System.Drawing.Color.White;
            this.wordSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wordSound.Image = global::EnglishApp.Properties.Resources.Speaker_Icon;
            this.wordSound.Location = new System.Drawing.Point(347, 92);
            this.wordSound.Name = "wordSound";
            this.wordSound.Size = new System.Drawing.Size(25, 25);
            this.wordSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wordSound.TabIndex = 6;
            this.wordSound.TabStop = false;
            this.wordSound.Click += new System.EventHandler(this.wordSound_Click);
            this.wordSound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wordSound_MouseDown);
            this.wordSound.MouseEnter += new System.EventHandler(this.wordSound_MouseEnter);
            this.wordSound.MouseLeave += new System.EventHandler(this.wordSound_MouseLeave);
            this.wordSound.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wordSound_MouseUp);
            // 
            // translationSound
            // 
            this.translationSound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.translationSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translationSound.Image = global::EnglishApp.Properties.Resources.Speaker_Icon;
            this.translationSound.Location = new System.Drawing.Point(579, 90);
            this.translationSound.Name = "translationSound";
            this.translationSound.Size = new System.Drawing.Size(25, 25);
            this.translationSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.translationSound.TabIndex = 6;
            this.translationSound.TabStop = false;
            this.translationSound.Click += new System.EventHandler(this.translationSound_Click);
            this.translationSound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TranslationSound_MouseDown);
            this.translationSound.MouseEnter += new System.EventHandler(this.TranslationSound_MouseEnter);
            this.translationSound.MouseLeave += new System.EventHandler(this.TranslationSound_MouseLeave);
            this.translationSound.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TranslationSound_MouseUp);
            // 
            // pictureMinusLogo
            // 
            this.pictureMinusLogo.Image = global::EnglishApp.Properties.Resources.MinusLogo;
            this.pictureMinusLogo.Location = new System.Drawing.Point(677, 82);
            this.pictureMinusLogo.Name = "pictureMinusLogo";
            this.pictureMinusLogo.Size = new System.Drawing.Size(63, 44);
            this.pictureMinusLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinusLogo.TabIndex = 7;
            this.pictureMinusLogo.TabStop = false;
            this.pictureMinusLogo.Click += new System.EventHandler(this.pictureMinusLogo_Click);
            // 
            // TranslationSource
            // 
            this.TranslationSource.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslationSource.Location = new System.Drawing.Point(285, 470);
            this.TranslationSource.Name = "TranslationSource";
            this.TranslationSource.Size = new System.Drawing.Size(184, 23);
            this.TranslationSource.TabIndex = 8;
            this.TranslationSource.Text = "Translation Source";
            this.TranslationSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchOn
            // 
            this.SwitchOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchOn.Image = global::EnglishApp.Properties.Resources.Switch_On;
            this.SwitchOn.Location = new System.Drawing.Point(331, 496);
            this.SwitchOn.Name = "SwitchOn";
            this.SwitchOn.Size = new System.Drawing.Size(100, 50);
            this.SwitchOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SwitchOn.TabIndex = 9;
            this.SwitchOn.TabStop = false;
            this.SwitchOn.Click += new System.EventHandler(this.SwitchOn_Click);
            // 
            // SwitchOff
            // 
            this.SwitchOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchOff.Image = global::EnglishApp.Properties.Resources.Switch_Off;
            this.SwitchOff.Location = new System.Drawing.Point(331, 496);
            this.SwitchOff.Name = "SwitchOff";
            this.SwitchOff.Size = new System.Drawing.Size(100, 50);
            this.SwitchOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SwitchOff.TabIndex = 10;
            this.SwitchOff.TabStop = false;
            this.SwitchOff.Visible = false;
            this.SwitchOff.Click += new System.EventHandler(this.SwitchOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yandex Translate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(419, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "MyDictionary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishApp.Properties.Resources.emile_seguin_R9OueKOtGGU_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitchOff);
            this.Controls.Add(this.SwitchOn);
            this.Controls.Add(this.TranslationSource);
            this.Controls.Add(this.pictureMinusLogo);
            this.Controls.Add(this.translationSound);
            this.Controls.Add(this.wordSound);
            this.Controls.Add(this.DictionaryTable);
            this.Controls.Add(this.picturePlusLogo);
            this.Controls.Add(this.TranslationField);
            this.Controls.Add(this.WordField);
            this.Controls.Add(this.Training);
            this.Controls.Add(this.Dictionary);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dictionary;
        private System.Windows.Forms.Label Training;
        private System.Windows.Forms.TextBox WordField;
        private System.Windows.Forms.TextBox TranslationField;
        private System.Windows.Forms.PictureBox picturePlusLogo;
        private System.Windows.Forms.DataGridView DictionaryTable;
        private System.Windows.Forms.PictureBox wordSound;
        private System.Windows.Forms.PictureBox translationSound;
        private System.Windows.Forms.PictureBox pictureMinusLogo;
        private System.Windows.Forms.Label TranslationSource;
        private System.Windows.Forms.PictureBox SwitchOn;
        private System.Windows.Forms.PictureBox SwitchOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

