using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        private string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdminGiris_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(txtAdminID.Value);
                string adminUsername = txtAdminUsername.Value;
                string adminPassword = txtAdminPassword.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Admin WHERE UserID = @UserID  AND KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@KullaniciAdi", adminUsername);
                    command.Parameters.AddWithValue("@Sifre", adminPassword);

                    int adminCount = (int)command.ExecuteScalar();

                    if (adminCount > 0)
                    {
                       
                        Response.Write("<script>alert('Admin girişi başarılı.');</script>");
                        
                        Response.Redirect("adminPanelKullanicilar.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Admin girişi başarısız.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.Message + "');</script>");
            }
        }
    }
}