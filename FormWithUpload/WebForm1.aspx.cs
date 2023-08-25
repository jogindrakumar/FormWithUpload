using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace FormWithUpload
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            String filePath = "";

            if (FileUpload1.HasFile)
            {

                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if(fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".docx" && fileExtension.ToLower() != ".pdf")
                {
                    lblMessage.Text = "File only with .doc or .docx or .pdf format are allowed";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if(fileSize  > 2097152)
                    {
                        lblMessage.Text = "Maximum file size (2MB) exceeded";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    //FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                     filePath = Server.MapPath("~/Uploads/" + FileUpload1.FileName);
                    FileUpload1.SaveAs(filePath);
                   
                    //Directory.GetFiles(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                    lblMessage.Text = "file uploaded";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                
            }
            else
            {
                lblMessage.Text = "Please file upload";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

            try
            {
              

                String qry = "insert into Table_1(link) values(@FileUpload1)";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);



                cmd.Parameters.AddWithValue("@FileUpload1", filePath);
            }
            catch (Exception ex)
            {


                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
           

        }
    }
}