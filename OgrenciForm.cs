using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DİJİTAL_YOKLAMA_SİSTEMİ.Models;

namespace DİJİTAL_YOKLAMA_SİSTEMİ
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            dataGridView1.DataSource = db.Ogrenciler.ToList();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            Ogrenci ogr = new Ogrenci();

            ogr.AdSoyad = textBox1.Text;
            ogr.Numara = Convert.ToInt32(textBox2.Text);

            db.Ogrenciler.Add(ogr);

            db.SaveChanges();

            MessageBox.Show("Öğrenci Kaydedildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cevap = MessageBox.Show(
                "Silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)

            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                YoklamaDbContext db = new YoklamaDbContext();

                var ogr = db.Ogrenciler.Find(id);

                db.Ogrenciler.Remove(ogr);

                db.SaveChanges();

                MessageBox.Show("Öğrenci Silindi");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            YoklamaDbContext db = new YoklamaDbContext();

            var ogr = db.Ogrenciler.Find(id);

            ogr.AdSoyad = textBox1.Text;
            ogr.Numara = Convert.ToInt32(textBox2.Text);

            db.SaveChanges();

            dataGridView1.DataSource = db.Ogrenciler.ToList();

            MessageBox.Show("Öğrenci Güncellendi");
        }
    }

}
