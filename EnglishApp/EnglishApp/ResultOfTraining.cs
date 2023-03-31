using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnglishApp
{
    public partial class ResultOfTraining : Form
    {
        public ResultOfTraining()
        {
            InitializeComponent();
        }

        //Первая строка: неправильные слова
        //Вторая строка: правильные слова

        public List<string> CorrectWords { get; set; }
        public List<string> IncorrectWords { get; set; }



        private void ResultOfTraining_Load(object sender, EventArgs e)
        {
            string words = "";
            foreach(string str in IncorrectWords)
            {
                words += str+", ";
            }
            if (words.Length > 0)
            {
                words = words.Remove(words.Length - 2);
                WordList.Text = ("Вот эти слова тебе стоит подучить: " + words);
            }
            else WordList.Text = ("Идёшь без ошибок! \nА ты хорооош \u263A");
            
            //Изменяем уровни у слов
            DictionaryTaking changes = new DictionaryTaking();
            changes.LevelChange(CorrectWords, IncorrectWords);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            TrainingForm trainingForm = new TrainingForm();
            trainingForm.Show();
        }

        
    }
}
