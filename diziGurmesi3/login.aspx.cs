using System;
using System.Data.SqlClient;
using System.Web;

namespace diziGurmesi3
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Eposta"] != null)
            {
                Response.Redirect("userHomePage.aspx");
            }
        }

        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                string Eposta = txtEmail.Value;
                string Sifre = txtPassword.Value;

                baglanti.Open();

                string query = "SELECT KullaniciAdi FROM Kullanicilar WHERE Eposta = @Email AND Sifre = @Password";
                SqlCommand command = new SqlCommand(query, baglanti);
                command.Parameters.AddWithValue("@Email", Eposta);
                command.Parameters.AddWithValue("@Password", Sifre);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Session["Eposta"] = Eposta;
                    Session["KullaniciAdi"] = reader["KullaniciAdi"].ToString();
                    Response.Redirect("userHomePage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('E-posta veya şifre hatalı.');</script>");
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
         
        protected void btnGirisYaptanKayitOl_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}
