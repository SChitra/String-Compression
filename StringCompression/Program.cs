using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    /*** Implement a method to perform a basic string compression using the counts of repeated characters. 
    For example, the string aabccccaaa would become a2b1c4a3. If the compressed string would not become smaller than the original string, your method should return the original string.   
    class Program ***/

    class Program
    {
        public static string CompressionCount(string str)
        {
            string compressedString = "";
            char chacracter = str[0];
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == chacracter)
                {
                    count++;

                }
                else
                {
                    compressedString = compressedString + chacracter + "" + count;
                    //character last seen
                    chacracter = str[i];
                    
                    count = 1;
                }
                
            }
            
            return compressedString + chacracter + count;

        }




        static void Main(string[] args)
        {
            //string str = "aab";
            string str = "aabbbbbbbbbbcccc";
            //string str = "ab";
            int size = CompressionCount(str).Length;
            if (size > str.Length)
            {
                Console.WriteLine(str);
            }
            else
                Console.WriteLine(CompressionCount(str));

        }
    }
}
