using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webEntityOkul
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OKULEntities ent = new OKULEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                SiniflariGetir();
        }
        private void SiniflariGetir()
        {
            var classes = (from sinif in ent.Siniflar
                           select sinif).ToList();
            ddlSiniflar.DataTextField = "SinifAd";
            ddlSiniflar.DataValueField = "ID";
            ddlSiniflar.DataSource = classes;            
            ddlSiniflar.DataBind();
            OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));

        }
        protected void ddlSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
        }
        private void OgrencileriGetirBySinif(int SinifNo)
        {
            var Students = (from ogrenci in ent.Ogrenciler
                           where ogrenci.SinifID == SinifNo
                           select ogrenci).ToList();
            gvOgrenciler.DataSource = Students;
            gvOgrenciler.DataBind();
            PanelEkle.Visible = false;
        }
        protected void lbtnEkle_Click(object sender, EventArgs e)
        {
            PanelEkle.Visible = true;
            txtAdi.Focus();
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenciler ogr = new Ogrenciler();
            ogr.Ad = txtAdi.Text;
            ogr.Soyad = txtSoyadi.Text;
            ogr.Telefon = txtTelefon.Text;
            ogr.Adres = txtAdres.Text;
            ogr.TCKNo = txtTCKNo.Text;
            ogr.Tutar = Convert.ToDecimal(txtToplamTutar.Text);
            ogr.TaksitSayisi = Convert.ToByte(txtTaksitSayisi.Text);
            ogr.SinifID = Convert.ToInt32(ddlSiniflar.SelectedValue);
            ent.Ogrenciler.Add(ogr);
            ent.SaveChanges();
            OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
            Temizle();
            PanelEkle.Visible = false;
        }
        private void Temizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtTCKNo.Text = "";
            txtToplamTutar.Text = "0";
            txtTaksitSayisi.Text = "0";
        }

        protected void gvOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOgrenciID.Text = Convert.ToInt32(gvOgrenciler.SelectedValue).ToString();
            PanelEkle.Visible = true;
            txtAdi.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[2].Text);
            txtSoyadi.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[3].Text);
            txtTelefon.Text = gvOgrenciler.SelectedRow.Cells[4].Text;
            txtAdres.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[5].Text);
            txtTCKNo.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[6].Text);
            txtToplamTutar.Text = gvOgrenciler.SelectedRow.Cells[7].Text;
            txtTaksitSayisi.Text= gvOgrenciler.SelectedRow.Cells[8].Text;
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            if (lblOgrenciID.Text != "")
            {
                int OgrenciNo = Convert.ToInt32(lblOgrenciID.Text);
                var degisen = (from o in ent.Ogrenciler
                               where o.ID == OgrenciNo
                               select o).First();
                degisen.ID = OgrenciNo;
                degisen.Ad = txtAdi.Text;
                degisen.Soyad = txtSoyadi.Text;
                degisen.Telefon = txtTelefon.Text;
                degisen.Adres = txtAdres.Text;
                degisen.TCKNo = txtTCKNo.Text;
                degisen.Tutar = Convert.ToDecimal(txtToplamTutar.Text);
                degisen.TaksitSayisi = Convert.ToByte(txtTaksitSayisi.Text);
                degisen.SinifID = Convert.ToInt32(ddlSiniflar.SelectedValue);
                ent.SaveChanges();
                OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
                Temizle();
                PanelEkle.Visible = false;
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            if (lblOgrenciID.Text != "")
            {
                int OgrenciNo = Convert.ToInt32(lblOgrenciID.Text);
                var silinen = (from o in ent.Ogrenciler
                               where o.ID == OgrenciNo
                               select o).First();
                ent.Ogrenciler.Remove(silinen);
                ent.SaveChanges();
                OgrencileriGetirBySinif(Convert.ToInt32(ddlSiniflar.SelectedValue));
                Temizle();
                PanelEkle.Visible = false;
            }
        }
    }
}