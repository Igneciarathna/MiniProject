using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace Feedback_System
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Import_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string path = Server.MapPath("~/ExcelFile/Feedback.xlsx");
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";
            conn.ConnectionString = connString;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from[Sheet6$]", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            GridView1.DataSource = rd;
            GridView1.DataBind();
        }
    }
}