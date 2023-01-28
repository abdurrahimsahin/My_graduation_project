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

namespace GörselProgramlamaProje
{
    public partial class Form3 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("user=root; password=; port=3306;  database=stok; server=localhost");
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string tarih;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            veri_ekleme();
            combo_ekle();
        }
        public void veri_ekleme()
        {
            da = new MySqlDataAdapter("Select * from urun_depo_tur", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            tarih=dateTimePicker1.Value.ToShortDateString();
            cmd.CommandText = "call urun_ekleme_islemi('" + textU_kod.Text+"','"+textUad.Text+"" +
                "','"+textUtur.Text+"','"+ textUfiyat.Text + "','"+tarih+"','"+textUStok.Text+"','"+ comboDepo.Text + "')";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            veri_ekleme();
        }
        public void combo_ekle()
        {
            cmd = new MySqlCommand("select * from depo", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboDepo.Items.Add(dr["d_adi"]);
            }
            baglanti.Close();
        }

        private void comboDepo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
