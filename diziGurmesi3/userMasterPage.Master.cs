using System;
using System.Data.SqlClient;

namespace diziGurmesi3
{
    public partial class userHomePage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                if (Session["KullaniciAdi"] != null)
                {
                    string kullaniciAdi = Session["KullaniciAdi"].ToString();
                    string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT adSoyad FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string adSoyad = result.ToString();
                            lblHoşgeldin.Text = "Hoşgeldin, " + adSoyad;
                        }
                    }
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("homePage.aspx");
        }
    }
}
