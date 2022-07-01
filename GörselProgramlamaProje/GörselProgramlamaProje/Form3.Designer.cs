
namespace GörselProgramlamaProje
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textU_kod = new System.Windows.Forms.TextBox();
            this.textUad = new System.Windows.Forms.TextBox();
            this.textUtur = new System.Windows.Forms.TextBox();
            this.textUfiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboDepo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textUStok = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(107, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textU_kod
            // 
            this.textU_kod.Location = new System.Drawing.Point(107, 29);
            this.textU_kod.Name = "textU_kod";
            this.textU_kod.Size = new System.Drawing.Size(100, 20);
            this.textU_kod.TabIndex = 1;
            // 
            // textUad
            // 
            this.textUad.Location = new System.Drawing.Point(107, 69);
            this.textUad.Name = "textUad";
            this.textUad.Size = new System.Drawing.Size(100, 20);
            this.textUad.TabIndex = 2;
            // 
            // textUtur
            // 
            this.textUtur.Location = new System.Drawing.Point(107, 105);
            this.textUtur.Name = "textUtur";
            this.textUtur.Size = new System.Drawing.Size(100, 20);
            this.textUtur.TabIndex = 3;
            // 
            // textUfiyat
            // 
            this.textUfiyat.Location = new System.Drawing.Point(107, 137);
            this.textUfiyat.Name = "textUfiyat";
            this.textUfiyat.Size = new System.Drawing.Size(100, 20);
            this.textUfiyat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Stok :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Giriş Tarih :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 312);
            this.dataGridView1.TabIndex = 11;
            // 
            // comboDepo
            // 
            this.comboDepo.FormattingEnabled = true;
            this.comboDepo.Location = new System.Drawing.Point(107, 214);
            this.comboDepo.Name = "comboDepo";
            this.comboDepo.Size = new System.Drawing.Size(121, 21);
            this.comboDepo.TabIndex = 12;
            this.comboDepo.SelectedIndexChanged += new System.EventHandler(this.comboDepo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Depo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ürün Tür :";
            // 
            // textUStok
            // 
            this.textUStok.Location = new System.Drawing.Point(107, 173);
            this.textUStok.Name = "textUStok";
            this.textUStok.Size = new System.Drawing.Size(100, 20);
            this.textUStok.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(776, 377);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textUStok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboDepo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUfiyat);
            this.Controls.Add(this.textUtur);
            this.Controls.Add(this.textUad);
            this.Controls.Add(this.textU_kod);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textU_kod;
        private System.Windows.Forms.TextBox textUad;
        private System.Windows.Forms.TextBox textUtur;
        private System.Windows.Forms.TextBox textUfiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboDepo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUStok;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}