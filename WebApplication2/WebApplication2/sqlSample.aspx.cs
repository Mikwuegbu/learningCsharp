using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication2
{
    public partial class sqlSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conString = "data source=.; database = Ado.net; user id = sa; password = Declare";
            using (SqlConnection con = new SqlConnection(conString))
            {
                // lesson on SQL Injection Check Injection prevention
                string command = "select * from register where Name like '" + TextBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(command, con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}