using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchAndBindData();
            }
        }

        private void FetchAndBindData()
        {
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string query = "SELECT TOP 8 DiziSiraID, DiziFoto, DiziAciklama FROM Diziler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string diziID = reader["DiziSiraID"].ToString();
                        string diziFoto = reader["DiziFoto"].ToString();
                        string diziAciklama = reader["DiziAciklama"].ToString();

                        Panel panelDizi = new Panel();
                        panelDizi.CssClass = "dizi";

                        Image imgDizi = new Image();
                        imgDizi.ImageUrl = diziFoto;
                        imgDizi.AlternateText = "Dizi Foto";
                        imgDizi.CssClass = "dizi-foto";

                        imgDizi.Style["max-width"] = "200px"; 
                        imgDizi.Style["max-height"] = "200px"; 

                        LiteralControl aciklamaControl = new LiteralControl($"<p class='dizi-aciklama'>{diziAciklama}</p>");
                        HyperLink devamLinkControl = new HyperLink();
                        devamLinkControl.Text = "Devamı için tıklayınız";
                        devamLinkControl.NavigateUrl = $"diziDetay.aspx?DiziID={diziID}";

                        panelDizi.Controls.Add(imgDizi);
                        panelDizi.Controls.Add(aciklamaControl);
                        panelDizi.Controls.Add(devamLinkControl);

                        diziContainer.Controls.Add(panelDizi);
                    }

                    reader.Close();
                }
            }
        }
    }
}