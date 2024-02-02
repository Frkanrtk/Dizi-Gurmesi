using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                string adSoyad = txtAdSoyad.Value;
                string kullaniciAdi = txtKullaniciAdi.Value;
                string cinsiyet = radioErkek.Checked ? "Erkek" : (radioKadin.Checked ? "Kadın" : "Belirtilmemiş");
                string eposta = txtEposta.Value;
                string sifre = txtSifre.Value;
                string sifreTekrar = txtSifreTekrar.Value;
                string telefon = txtTelefon.Value;

                if (sifre != sifreTekrar)
                {
                    Response.Write("<script>alert('Şifreler uyuşmuyor. Lütfen aynı şifreyi girin.');</script>");
                    return;
                }

                baglanti.Open();

                string kayit = "INSERT INTO dbo.Kullanicilar (AdSoyad, KullaniciAdi, Cinsiyet, Eposta, Sifre, Telefon) VALUES (@AdSoyad, @KullaniciAdi, @Cinsiyet, @Eposta, @Sifre, @Telefon)";
                SqlCommand command = new SqlCommand(kayit, baglanti);

                command.Parameters.AddWithValue("@AdSoyad", adSoyad);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@Sifre", sifre);
                command.Parameters.AddWithValue("@Telefon", telefon);

                int affectedRows = command.ExecuteNonQuery();

                baglanti.Close();

                if (affectedRows > 0)
                {
                    Response.Write("<script>alert('Kayıt başarıyla tamamlandı. Giriş yapabilirsiniz.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Kayıt eklenirken bir hata oluştu.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.Message + "');</script>");
            }
            finally
            {
                baglanti.Close();
            }
        }
        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}
