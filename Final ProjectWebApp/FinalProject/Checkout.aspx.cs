/*
 * Author: Dhruv Patel
 * 
 * Description: This class will handle the final stage or order placement. It will add the order into the database and show user the items that they've added in their carts.
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
    public partial class Checkout : System.Web.UI.Page
    {

        /// <summary>
        ///  Show the items in the users cart or show the order confimation depending upon the Request.QueryString values.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sLoggedIn"] != null && Session["sLoggedIn"].Equals(true))
            {
                divLoginBox.InnerHtml = "Hi, " + Session["sUsername"].ToString();
            }
            else
            {
                Response.Redirect("Browse.aspx",true);
            }


            if (Session["sCartItems"] != null)
            {
                divCheckoutList.InnerHtml = "";
                List<Item> checkoutList = new List<Item>();
                //Casting objects inside the sCartItems session variable into a List so that we can loop through these objects. 
                checkoutList = (List<Item>)Session["sCartItems"];
                divCheckoutList.InnerHtml = "";
                int totalPrice = 0;
                for (int counter = 0; counter < checkoutList.Count; counter++)
                {
                    totalPrice += checkoutList[counter];
                    divCheckoutList.InnerHtml += "<div style=\"outline:1px solid black;margin:10px 10px 0 10px; float:left; clear:both; width:100%;\">" +
                    "<img src=\"./Media/"+checkoutList[counter].getImage()+"\" style=\"height:100px; width: auto; outline:1px solid black; float:left;\" /> " +
                    "<div style=\"float:left; margin-left:10px;\">" +
                    "<span style=\"font-weight:bold; font-size:22px;\">" + checkoutList[counter].getName() +
                    "<img src=\"./Media/"+checkoutList[counter].getImageForType()+"\" style=\"height:22px;\" /></span> <br> Price: $"+checkoutList[counter].getPrice()+"<br>Available Quantity: "+checkoutList[counter].getQty()+"</div></div>";
                }

                lblTotalPrice.Text = "$"+totalPrice;

            }
            else if (Request.QueryString["placedOrder"] != null && Request.QueryString["placedOrder"] == "true")
            {
                divCheckoutList.InnerHtml = "<span style='margin:22px'>Your order was placed successfully.</span> <br>" +
                                            "<div style='margin:20px;'> <span style='font-size:20px;'>Order Details:<br/></span>" +
                                            "Your order will be shipped to: " + Session["sShipAddress"] + "<br/><br/>" +
                                            "A confirmation email has been sent to your email address (" + Session["sUserEmail"] + ").</div>";

            }
            else
            {
                divCheckoutList.InnerHtml = "<span style='margin:20px'>Your cart is empty.</span>";
            }
        }


        /// <summary>
        ///  Inserts the items in the users cart into ordes database
        /// </summary>
        protected void btnCheckout_Click(object sender, EventArgs e)
        {

            SqlConnection courseConnect = new SqlConnection();
            courseConnect.ConnectionString = ConfigurationManager.ConnectionStrings["FinalProjectConnectionString"].ConnectionString;

            bool connectionClosed = false;

            try
            {
                List<Item> orderItems = new List<Item>();
                //Casting objects inside the sCartItems session variable into a List so that we can loop through these objects. 
                orderItems = (List<Item>)Session["sCartItems"];
                
                for (int counter = 0; counter < orderItems.Count; counter++)
                {
                    SqlCommand cmd = courseConnect.CreateCommand();
                    string query = "INSERT INTO orders(userId, itemId, qty, shipAddress) VALUES ("+Session["sUserId"]+", "+orderItems[counter].getItemId()+", 1, '"+Session["sShipAddress"]+"');";
                    cmd.CommandText = query;
                    courseConnect.Open();
                    cmd.ExecuteScalar();
                    courseConnect.Close();
                }
                Session["sCartItems"] = null;
            }
            catch (Exception ex)
            {
                divCheckoutList.InnerHtml = ex.ToString();
            }
            finally
            {
                if (!connectionClosed)
                {
                    courseConnect.Close();
                    connectionClosed = true;
                }
            }

            Response.Redirect("Checkout.aspx?placedOrder=true",true);
        }


        /// <summary>
        ///  Removes all the items from users cart.
        /// </summary>
        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            divCheckoutList.InnerHtml = "";
            lblTotalPrice.Text = "";
            Session["sCartItems"] = null;
        }
    }
}