using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class userAllSeries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchAndBindUserAllSeriesData();
            }
        }

        private void FetchAndBindUserAllSeriesData()
        {
            string userConnectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string userAllSeriesQuery = "SELECT DiziSiraID, DiziFoto, DiziAciklama FROM Diziler";

            using (SqlConnection connection = new SqlConnection(userConnectionString))
            {
                using (SqlCommand command = new SqlCommand(userAllSeriesQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string allSeriesDiziID = reader["DiziSiraID"].ToString();
                        string allSeriesDiziFoto = reader["DiziFoto"].ToString();
                        string allSeriesDiziAciklama = reader["DiziAciklama"].ToString();

                        Panel panelAllSeries = new Panel();
                        panelAllSeries.CssClass = "all-series";

                        Image imgAllSeries = new Image();
                        imgAllSeries.ImageUrl = allSeriesDiziFoto;
                        imgAllSeries.AlternateText = "Dizi Foto";
                        imgAllSeries.CssClass = "all-series-foto";

                        imgAllSeries.Style["max-width"] = "200px"; 
                        imgAllSeries.Style["max-height"] = "200px"; 

                        LiteralControl allSeriesDiziAciklamaControl = new LiteralControl($"<p class='all-series-aciklama'>{allSeriesDiziAciklama}</p>");

                        HyperLink devamLinkControl = new HyperLink();
                        devamLinkControl.Text = "Devamı için tıklayınız";
                        devamLinkControl.NavigateUrl = $"diziDetay.aspx?DiziID={allSeriesDiziID}";
                        devamLinkControl.CssClass = "devam-link";

                        panelAllSeries.Controls.Add(imgAllSeries);
                        panelAllSeries.Controls.Add(allSeriesDiziAciklamaControl);
                        panelAllSeries.Controls.Add(devamLinkControl);

                       
                        userAllSeriesContainer.Controls.Add(panelAllSeries);
                    }

                    reader.Close();
                }
            }
        }
    }
}