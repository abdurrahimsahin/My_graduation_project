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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("user=root; password=; port=3306; server=localhost; database=stok");
        MySqlDataAdapter da;
        DataTable dt;
        Form2 form2__;
        public string yetkix;
         

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new MySqlDataAdapter("Select * from kullanici_bilgi where k_ad='"+textBox1.Text+"' and k_sifre='"+textBox2.Text+"'", baglanti);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                form2__ = new Form2();
                form2__.panel1.Visible = false;
                form2__.panel2.Visible = false;
                yetkix = dt.Rows[0]["y_id"].ToString() ;
                if (yetkix == "1" || yetkix== "2")
                {
                    form2__.groupBox3.Visible = true;
                    form2__.button3.Visible = true;
                    form2__.Show();
                }
                else if (yetkix == "3")
                {
                    form2__.groupBox3.Visible = false;
                    form2__.button3.Visible = true;
                    form2__.Show();
                }
                else
                {
                    form2__.groupBox3.Visible = false;
                    form2__.button3.Visible = false;
                    form2__.Show();
                }
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
