namespace WindowsFormsApp1
{
    partial class Frm_Fatura
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstVw_FatIcerigi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_ToplamTutar = new System.Windows.Forms.Label();
            this.Lbl_Kdv = new System.Windows.Forms.Label();
            this.Lbl_Tutar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Lbl_Tarih = new System.Windows.Forms.Label();
            this.Lbl_Alici = new System.Windows.Forms.Label();
            this.Lbl_FatNo = new System.Windows.Forms.Label();
            this.Lbl_Gonderen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LstVw_FatIcerigi);
            this.groupBox2.Location = new System.Drawing.Point(232, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 602);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura İçerik";
            // 
            // LstVw_FatIcerigi
            // 
            this.LstVw_FatIcerigi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.LstVw_FatIcerigi.HideSelection = false;
            this.LstVw_FatIcerigi.Location = new System.Drawing.Point(12, 18);
            this.LstVw_FatIcerigi.Name = "LstVw_FatIcerigi";
            this.LstVw_FatIcerigi.Size = new System.Drawing.Size(801, 578);
            this.LstVw_FatIcerigi.TabIndex = 3;
            this.LstVw_FatIcerigi.UseCompatibleStateImageBehavior = false;
            this.LstVw_FatIcerigi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Barkod";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Marka";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Model";
            this.columnHeader8.Width = 51;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Renk";
            this.columnHeader15.Width = 43;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Beden";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Adet";
            this.columnHeader17.Width = 51;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Birim Fiyat";
            this.columnHeader18.Width = 76;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Kdv";
            this.columnHeader19.Width = 55;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Toplam Tutar";
            this.columnHeader20.Width = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_ToplamTutar);
            this.groupBox1.Controls.Add(this.Lbl_Kdv);
            this.groupBox1.Controls.Add(this.Lbl_Tutar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Lbl_Tarih);
            this.groupBox1.Controls.Add(this.Lbl_Alici);
            this.groupBox1.Controls.Add(this.Lbl_FatNo);
            this.groupBox1.Controls.Add(this.Lbl_Gonderen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // Lbl_ToplamTutar
            // 
            this.Lbl_ToplamTutar.AutoSize = true;
            this.Lbl_ToplamTutar.Location = new System.Drawing.Point(89, 180);
            this.Lbl_ToplamTutar.Name = "Lbl_ToplamTutar";
            this.Lbl_ToplamTutar.Size = new System.Drawing.Size(16, 13);
            this.Lbl_ToplamTutar.TabIndex = 8;
            this.Lbl_ToplamTutar.Text = "...";
            // 
            // Lbl_Kdv
            // 
            this.Lbl_Kdv.AutoSize = true;
            this.Lbl_Kdv.Location = new System.Drawing.Point(89, 153);
            this.Lbl_Kdv.Name = "Lbl_Kdv";
            this.Lbl_Kdv.Size = new System.Drawing.Size(16, 13);
            this.Lbl_Kdv.TabIndex = 9;
            this.Lbl_Kdv.Text = "...";
            // 
            // Lbl_Tutar
            // 
            this.Lbl_Tutar.AutoSize = true;
            this.Lbl_Tutar.Location = new System.Drawing.Point(89, 126);
            this.Lbl_Tutar.Name = "Lbl_Tutar";
            this.Lbl_Tutar.Size = new System.Drawing.Size(16, 13);
            this.Lbl_Tutar.TabIndex = 10;
            this.Lbl_Tutar.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Toplam Tutar :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kdv :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tutar :";
            // 
            // Lbl_Tarih
            // 
            this.Lbl_Tarih.AutoSize = true;
            this.Lbl_Tarih.Location = new System.Drawing.Point(89, 99);
            this.Lbl_Tarih.Name = "Lbl_Tarih";
            this.Lbl_Tarih.Size = new System.Drawing.Size(16, 13);
            this.Lbl_Tarih.TabIndex = 1;
            this.Lbl_Tarih.Text = "...";
            // 
            // Lbl_Alici
            // 
            this.Lbl_Alici.AutoSize = true;
            this.Lbl_Alici.Location = new System.Drawing.Point(89, 72);
            this.Lbl_Alici.Name = "Lbl_Alici";
            this.Lbl_Alici.Size = new System.Drawing.Size(16, 13);
            this.Lbl_Alici.TabIndex = 2;
            this.Lbl_Alici.Text = "...";
            // 
            // Lbl_FatNo
            // 
            this.Lbl_FatNo.AutoSize = true;
            this.Lbl_FatNo.Location = new System.Drawing.Point(89, 18);
            this.Lbl_FatNo.Name = "Lbl_FatNo";
            this.Lbl_FatNo.Size = new System.Drawing.Size(16, 13);
            this.Lbl_FatNo.TabIndex = 3;
            this.Lbl_FatNo.Text = "...";
            // 
            // Lbl_Gonderen
            // 
            this.Lbl_Gonderen.AutoSize = true;
            this.Lbl_Gonderen.Location = new System.Drawing.Point(89, 45);
            this.Lbl_Gonderen.Name = "Lbl_Gonderen";
            this.Lbl_Gonderen.Size = new System.Drawing.Size(16, 13);
            this.Lbl_Gonderen.TabIndex = 4;
            this.Lbl_Gonderen.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alıcı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gönderen :";
            // 
            // Frm_Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Fatura";
            this.Load += new System.EventHandler(this.Frm_Fatura_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView LstVw_FatIcerigi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        public System.Windows.Forms.Label Lbl_ToplamTutar;
        public System.Windows.Forms.Label Lbl_Kdv;
        public System.Windows.Forms.Label Lbl_Tutar;
        public System.Windows.Forms.Label Lbl_Tarih;
        public System.Windows.Forms.Label Lbl_Alici;
        public System.Windows.Forms.Label Lbl_FatNo;
        public System.Windows.Forms.Label Lbl_Gonderen;
    }
}