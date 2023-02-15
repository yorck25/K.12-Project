using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class cKostenstelle
    { 
        public static List<Kostenstelle> liste = new List<Kostenstelle>();

        public long? Kst_ID { get; set; } = null;
        public string Kst_Bez { get; set; }

        public void Spiechern()
        {
            Datenbank d = new Datenbank();
            d.verbinden();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader rdr = cmd.ExecuteReader();

        }
    }
}
