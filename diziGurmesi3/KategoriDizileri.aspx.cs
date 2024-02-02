using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class KategoriDizileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public void FetchAndBindCategoryData()
        {
            string kategoriAdi = Request.QueryString["kategori"];

            if (string.IsNullOrEmpty(kategoriAdi))
            {
                Response.Write("Kategori bilgisi bulunamadı.");
                return;
            }

            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string query = "SELECT DiziFoto, DiziAciklama FROM Diziler WHERE DiziKategori = @Kategori";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Kategori", kategoriAdi);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string diziFoto = reader["DiziFoto"].ToString();    
                        string diziAciklama = reader["DiziAciklama"].ToString();

                        Response.Write("<div class='dizi'>");
                        Response.Write($"<img src='{diziFoto}' alt='Dizi Fotoğrafı' class='dizi-foto' />");
                        Response.Write($"<p class='dizi-aciklama'>{diziAciklama}</p>");
                        Response.Write("</div>");
                    }

                    reader.Close();
                }
            }
        }
    }
}