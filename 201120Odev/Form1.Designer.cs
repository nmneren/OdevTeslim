
namespace _201120Odev
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
            this.listBox_kayıtlı = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_odenmis = new System.Windows.Forms.ListBox();
            this.btn_ode = new System.Windows.Forms.Button();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_filtre = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_odenen_ara = new System.Windows.Forms.TextBox();
            this.btn_gider_ara = new System.Windows.Forms.Button();
            this.btn_sil_odenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_kayıtlı
            // 
            this.listBox_kayıtlı.FormattingEnabled = true;
            this.listBox_kayıtlı.Location = new System.Drawing.Point(313, 61);
            this.listBox_kayıtlı.Name = "listBox_kayıtlı";
            this.listBox_kayıtlı.Size = new System.Drawing.Size(204, 251);
            this.listBox_kayıtlı.TabIndex = 0;
            this.listBox_kayıtlı.DoubleClick += new System.EventHandler(this.listBox_kayıtlı_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıtlı Ödemeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(589, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gider ve Ödenmiş Faturalar";
            // 
            // listBox_odenmis
            // 
            this.listBox_odenmis.FormattingEnabled = true;
            this.listBox_odenmis.Location = new System.Drawing.Point(560, 111);
            this.listBox_odenmis.Name = "listBox_odenmis";
            this.listBox_odenmis.Size = new System.Drawing.Size(296, 199);
            this.listBox_odenmis.TabIndex = 3;
            // 
            // btn_ode
            // 
            this.btn_ode.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ode.Location = new System.Drawing.Point(189, 123);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(75, 38);
            this.btn_ode.TabIndex = 4;
            this.btn_ode.Text = "Öde";
            this.btn_ode.UseVisualStyleBackColor = true;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(101, 62);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(163, 20);
            this.txt_isim.TabIndex = 5;
            this.txt_isim.TextChanged += new System.EventHandler(this.txt_isim_TextChanged);
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(101, 88);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(163, 20);
            this.txt_tutar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödeme İsmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ödeme Tutar";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(101, 123);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(82, 38);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(117, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gider Ödeme";
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(426, 318);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(91, 38);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.Location = new System.Drawing.Point(101, 167);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(163, 38);
            this.btn_yenile.TabIndex = 12;
            this.btn_yenile.Text = "Listeleri Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_filtre
            // 
            this.btn_filtre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_filtre.Location = new System.Drawing.Point(766, 59);
            this.btn_filtre.Name = "btn_filtre";
            this.btn_filtre.Size = new System.Drawing.Size(90, 22);
            this.btn_filtre.TabIndex = 14;
            this.btn_filtre.Text = "Filtrele";
            this.btn_filtre.UseVisualStyleBackColor = true;
            this.btn_filtre.Click += new System.EventHandler(this.btn_filtre_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // txt_odenen_ara
            // 
            this.txt_odenen_ara.Location = new System.Drawing.Point(560, 85);
            this.txt_odenen_ara.Name = "txt_odenen_ara";
            this.txt_odenen_ara.Size = new System.Drawing.Size(200, 20);
            this.txt_odenen_ara.TabIndex = 18;
            this.txt_odenen_ara.Click += new System.EventHandler(this.txt_odenen_ara_Click);
            this.txt_odenen_ara.TextChanged += new System.EventHandler(this.txt_odenen_ara_TextChanged);
            // 
            // btn_gider_ara
            // 
            this.btn_gider_ara.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gider_ara.Location = new System.Drawing.Point(766, 85);
            this.btn_gider_ara.Name = "btn_gider_ara";
            this.btn_gider_ara.Size = new System.Drawing.Size(90, 22);
            this.btn_gider_ara.TabIndex = 19;
            this.btn_gider_ara.Text = "Ara";
            this.btn_gider_ara.UseVisualStyleBackColor = true;
            this.btn_gider_ara.Click += new System.EventHandler(this.btn_gider_ara_Click);
            // 
            // btn_sil_odenen
            // 
            this.btn_sil_odenen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil_odenen.Location = new System.Drawing.Point(766, 318);
            this.btn_sil_odenen.Name = "btn_sil_odenen";
            this.btn_sil_odenen.Size = new System.Drawing.Size(91, 38);
            this.btn_sil_odenen.TabIndex = 20;
            this.btn_sil_odenen.Text = "Sil";
            this.btn_sil_odenen.UseVisualStyleBackColor = true;
            this.btn_sil_odenen.Click += new System.EventHandler(this.btn_sil_odenen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 423);
            this.Controls.Add(this.btn_sil_odenen);
            this.Controls.Add(this.btn_gider_ara);
            this.Controls.Add(this.txt_odenen_ara);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_filtre);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.listBox_odenmis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_kayıtlı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_kayıtlı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_odenmis;
        private System.Windows.Forms.Button btn_ode;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_filtre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_odenen_ara;
        private System.Windows.Forms.Button btn_gider_ara;
        private System.Windows.Forms.Button btn_sil_odenen;
    }
}

