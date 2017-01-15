/*
 * Author: Dhruv Patel
 * 
 * Description: The class that will help in adding a new item into the database and delete shipped orders
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProjectWindowsApp
{
    public partial class Form1 : Form
    {
        private String _conString = "Server=(local); Database=FinalProject; User=dhruv; Password=dhruv";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  This function will clear out all the textboxes.
        /// </summary>
        public void clearAllTextBoxes()
        {
            tbItemImage.Text = "";
            tbItemIMDB.Text = "";
            tbItemName.Text = "";
            tbItemPrice.Text = "";
            tbItemQty.Text = "";
            tbItemType.Text = "";
        }

        /// <summary>
        ///  Get all the values from the text boxes and adds the item into the database
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String itemName = tbItemName.Text;
            String itemImage = tbItemImage.Text;
            String itemPrice = tbItemPrice.Text;
            String itemQty = tbItemQty.Text;
            String itemType = tbItemType.Text;
            String itemIMDB = tbItemIMDB.Text;

            if ((itemName == "") || (itemImage == "") || (itemPrice == "") || (itemQty == "") || (itemType == ""))
            {
                MessageBox.Show(
                    "No textbox can be empty!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection courseConnect = new SqlConnection();
                courseConnect.ConnectionString = _conString;

                SqlCommand cmd = courseConnect.CreateCommand();

                try
                {
                    string query = "INSERT INTO items(image, itemName, itemPrice, availableQty, itemType, imdb) VALUES" +
                        "('" + itemImage + "', '" + itemName + "'," + Convert.ToInt32(itemPrice) + "," + Convert.ToInt32(itemQty) + ",'" + itemType + "','" + itemIMDB + "')";

                    cmd.CommandText = query;
                    courseConnect.Open();

                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                   ex.ToString(),
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                finally
                {
                    courseConnect.Close();
                }

                clearAllTextBoxes();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        /// <summary>
        ///  Fills the textboxes depending upon the order Id that is selected
        /// </summary>
        private void comboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(comboOrderId.SelectedValue);

            SqlConnection courseConnect = new SqlConnection();
            courseConnect.ConnectionString = _conString;
            SqlCommand cmd = courseConnect.CreateCommand();

            try
            {
                string query = "Select * from orders where orderId="
                    + orderID;
                cmd.CommandText = query;
                courseConnect.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();

                string userId = dt.Rows[0][1].ToString();
                tbUserId.Text = userId;

                string itemId = dt.Rows[0][2].ToString();
                tbItemId.Text = itemId;

                string itemQty = dt.Rows[0][3].ToString();
                tbShipQty.Text = itemQty;

                string address = dt.Rows[0][4].ToString();
                tbShipAddress.Text = address;

            }
            catch (Exception ex)
            {
            }
            finally
            {
                courseConnect.Close();
            }

        }


        /// <summary>
        ///  Deletes the selected order from the database
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(comboOrderId.SelectedValue);

            SqlConnection courseConnect = new SqlConnection();
            courseConnect.ConnectionString = _conString;
            SqlCommand cmd = courseConnect.CreateCommand();

            try
            {
                string query = "Delete from orders where orderId=" + orderID;
                cmd.CommandText = query;
                courseConnect.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                courseConnect.Close();
            }
            loadComboBox();
        }


        /// <summary>
        ///  Populates the combo box with all the available order IDs
        /// </summary>
        private void loadComboBox()
        {
            SqlConnection courseConnect = new SqlConnection();
            courseConnect.ConnectionString = _conString;

            SqlCommand cmd = courseConnect.CreateCommand();

            try
            {
                string query = "Select * from orders";

                cmd.CommandText = query;
                courseConnect.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();

                comboOrderId.DisplayMember = "orderId";
                comboOrderId.ValueMember = "orderId";
                comboOrderId.DataSource = dt;
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
