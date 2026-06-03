namespace DİJİTAL_YOKLAMA_SİSTEMİ
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYoklama = new System.Windows.Forms.Button();
            this.btnDers = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListe = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(274, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci İşlemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Location = new System.Drawing.Point(274, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yoklama Al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Location = new System.Drawing.Point(583, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ders İşlemleri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.Location = new System.Drawing.Point(583, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 110);
            this.button4.TabIndex = 3;
            this.button4.Text = "Yoklama Listesi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Navy;
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btnListe);
            this.panelMenu.Controls.Add(this.btnYoklama);
            this.panelMenu.Controls.Add(this.btnDers);
            this.panelMenu.Controls.Add(this.btnOgrenci);
            this.panelMenu.Controls.Add(this.btnAnaSayfa);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(184, 410);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint_1);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCikis.Location = new System.Drawing.Point(21, 338);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 31);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "🚪 Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYoklama
            // 
            this.btnYoklama.FlatAppearance.BorderSize = 0;
            this.btnYoklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoklama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYoklama.Location = new System.Drawing.Point(3, 240);
            this.btnYoklama.Name = "btnYoklama";
            this.btnYoklama.Size = new System.Drawing.Size(131, 23);
            this.btnYoklama.TabIndex = 4;
            this.btnYoklama.Text = "➡️ Yoklama Al";
            this.btnYoklama.UseVisualStyleBackColor = true;
            this.btnYoklama.Click += new System.EventHandler(this.btnYoklama_Click);
            // 
            // btnDers
            // 
            this.btnDers.FlatAppearance.BorderSize = 0;
            this.btnDers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDers.Location = new System.Drawing.Point(-1, 207);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(157, 23);
            this.btnDers.TabIndex = 3;
            this.btnDers.Text = "➡️ Ders İşlemleri";
            this.btnDers.UseVisualStyleBackColor = true;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.FlatAppearance.BorderSize = 0;
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOgrenci.Location = new System.Drawing.Point(3, 178);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(169, 23);
            this.btnOgrenci.TabIndex = 2;
            this.btnOgrenci.Text = "➡️ Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.Snow;
            this.btnAnaSayfa.Location = new System.Drawing.Point(3, 149);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(127, 23);
            this.btnAnaSayfa.TabIndex = 1;
            this.btnAnaSayfa.Text = "➡️ Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "DİJİTAL YOKLAMA SİSTEMİ";
            // 
            // btnListe
            // 
            this.btnListe.FlatAppearance.BorderSize = 0;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListe.Location = new System.Drawing.Point(-1, 269);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(151, 23);
            this.btnListe.TabIndex = 5;
            this.btnListe.Text = "➡️ Yoklama Listesi";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Dijital Yoklama Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnYoklama;
        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}

