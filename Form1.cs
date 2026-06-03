using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DİJİTAL_YOKLAMA_SİSTEMİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void button2_Click(object sender, EventArgs e)
        {
            DersForm frm = new DersForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciForm frm = new OgrenciForm();
            frm.Show();        }

        private void button3_Click(object sender, EventArgs e)
        {
            YoklamaForm frm = new YoklamaForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListeForm frm = new ListeForm();
            frm.Show();
        }

        private void IblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OgrenciForm frm = new OgrenciForm();
            frm.Show();
        }

        private void btnYoklama_Click(object sender, EventArgs e)
        {
            YoklamaForm frm = new YoklamaForm();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            DersForm frm = new DersForm();
            frm.Show();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            ListeForm frm = new ListeForm();
            frm.Show();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
