using System;
using System.Text;
using System.IO;
using MySqlConnector;
using System.Windows.Forms;
using System.Data;
using System.Net;

namespace EnglishApp
{
    class Translating
    {
        
        //Проверить какой язык
        //Найти это слово в БД
        //Взять его перевод

        public string getMyDictionaryTranslation(string line)
        {
            line = line.ToLower();
            if (getLanguage(line) == "eng")
            {
                DataTable table = new DataTable();

                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `listofwords` WHERE `WordEnglish` = @wE", db.GetConnection());
                command.Parameters.Add("@wE", MySqlDbType.VarChar).Value = line;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if(table.Rows.Count>0) line = (string)table.Rows[0][2];
                else line = "Что-то непонятное...";
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                }
                db.closeConnection();
                return line;
            }
            else if (getLanguage(line) == "rus")
            {
                DataTable table = new DataTable();

                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `listofwords` WHERE `WordRussian` = @wR", db.GetConnection());
                command.Parameters.Add("@wR", MySqlDbType.VarChar).Value = line;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0) line = (string)table.Rows[0][1];
                else line = "Something unclear...";
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                }
                db.closeConnection();
                return line;
            }
            else if (getLanguage(line) == "error")
            {

            }
            return line;
        }
        

        public string getYandexTranslation(string line)
        {
            if (getLanguage(line) == "eng")
            {
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                    "https://dictionary.yandex.net/api/v1/dicservice.json/lookup?key=dict.1.1.20221204T122255Z.e65d06242dd3e047.24dc4e761e7449f44e7535b828685da0ed33670c&lang=en-ru&text=" + line);


                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                Stream stream = res.GetResponseStream();
                StreamReader sr = new StreamReader(stream);

                string response = sr.ReadToEnd();
                res.Close();
                string str = "";
                int index = response.IndexOf("text");
                response = response.Remove(0, index + 7);
                index = response.IndexOf("text");
                index += 7;
                while (response[index] != '\"')
                {
                    str += response[index];
                    index++;
                }
                if(str=="def") return "Что - то непонятное...";
                return str;
            }
            else if (getLanguage(line) == "rus")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                    "https://dictionary.yandex.net/api/v1/dicservice.json/lookup?key=dict.1.1.20221204T122255Z.e65d06242dd3e047.24dc4e761e7449f44e7535b828685da0ed33670c&lang=ru-en&text=" + line);


                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                Stream stream = res.GetResponseStream();
                StreamReader sr = new StreamReader(stream);

                string response = sr.ReadToEnd();
                res.Close();
                string str = "";
                int index = response.IndexOf("text");
                response = response.Remove(0, index + 7);
                index = response.IndexOf("text");
                index += 7;
                while (response[index] != '\"')
                {
                    str += response[index];
                    index++;
                }
                if (str == "def") return "Something unclear...";
                return str;
            }
            else return "";
        }

        //Определяет язык первого символа
        public string getLanguage(string line)
        {
            char c = line[0];
            if ((c > 'а'-1 && c < 'я'+1) || (c > 'А'-1 && c < 'Я'+1))
                return "rus";
            else if ((c > 'a' - 1 && c < 'z' + 1) || (c > 'A' - 1 && c < 'Z' + 1))
                return "eng";
            else
            {
                MessageBox.Show("Вы ввели некорректные символы");
                return "error";
            }
        }
    }
}