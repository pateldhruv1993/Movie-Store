using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProject
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///  Function that will add the new users details into the database.
        /// </summary>
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Hashing hasingObject = new Hashing();
            SqlConnection courseConnect = new SqlConnection();
            courseConnect.ConnectionString = ConfigurationManager.ConnectionStrings["FinalProjectConnectionString"].ConnectionString;
            try
            {
                SqlCommand cmd = courseConnect.CreateCommand();
                string query = "INSERT INTO users(username, pwd, creditCard, address, email) VALUES ('"+tbUsername.Text+"', '"+
                    hasingObject.CalculateMD5Hash(tbPwd.Text)+"', '"+tbCreditCard.Text+"', '"+tbAddress.Text+"', '"+tbEmail.Text+"');";
                cmd.CommandText = query;
                courseConnect.Open();
                cmd.ExecuteScalar();
                Response.Redirect("Login.aspx", true);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                courseConnect.Close();
            }
        }
    }
}