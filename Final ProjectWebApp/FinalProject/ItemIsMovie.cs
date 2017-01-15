/*
 * Author: Dhruv Patel
 * 
 * Description: The subclass of the Item class that will override getImageForType() method and the getRating() method of the superclass.
 *              This class will have functions that are related to movie items.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class ItemIsMovie:Item
    {
        public ItemIsMovie(String itemName, String itemImage, int itemPrice, String itemImdb, int itemQty, int itemId)
        {
            _name = itemName;
            _price = itemPrice;
            _image = itemImage;
            _imdb = itemImdb;
            _qty = itemQty;
            _id = itemId;
        }

        /// <summary>
        ///  Returns the image name of the icon, for movie items.
        /// </summary>
        public override string getImageForType()
        {
            return "movieIcon.png";
        }

        /// <summary>
        ///  Returns the rotten tomato rating for the particular movie by using a 3rd party API.
        /// </summary>
        public override string getRating()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("http://www.omdbapi.com/?i=" + _imdb + "&tomatoes=true");
            

            //Converting raw data into UTF8 encoded string for easier string manipulation.
            String webdata = System.Text.Encoding.UTF8.GetString(raw);
            int start = webdata.IndexOf("tomatoMeter\":\"");
            if(start == -1){
                return "N/A";
            }
            start+= 14;
            int end = webdata.IndexOf("\"", start);
            String rating = webdata.Substring(start, (end - start));
            return rating + "&nbsp;<img src = './Media/rottenIcon.png' style='height:15px; width:15px;'/>";
        }
    }
}