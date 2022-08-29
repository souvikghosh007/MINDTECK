using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mysecondapp
{
    public partial class Regitration : System.Web.UI.Page
    {
        SqlConnection SqlCon = new SqlConnection();
        SqlCommand com = new SqlCommand();
        string myConnectionString = ConfigurationManager.ConnectionStrings["StrCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRegistrationDetails();

            }

        }
        private void LoadRegistrationDetails()
        {
            try
            {
                SqlCon.ConnectionString = (myConnectionString);
                SqlCon.Open();
                com = new SqlCommand("GetRegistrationDetails", SqlCon);// passing stored proc name here 
                com.CommandType = CommandType.StoredProcedure; // stored proc
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grdDetails.DataSource = ds;
                grdDetails.DataBind();
                SqlCon.Close();


            }

            catch (Exception ex)
            {
                throw ex;

            }

        }

    }
}