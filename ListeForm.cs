using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DİJİTAL_YOKLAMA_SİSTEMİ
{
    public partial class ListeForm : Form
    {
        public ListeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeForm_Load(object sender, EventArgs e)
        {
            YoklamaDbContext db = new YoklamaDbContext();

            dataGridView1.DataSource = db.YoklamaKayitleri.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DialogResult cevap = MessageBox.Show(
                "Bu kaydı silmek istediğinize emin misiniz?",
                "Silme onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes )
            { 

                int id = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["KayitId"].Value);

                YoklamaDbContext db = new YoklamaDbContext();

                var kayit = db.YoklamaKayitleri.Find(id);

                if (kayit != null )
                {

                    db.YoklamaKayitleri.Remove(kayit);
                    db.SaveChanges();

                    dataGridView1.DataSource =
                        db.YoklamaKayitleri.ToList();

                    MessageBox.Show("Kayıt Silindi.");
                }
            }
        }
    }
}
