using System;
using System.Net;
using System.IO;
//using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using MySqlConnector;
using WMPLib;




namespace EnglishApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WordField.Text = "Введите слово для перевода";
            WordField.ForeColor = Color.Gray;
        }
        string translationSource = "MyDictionary";

        private void Form1_Load(object sender, EventArgs e)
        {
            SortingTable();
            Dictionary_Click(sender,  e);

            //С помощью данных манипуляций была создана БД со всеми словами и переводами.
            //Используется единожды

            /*
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (StreamReader fileIn2 = new StreamReader("d:/RussianWords.txt"))
            {
                using (StreamReader fileIn = new StreamReader("d:/EnglishWords.txt", Encoding.GetEncoding(1251)))
                {
                    string line;
                    string line2;
                    DB db = new DB();
                    int id = 1;
                    //читаем построчно до тех пор, пока поток fileIn не пуст
                    while ((line = fileIn.ReadLine()) != null)
                    {
                        line2 = fileIn2.ReadLine();
                        line = line.ToLower();
                        line2 = line2.ToLower();
                        MySqlCommand command = new MySqlCommand("INSERT INTO `listofwords` (`id`, `WordEnglish`, `WordRussian`) VALUES (@id, @eW, @rW)", db.GetConnection());
                        command.Parameters.Add("@eW", MySqlDbType.VarChar).Value = line;
                        command.Parameters.Add("@rW", MySqlDbType.VarChar).Value = line2;
                        command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;

                        db.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                        }
                        db.closeConnection();
                        id++;
                    }


                }
            }
            */
        }
        private void Training_Click(object sender, EventArgs e)
        {
            DictionaryTable.Visible = false;
            picturePlusLogo.Visible = false;
            WordField.Visible = false;
            TranslationField.Visible = false;

            this.Hide();
            TrainingForm tForm = new TrainingForm();
            tForm.Show();

        }
        private void Dictionary_Click(object sender, EventArgs e)
        {
            picturePlusLogo.Visible = true;
            WordField.Visible = true;
            TranslationField.Visible = true;
            DictionaryTable.Visible = true;
            

            DictionaryTable.AllowUserToAddRows = false; //Убрали ненужные строки снизу
            DictionaryTable.RowHeadersVisible = false;  //Убрали ненужную колонку слева


            DataTable table = new DataTable();

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dictionary`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            DictionaryTable.DataSource = table;
        }
        private void SortingTable()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dictionary` ORDER BY `dictionary`.`Level` ASC", db.GetConnection());

            adapter.SelectCommand = command;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
            }
            db.closeConnection();
            
        }

        private void picturePlusLogo_Click(object sender, EventArgs e)
        {
            //РЕАЛИЗОВАТЬ ПРОВЕРКУ НА ДУБЛИРОВАНИЕ СЛОВА
            if (WordField.Text == "Введите слово для перевода" || WordField.Text == "")
            {
                MessageBox.Show("Ну ты же ничего не ввёл))");
                return;
            }
            if (TranslationField.Text == "Something unclear..." || TranslationField.Text == "Что - то непонятное...")
            {
                MessageBox.Show("Такой пары слово - перевод не существует, возможно, ты ошибся");
                return;
            }
          
            string word = WordField.Text;
            string translation = TranslationField.Text;
            
            DB db = new DB();
            Translating tran = new Translating();
            if (tran.getLanguage(WordField.Text) == "eng")
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `dictionary` (`Word`, `TranslationRussian`, `Level`) VALUES (@word, @translation, 0)", db.GetConnection());
                command.Parameters.Add("@word", MySqlDbType.VarChar).Value = word;
                command.Parameters.Add("@translation", MySqlDbType.VarChar).Value = translation;

                db.openConnection();
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Какая то ошибка....");
                }
                db.closeConnection();
                Dictionary_Click(sender, e);
            }
            else if (tran.getLanguage(WordField.Text) == "rus")
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `dictionary` (`Word`, `TranslationRussian`) VALUES (@translation, @word)", db.GetConnection());
                command.Parameters.Add("@word", MySqlDbType.VarChar).Value = word;
                command.Parameters.Add("@translation", MySqlDbType.VarChar).Value = translation;

                db.openConnection();
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Какая то ошибка....");
                }
                db.closeConnection();
                Dictionary_Click(sender, e);
            }
            else if (tran.getLanguage(WordField.Text) == "error") MessageBox.Show("Вы ввели посторонние символы");
        }

        private void pictureMinusLogo_Click(object sender, EventArgs e)
        {

            //WordField.Text = s;
            //РЕАЛИЗОВАТЬ ПРОВЕРКУ НА ДУБЛИРОВАНИЕ СЛОВА


            string word = (string)DictionaryTable.CurrentCell.Value;

            DB db = new DB();
            Translating tran = new Translating();
            if (tran.getLanguage(word) == "eng")
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM dictionary WHERE `dictionary`.`Word` = @w", db.GetConnection());
                command.Parameters.Add("@w", MySqlDbType.VarChar).Value = word;


                db.openConnection();
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Какая то ошибка....");
                }
                db.closeConnection();

            }
            else if (tran.getLanguage(word) == "rus")
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM dictionary WHERE `dictionary`.`TranslationRussian` = @w", db.GetConnection());
                command.Parameters.Add("@w", MySqlDbType.VarChar).Value = word;


                db.openConnection();
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Какая то ошибка....");
                }
                db.closeConnection();

            }
            else if (tran.getLanguage(WordField.Text) == "error") MessageBox.Show("Вы ввели посторонние символы");
            Dictionary_Click(sender, e);
        }

        private void WordField_KeyUp(object sender, KeyEventArgs e)
        {
            if (WordField.Text != "")
            {
                Translating tran = new Translating();
                if(translationSource=="YandexTranslate")TranslationField.Text = tran.getYandexTranslation(WordField.Text);
                else TranslationField.Text = tran.getMyDictionaryTranslation(WordField.Text);
            }
            else TranslationField.Text = "" ;

            if (TranslationField.Text == "Something unclear...") TranslationField.ForeColor = Color.LightGray;
            if (TranslationField.Text == "Что-то непонятное...") TranslationField.ForeColor = Color.LightGray;
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

        private void WordField_Enter(object sender, EventArgs e)
        {
            if (WordField.Text == "Введите слово для перевода")
            {
                WordField.Text = "";
                WordField.ForeColor = Color.Black;
            }
        }

        private void WordField_Leave(object sender, EventArgs e)
        {
            if (WordField.Text == "")
            {
                WordField.Text = "Введите слово для перевода"; 
                WordField.ForeColor = Color.Gray;
            }
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

        private void wordSound_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();  
            player.URL = @"https://wooordhunt.ru/data/sound/sow/us/" + WordField.Text +".mp3";
            player.controls.play();
            
        }

        private void translationSound_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = @"https://wooordhunt.ru/data/sound/sow/us/" + TranslationField.Text + ".mp3";
            player.controls.play();
        }

        private void wordSound_MouseEnter(object sender, EventArgs e)
        {
            wordSound.Size = new Size(26, 26);
        }

        private void wordSound_MouseLeave(object sender, EventArgs e)
        {
            wordSound.Size = new Size(25, 25);
        }
        private void wordSound_MouseUp(object sender, MouseEventArgs e)
        {
            wordSound.Size = new Size(26, 26);
        }
        

        private void wordSound_MouseDown(object sender, MouseEventArgs e)
        {
            wordSound.Size = new Size(30, 30);
        }

        private void TranslationSound_MouseEnter(object sender, EventArgs e)
        {
            translationSound.Size = new Size(26, 26);
        }

        private void TranslationSound_MouseLeave(object sender, EventArgs e)
        {
            translationSound.Size = new Size(25, 25);
        }
        private void TranslationSound_MouseUp(object sender, MouseEventArgs e)
        {
            translationSound.Size = new Size(26, 26);
        }


        private void TranslationSound_MouseDown(object sender, MouseEventArgs e)
        {
            translationSound.Size = new Size(30, 30);
        }

        private void SwitchOn_Click(object sender, EventArgs e)
        {
            KeyEventArgs asd = new KeyEventArgs(Keys.D);
            SwitchOn.Visible = false;
            SwitchOff.Visible = true;
            translationSource = "YandexTranslate";
            WordField_KeyUp(sender, asd);
        }

        private void SwitchOff_Click(object sender, EventArgs e)
        {
            KeyEventArgs asd = new KeyEventArgs(Keys.D);
            SwitchOn.Visible = true;
            SwitchOff.Visible = false;
            translationSource = "MyDictionary";
            WordField_KeyUp(sender, asd);

        }
    }
}







