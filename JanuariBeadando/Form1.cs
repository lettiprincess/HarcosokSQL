using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanuariBeadando
{
    public partial class Form1 : Form
    {
        const string AdatLetrehozasSql = "create table if not exists harcosok(id integer auto_increment primary key, nev text not null, letrehozas date not null)";
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            try
            {
                conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;");
                conn.Open();
                var letrehozas = conn.CreateCommand();
                letrehozas.CommandText = AdatLetrehozasSql;
                letrehozas.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Adatbázis hiba: " + e);
            }
        }

        private void letrehozas_Click(object sender, EventArgs e)
        {

        }
    }
}
