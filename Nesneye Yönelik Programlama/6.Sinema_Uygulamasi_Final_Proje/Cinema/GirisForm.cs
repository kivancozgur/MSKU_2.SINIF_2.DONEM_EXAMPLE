using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MySql.Data.MySqlClient;
namespace Cinema
{
    public partial class GirisForm : MaterialForm
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        MySqlConnection con;
        string connectionString;
        MySqlCommand com;
        MySqlDataReader rd;
        string username, password;
        int yetki;

        private void GirisForm_Load(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
                con = new MySqlConnection(connectionString);
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "SELECT * FROM kullanci_kayit";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("MYSQL BAGLANTI HATASI : " + ex.Message.ToString());
            }

        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    username = rd.GetString(1);
                    password = rd.GetString(2);
                    yetki = rd.GetInt32(3);
                    if (username == usernameTextBox.Text && password == passwordTextBox.Text)
                    {
                        if (yetki == 1)
                        {
                            SinemaForm f = new SinemaForm();
                            f.Show();
                            this.Hide();
                            break;
                        }
                        else if (yetki == 0)
                        {
                            SinemaForm f = new SinemaForm();
                            f.SinemaOlusturButton.Visible = false;
                            f.KullanicilarButton.Visible = false;
                            f.Show();
                            this.Hide();
                            break;
                        }
                    }
                    else if (username != usernameTextBox.Text && password != passwordTextBox.Text)
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                        break;
                    }
                }
                
                rd.Close();
            }
        }

        private void GirisLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitPanel.Visible = false;
            GirisPanel.Visible = true;
        }

        private void KayitButton_Click(object sender, EventArgs e)
        {
            string InsertSorgu = "INSERT INTO kullanci_kayit (id,k_adi,sifre,yetki) VALUES (NULL, '" + YeniAdText.Text + "', '" + YeniSifreText.Text + "','" + 0 + "')";

            MySqlCommand com1 = new MySqlCommand(InsertSorgu, con);
            if (com1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("KAYDEDILDI");
                KayitPanel.Visible = false;
                GirisPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("KAYIT BAŞARISIZ");
            }
        }

        private void KayitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitPanel.Visible = true;
            GirisPanel.Visible = false;
        }

        private void CikisButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
