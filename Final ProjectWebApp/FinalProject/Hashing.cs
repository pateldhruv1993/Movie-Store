/*
 * Author: Dhruv Patel
 * 
 * Description: Function that will be called by the Register page and the login page to store/compare the users hashed password
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace FinalProject
{
    public class Hashing
    {
        public Hashing() { }

        /// <summary>
        ///  Function that will retun the MD5 hashed string from the input.
        /// </summary>
        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}