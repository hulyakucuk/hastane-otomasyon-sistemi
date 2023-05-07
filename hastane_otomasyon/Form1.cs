using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hastane_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string constr = "server=localhost; port=3306; user=root; password=*j3483zG; database=hastane_database";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        private void button_giris_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand("select * from kullanicilar where k_ad='" + textBox_ad.Text + "' and k_parola='" + textBox_parola.Text + "'", con);
            dr=cmd.ExecuteReader();
            string yetki = "";
            while (dr.Read())
            {
                yetki = dr["yetki"].ToString();
            }
            if (yetki != "")
            {
                anasayfa yonlendirilecek_sayfa = new anasayfa();
                Hide(); //mevcutta bulundugun form kapatilip yeni sayfa acılır
                anasayfa.a_yetki = yetki;
                yonlendirilecek_sayfa.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
            con.Close();
           
        }
    }
}
