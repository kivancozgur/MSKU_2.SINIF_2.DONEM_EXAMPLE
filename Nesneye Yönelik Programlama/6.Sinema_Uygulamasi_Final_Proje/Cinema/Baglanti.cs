using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Cinema
{
    class Baglanti
    {
        private MySqlConnection CON;
        string connectionString = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
        public MySqlConnection con {
            get { return CON; }
            set { CON = value; }
        }

        public string bilgimetin;
        public Baglanti()
        {
            con = new MySqlConnection(connectionString);
            this.con.Open();
        }
        public void BaglantiKapat()
        {
            this.con.Close();
        }

        public void FilmSilGuncelleEkle(string sorgu)
        {
            con = new MySqlConnection(connectionString);
            MySqlCommand com = new MySqlCommand(sorgu, con);
            con.Open();
            if (com.ExecuteNonQuery() > 0)
            {

                bilgimetin = "KAYDEDILDI" +
                    "";
                con.Close();
            }
            else
            {
                bilgimetin = "KAYIT BAŞARISIZ";
                con.Close();
            }
        }
        public void KayitSilGuncelleEkle(string sorgu)
        {
            con = new MySqlConnection(connectionString);
            MySqlCommand com = new MySqlCommand(sorgu, con);
            con.Open();
            if (com.ExecuteNonQuery() > 0)
            {

                bilgimetin = "KAYDEDILDI";
                con.Close();
            }
            else
            {
                bilgimetin = "KAYIT BAŞARISIZ";
                con.Close();
            }
        }
    }
}
