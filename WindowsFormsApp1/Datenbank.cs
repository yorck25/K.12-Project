using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Datenbank
    {

        public void verbinden()
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd= ;database=test";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("verbindung offen");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fehler beim verbinden" + ex.ToString());
            }
            

            /*
            //Connection String für SqlGuru
            string connectionString = "server=dedi1778.your-server.de;user=sqlguru_5;database=sqlguru_db5;port=3306;password=t5Z3s4Z7uqig2bwJ";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                Console.WriteLine("Conn Open");
            }
            catch (Exception ex)
            {
                Console.WriteLine("not open" + ex.Message);
            }
            */
        }
    }
}
