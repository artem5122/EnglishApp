using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnglishApp
{
    public partial class TrainingForm : Form
    {
        Form1 mainForm = new Form1();
        public TrainingForm()
        {
            InitializeComponent();
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {

        }

        private void Dictionary_Click(object sender, EventArgs e)
        {
            Hide();
            mainForm.Show();
        }

        private void Dictionary_MouseEnter(object sender, EventArgs e)
        {
            Dictionary.ForeColor = Color.FromArgb(0, 150, 150, 150);
        }

        private void Dictionary_MouseDown(object sender, MouseEventArgs e)
        {
            Dictionary.ForeColor = Color.FromArgb(0, 200, 200, 200);
        }


        private void Dictionary_MouseLeave(object sender, EventArgs e)
        {
            Dictionary.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void Dictionary_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dictionary.ForeColor = Color.FromArgb(0, 150, 150, 150);

        }

        private void Training_MouseUp(object sender, MouseEventArgs e)
        {
            Training.ForeColor = Color.FromArgb(0, 150, 150, 150);
        }
        private void Training_MouseEnter(object sender, EventArgs e)
        {
            Training.ForeColor = Color.FromArgb(0, 150, 150, 150);
        }

        private void Training_MouseDown(object sender, MouseEventArgs e)
        {
            Training.ForeColor = Color.FromArgb(0, 200, 200, 200);
        }


        private void Training_MouseLeave(object sender, EventArgs e)
        {
            Training.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Training1Form training1Form = new Training1Form();
            training1Form.Show();
        }
    }
}
