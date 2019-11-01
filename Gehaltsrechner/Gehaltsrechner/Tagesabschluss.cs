using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Gehaltsrechner
{
    public class Tagesabschluss
    {
        public DateTime Datum { get; set; }
        public double Tagesgehalt { get; set; }

        public Tagesabschluss()
        {
            ExecuteQuery();
        }

        private string connectionString;
        private MySqlConnection connection;
        string myConnectionString = "server=localhost;database=testDB;uid=root;pwd=abc123;";

        //Wenn Button gedrückt wird, sollte ein neuer Tagesabschluss erstellt werden.
        public void SaveTagesabschlussToDatabase()
        {

        }

        private void SetConnectionString()
        {
            connectionString = @"server=localhost;userid=root;
            database=martengehalt";
        }

        private void OpenDbConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        public void ExecuteQuery()
        {
            DBConnection dbCon = DBConnection.Instance();
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT * FROM mysqltest";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    MessageBox.Show(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                dbCon.Close();
            }


        }

    }
}
