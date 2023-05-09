using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hastane_otomasyon
{
    public partial class doktor_girisi : Form
    {
        public doktor_girisi()
        {
            InitializeComponent();
        }
        string constr = "server=localhost; port=3306; user=root; password=*j3483zG; database=hastane_database";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        private void button_giris_Click(object sender, EventArgs e)
        {

            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand("select * from doktor where doktor_ad='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", con);
            dr = cmd.ExecuteReader();
            string yetki = "";
            while (dr.Read())
            {
                yetki = dr["yetki_id"].ToString();
            }
            if (yetki != "")
            {
                anasayfa anasayfa = new anasayfa();
                Hide();
                anasayfa.a_yetki = yetki;
                anasayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Parola girdiniz", "Hatalı İşlem", MessageBoxButtons.YesNoCancel);
                Application.Exit();
            }
            con.Close();

        }

        private void button_iptal_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Hide();
            form.ShowDialog();
        }
    }
}
