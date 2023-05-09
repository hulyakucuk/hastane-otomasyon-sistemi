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

  

        private void button_hasta_Click(object sender, EventArgs e)
        {
            hasta_girisi hasta_girisi = new hasta_girisi();
            Hide();
            hasta_girisi.ShowDialog();
        }

        private void button_doktor_Click(object sender, EventArgs e)
        {
            doktor_girisi doktor_girisi = new doktor_girisi();
            Hide();
            doktor_girisi.ShowDialog();
        }
    }
}
