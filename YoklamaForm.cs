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
    public partial class YoklamaForm : Form
    {
        public YoklamaForm()
        {
            ;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            YoklamaKayit kayit = new YoklamaKayit();

            kayit.OgrenciId = Convert.ToInt32(cmbOgrenci.SelectedValue);
            kayit.OturumId = 1;
            kayit.Durum = cmbDurum.Text;

            kayit.OgrenciEnlem = 41.0082;
            kayit.OgrenciBoylam = 28.9784;

            db.YoklamaKayitleri.Add(kayit);
            db.SaveChanges();

            dataGridView1.DataSource = db.YoklamaKayitleri.ToList();

            MessageBox.Show("Yoklama kaydedildi.");


        }

        private void YoklamaForm_Load(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            cmbDers.DataSource = db.Dersler.ToList();
            cmbDers.DisplayMember = "DersAdi";
            cmbDers.ValueMember = "Id";

            cmbOgrenci.DataSource = db.Ogrenciler.ToList();
            cmbOgrenci.DisplayMember = "AdSoyad";
            cmbOgrenci.ValueMember = "Id";

            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Geldi");
            cmbDurum.Items.Add("Gelmedi");
            cmbDurum.SelectedIndex = 0;

            dataGridView1.DataSource = db.YoklamaKayitleri.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                DialogResult sonuc = MessageBox.Show(
                    "Bu kaydı silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if(sonuc == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(
                        dataGridView1.CurrentRow.Cells["KayitId"].Value);

                    YoklamaDbContext db = new YoklamaDbContext();

                    var kayit = db.YoklamaKayitleri.Find(id);

                    if (kayit !=null )
                    {
                        db.YoklamaKayitleri.Remove(kayit);
                        db.SaveChanges();

                        dataGridView1.DataSource =
                            db.YoklamaKayitleri.ToList();

                        MessageBox.Show("Kayıt silindi.");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            var gelenler = db.YoklamaKayitleri
                 .Where(x => x.Durum == "Geldi")
                 .ToList();

            dataGridView1.DataSource = gelenler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            var gelmeyenler = db.YoklamaKayitleri
                .Where(x => x.Durum == "Gelmedi")
                .ToList();

            dataGridView1.DataSource = gelmeyenler;
        }
    }
}

