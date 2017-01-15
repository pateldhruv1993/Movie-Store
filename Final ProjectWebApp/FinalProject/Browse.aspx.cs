/*
 * Author: Dhruv Patel
 * 
 * Description: This class will show all the items available in the store.
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
    public partial class Browse : System.Web.UI.Page
    {

        /// <summary>
        ///  Generates and inserts a catalog into the 'contents' that will have all the items of the items table.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sLoggedIn"] !=null && Session["sLoggedIn"].Equals(true))
            {
                divLoginBox.InnerHtml= "Hi, " + Session["sUsername"].ToString() + "&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp; <a href='Checkout.aspx'>Checkout</a>";
            }


            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            List<Item> itemArrayList = new List<Item>();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["FinalProjectConnectionString"].ConnectionString;

                cmd.CommandText = "SELECT * FROM items;";

                cmd.Connection = con;
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        Item tempItem;
                        List<Item> addThisListToSession = new List<Item>();

                        //Will create an ItemIsTV or ItemIsMovie object depending upon the type of item. This will allow us to call the item specific functions that these subclasses override
                        if (reader.GetString(5) == "tv")
                        {
                            tempItem = new ItemIsTV(reader.GetString(2),reader.GetString(1),reader.GetInt32(3), reader.GetString(6), reader.GetInt32(4), reader.GetInt32(0));
                        }
                        else
                        {
                            tempItem = new ItemIsMovie(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetString(6), reader.GetInt32(4), reader.GetInt32(0));
                        }

                        if(Request.QueryString["addItem"] != null && Convert.ToInt32(Request.QueryString["addItem"]) == reader.GetInt32(0)){
                            if (Session["sCartItems"] != null)
                            {
                                addThisListToSession = (List<Item>)Session["sCartItems"];
                                addThisListToSession.Add(tempItem);
                            } else if(Session["sCartItems"] == null){
                                addThisListToSession.Add(tempItem);
                            }

                            Session["sCartItems"] = addThisListToSession;
                        }
                        
                        itemArrayList.Add(tempItem);
                    }
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



            divItemList.InnerHtml = "";
            for (int counter = 0; counter < itemArrayList.Count; counter++)
            {
                divItemList.InnerHtml += "<div style=\"float:left; outline:1px solid black; width:150px; margin: 10px 10px 0 0;\">"
                + "<img src =\"./Media/" + itemArrayList[counter].getImage().Trim() + "\" style=\" outline:1px solid black;width:150px; height:222px;\"/><br /><div id='divItemDetails-"+itemArrayList[counter].getItemId() +"' style=\"margin:3px;\"><span style=\"font-size: 20px; font-weight:bold;\">"
                + itemArrayList[counter].getName().Trim() + " <img src=\"./Media/" + itemArrayList[counter].getImageForType().Trim() + "\" style=\"height:20px; width:20px;\"/></span><br />"
                + "Rating: " + itemArrayList[counter].getRating().Trim() + " <br />"
                + "Price: $" + itemArrayList[counter].getPrice() + " &nbsp;&nbsp; QTY: " + itemArrayList[counter].getQty() + "<br />"
                + "<a href='Browse.aspx?addItem=" + itemArrayList[counter].getItemId() +  "'>Add to Cart</a></div></div>";

            }


        }

        /// <summary>
        ///  Redirects the user to the login page if he/she clicks on the login button (The button will only be visible if the user is not logged in already).
        /// </summary>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", true);
        }

    }
}