using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Kullanicilar";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataAdapter.Fill(dataTable);

                gridViewKullanicilar.DataSource = null;

                gridViewKullanicilar.DataSource = dataTable;
                gridViewKullanicilar.DataBind();
            }
        }

        protected void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtUserID.Value);

                string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ID, AdSoyad, KullaniciAdi, Cinsiyet, Eposta, Telefon, Sifre FROM Kullanicilar WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", ID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        gridViewKullanicilar.AutoGenerateColumns = false;
                        gridViewKullanicilar.DataSource = new[]
                        {
                    new
                    {
                        ID = reader["ID"].ToString(),
                        AdSoyad = reader["AdSoyad"].ToString(),
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Cinsiyet = reader["Cinsiyet"].ToString(),
                        Eposta = reader["Eposta"].ToString(),
                        Telefon = reader["Telefon"].ToString(),
                        Sifre = reader["Sifre"].ToString()
                    }
                };
                        gridViewKullanicilar.DataBind();

                        Response.Write("<script>alert('Veri bulundu.');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Kullanıcı bulunamadı.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.Message + "');</script>");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtUserID.Value);

                string yeniAdSoyad = txtAdSoyad.Value;
                string yeniKullaniciAdi = txtKullaniciAdi.Value;
                string yeniEmail = txtEmail.Value;
                string yeniTelefon = txtTelefon.Value;
                string yeniSifre = txtSifre.Value;
                string yeniCinsiyet = radioErkek.Checked ? "Erkek" : "Kadin";

                string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Kullanicilar SET AdSoyad = @AdSoyad, KullaniciAdi = @KullaniciAdi, Cinsiyet = @Cinsiyet, Eposta = @Eposta, Telefon = @Telefon, Sifre = @Sifre WHERE ID = @ID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@ID", ID);
                    updateCommand.Parameters.AddWithValue("@AdSoyad", yeniAdSoyad);
                    updateCommand.Parameters.AddWithValue("@KullaniciAdi", yeniKullaniciAdi);
                    updateCommand.Parameters.AddWithValue("@Cinsiyet", yeniCinsiyet);
                    updateCommand.Parameters.AddWithValue("@Eposta", yeniEmail);
                    updateCommand.Parameters.AddWithValue("@Telefon", yeniTelefon);
                    updateCommand.Parameters.AddWithValue("@Sifre", yeniSifre);

                    int affectedRows = updateCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Response.Write("<script>alert('Kullanıcı bilgileri başarıyla güncellendi.');</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('Kullanıcı bilgileri güncellenirken bir hata oluştu.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.Message + "');</script>");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtUserID.Value);

                string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Kullanicilar WHERE ID = @ID";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@ID", ID);

                    int affectedRows = deleteCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Response.Write("<script>alert('Kullanıcı başarıyla silindi.');</script>");

                        BindGridView();
                    }
                    else
                    {
                        Response.Write("<script>alert('Kullanıcı silinirken bir hata oluştu.');</script>");
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