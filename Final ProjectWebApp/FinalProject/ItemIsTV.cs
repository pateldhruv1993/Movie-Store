/*
 * Author: Dhruv Patel
 * 
 * Description: The subclass of the Item class that will override getImageForType() method and the getRating() method of the superclass.
 *              This class will have functions that are related to tv show items.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class ItemIsTV:Item
    {
        public ItemIsTV(String itemName, String itemImage, int itemPrice, String itemImdb, int itemQty, int itemId)
        {
            _name = itemName;
            _price = itemPrice;
            _image = itemImage;
            _imdb = itemImdb;
            _qty = itemQty;
            _id = itemId;
        }

        /// <summary>
        ///  Returns the image name of the icon, for tv shows.
        /// </summary>
        public override string getImageForType()
        {
            return "tvShowIcon.png";
        }


        /// <summary>
        ///  Returns the imdb rating for the particular tv show by using a 3rd party API.
        /// </summary>
        public override string getRating()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("http://www.omdbapi.com/?i=" + _imdb);
            //Converting raw data into UTF8 encoded string for easier string manipulation.
            String webdata = System.Text.Encoding.UTF8.GetString(raw);
            int start = webdata.IndexOf("imdbRating\":\"");

            if (start == -1)
            {
                return "N/A";
            }
            start += 13;
            int end = webdata.IndexOf("\"", start);
            String rating = webdata.Substring(start, (end-start));
            rating = rating.Replace(".","");
            return rating + "&nbsp;<img src = './Media/imdbIcon.jpg' style='height:15px;'/>";
        }
    }
}