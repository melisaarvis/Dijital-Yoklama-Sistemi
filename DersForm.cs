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
    public partial class DersForm : Form
    {
        YoklamaDbContext db = new YoklamaDbContext();
        public DersForm()
        {
            InitializeComponent();
        }

        private void DersForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDersKodu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ders d = new Ders();

            d.DersAdi = txtDersAdi.Text;
            d.DersKodu = txtDersKodu.Text;

            db.Set<Ders>().Add(d);
            db.SaveChanges();

            MessageBox.Show("Ders Kaydedildi");

        }



        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Set<Ders>().ToList();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show(
                "Silmek istediğinizden emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)

            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                var ders = db.Set<Ders>().Find(id);

                db.Set<Ders>().Remove(ders);
                db.SaveChanges();

                dataGridView1.DataSource = db.Set<Ders>().ToList();

                MessageBox.Show("Ders Silindi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var ders = db.Set<Ders>().Find(id);

            ders.DersAdi = txtDersAdi.Text;
            ders.DersKodu = txtDersKodu.Text;

            db.SaveChanges();

            dataGridView1.DataSource = db.Set<Ders>().ToList();

            MessageBox.Show("Ders Güncellendi");


        }
    }
}
