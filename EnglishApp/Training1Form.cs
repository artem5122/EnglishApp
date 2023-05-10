using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;


namespace EnglishApp
{
    public partial class Training1Form : Form
    {
        public Training1Form()
        {
            InitializeComponent();
            wordLoading();
        }

        static int trueVariant = 0;
        static List<Button> buttons = new List<Button>();
        int wordsCount = 10;//Сколько слов осталось потренить
        List<List<string>> wordsToTrainList;//Список всех 10-ти слов без изменений
        List<List<string>> wordsToTrain; //Список ОСТАВШИХСЯ слов для текущей тренировки
        

        List<string> correctWords = new List<string>();
        List<string> incorrectWords = new List<string>();



        

        private void answerHandler(int variant)
        {

            if (variant == trueVariant)
            {
                switch (variant)
                {
                    case 1:
                        Variant1.BackColor = Color.Green;
                        break;
                    case 2:
                        Variant2.BackColor = Color.Green;
                        break;
                    case 3:
                        Variant3.BackColor = Color.Green;
                        break;
                    case 4:
                        Variant4.BackColor = Color.Green;
                        break;
                    default:
                        break;
                }
               
                correctWords.Add(Word.Text);
            }
            else 
            {
                switch (variant)
                {
                    case 1:
                        Variant1.BackColor = Color.Red;
                        break;
                    case 2:
                        Variant2.BackColor = Color.Red;
                        break;
                    case 3:
                        Variant3.BackColor = Color.Red;
                        break;
                    case 4:
                        Variant4.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
                switch (trueVariant)
                {
                    case 1:
                        Variant1.BackColor = Color.Green;
                        break;
                    case 2:
                        Variant2.BackColor = Color.Green;
                        break;
                    case 3:
                        Variant3.BackColor = Color.Green;
                        break;
                    case 4:
                        Variant4.BackColor = Color.Green;
                        break;
                    default:
                        break;
                }
                incorrectWords.Add(Word.Text);
            }

            Refresh();
            System.Threading.Thread.Sleep(1000);
            wordsCount--;
            if (wordsCount > 0) wordLoading();
            else Results();
        }
        
        private void wordLoading()
        {
            WordCount.Text = "Осталось слов: " + wordsCount;
            Variant1.BackColor = Color.LightGray;
            Variant2.BackColor = Color.LightGray;
            Variant3.BackColor = Color.LightGray;
            Variant4.BackColor = Color.LightGray;

            //Производим выбор слов
            DictionaryTaking dt = new DictionaryTaking();
            if (wordsToTrain == null) wordsToTrain = dt.dictionaryTaking();
            wordsToTrainList = dt.dictionaryTaking();


            List<string> word = new List<string>(); //Первый элемент - загаданное слово, второй - пятый -- варианты ответа


            //Задача - заполнить пять слов
            //Первое - английское. Список слов откуда мы берём его должны уменьшать на это слово
            //Остальные - берём из полного списка слов, проверяем, чтобы они не были равны тому слову, которое нужно отгадать
            //После этого определяем какая кнопка будет отвечать за правильный варик

            Random rnd = new Random();
            int id;

            //Выбираем английское слово, которое нужно отгадать
            int ID = rnd.Next(0, wordsCount - 1);//Выбираем айди английского слова
            word.Add(wordsToTrain[ID][0]);//Выбираем английское слово
            wordsToTrainList.RemoveAt(ID);


            //Выбираем русские слова
            for (int i = 1; i <= 4; i++)
            {
                id = rnd.Next(0, 10 - i);
                word.Add(wordsToTrainList[id][1]);//Выбираем английское слово
                wordsToTrainList.RemoveAt(id);
            }


            //Выбираем на какой кнопке будет правильный ответ
                //Проверка на ошибку
            int k=-1;
            for (int i = 1; i <= 4; i++)  
            {
                if (word[i] == wordsToTrain[ID][1]) k = i;
            }

            if (k < 0)
            {
                id = rnd.Next(1, 5);
                word[id] = wordsToTrain[ID][1];
                trueVariant = id;
            }
            else trueVariant = k;




            wordsToTrain.RemoveAt(ID);


            //Выводим надписи на кнопках
            Variant1.Text = word[1];
            Variant2.Text = word[2];
            Variant3.Text = word[3];
            Variant4.Text = word[4];
            Word.Text = word[0];
        }
        private void Variant1_Click(object sender, EventArgs e)
        {
            answerHandler(1);
        }

        
        private void Variant2_Click(object sender, EventArgs e)
        {
            answerHandler(2);
        }

        private void Variant3_Click(object sender, EventArgs e)
        {
            answerHandler(3);
        }

        private void Variant4_Click(object sender, EventArgs e)
        {
            answerHandler(4);
        }
        private void Results()
        {
            Hide();
            ResultOfTraining result = new ResultOfTraining();
            

            result.CorrectWords = correctWords;
            result.IncorrectWords = incorrectWords;
            result.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            TrainingForm trainingForm = new TrainingForm();
            trainingForm.Show();
        }

        private void Training1Form_Load(object sender, EventArgs e)
        {


        }
    }
}
