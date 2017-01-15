/*
 * Author: Dhruv Patel
 * 
 * Description: The superclass for store item that will store the comman variables like item name, item price, item image, item id etc.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class Item
    {
        /// <summary>
        ///  Field variable that will store the item name.
        /// </summary>
        protected String _name;
        /// <summary>
        ///  Field variable that will store the item price.
        /// </summary>
        protected int _price;
        /// <summary>
        ///  Field variable that will store the image name for the item.
        /// </summary>
        protected String _image;
        /// <summary>
        ///  Field variable that will imdb ID of the particular item.
        /// </summary>
        protected String _imdb;
        /// <summary>
        ///  Field variable that will store the available quantity of the item.
        /// </summary>
        protected int _qty;
        /// <summary>
        ///  Field variable that will store the item ID.
        /// </summary>
        protected int _id;

        /// <summary>
        ///  Operator overload function that will return the sum of the prices of the 2 items
        /// </summary>
        public static int operator +(Item i1, Item i2)
        {
            return i1._price + i2._price;
        }

        /// <summary>
        ///  Operator overload function that will return the sum of the price of the item and the int
        /// </summary>
        public static int operator +(int i1, Item i2)
        {
            return i1 + i2._price;
        }

        /// <summary>
        ///  Operator overload function that will return the sum of the price of the item and the int
        /// </summary>
        public static int operator +(Item i1, int i2)
        {
            return i1._price + i2;
        }


        /// <summary>
        ///  Get the item name of the Item object.
        /// </summary>
        public String getName()
        {
            return _name;
        }


        /// <summary>
        ///  Get the item price of the Item object.
        /// </summary>
        public int getPrice()
        {
            return _price;
        }

        /// <summary>
        ///  Get the image name of the Item object.
        /// </summary>
        public String getImage()
        {
            return _image;
        }

        /// <summary>
        ///  Get the item ID of the Item object.
        /// </summary>
        public int getItemId()
        {
            return _id;
        }

        /// <summary>
        ///  Get the available quantity of the Item object.
        /// </summary>
        public int getQty()
        {
            return _qty;
        }

        /// <summary>
        ///  This function is overridden by the subclasses
        /// </summary>
        public virtual String getImageForType()
        {
            return "";
        }

        /// <summary>
        ///  This function is overridden by the subclasses
        /// </summary>
        public virtual String getRating()
        {
            return "";
        }
    }
}