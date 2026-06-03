namespace DİJİTAL_YOKLAMA_SİSTEMİ
{
    partial class YoklamaForm
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
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.YoklamaKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dersseç = new System.Windows.Forms.Label();
            this.öğrenciseç = new System.Windows.Forms.Label();
            this.durum = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Items.AddRange(new object[] {
            "Geldi",
            "Gelmedi"});
            this.cmbDers.Location = new System.Drawing.Point(116, 53);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 21);
            this.cmbDers.TabIndex = 0;
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(116, 101);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(121, 21);
            this.cmbOgrenci.TabIndex = 1;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(116, 152);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbDurum.TabIndex = 2;
            // 
            // YoklamaKaydet
            // 
            this.YoklamaKaydet.Location = new System.Drawing.Point(39, 201);
            this.YoklamaKaydet.Name = "YoklamaKaydet";
            this.YoklamaKaydet.Size = new System.Drawing.Size(109, 24);
            this.YoklamaKaydet.TabIndex = 3;
            this.YoklamaKaydet.Text = "Yoklama Kaydet";
            this.YoklamaKaydet.UseVisualStyleBackColor = true;
            this.YoklamaKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 207);
            this.dataGridView1.TabIndex = 4;
            // 
            // dersseç
            // 
            this.dersseç.AutoSize = true;
            this.dersseç.Location = new System.Drawing.Point(36, 53);
            this.dersseç.Name = "dersseç";
            this.dersseç.Size = new System.Drawing.Size(51, 13);
            this.dersseç.TabIndex = 5;
            this.dersseç.Text = "Ders Seç";
            // 
            // öğrenciseç
            // 
            this.öğrenciseç.AutoSize = true;
            this.öğrenciseç.Location = new System.Drawing.Point(36, 104);
            this.öğrenciseç.Name = "öğrenciseç";
            this.öğrenciseç.Size = new System.Drawing.Size(66, 13);
            this.öğrenciseç.TabIndex = 6;
            this.öğrenciseç.Text = "Öğrenci Seç";
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Location = new System.Drawing.Point(36, 152);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(38, 13);
            this.durum.TabIndex = 7;
            this.durum.Text = "Durum";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(168, 202);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gelenleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Gelmeyenleri Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YoklamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.öğrenciseç);
            this.Controls.Add(this.dersseç);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.YoklamaKaydet);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbOgrenci);
            this.Controls.Add(this.cmbDers);
            this.Name = "YoklamaForm";
            this.Text = "Yoklama Kaydet";
            this.Load += new System.EventHandler(this.YoklamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button YoklamaKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dersseç;
        private System.Windows.Forms.Label öğrenciseç;
        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}