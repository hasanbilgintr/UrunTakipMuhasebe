using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class mhsb : Form
    {
        public mhsb()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        Frm_Fatura frm_fat = (Frm_Fatura)Application.OpenForms["Frm_Fatura"];

        private void mhsb_Load(object sender, EventArgs e)
        {
            SatOnayBekleyenler();
            SatOnaylanan();
            SatIptaller();
            AlisOnayBekleyenler();
            AlisOnaylananlar();
            AlisIptaller();
            GiderList();
        }

        private void GiderList()
        {
            LstVw_GiderList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Kasa", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = oku["FatNo"].ToString();
                item.SubItems.Add(oku["Kdv"].ToString());
                item.SubItems.Add(oku["ToplamTutar"].ToString());
                item.SubItems.Add(oku["Aciklama"].ToString());
                item.SubItems.Add(oku["Tarih"].ToString());
                LstVw_GiderList.Items.Add(item);
            }
            bgl.baglanti();
        }

        private void AlisIptaller()
        {
            LstVw_AlisIptalList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Islem=0  and FatTipiID=2", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_AlisIptalList.Items.Add(kayıt);
            }
            bgl.baglanti().Close();
        }

        private void AlisOnaylananlar()
        {
            LstVw_AlisOnaylananList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Islem=1 and FatTipiID=2", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_AlisOnaylananList.Items.Add(kayıt);
            }
            bgl.baglanti().Close();
        }

        private void AlisOnayBekleyenler()
        {
            LstVw_AlisOnayBekleList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Islem is null and  FatTipiID=2", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_AlisOnayBekleList.Items.Add(kayıt);
            }
            bgl.baglanti().Close();
        }

        private void SatOnaylanan()
        {
            LstVw_SatOnaylanan.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Islem=1 and FatTipiID=1", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(MagazaAdi(int.Parse(oku["AliciID"].ToString())));
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_SatOnaylanan.Items.Add(kayıt);
            }
            bgl.baglanti().Close();
        }

        private void SatOnayBekleyenler()
        {
            LstVw_SatOnayBekle.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Islem is null and FatTipiID=1", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["IrsNo"].ToString());
                kayıt.SubItems.Add(MagazaAdi(int.Parse(oku["AliciID"].ToString())));
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_SatOnayBekle.Items.Add(kayıt);
            }
            bgl.baglanti().Close();
        }

        private void SatIptaller()
        {
            LstVw_SatIptaller.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Islem =0  and FatTipiID=1", bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["IrsNo"].ToString());
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_SatIptaller.Items.Add(kayıt);
            }
            bgl.baglanti().Close();
        }

        private string MagazaAdi(int magid)
        {
            SqlCommand kmt = new SqlCommand("select *from Tbl_Magaza where MagID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", magid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["Ad"].ToString();
            }
            return "";
        }

        private string TedFirma(int Tedfirmaid)
        {
            SqlCommand kmt = new SqlCommand("select *from Tbl_TedFirma where TedFirmaID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", Tedfirmaid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["TedFirma"].ToString();
            }
            return "";
        }

        int EsID = 0;

        private void LstVw_SatOnayBekle_MouseClick(object sender, MouseEventArgs e)
        {
            EsID = int.Parse(LstVw_SatOnayBekle.SelectedItems[0].SubItems[0].Text);
        }

        private void Btn_FatOlusVeYaz_Click(object sender, EventArgs e)
        {
            if (EsID > 0 && !string.IsNullOrWhiteSpace(Txt_FatNo.Text))
            {
                if (MessageBox.Show("Fatura Onaylama", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string aciklama = Interaction.InputBox("Açıklama Giriniz ", "Açıklama Kutusu", "");
                    SqlCommand kmt = new SqlCommand("update Tbl_Esleme  set FatNo=@p2 ,Islem=1,IslemYapan=@p3 ,Aciklama=@p4 where EsID=@p1", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", EsID);
                    kmt.Parameters.AddWithValue("@p2", Txt_FatNo.Text);
                    kmt.Parameters.AddWithValue("@p3", "usermuhasebe");
                    kmt.Parameters.AddWithValue("@p4", aciklama);
                    if (kmt.ExecuteNonQuery() > 0)
                    {
                        DialogResult pdr2 = printDialog1.ShowDialog();
                        if (pdr2 == DialogResult.OK)
                        {
                            printDocument1.Print();
                        }
                        SatOnaylanan();
                        SatOnayBekleyenler();

                    }
                    else { MessageBox.Show("Fatura Onaylama Başarısız"); }
                }
                else { MessageBox.Show("işlem iptal"); }
            }
            else { MessageBox.Show("Lütfen Seçim ve Fatura No Giriniz"); }
        }

        private void Btn_SatOnaybekleListYenile_Click(object sender, EventArgs e)
        {
            SatOnayBekleyenler();
        }

        private void Btn_SatOnayBekleFatIptal_Click(object sender, EventArgs e)
        {
            if (EsID > 0)
            {
                if (MessageBox.Show("Fatura Iptal", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand kmt = new SqlCommand("update Tbl_Esleme  set  Islem=0,IslemYapan=@p2 where EsID=@p1", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", EsID);
                    kmt.Parameters.AddWithValue("@p2", "usermuhasebe");
                    if (kmt.ExecuteNonQuery() > 0)
                    {
                        SatIptaller();
                        SatOnayBekleyenler();
                        MessageBox.Show("Fatura İptal Başarılı");
                    }
                    else { MessageBox.Show("Fatura İptal Başarısız"); }
                }
                else { MessageBox.Show("işlem iptal"); }
            }
            else { MessageBox.Show("Lütfen Seçim Yapınız"); }
        }

        private void Btn_SatOnaylananListYenile_Click(object sender, EventArgs e)
        {
            Btn_SatOnayListYaz.Enabled = true;
            LstVw_SatOnaylanan.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Tarih>=@p1 and Tarih<=@p2 and Islem=1 and FatTipiID=1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", DateTime.Parse(Date_SatOnaylıBasTarih.Value.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p2", DateTime.Parse(Date_SatOnaylıBitTarih.Value.ToShortDateString()));
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(MagazaAdi(int.Parse(oku["AliciID"].ToString())));
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_SatOnaylanan.Items.Add(kayıt);
            }
            oku.Close();


            decimal tkdv = 0;
            decimal ttutar = 0;

            if (LstVw_SatOnaylanan.Items.Count > 0)
            {
                for (int i = 0; i < LstVw_SatOnaylanan.Items.Count; i++)
                {
                    tkdv = tkdv + decimal.Parse(LstVw_SatOnaylanan.Items[i].SubItems[4].Text);
                    ttutar = ttutar + decimal.Parse(LstVw_SatOnaylanan.Items[i].SubItems[5].Text);
                }
            }
            Lbl_SatOTKdv.Text = tkdv.ToString() + " TL";
            Lbl_SatOTTutar.Text = ttutar.ToString() + " TL";

            bgl.baglanti().Close();
        }

        private void Btn_SatIptalListYenile_Click(object sender, EventArgs e)
        {
            Btn_SatIptalListYaz.Enabled = true;

            LstVw_SatIptaller.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Tarih>=@p1 and Tarih<=@p2 and Islem=0 and FatTipiID=1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", DateTime.Parse(Date_SatIptalBasTarih.Value.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p2", DateTime.Parse(Date_SatIptalBitTarih.Value.ToShortDateString()));
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["IrsNo"].ToString());
                kayıt.SubItems.Add(MagazaAdi(int.Parse(oku["AliciID"].ToString())));
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_SatIptaller.Items.Add(kayıt);
            }
            oku.Close();

            decimal tkdv = 0;
            decimal ttutar = 0;

            if (LstVw_SatIptaller.Items.Count > 0)
            {
                for (int i = 0; i < LstVw_SatIptaller.Items.Count; i++)
                {
                    tkdv = tkdv + decimal.Parse(LstVw_SatIptaller.Items[i].SubItems[4].Text);
                    ttutar = ttutar + decimal.Parse(LstVw_SatIptaller.Items[i].SubItems[5].Text);
                }
            }
            Lbl_SatITKdv.Text = tkdv.ToString() + " TL";
            Lbl_SatITTutar.Text = ttutar.ToString() + " TL";
            bgl.baglanti().Close();
        }

        private void Btn_SatOnayBekleFatGor_Click(object sender, EventArgs e)
        {
            FatIcerik();
        }

        public void FatIcerik()
        {
            frm_fat = new Frm_Fatura();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where  EsID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", EsID);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                if (!string.IsNullOrWhiteSpace(oku["AliciID"].ToString()))
                {
                    frm_fat.Lbl_Alici.Text = MagazaAdi(int.Parse(oku["AliciID"].ToString()));
                }
                if (!string.IsNullOrWhiteSpace(oku["GondericiID"].ToString()))
                {
                    frm_fat.Lbl_Gonderen.Text = TedFirma(int.Parse(oku["GondericiID"].ToString()));
                }
                if (!string.IsNullOrWhiteSpace(oku["FatNo"].ToString()))
                {
                    frm_fat.Lbl_FatNo.Text = oku["FatNo"].ToString();
                }
                frm_fat.Lbl_Tarih.Text = oku["Tarih"].ToString();
                frm_fat.Lbl_Tutar.Text = oku["BirimFiyat"].ToString() + " TL";
                frm_fat.Lbl_Kdv.Text = oku["Kdv"].ToString() + " TL";
                frm_fat.Lbl_ToplamTutar.Text = oku["ToplamTutar"].ToString() + " TL";
                SqlCommand kmt2 = new SqlCommand("select *from Tbl_Irsaliye where IrsNo=@p1", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p1", oku["IrsNo"].ToString());
                SqlDataReader oku2 = kmt2.ExecuteReader();
                while (oku2.Read())
                {
                    SqlCommand kmturun = new SqlCommand("select *from Tbl_UrunDetay where BarkodNo=@p1", bgl.baglanti());
                    kmturun.Parameters.AddWithValue("@p1", oku2["Barkod"].ToString());
                    SqlDataReader urunoku = kmturun.ExecuteReader();
                    while (urunoku.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = urunoku["UrunDtyID"].ToString();
                        item.SubItems.Add(urunoku["BarkodNo"].ToString());
                        item.SubItems.Add(UrunAdi(int.Parse(urunoku["UrunID"].ToString())));
                        item.SubItems.Add(MarkaAdi(int.Parse(urunoku["MarkaID"].ToString())));
                        item.SubItems.Add(ModelAdi(int.Parse(urunoku["ModelID"].ToString())));
                        item.SubItems.Add(RenkAdi(int.Parse(urunoku["RenkID"].ToString())));
                        item.SubItems.Add(BedenAdi(int.Parse(urunoku["BedenID"].ToString())));
                        item.SubItems.Add(oku2["Adet"].ToString());
                        item.SubItems.Add(oku2["BirimFiyat"].ToString());
                        item.SubItems.Add(oku2["Kdv"].ToString() + " %");
                        item.SubItems.Add(oku2["ToplamFiyat"].ToString());
                        frm_fat.LstVw_FatIcerigi.Items.Add(item);
                    }
                }
            }
            bgl.baglanti().Close();
            frm_fat.ShowDialog();
        }

        public string UrunAdi(int urunid)
        {
            SqlCommand kmt = new SqlCommand("Select *from Tbl_Urun where UrunID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["Urun"].ToString();
            }
            return "";
        }

        public string MarkaAdi(int Markaid)
        {
            SqlCommand kmt = new SqlCommand("Select *from Tbl_Marka where MarkaID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", Markaid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["Marka"].ToString();
            }
            return "";
        }

        public string ModelAdi(int Modelid)
        {
            SqlCommand kmt = new SqlCommand("Select *from Tbl_Model where ModelID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", Modelid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["Model"].ToString();
            }
            return "";
        }

        public string RenkAdi(int renkid)
        {
            SqlCommand kmt = new SqlCommand("Select *from Tbl_Renk where RenkID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", renkid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["Renk"].ToString();
            }
            return "";
        }

        public string BedenAdi(int bedenid)
        {
            SqlCommand kmt = new SqlCommand("Select *from Tbl_Beden where BedenID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", bedenid);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                return oku["Beden"].ToString();
            }
            return "";
        }

        private void Btn_SatOnaylananFatGor_Click(object sender, EventArgs e)
        {
            FatIcerik();
        }

        private void LstVw_SatOnaylanan_MouseClick(object sender, MouseEventArgs e)
        {
            EsID = int.Parse(LstVw_SatOnaylanan.SelectedItems[0].SubItems[0].Text);
        }

        private void Btn_SatIptalFatGor_Click(object sender, EventArgs e)
        {
            FatIcerik();
        }

        private void LstVw_SatIptaller_MouseClick(object sender, MouseEventArgs e)
        {
            EsID = int.Parse(LstVw_SatIptaller.SelectedItems[0].SubItems[0].Text);
        }

        private void Btn_AlisOnayBekleListYenile_Click(object sender, EventArgs e)
        {
            AlisOnayBekleyenler();
        }

        private void Btn_AlisOnayBekleFatIcerik_Click(object sender, EventArgs e)
        {
            FatIcerik();
        }

        private void Btn_AlisOnaylananFatIcerik_Click(object sender, EventArgs e)
        {
            FatIcerik();
        }

        private void Btn_AlisIptalFatIcerik_Click(object sender, EventArgs e)
        {
            FatIcerik();
        }

        private void LstVw_AlisOnayBekleList_MouseClick(object sender, MouseEventArgs e)
        {
            EsID = int.Parse(LstVw_AlisOnayBekleList.SelectedItems[0].SubItems[0].Text);
        }

        private void LstVw_AlisOnaylananList_MouseClick(object sender, MouseEventArgs e)
        {
            EsID = int.Parse(LstVw_AlisOnaylananList.SelectedItems[0].SubItems[0].Text);
        }

        private void LstVw_AlisIptalList_MouseClick(object sender, MouseEventArgs e)
        {
            EsID = int.Parse(LstVw_AlisIptalList.SelectedItems[0].SubItems[0].Text);
        }

        private void Btn_AlisOnayBekleFatIptal_Click(object sender, EventArgs e)
        {
            if (EsID > 0)
            {
                if (MessageBox.Show("Fatura Iptal", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand kmt = new SqlCommand("Update Tbl_Esleme set Islem=0 , IslemYapan=@p2 where EsID=@p1", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", EsID);
                    kmt.Parameters.AddWithValue("@p2", "usermuhasebe");
                    if (kmt.ExecuteNonQuery() > 0)
                    {
                        AlisIptaller();
                        AlisOnayBekleyenler();
                        MessageBox.Show("Fatura İptal Başarılı");
                    }
                    else { MessageBox.Show("Fatura İptal Başarısız"); }
                }
                else { MessageBox.Show("işlem iptal"); }
            }
            else { MessageBox.Show("Lütfen Seçim Yapınız"); }
        }

        private void Btn_AlisOnaylananListYenile_Click(object sender, EventArgs e)
        {
            Btn_AlisOnayListYaz.Enabled = true;

            LstVw_AlisOnaylananList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Tarih>=@p1 and Tarih<=@p2 and Islem=1  and  FatTipiID=2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", DateTime.Parse(Date_AlisOnayBasTarihi.Value.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p2", DateTime.Parse(Date_AlisOnayBitTarihi.Value.ToShortDateString()));
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_AlisOnaylananList.Items.Add(kayıt);
            }
            oku.Close();
            decimal tkdv = 0;
            decimal ttutar = 0;

            if (LstVw_AlisOnaylananList.Items.Count > 0)
            {
                for (int i = 0; i < LstVw_AlisOnaylananList.Items.Count; i++)
                {
                    tkdv = tkdv + decimal.Parse(LstVw_AlisOnaylananList.Items[i].SubItems[3].Text);
                    ttutar = ttutar + decimal.Parse(LstVw_AlisOnaylananList.Items[i].SubItems[4].Text);
                }
            }
            Lbl_AlisOTKdv.Text = tkdv.ToString() + " TL";
            Lbl_AlisOTTutar.Text = ttutar.ToString() + " TL";

            bgl.baglanti().Close();
        }

        private void Btn_AlisOnayBekleFAtOnayla_Click(object sender, EventArgs e)
        {
            if (EsID > 0)
            {
                if (MessageBox.Show("Fatura Onaylama", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string aciklama = Interaction.InputBox("Açıklama Giriniz ", "Açıklama Kutusu", "");
                    SqlCommand kmt = new SqlCommand("update Tbl_Esleme  set Islem=1,IslemYapan=@p2 ,Aciklama=@p3 where EsID=@p1", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", EsID);
                    kmt.Parameters.AddWithValue("@p2", "usermuhasebe");
                    kmt.Parameters.AddWithValue("@p3", aciklama);
                    if (kmt.ExecuteNonQuery() > 0)
                    {
                        AlisOnaylananlar();
                        AlisOnayBekleyenler();
                        MessageBox.Show("Fatura Onaylama Başarılı");
                    }
                    else { MessageBox.Show("Fatura Onaylama Başarısız"); }
                }
                else { MessageBox.Show("işlem iptal"); }
            }
            else { MessageBox.Show("Lütfen Seçim Yapınız"); }
        }

        private void Btn_AlisIptalListYenile_Click(object sender, EventArgs e)
        {
            Btn_AlisIptalListYaz.Enabled = true;
            LstVw_AlisIptalList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where Tarih>=@p1 and Tarih<=@p2 and Islem=0  and  FatTipiID=2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", DateTime.Parse(Date_AlisIptalBasTarihi.Value.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p2", DateTime.Parse(Date_AlisIptalBitTarihi.Value.ToShortDateString()));
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["EsID"].ToString();
                kayıt.SubItems.Add(oku["FatNo"].ToString());
                kayıt.SubItems.Add(oku["BirimFiyat"].ToString());
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                kayıt.SubItems.Add(oku["Hazirlayan"].ToString());
                kayıt.SubItems.Add(oku["IslemYapan"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                LstVw_AlisIptalList.Items.Add(kayıt);
            }
            oku.Close();
            decimal tkdv = 0;
            decimal ttutar = 0;

            if (LstVw_AlisIptalList.Items.Count > 0)
            {
                for (int i = 0; i < LstVw_AlisIptalList.Items.Count; i++)
                {
                    tkdv = tkdv + decimal.Parse(LstVw_AlisIptalList.Items[i].SubItems[3].Text);
                    ttutar = ttutar + decimal.Parse(LstVw_AlisIptalList.Items[i].SubItems[4].Text);
                }
            }
            Lbl_AlisITKdv.Text = tkdv.ToString() + " TL";
            Lbl_AlisITTutar.Text = ttutar.ToString() + " TL";

            bgl.baglanti().Close();
        }

        private void Btn_GidEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_GidUrun.Text) && !string.IsNullOrWhiteSpace(Txt_GidAdet.Text) && !string.IsNullOrWhiteSpace(Txt_GidKdv.Text) && !string.IsNullOrWhiteSpace(Txt_GidTTutar.Text))
            {
                ListViewItem item = new ListViewItem();
                item.Text = Txt_GidUrun.Text;
                item.SubItems.Add(Txt_GidAdet.Text);
                item.SubItems.Add(Txt_GidKdv.Text);
                item.SubItems.Add(Txt_GidTTutar.Text);
                LstVw_FatIcerikList.Items.Add(item);
                Txt_GidUrun.Clear();
                Txt_GidAdet.Clear();
                Txt_GidKdv.Clear();
                Txt_GidTTutar.Clear();
                Txt_GidUrun.Focus();
            }
            else { MessageBox.Show("Lütfen Ürün Adet Birim Fiyatı ve kdv yi boş bırakmayınız "); }
        }

        private void Btn_GidListYenile_Click(object sender, EventArgs e)
        {
            LstVw_GiderList.Items.Clear();
            SqlCommand kmt = new SqlCommand("select *from Tbl_Kasa where Tarih>=@p1 and Tarih<=@p2  ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", DateTime.Parse(Date_GidBasTarihi.Value.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p2", DateTime.Parse(Date_GidBitTarihi.Value.ToShortDateString()));
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem kayıt = new ListViewItem();
                kayıt.Text = oku["FatNo"].ToString();
                kayıt.SubItems.Add(oku["Kdv"].ToString());
                kayıt.SubItems.Add(oku["ToplamTutar"].ToString());
                kayıt.SubItems.Add(oku["Aciklama"].ToString());
                kayıt.SubItems.Add(oku["Tarih"].ToString());
                LstVw_GiderList.Items.Add(kayıt);
            }
            oku.Close();

            decimal tkdv = 0;
            decimal ttutar = 0;

            if (LstVw_GiderList.Items.Count > 0)
            {
                for (int i = 0; i < LstVw_GiderList.Items.Count; i++)
                {
                    tkdv = tkdv + decimal.Parse(LstVw_GiderList.Items[i].SubItems[1].Text);
                    ttutar = ttutar + decimal.Parse(LstVw_GiderList.Items[i].SubItems[2].Text);
                }
            }
            Lbl_TTutar.Text = ttutar.ToString() + " TL";
            Lbl_Tkdv.Text = tkdv.ToString() + " TL";
            bgl.baglanti().Close();
        }

        private void Btn_GidTemizle_Click(object sender, EventArgs e)
        {
            GidTemizle();
        }

        private void GidTemizle()
        {
            Btn_GidEkle.Enabled = true;
            Btn_GidKaydet.Enabled = true;
            Btn_FatIcerikKaldir.Enabled = true;

            Txt_GidFatFisNo.Enabled = true;
            Txt_GidUrun.Enabled = true;
            Txt_GidAdet.Enabled = true;
            Txt_GidKdv.Enabled = true;
            Txt_GidTTutar.Enabled = true;
            Txt_FatAciklama.Enabled = true;

            Txt_GidFatFisNo.Clear();
            Txt_GidUrun.Clear();
            Txt_GidAdet.Clear();
            Txt_GidTTutar.Clear();
            Txt_FatAciklama.Clear();
            LstVw_FatIcerikList.Items.Clear();
        }

        private void Btn_FatIcerikKaldir_Click(object sender, EventArgs e)
        {
            if (LstVw_FatIcerikList.SelectedIndices.Count > 0)
            { LstVw_FatIcerikList.Items.Remove(LstVw_FatIcerikList.SelectedItems[0]); }
            else { MessageBox.Show("Lütfen Ürün Seçiniz"); }
        }

        private void Btn_GidKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt0 = new SqlCommand("select *from Tbl_Esleme where FatNo=@p1", bgl.baglanti());
            kmt0.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
            SqlDataReader oku = kmt0.ExecuteReader();
            if (oku.Read())
            {
                SqlCommand kmt = new SqlCommand("insert into Tbl_Kasa (FatNo,Kdv,ToplamTutar,Aciklama) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
                //kasaiçeriği
                for (int i = 0; i < LstVw_FatIcerikList.Items.Count; i++)
                {
                    SqlCommand kmt1 = new SqlCommand("insert into Tbl_KasaIcerik (FatNo,Urun,Adet,Kdv,ToplamTutar) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    kmt1.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
                    kmt1.Parameters.AddWithValue("@p2", LstVw_FatIcerikList.Items[i].SubItems[0].Text);
                    kmt1.Parameters.AddWithValue("@p3", int.Parse(LstVw_FatIcerikList.Items[i].SubItems[1].Text));
                    kmt1.Parameters.AddWithValue("@p4", decimal.Parse(LstVw_FatIcerikList.Items[i].SubItems[2].Text));
                    kmt1.Parameters.AddWithValue("@p5", decimal.Parse(LstVw_FatIcerikList.Items[i].SubItems[3].Text));
                    kmt1.ExecuteNonQuery();
                }
                SqlCommand kmt2 = new SqlCommand("select *from Tbl_KasaIcerik where FatNo=@p1", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
                SqlDataReader oku2 = kmt2.ExecuteReader();
                decimal toplamtutar = 0;
                decimal ttoplamtutar = 0;
                int adet = 0;
                decimal kdv = 0;
                decimal tkdv = 0;
                while (oku2.Read())
                {
                    //adet = int.Parse(oku2["Adet"].ToString());
                    kdv = int.Parse(oku2["Kdv"].ToString());
                    toplamtutar = decimal.Parse(oku2["ToplamTutar"].ToString());
                    kdv = toplamtutar * kdv / 100;
                    toplamtutar = toplamtutar + kdv;
                    tkdv = tkdv + kdv;
                    ttoplamtutar = ttoplamtutar + toplamtutar;
                }
                kmt.Parameters.AddWithValue("@p2", tkdv);
                kmt.Parameters.AddWithValue("@p3", ttoplamtutar);
                kmt.Parameters.AddWithValue("@p4", Txt_FatAciklama.Text);
                if (kmt.ExecuteNonQuery() > 0)
                {
                    GidTemizle();
                    GiderList();
                    MessageBox.Show("Kasa Ekleme Başarılı");
                }
                else { MessageBox.Show("Kasa Ekleme Başarısız"); }
            }
            else
            {
                SqlCommand kmt = new SqlCommand("insert into Tbl_Kasa (FatNo,Kdv,ToplamTutar,Aciklama) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
                //kasaiçeriği
                for (int i = 0; i < LstVw_FatIcerikList.Items.Count; i++)
                {
                    SqlCommand kmt1 = new SqlCommand("insert into Tbl_KasaIcerik (FatNo,Urun,Adet,Kdv,ToplamTutar) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    kmt1.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
                    kmt1.Parameters.AddWithValue("@p2", LstVw_FatIcerikList.Items[i].SubItems[0].Text);
                    kmt1.Parameters.AddWithValue("@p3", int.Parse(LstVw_FatIcerikList.Items[i].SubItems[1].Text));
                    kmt1.Parameters.AddWithValue("@p4", decimal.Parse(LstVw_FatIcerikList.Items[i].SubItems[2].Text));
                    kmt1.Parameters.AddWithValue("@p5", decimal.Parse(LstVw_FatIcerikList.Items[i].SubItems[3].Text));
                    kmt1.ExecuteNonQuery();
                }
                SqlCommand kmt2 = new SqlCommand("select *from Tbl_KasaIcerik where FatNo=@p1", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p1", Txt_GidFatFisNo.Text);
                SqlDataReader oku2 = kmt2.ExecuteReader();
                decimal toplamtutar = 0;
                decimal ttoplamtutar = 0;
                int adet = 0;
                decimal kdv = 0;
                decimal tkdv = 0;
                while (oku2.Read())
                {
                    kdv = int.Parse(oku2["Kdv"].ToString());
                    toplamtutar = decimal.Parse(oku2["ToplamTutar"].ToString());

                    kdv = toplamtutar * kdv / 100;
                    //toplamtutar = toplamtutar + kdv;
                    tkdv = tkdv + kdv;
                    ttoplamtutar = ttoplamtutar + toplamtutar;
                }
                kmt.Parameters.AddWithValue("@p2", tkdv);
                kmt.Parameters.AddWithValue("@p3", ttoplamtutar);
                kmt.Parameters.AddWithValue("@p4", Txt_FatAciklama.Text);
                if (kmt.ExecuteNonQuery() > 0)
                {
                    GidTemizle();
                    GiderList();
                    MessageBox.Show("Kasa Ekleme Başarılı");
                }
                else { MessageBox.Show("Kasa Ekleme Başarısız"); }
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font myFont = new Font("Calibri", 26);
            Font myFont2 = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawString("FATURA", myFont, sbrush, 50, 50);


            e.Graphics.DrawString("Ürün", myFont2, sbrush, 50, 100);
            e.Graphics.DrawString("Adet", myFont2, sbrush, 150, 100);
            e.Graphics.DrawString("Birim Fiyat", myFont2, sbrush, 250, 100);
            e.Graphics.DrawString("Kdv", myFont2, sbrush, 350, 100);
            e.Graphics.DrawString("Tutar", myFont2, sbrush, 450, 100);

            e.Graphics.DrawString("Tutar", myFont2, sbrush, 350, 500);
            e.Graphics.DrawString("Kdv", myFont2, sbrush, 350, 525);
            e.Graphics.DrawString("Toplam Fiyat", myFont2, sbrush, 350, 550);

            e.Graphics.DrawString("Tarih", myFont2, sbrush, 450, 25);
            e.Graphics.DrawString("Fatura No", myFont2, sbrush, 450, 50);
            e.Graphics.DrawString("Alıcı", myFont2, sbrush, 450, 75);




            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;


            SqlCommand kmt = new SqlCommand("select *from Tbl_Irsaliye where IrsNo=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", LstVw_SatOnayBekle.SelectedItems[0].SubItems[1].Text);
            SqlDataReader oku = kmt.ExecuteReader();
            int arttır = 0;
            while (oku.Read())
            {
                SqlCommand kmt2 = new SqlCommand("select *from Tbl_UrunDetay where BarkodNo=@p1", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p1", oku["Barkod"].ToString());
                SqlDataReader oku2 = kmt2.ExecuteReader();
                if (oku2.Read())
                {
                    e.Graphics.DrawString(UrunAdi(int.Parse(oku2["UrunID"].ToString())), myFont2, sbrush, 50, 150 + arttır);
                }
                e.Graphics.DrawString(oku["Adet"].ToString(), myFont2, sbrush, 150, 150 + arttır);
                e.Graphics.DrawString(oku["BirimFiyat"].ToString(), myFont2, sbrush, 250, 150 + arttır);
                e.Graphics.DrawString(oku["Kdv"].ToString(), myFont2, sbrush, 350, 150 + arttır);
                e.Graphics.DrawString(oku["ToplamFiyat"].ToString(), myFont2, sbrush, 450, 150 + arttır);
                arttır += 30;
            }
            oku.Close();

            SqlCommand kmt3 = new SqlCommand("select *from Tbl_Esleme where EsID=@p1", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@p1", LstVw_SatOnayBekle.SelectedItems[0].SubItems[0].Text);
            SqlDataReader oku3 = kmt3.ExecuteReader();
            if (oku3.Read())
            {
                e.Graphics.DrawString(oku3["BirimFiyat"] + " TL".ToString(), myFont2, sbrush, 450, 500);
                e.Graphics.DrawString(oku3["Kdv"] + " TL".ToString(), myFont2, sbrush, 450, 525);
                e.Graphics.DrawString(oku3["ToplamTutar"] + " TL".ToString(), myFont2, sbrush, 450, 550);
                e.Graphics.DrawString(oku3["Tarih"].ToString(), myFont2, sbrush, 500, 25);
                e.Graphics.DrawString(oku3["FatNo"].ToString(), myFont2, sbrush, 520, 50);
                e.Graphics.DrawString(MagazaAdi(int.Parse(oku3["AliciID"].ToString())), myFont2, sbrush, 540, 75);
            }
        }

        private void Txt_GidFatFisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32) //boşluk engeller
            {
                e.Handled = true;
            }
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´') //özelsimgeler 
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47) //özel krkterler giremez
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)//özel krkterler
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)//özel krkterler
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)//özel krkterler
            {
                e.Handled = true;
            }
            //if ((int)e.KeyChar >=0 || (int)e.KeyChar <=31) //alt tuşunu asci kodu yok :D
            //{
            //    e.Handled = true;
            //}
        }

        private void Txt_GidUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32) //boşluk engeller
            {
                e.Handled = true;
            }
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´') //özelsimgeler 
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47) //özel krkterler giremez
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)//özel krkterler
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)//özel krkterler
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)//özel krkterler
            {
                e.Handled = true;
            }
        }

        private void Txt_GidAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void Txt_Kdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void Txt_GidTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void Btn_GidIcerikGoster_Click(object sender, EventArgs e)
        {
            //frm_fat = new Frm_Fatura();
            //SqlCommand kmt = new SqlCommand("select *from Tbl_Esleme where  FatNo=@p1", bgl.baglanti());
            //kmt.Parameters.AddWithValue("@p1", fatno);
            //SqlDataReader oku = kmt.ExecuteReader();
            //if (oku.Read())
            //{
            //    if (!string.IsNullOrWhiteSpace(oku["AliciID"].ToString()))
            //    {
            //        frm_fat.Lbl_Alici.Text = MagazaAdi(int.Parse(oku["AliciID"].ToString()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(oku["GondericiID"].ToString()))
            //    {
            //        frm_fat.Lbl_Gonderen.Text = TedFirma(int.Parse(oku["GondericiID"].ToString()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(oku["FatNo"].ToString()))
            //    {
            //        frm_fat.Lbl_FatNo.Text = oku["FatNo"].ToString();
            //    }
            //    frm_fat.Lbl_Tarih.Text = oku["Tarih"].ToString();
            //    frm_fat.Lbl_Tutar.Text = oku["BirimFiyat"].ToString() + " TL";
            //    frm_fat.Lbl_Kdv.Text = oku["Kdv"].ToString() + " TL";
            //    frm_fat.Lbl_ToplamTutar.Text = oku["ToplamTutar"].ToString() + " TL";
            //    SqlCommand kmt2 = new SqlCommand("select *from Tbl_Irsaliye where IrsNo=@p1", bgl.baglanti());
            //    kmt2.Parameters.AddWithValue("@p1", oku["IrsNo"].ToString());
            //    SqlDataReader oku2 = kmt2.ExecuteReader();
            //    while (oku2.Read())
            //    {
            //        SqlCommand kmturun = new SqlCommand("select *from Tbl_UrunDetay where BarkodNo=@p1", bgl.baglanti());
            //        kmturun.Parameters.AddWithValue("@p1", oku2["Barkod"].ToString());
            //        SqlDataReader urunoku = kmturun.ExecuteReader();
            //        while (urunoku.Read())
            //        {
            //            ListViewItem item = new ListViewItem();
            //            item.Text = urunoku["UrunDtyID"].ToString();
            //            item.SubItems.Add(urunoku["BarkodNo"].ToString());
            //            item.SubItems.Add(UrunAdi(int.Parse(urunoku["UrunID"].ToString())));
            //            item.SubItems.Add(MarkaAdi(int.Parse(urunoku["MarkaID"].ToString())));
            //            item.SubItems.Add(ModelAdi(int.Parse(urunoku["ModelID"].ToString())));
            //            item.SubItems.Add(RenkAdi(int.Parse(urunoku["RenkID"].ToString())));
            //            item.SubItems.Add(BedenAdi(int.Parse(urunoku["BedenID"].ToString())));
            //            item.SubItems.Add(oku2["Adet"].ToString());
            //            item.SubItems.Add(oku2["BirimFiyat"].ToString());
            //            item.SubItems.Add(oku2["Kdv"].ToString() + " %");
            //            item.SubItems.Add(oku2["ToplamFiyat"].ToString());
            //            frm_fat.LstVw_FatIcerigi.Items.Add(item);
            //        }
            //    }
            //}
            //else
            //{
            //    SqlCommand kmt2 = new SqlCommand("select *from Tbl_Kasa where KasaID=@p1", bgl.baglanti());
            //    kmt2.Parameters.AddWithValue("@p1", bgl.baglanti());
            //}
            //bgl.baglanti().Close();
            //frm_fat.ShowDialog();
        }

        private void Btn_SatOnayListYaz_Click(object sender, EventArgs e)
        {
            if (LstVw_SatOnaylanan.Items.Count > 0)
            {
                DialogResult pdr2 = printDialog1.ShowDialog();
                if (pdr2 == DialogResult.OK)
                {
                    PDoc_SatOnay.Print();
                }
            }
            else { MessageBox.Show("Listeleme Yapınız"); }
        }

        private void PDoc_SatOnay_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font myFont = new Font("Calibri", 26);
            Font myFont2 = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawString("ONAYLANAN SATIŞ FATURALAR", myFont, sbrush, 150, 100);


            e.Graphics.DrawString("Fatura No", myFont2, sbrush, 50, 150);
            e.Graphics.DrawString("Alıcı", myFont2, sbrush, 150, 150);
            e.Graphics.DrawString("Tutar", myFont2, sbrush, 250, 150);
            e.Graphics.DrawString("Kdv", myFont2, sbrush, 350, 150);
            e.Graphics.DrawString("Toplam Tutar", myFont2, sbrush, 450, 150);
            e.Graphics.DrawString("Tarih", myFont2, sbrush, 600, 150);

            e.Graphics.DrawString("Başlangıç Tarihi", myFont2, sbrush, 450, 5);
            e.Graphics.DrawString("Bitiş Tarihi", myFont2, sbrush, 450, 25);

            e.Graphics.DrawString(Date_SatOnaylıBasTarih.Text, myFont2, sbrush, 570, 5);
            e.Graphics.DrawString(Date_SatOnaylıBitTarih.Text, myFont2, sbrush, 570, 25);

            e.Graphics.DrawString("Toplam Kdv", myFont2, sbrush, 40, 5);
            e.Graphics.DrawString("Toplam Fiyat", myFont2, sbrush, 40, 25);

            e.Graphics.DrawString(Lbl_SatOTKdv.Text, myFont2, sbrush, 140, 5);
            e.Graphics.DrawString(Lbl_SatOTTutar.Text, myFont2, sbrush, 140, 25);



            if (LstVw_SatOnaylanan.Items.Count > 0)
            {
                int arttır = 0;
                for (int i = 0; i < LstVw_SatOnaylanan.Items.Count; i++)
                {
                    e.Graphics.DrawString(LstVw_SatOnaylanan.Items[i].SubItems[1].Text, myFont2, sbrush, 50, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatOnaylanan.Items[i].SubItems[2].Text, myFont2, sbrush, 150, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatOnaylanan.Items[i].SubItems[3].Text, myFont2, sbrush, 250, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatOnaylanan.Items[i].SubItems[4].Text, myFont2, sbrush, 350, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatOnaylanan.Items[i].SubItems[5].Text, myFont2, sbrush, 450, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatOnaylanan.Items[i].SubItems[6].Text, myFont2, sbrush, 600, 200 + arttır);
                    arttır += 30;
                }
            }


        }

        private void Btn_SatIptalListYaz_Click(object sender, EventArgs e)
        {
            if (LstVw_SatIptaller.Items.Count > 0)
            {
                DialogResult pdr2 = printDialog1.ShowDialog();
                if (pdr2 == DialogResult.OK)
                {
                    PDoc_SatIptal.Print();
                }
            }
            else { MessageBox.Show("Listeleme Yapınız"); }
        }

        private void PDoc_SatIptal_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font myFont = new Font("Calibri", 26);
            Font myFont2 = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawString("İPTAL EDİLEN FATURALAR", myFont, sbrush, 150, 100);


            e.Graphics.DrawString("İrsaliye No", myFont2, sbrush, 50, 150);
            e.Graphics.DrawString("Alıcı", myFont2, sbrush, 150, 150);
            e.Graphics.DrawString("Tutar", myFont2, sbrush, 250, 150);
            e.Graphics.DrawString("Kdv", myFont2, sbrush, 350, 150);
            e.Graphics.DrawString("Toplam Tutar", myFont2, sbrush, 450, 150);
            e.Graphics.DrawString("Tarih", myFont2, sbrush, 600, 150);

            e.Graphics.DrawString("Başlangıç Tarihi", myFont2, sbrush, 450, 5);
            e.Graphics.DrawString("Bitiş Tarihi", myFont2, sbrush, 450, 25);

            e.Graphics.DrawString(Date_SatIptalBasTarih.Text, myFont2, sbrush, 570, 5);
            e.Graphics.DrawString(Date_SatIptalBitTarih.Text, myFont2, sbrush, 570, 25);

            e.Graphics.DrawString("Toplam Kdv", myFont2, sbrush, 40, 5);
            e.Graphics.DrawString("Toplam Fiyat", myFont2, sbrush, 40, 25);

            e.Graphics.DrawString(Lbl_SatITKdv.Text, myFont2, sbrush, 140, 5);
            e.Graphics.DrawString(Lbl_SatITTutar.Text, myFont2, sbrush, 140, 25);



            if (LstVw_SatIptaller.Items.Count > 0)
            {
                int arttır = 0;
                for (int i = 0; i < LstVw_SatIptaller.Items.Count; i++)
                {
                    e.Graphics.DrawString(LstVw_SatIptaller.Items[i].SubItems[1].Text, myFont2, sbrush, 50, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatIptaller.Items[i].SubItems[2].Text, myFont2, sbrush, 150, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatIptaller.Items[i].SubItems[3].Text, myFont2, sbrush, 250, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatIptaller.Items[i].SubItems[4].Text, myFont2, sbrush, 350, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatIptaller.Items[i].SubItems[5].Text, myFont2, sbrush, 450, 200 + arttır);
                    e.Graphics.DrawString(LstVw_SatIptaller.Items[i].SubItems[6].Text, myFont2, sbrush, 600, 200 + arttır);
                    arttır += 30;
                }
            }
        }



        private void PDoc_AlisOnay_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 26);
            Font myFont2 = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawString("ONAYLANAN ALIŞ FATURALAR", myFont, sbrush, 150, 100);

            e.Graphics.DrawString("Fatura No", myFont2, sbrush, 50, 150);
            e.Graphics.DrawString("Tutar", myFont2, sbrush, 250, 150);
            e.Graphics.DrawString("Kdv", myFont2, sbrush, 350, 150);
            e.Graphics.DrawString("Toplam Tutar", myFont2, sbrush, 450, 150);
            e.Graphics.DrawString("Tarih", myFont2, sbrush, 600, 150);

            e.Graphics.DrawString("Başlangıç Tarihi", myFont2, sbrush, 450, 5);
            e.Graphics.DrawString("Bitiş Tarihi", myFont2, sbrush, 450, 25);

            e.Graphics.DrawString(Date_AlisOnayBasTarihi.Text, myFont2, sbrush, 570, 5);
            e.Graphics.DrawString(Date_AlisOnayBitTarihi.Text, myFont2, sbrush, 570, 25);

            e.Graphics.DrawString("Toplam Kdv", myFont2, sbrush, 40, 5);
            e.Graphics.DrawString("Toplam Fiyat", myFont2, sbrush, 40, 25);

            e.Graphics.DrawString(Lbl_AlisOTKdv.Text, myFont2, sbrush, 140, 5);
            e.Graphics.DrawString(Lbl_AlisOTTutar.Text, myFont2, sbrush, 140, 25);



            if (LstVw_AlisOnaylananList.Items.Count > 0)
            {
                int arttır = 0;
                for (int i = 0; i < LstVw_AlisOnaylananList.Items.Count; i++)
                {
                    e.Graphics.DrawString(LstVw_AlisOnaylananList.Items[i].SubItems[1].Text, myFont2, sbrush, 50, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisOnaylananList.Items[i].SubItems[2].Text, myFont2, sbrush, 250, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisOnaylananList.Items[i].SubItems[3].Text, myFont2, sbrush, 350, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisOnaylananList.Items[i].SubItems[4].Text, myFont2, sbrush, 450, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisOnaylananList.Items[i].SubItems[5].Text, myFont2, sbrush, 600, 200 + arttır);
                    arttır += 30;
                }
            }
        }

        private void Btn_AlisOnayListYaz_Click(object sender, EventArgs e)
        {
            if (LstVw_AlisOnaylananList.Items.Count > 0)
            {
                DialogResult pdr2 = printDialog1.ShowDialog();
                if (pdr2 == DialogResult.OK)
                {
                    PDoc_AlisOnay.Print();
                }
            }
            else { MessageBox.Show("Listeleme Yapınız"); }
        }

        private void Btn_AlisIptalListYaz_Click(object sender, EventArgs e)
        {
            if (LstVw_AlisIptalList.Items.Count > 0)
            {
                DialogResult pdr2 = printDialog1.ShowDialog();
                if (pdr2 == DialogResult.OK)
                {
                    PDoc_AlisIptal.Print();
                }
            }
            else { MessageBox.Show("Listeleme Yapınız"); }
        }

        private void PDoc_AlisIptal_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 26);
            Font myFont2 = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawString("İPTAL EDİLEN ALIŞ FATURALARI", myFont, sbrush, 150, 100);

            e.Graphics.DrawString("Fatura No", myFont2, sbrush, 50, 150);
            e.Graphics.DrawString("Tutar", myFont2, sbrush, 250, 150);
            e.Graphics.DrawString("Kdv", myFont2, sbrush, 350, 150);
            e.Graphics.DrawString("Toplam Tutar", myFont2, sbrush, 450, 150);
            e.Graphics.DrawString("Tarih", myFont2, sbrush, 600, 150);

            e.Graphics.DrawString("Başlangıç Tarihi", myFont2, sbrush, 450, 5);
            e.Graphics.DrawString("Bitiş Tarihi", myFont2, sbrush, 450, 25);

            e.Graphics.DrawString(Date_AlisIptalBasTarihi.Text, myFont2, sbrush, 570, 5);
            e.Graphics.DrawString(Date_AlisIptalBitTarihi.Text, myFont2, sbrush, 570, 25);

            e.Graphics.DrawString("Toplam Kdv", myFont2, sbrush, 40, 5);
            e.Graphics.DrawString("Toplam Fiyat", myFont2, sbrush, 40, 25);

            e.Graphics.DrawString(Lbl_AlisITKdv.Text, myFont2, sbrush, 140, 5);
            e.Graphics.DrawString(Lbl_AlisITTutar.Text, myFont2, sbrush, 140, 25);



            if (LstVw_AlisIptalList.Items.Count > 0)
            {
                int arttır = 0;
                for (int i = 0; i < LstVw_AlisIptalList.Items.Count; i++)
                {
                    e.Graphics.DrawString(LstVw_AlisIptalList.Items[i].SubItems[1].Text, myFont2, sbrush, 50, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisIptalList.Items[i].SubItems[2].Text, myFont2, sbrush, 250, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisIptalList.Items[i].SubItems[3].Text, myFont2, sbrush, 350, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisIptalList.Items[i].SubItems[4].Text, myFont2, sbrush, 450, 200 + arttır);
                    e.Graphics.DrawString(LstVw_AlisIptalList.Items[i].SubItems[5].Text, myFont2, sbrush, 600, 200 + arttır);
                    arttır += 30;
                }
            }
        }

        private void LstVw_GiderList_DoubleClick(object sender, EventArgs e)
        {
            Btn_GidEkle.Enabled = false;
            Btn_GidKaydet.Enabled = false;
            Btn_FatIcerikKaldir.Enabled = false;

            Txt_GidFatFisNo.Enabled = false;
            Txt_GidUrun.Enabled = false;
            Txt_GidAdet.Enabled = false;
            Txt_GidKdv.Enabled = false;
            Txt_GidTTutar.Enabled = false;
            Txt_FatAciklama.Enabled = false;

            LstVw_FatIcerikList.Items.Clear();
            Txt_GidFatFisNo.Text = LstVw_GiderList.SelectedItems[0].SubItems[0].Text;
            SqlCommand kmt = new SqlCommand("select *from Tbl_KasaIcerik where FatNo=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", LstVw_GiderList.SelectedItems[0].SubItems[0].Text);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = oku["Urun"].ToString();
                item.SubItems.Add(oku["Adet"].ToString());
                item.SubItems.Add(oku["Kdv"].ToString());
                item.SubItems.Add(oku["ToplamTutar"].ToString());
                LstVw_FatIcerikList.Items.Add(item);
            }
            bgl.baglanti().Close();
            Txt_FatAciklama.Text = LstVw_GiderList.SelectedItems[0].SubItems[3].Text;
        }
    }
}
