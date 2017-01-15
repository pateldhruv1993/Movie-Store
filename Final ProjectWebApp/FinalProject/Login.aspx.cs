/*
 * Author: Dhruv Patel
 * 
 * Description: The function in this class will allow the users to create a new session and will log them in so that they can add items to  cart and place order.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using System.Configuration;

namespace FinalProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///  Function that will create a new session for the user if he/she has entered the correct credentials.
        /// </summary>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["FinalProjectConnectionString"].ConnectionString;
                
                cmd.CommandText = "SELECT * FROM users WHERE users.username = '"+tbUsername.Text+"';";
                
                cmd.Connection = con;
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(1))
                        {
                            Hashing hashObject = new Hashing();
                            if (hashObject.CalculateMD5Hash(tbPwd.Text) == reader.GetString(2))
                            {
                                this.Session.Add("sLoggedIn", true);
                                this.Session.Add("sUsername", reader.GetString(1));
                                this.Session.Add("sUserId", reader.GetInt32(0));
                                this.Session.Add("sShipAddress", reader.GetString(4));
                                this.Session.Add("sUserEmail", reader.GetString(5));
                                Response.Redirect("Browse.aspx", false);
                            }
                            else
                            {
                                lblWrongDetails.Visible = true;
                            }
                        }
                    }
                }
                else
                {
                    lblWrongDetails.Visible = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx", true);
        }

       
    }
}