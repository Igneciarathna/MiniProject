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
    public partial class StudentsFeedback : System.Web.UI.Page
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StaffTbl", sqlCon);
                sqlDa.Fill(dtbl);
            }
            if (dtbl.Rows.Count > 0)
            {
                gvStaff.DataSource = dtbl;
                gvStaff.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                gvStaff.DataSource = dtbl;
                gvStaff.DataBind();
                gvStaff.Rows[0].Cells.Clear();
                gvStaff.Rows[0].Cells.Add(new TableCell());
                gvStaff.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                gvStaff.Rows[0].Cells[0].Text = "No Data Found ..!";
                gvStaff.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void gvStaff_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        string query = "INSERT INTO StaffTbl (FacultyName,Subject,Question1,Question2,Question3,Question4,Question5) VALUES (@FacultyName,@Subject,@Question1,@Question2,@Question3,@Question4,@Question5)";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@FacultyName", (gvStaff.FooterRow.FindControl("txtFacultyNameFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Subject", (gvStaff.FooterRow.FindControl("txtSubjectFooter") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Question1", (gvStaff.FooterRow.FindControl("txtQuestion1Footer") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Question2", (gvStaff.FooterRow.FindControl("txtQuestion2Footer") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Question3", (gvStaff.FooterRow.FindControl("txtQuestion3Footer") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Question4", (gvStaff.FooterRow.FindControl("txtQuestion4Footer") as TextBox).Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Question5", (gvStaff.FooterRow.FindControl("txtQuestion5Footer") as TextBox).Text.Trim());
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

        protected void gvStaff_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStaff.EditIndex = e.NewEditIndex;
            PopulateGridview();
        }

        protected void gvStaff_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStaff.EditIndex = -1;
            PopulateGridview();
        }

        protected void gvStaff_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "UPDATE StaffTbl SET FacultyName=@FacultyName,Subject=@Subject,Question1=@Question1,Question2=@Question2,Question3=@Question3,Question4=@Question4,Question5=@Question5 WHERE StaffID = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@FacultyName", (gvStaff.Rows[e.RowIndex].FindControl("txtFacultyName") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Subject", (gvStaff.Rows[e.RowIndex].FindControl("txtSubject") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Question1", (gvStaff.Rows[e.RowIndex].FindControl("txtQuestion1") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Question2", (gvStaff.Rows[e.RowIndex].FindControl("txtQuestion2") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Question3", (gvStaff.Rows[e.RowIndex].FindControl("txtQuestion3") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Question4", (gvStaff.Rows[e.RowIndex].FindControl("txtQuestion4") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Question5", (gvStaff.Rows[e.RowIndex].FindControl("txtQuestion5") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gvStaff.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    gvStaff.EditIndex = -1;
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

        protected void gvStaff_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "DELETE FROM StaffTbl WHERE StaffID = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gvStaff.DataKeys[e.RowIndex].Value.ToString()));
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