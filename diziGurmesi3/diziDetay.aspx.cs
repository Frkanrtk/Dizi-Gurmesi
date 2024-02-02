using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class diziDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchAndBindDiziDetails();
            }
        }

        private void FetchAndBindDiziDetails()
        {
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string diziID = Request.QueryString["DiziID"];

            if (diziID != null)
            {
                string query = "SELECT DiziSiraID, DiziAdi, DiziAciklama, DiziPuan, DiziFragman FROM Diziler WHERE DiziSiraID = @DiziID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DiziID", diziID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string diziAdi = reader["DiziAdi"].ToString();
                            string diziAciklama = reader["DiziAciklama"].ToString();
                            decimal diziPuan = Convert.ToDecimal(reader["DiziPuan"]);
                            string diziFragman = reader["DiziFragman"].ToString();

                            UpdatePageContent(diziAdi, diziAciklama, diziPuan, diziFragman);
                        }
                        else
                        {

                        }

                        reader.Close();
                    }
                }
            }
        }

        private void UpdatePageContent(string diziAdi, string diziAciklama, decimal diziPuan, string diziFragman)
        {
            divDiziAdi.InnerText = diziAdi;
            divDiziAciklama.InnerText = diziAciklama;
            string youtubeEmbedCode = $"<iframe width='560' height='315' src='{diziFragman}' frameborder='0' allowfullscreen></iframe>";

            divDiziFragman.InnerHtml = youtubeEmbedCode;
            divDiziPuan.InnerText = $"Puan: {diziPuan}";

            divDiziPuan.Style["text-align"] = "center";

        }

    }
}