using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Samples
{
    public partial class getting_started : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Tie;Data Source=(local)\sqlexpress";
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, Slug, CreatedDate, UpdatedDate, Version FROM Page", conn);
                    adapter.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }
            catch
            {
            }
        }

        protected void TabControl1_TabPageChanged(object sender, Tie.Controls.Bootstrap.TabPageChangedEventArgs e)
        {

        }

        protected void Paginator2_PageIndexChanged(object sender, Tie.Controls.Bootstrap.PageChangedEventArgs e)
        {
            lblPaginator.Text = "Current Page: " + (e.Index + 1).ToString();
        }
    }
}