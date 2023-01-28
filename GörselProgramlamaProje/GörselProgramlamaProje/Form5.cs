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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("user=root; password=; port=3306;  database=stok; server=localhost");
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void Form5_Load(object sender, EventArgs e)
        {
            veri_goruntule();
            combo_ekle();
            combo_ekle2();
        }
        public void veri_goruntule()
        {
            da = new MySqlDataAdapter("Select * from kullanıcı_bilgi_yetki", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kullanıcı_bilgi_yetki");
            dataGridView1.DataSource = ds.Tables["kullanıcı_bilgi_yetki"];
            baglanti.Close();
        }
        public void combo_ekle()
        {
            cmd = new MySqlCommand("select * from kullanici_yetki", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["y_ad"]);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "call kullanici_ekleme_islemi('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarılı bir şekilde eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı eklenemedi");
            }
            baglanti.Close();
            veri_goruntule();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "delete from kullanici_bilgi where k_ad='" + textBox1.Text+ "';";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarılı bir şekilde silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Silinemedi");
            }
            baglanti.Close();
            veri_goruntule();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        public void combo_ekle2()
        {
            cmd = new MySqlCommand("select * from kullanici_yetki", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["y_ad"]);
            }
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "call kullanici_guncelleme_islemi("+textBox5.Text+",'"+textBox3.Text+"','"+textBox4.Text+"', '"+comboBox2.Text+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarılı bir şekilde güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncellenemedi");
            }
            baglanti.Close();
            veri_goruntule();
            panel1.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
