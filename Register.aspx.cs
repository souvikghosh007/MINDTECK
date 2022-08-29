using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Myfirstweb
{
    public partial class Mindteck : System.Web.UI.Page
    {
        SqlConnection SqlCon = new SqlConnection();
        SqlCommand com = new SqlCommand();
        string myConnectionString = ConfigurationManager.ConnectionStrings["StrCons"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsv_Click(object sender, EventArgs e)
        {
            string gender = "";
            string status = string.Empty;
            try
            {
                SqlCon.ConnectionString = (myConnectionString);
                SqlCon.Open();
                com.Connection = SqlCon;
                com.CommandText = "INSERT INTO [dbo].[StudentRegistration] (Name,Address,[Price Date],[Brand Name],State,Gender,Status,Time) VALUES (@Name,@Adress,@PriceDate,@BrandName,@State,@Gender,@Status,@Time)";
                com.Parameters.AddWithValue("@Name", textName.Text.Trim());
                com.Parameters.AddWithValue("@Adress", textAdress.Text.Trim());
                com.Parameters.AddWithValue("@PriceDate", textPriceDate.Text.Trim());
                com.Parameters.AddWithValue("@BrandName", textBrandName.Text.Trim());
                com.Parameters.AddWithValue("@State", textstate.SelectedItem.Value);

                if (rbMale.Checked)
                {
                    gender = rbMale.Text;
                }
                else if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                com.Parameters.AddWithValue("@Gender", gender);
                if (CheckBox1.Checked)
                {
                    status = "Active";
                }
                else if (CheckBox2.Checked)
                {
                    status = "Inactive";
                }
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@Time", texttime.Text.Trim());
                com.ExecuteNonQuery();
                SqlCon.Close();

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

    }
}