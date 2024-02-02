using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class userTrend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchAndBindUserTrendData();
            }
        }

        private void FetchAndBindUserTrendData()
        {
            string userConnectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string userTrendQuery = "SELECT DiziSiraID, DiziFoto, DiziAciklama FROM TrendDiziler";

            using (SqlConnection connection = new SqlConnection(userConnectionString))
            {
                using (SqlCommand command = new SqlCommand(userTrendQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string trendDiziID = reader["DiziSiraID"].ToString();
                        string trendDiziFoto = reader["DiziFoto"].ToString();
                        string trendDiziAciklama = reader["DiziAciklama"].ToString();

                        Panel panelTrendDizi = new Panel();
                        panelTrendDizi.CssClass = "trend-dizi";

                        Image imgTrendDizi = new Image();
                        imgTrendDizi.ImageUrl = trendDiziFoto;
                        imgTrendDizi.AlternateText = "Trend Dizi Foto";
                        imgTrendDizi.CssClass = "trend-dizi-foto";

                        imgTrendDizi.Style["max-width"] = "200px"; 
                        imgTrendDizi.Style["max-height"] = "200px";

                        LiteralControl trendDiziAciklamaControl = new LiteralControl($"<p class='trend-dizi-aciklama'>{trendDiziAciklama}</p>");

                        HyperLink devamLinkControl = new HyperLink();
                        devamLinkControl.Text = "Devamı için tıklayınız";
                        devamLinkControl.NavigateUrl = $"diziTrendDetay.aspx?DiziID={trendDiziID}";
                        devamLinkControl.CssClass = "devam-link";

                        panelTrendDizi.Controls.Add(imgTrendDizi);
                        panelTrendDizi.Controls.Add(trendDiziAciklamaControl);
                        panelTrendDizi.Controls.Add(devamLinkControl);

                        userTrendDiziContainer.Controls.Add(panelTrendDizi);
                    }

                    reader.Close();
                }
            }
        }
    }
}