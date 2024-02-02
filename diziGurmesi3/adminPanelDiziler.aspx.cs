using System;
using System.Data;
using System.Data.SqlClient;

namespace diziGurmesi3
{
    public partial class adminPanelDiziler : System.Web.UI.Page
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
                string query = "SELECT * FROM Diziler";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridViewDiziler.DataSource = dataTable;
                gridViewDiziler.DataBind();
            }
        }
        protected void btnDiziEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string diziAdi = txtDiziAdi.Text;
                string diziAciklama = txtDiziAciklama.Text;
                decimal diziPuani = Convert.ToDecimal(txtDiziPuani.Text);
                string diziFragman = txtDiziFragman.Text;
                string diziKategori = ddlDiziKategori.SelectedValue;
                string diziFoto = txtDiziFoto.Text;

                string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Diziler (DiziAdi, DiziAciklama, DiziPuan, DiziFragman, DiziKategori, DiziFoto) VALUES (@DiziAdi, @DiziAciklama, @DiziPuani, @DiziFragman, @DiziKategori, @DiziFoto)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@DiziAdi", diziAdi);
                        insertCommand.Parameters.AddWithValue("@DiziAciklama", diziAciklama);
                        insertCommand.Parameters.AddWithValue("@DiziPuani", diziPuani);
                        insertCommand.Parameters.AddWithValue("@DiziFragman", diziFragman);
                        insertCommand.Parameters.AddWithValue("@DiziKategori", diziKategori);
                        insertCommand.Parameters.AddWithValue("@DiziFoto", diziFoto);
                        int affectedRows = insertCommand.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            Response.Write("<script>alert('Dizi başarıyla eklendi.');</script>");
                            BindGridView();
                        }
                        else
                        {
                            Response.Write("<script>alert('Dizi eklenirken bir hata oluştu.');</script>");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.ToString() + "');</script>");
            }
        }
        protected void btnDiziBul_Click(object sender, EventArgs e)
        {
            try
            {
                string diziAdi = txtDiziAdi.Text.Trim();

                if (!string.IsNullOrEmpty(diziAdi))
                {
                    string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Diziler WHERE DiziAdi LIKE '%' + @DiziAdi + '%'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DiziAdi", diziAdi);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            gridViewDiziler.DataSource = dataTable;
                            gridViewDiziler.DataBind();
                        }
                        else
                        {
                            Response.Write("<script>alert('Dizi bulunamadı.');</script>");
                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('Lütfen bir dizi adı girin.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.Message + "');</script>");
            }
        }
        protected void btnDiziGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string diziAdi = txtDiziAdi.Text.Trim();
                string yeniDiziAciklama = txtDiziAciklama.Text.Trim();
                decimal yeniDiziPuan = Convert.ToDecimal(txtDiziPuani.Text.Trim());
                string yeniDiziFragman = txtDiziFragman.Text.Trim();
                string yeniDiziKategori = ddlDiziKategori.SelectedValue;
                string yeniDiziFoto = txtDiziFoto.Text.Trim();

                string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Diziler SET DiziAciklama = @YeniDiziAciklama, DiziPuan = @YeniDiziPuan, DiziFragman = @YeniDiziFragman, DiziKategori = @YeniDiziKategori, DiziFoto = @YeniDiziFoto WHERE DiziAdi = @DiziAdi";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@YeniDiziAciklama", yeniDiziAciklama);
                    updateCommand.Parameters.AddWithValue("@YeniDiziPuan", yeniDiziPuan);
                    updateCommand.Parameters.AddWithValue("@YeniDiziFragman", yeniDiziFragman);
                    updateCommand.Parameters.AddWithValue("@YeniDiziKategori", yeniDiziKategori);
                    updateCommand.Parameters.AddWithValue("@YeniDiziFoto", yeniDiziFoto);
                    updateCommand.Parameters.AddWithValue("@DiziAdi", diziAdi);

                    int affectedRows = updateCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Response.Write("<script>alert('Dizi başarıyla güncellendi.');</script>");
                        BindGridView();
                    }
                    else
                    {
                        Response.Write("<script>alert('Güncelleme sırasında bir hata oluştu veya güncellenecek dizi bulunamadı.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata oluştu: " + ex.Message + "');</script>");
            }
        }
        protected void btnDiziSil_Click(object sender, EventArgs e)
        {
            try
            {
                string diziAdi = txtDiziAdi.Text.Trim();

                string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=diziGurmesi;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Diziler WHERE DiziAdi = @DiziAdi";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@DiziAdi", diziAdi);

                    int affectedRows = deleteCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Response.Write("<script>alert('Dizi başarıyla silindi.');</script>");
                        BindGridView();
                    }
                    else
                    {
                        Response.Write("<script>alert('Silinecek dizi bulunamadı veya silme sırasında bir hata oluştu.');</script>");
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

