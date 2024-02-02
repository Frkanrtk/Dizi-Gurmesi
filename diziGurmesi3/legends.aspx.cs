using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class WebForm4 : System.Web.UI.Page
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
            string query = "SELECT DiziSiraID, DiziFoto, DiziAciklama FROM efsaneDiziler";

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

                        Panel panelLegendsDizi = new Panel();
                        panelLegendsDizi.CssClass = "legends-dizi";

                        Image imgDizi = new Image();
                        imgDizi.ImageUrl = diziFoto;
                        imgDizi.AlternateText = "Dizi Foto";
                        imgDizi.CssClass = "legends-dizi-foto";

                        imgDizi.Style["max-width"] = "200px"; 
                        imgDizi.Style["max-height"] = "200px";

                        Panel panelIcerik = new Panel();
                        panelIcerik.CssClass = "legends-dizi-icerik";

                        LiteralControl aciklamaControl = new LiteralControl($"<p class='legends-dizi-aciklama'>{diziAciklama}</p>");

                        HyperLink devamLinkControl = new HyperLink();
                        devamLinkControl.Text = "Devamı için tıklayınız";
                        devamLinkControl.NavigateUrl = $"diziLegendsDetay.aspx?DiziID={diziID}";
                        devamLinkControl.CssClass = "devam-link";

                        panelIcerik.Controls.Add(aciklamaControl);
                        panelIcerik.Controls.Add(devamLinkControl);

                        panelLegendsDizi.Controls.Add(imgDizi);
                        panelLegendsDizi.Controls.Add(panelIcerik);

                        
                        efsaneDizilerContainer.Controls.Add(panelLegendsDizi);
                    }

                    reader.Close();
                }
            }
        }
    }
}