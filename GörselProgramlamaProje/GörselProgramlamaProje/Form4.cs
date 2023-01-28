using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace GörselProgramlamaProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost; user=root; password=; port=3306; database=stok");
        MySqlDataAdapter da;
        DataSet ds;
        

        private void Form4_Load(object sender, EventArgs e)
        {
            veri_aktar();
        }
        public void veri_aktar()
        {
            da = new MySqlDataAdapter("select * from urun_depo_tur", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urun_depo_tur");
            dataGridView1.DataSource = ds.Tables["urun_depo_tur"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }
    }
}
