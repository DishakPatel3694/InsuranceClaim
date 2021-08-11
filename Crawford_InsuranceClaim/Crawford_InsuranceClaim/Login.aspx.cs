using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Crawford_InsuranceClaim
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["crawford"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    
        protected void btnLogin_Click(object sender, EventArgs e)
        {
                try
                {
                  
                    SqlCommand cmd = new SqlCommand("select * from users where UserName=@Username and Password=@Password", con);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                    if (dt.Rows[0][4].ToString() == "False")
                    {
                        dvMessage.Visible = true;
                        lblMessage.Text = "User ID is not activated..!!";
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }
                    else
                    {
                        dvMessage.Visible = false;
                        Session["UserID"] = dt.Rows[0][0].ToString();
                        Session["Username"] = dt.Rows[0][3].ToString();
                        Response.Redirect("LossTypes.aspx");
                    }
                    }
                    else
                    {
                        dvMessage.Visible = true;
                        lblMessage.Text = "UserId & Password Is not correct Try again..!!";
                        txtPassword.Text = "";
                        txtUsername.Text = "";

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }

}