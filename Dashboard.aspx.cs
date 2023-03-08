using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Feedback_System
{
    public partial class Dashboard : System.Web.UI.Page
    {
        string connectionString = @"Data Source=DESKTOP-C9IAO23\SQLEXPRESS;Integrated Security=true;Initial Catalog=LoginDB";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                PopulateGridview();
        }
        void PopulateGridview()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM FacultyTbl", sqlCon);
                sqlDa.Fill(dtbl);
            }
            if (dtbl.Rows.Count > 0)
            {
                gvFaculty.DataSource = dtbl;
                gvFaculty.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                gvFaculty.DataSource = dtbl;
                gvFaculty.DataBind();
                gvFaculty.Rows[0].Cells.Clear();
                gvFaculty.Rows[0].Cells.Add(new TableCell());
                gvFaculty.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                gvFaculty.Rows[0].Cells[0].Text = "No Data Found ..!";
                gvFaculty.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void gvFaculty_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        string query = "INSERT INTO FacultyTbl (FacultyName,Subject) VALUES (@FacultyName,@Subject)";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@FacultyName", (gvFaculty.FooterRow.FindControl("txtFacultyNameFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Subject", (gvFaculty.FooterRow.FindControl("txtSubjectFooter") as TextBox).Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        PopulateGridview();
                        lblSuccessMessage.Text = "New Record Added";
                        lblErrorMessage.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gvFaculty_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvFaculty.EditIndex = e.NewEditIndex;
            PopulateGridview();
        }

        protected void gvFaculty_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvFaculty.EditIndex = -1;
            PopulateGridview();
        }

        protected void gvFaculty_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "UPDATE FacultyTbl SET FacultyName=@FacultyName,Subject=@Subject WHERE FacultyID = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@FacultyName", (gvFaculty.Rows[e.RowIndex].FindControl("txtFacultyName") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Subject", (gvFaculty.Rows[e.RowIndex].FindControl("txtSubject") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gvFaculty.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    gvFaculty.EditIndex = -1;
                    PopulateGridview();
                    lblSuccessMessage.Text = "Selected Record Updated";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gvFaculty_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM FacultyTbl WHERE FacultyID = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gvFaculty.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    PopulateGridview();
                    lblSuccessMessage.Text = "Selected Record Deleted";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }
    }
}