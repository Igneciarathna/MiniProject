using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Feedback_System
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void StudentLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-C9IAO23\SQLEXPRESS;initial Catalog=LoginDB;Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM tblStud WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = txtUserName.Text.Trim();
                    Response.Redirect("Feedback.aspx");
                }
                else { lblErrorMessage.Visible = true; }
            }
        }
    }
}