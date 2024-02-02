using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diziGurmesi3
{
    public partial class masterPage : System.Web.UI.MasterPage
    {
        protected TextBox txtSearch;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtSearch = (TextBox)FindControl("txtSearch");
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text;
            string query = "SELECT * FROM Diziler WHERE DiziAdi LIKE '%' + @Keyword + '%'";
            Response.Redirect($"SearchResults.aspx?keyword={searchKeyword}");
        }
    }
}