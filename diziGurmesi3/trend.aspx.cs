using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchAndBindTrendData();
            }
        }

        private void FetchAndBindTrendData()
        {
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string query = "SELECT DiziSiraID, DiziFoto, DiziAciklama FROM TrendDiziler";

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

                        Panel panelTrendDizi = new Panel();
                        panelTrendDizi.CssClass = "trend-dizi";

                        Image imgDizi = new Image();
                        imgDizi.ImageUrl = diziFoto;
                        imgDizi.AlternateText = "Dizi Foto";
                        imgDizi.CssClass = "trend-dizi-foto";

                        imgDizi.Style["max-width"] = "200px"; 
                        imgDizi.Style["max-height"] = "200px";

                        Panel panelIcerik = new Panel();
                        panelIcerik.CssClass = "trend-dizi-icerik";

                        LiteralControl aciklamaControl = new LiteralControl($"<p class='trend-dizi-aciklama'>{diziAciklama}</p>");

                        HyperLink devamLinkControl = new HyperLink();
                        devamLinkControl.Text = "Devamı için tıklayınız";
                        devamLinkControl.NavigateUrl = $"diziTrendDetay.aspx?DiziID={diziID}";
                        devamLinkControl.CssClass = "devam-link";

                        panelIcerik.Controls.Add(aciklamaControl);
                        panelIcerik.Controls.Add(devamLinkControl);

                        panelTrendDizi.Controls.Add(imgDizi);
                        panelTrendDizi.Controls.Add(panelIcerik);

                       
                        trendDiziContainer.Controls.Add(panelTrendDizi);
                    }

                    reader.Close();
                }
            }
        }
    }
}