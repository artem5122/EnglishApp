using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace EnglishApp
{
    //Класс реализует:
        //Выбор неизученных слов
        //Повышение уровня слов
        //Понижение уровня слов

    //У каждого слова - числовое значение сколько раз оно было угадано верно
    //Изначально оно равно 0
    //Когда оно угадано неверно это число снижается на 1(только если оно больше двух, чтобы не откатываться на 0)
    //Пользователю это отображается так:
    //Новое слово - 0
    //Изучается - [1;6]
    //Почти изучено - [7;9]
    //Изучено - 10
    
    //Чем выше слово по уровню, тем реже оно попадается
    //Со временем уровень слова, может уменьшаться
    class DictionaryTaking
    {
        public List<List<string>> dictionaryTaking()
        {
            //СДЕЛАТЬ ВЫБОР ДЕСЯТИ НЕИЗУЧЕННЫХ СЛОВ
            DataTable table = new DataTable();
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dictionary`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            List<List<string>> words = new List<List<string>>();


            //Преобразую в список для удобства
            for (int i = 0; i < 10; i++)
            {
                List<string> item = new List<string>();
                for (int j = 0; j < 2; j++)
                {

                    item.Add((string)table.Rows[i][j]);
                }
                words.Add(item);
            }
            return words;
        }

        public void LevelChange(List<string> CorrectWords, List<string> IncorrectWords)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            foreach(string elem in CorrectWords) 
            {
                MySqlCommand command = new MySqlCommand("UPDATE dictionary SET Level = CASE WHEN Level<10 THEN Level + 1 ELSE Level END WHERE dictionary.Word = @wR", db.GetConnection());
                command.Parameters.Add("@wR", MySqlDbType.VarChar).Value = elem;
                
                adapter.SelectCommand = command;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                }
                db.closeConnection();
            }

            foreach (string elem in IncorrectWords)
            {
                MySqlCommand command = new MySqlCommand("UPDATE dictionary SET Level = CASE WHEN Level>1 THEN Level - 1 ELSE Level END WHERE dictionary.Word = @wR", db.GetConnection());
                command.Parameters.Add("@wR", MySqlDbType.VarChar).Value = elem;

                adapter.SelectCommand = command;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                }
                db.closeConnection();
            }

        }
        

    }
}
