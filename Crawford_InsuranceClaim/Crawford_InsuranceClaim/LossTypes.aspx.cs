using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crawford_InsuranceClaim
{
    public partial class LossTypes : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                lblusername.Text = Session["Username"].ToString();
                this.BindListView();
            }
        }


        private void BindListView()
        {
            string constr = ConfigurationManager.ConnectionStrings["crawford"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT LossTypeId, LossTypeCode, LossTypeDescription FROM LossTypes where LastUpdatedId= '" + Session["UserId"] + "'";
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        lvCustomers.DataSource = dt;
                        lvCustomers.DataBind();
                    }
                }
            }
        }

        
    }
}