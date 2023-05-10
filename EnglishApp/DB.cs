//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
//Я удалил файл MySql.data, добавил библу NuGet MySqlConnector. В случае трабла - откатись

namespace EnglishApp
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=englishapp;port=3306;password=root");
    
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
        }


        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
