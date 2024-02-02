using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class userLegends : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchAndBindUserLegendsData();
            }
        }

        private void FetchAndBindUserLegendsData()
        {
            string userConnectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            string userLegendsQuery = "SELECT DiziSiraID, DiziFoto, DiziAciklama FROM efsaneDiziler";

            using (SqlConnection connection = new SqlConnection(userConnectionString))
            {
                using (SqlCommand command = new SqlCommand(userLegendsQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string legendsDiziID = reader["DiziSiraID"].ToString();
                        string legendsDiziFoto = reader["DiziFoto"].ToString();
                        string legendsDiziAciklama = reader["DiziAciklama"].ToString();

                        Panel panelLegends = new Panel();
                        panelLegends.CssClass = "legends";

                        Image imgLegends = new Image();
                        imgLegends.ImageUrl = legendsDiziFoto;
                        imgLegends.AlternateText = "Dizi Foto";
                        imgLegends.CssClass = "legends-foto";

                        imgLegends.Style["max-width"] = "200px"; 
                        imgLegends.Style["max-height"] = "200px"; 

                        LiteralControl legendsDiziAciklamaControl = new LiteralControl($"<p class='legends-aciklama'>{legendsDiziAciklama}</p>");

                        HyperLink devamLinkControl = new HyperLink();
                        devamLinkControl.Text = "Devamı için tıklayınız";
                        devamLinkControl.NavigateUrl = $"diziLegendsDetay.aspx?DiziID={legendsDiziID}";
                        devamLinkControl.CssClass = "devam-link";

                        panelLegends.Controls.Add(imgLegends);
                        panelLegends.Controls.Add(legendsDiziAciklamaControl);
                        panelLegends.Controls.Add(devamLinkControl);

                        userLegendsContainer.Controls.Add(panelLegends);
                    }

                    reader.Close();
                }
            }
        }
    }
}