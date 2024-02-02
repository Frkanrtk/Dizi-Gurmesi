using System;
using System.Data.SqlClient;

namespace diziGurmesi3
{
    public partial class profileSettings : System.Web.UI.Page
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Eposta"] == null)
                {
                    Response.Redirect("login.aspx");
                }
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string userEmail = Session["Eposta"].ToString();
                string currentPassword = txtCurrentPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmNewPassword = txtConfirmNewPassword.Text;

                baglanti.Open();

                string checkCurrentPasswordQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE Eposta = @UserEmail AND Sifre = @CurrentPassword";
                SqlCommand checkCurrentPasswordCommand = new SqlCommand(checkCurrentPasswordQuery, baglanti);
                checkCurrentPasswordCommand.Parameters.AddWithValue("@UserEmail", userEmail);
                checkCurrentPasswordCommand.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                int passwordCount = (int)checkCurrentPasswordCommand.ExecuteScalar();

                if (passwordCount > 0)
                {
                    string changePasswordQuery = "UPDATE Kullanicilar SET Sifre = @NewPassword WHERE Eposta = @UserEmail";
                    SqlCommand changePasswordCommand = new SqlCommand(changePasswordQuery, baglanti);
                    changePasswordCommand.Parameters.AddWithValue("@UserEmail", userEmail);
                    changePasswordCommand.Parameters.AddWithValue("@NewPassword", newPassword);

                    changePasswordCommand.ExecuteNonQuery();

                    Response.Redirect("userHomePage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Mevcut şifre hatalı.');</script>");
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
    }
}
