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
    public partial class Form2 : Form
    {

        public static string yetki;
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("user=root; password=; port=3306; server=localhost; database=stok");
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable dt;
        Form3 form3;
        Form4 form4;
        Form5 form5;

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            main_form();
            baglanti.Close();
        }
        public void main_form()
        {
            cmd = new MySqlCommand("Select * from urun_depo_tur", baglanti);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }

        private void buttonEkleSil_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.panel1.Visible = false;
            form5.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("Select * from urun_depo_tur where UrunAdı LIKE '%" + textBox1.Text+"%'", baglanti);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("Select * from urun_depo_tur where UrunKod LIKE '%" + textBox2.Text + "%'", baglanti);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            try
            {
                cmd = new MySqlCommand("UPDATE urun SET u_fiyat = '" + textBox4.Text + "' WHERE u_id = '" + textBox3.Text + "' ", baglanti);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                
                MessageBox.Show("Ürün başarılı bir şekilde güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu id de bir birin bulunamadı");
            }
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("DELETE FROM urun WHERE u_id='" + textBox5.Text + "'", baglanti);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Ürün başarılı bir şekilde Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu id de bir birin bulunamadı");
            }
            panel2.Visible = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
