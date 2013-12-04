using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BSocial;

namespace screen_crawler.BReader
{
    class SelectWord 
    {

        private static bool rs = true;
        private static bool brloop = true;
/// <summary>
///choses at random and sets text value
/// </summary>
/// <returns> returns false if no more text to randomly choose from</returns>
        public static bool GetShortText()
        {
           // bool rs = true;
           // bool brloop = true;
            Random data = new Random();
            int i = data.Next(TextGen.RandomWord.Length);
            // does not loop through all the data

            ///if true keeps on adding to string sets value to null
            if (brloop == true)
            {
                if (isNull(i) != true)
                {
                    TextGen.ChosenWord += String.Format("{0} ", TextGen.RandomWord[i]);
                    TextGen.RandomWord[i] = null;

                }
                else
                {

                    for (int a = 0; TextGen.RandomWord.Length > a; a++)
                    {
                        if (isNull(a) != true)
                        {
                            brloop = true;
                            break;
                        }
                        else { brloop = false; }
                    }

                }


            }
            else
            { 
                rs = false;
            }
            return rs;
        }

        /// <summary>
        /// checks to see if array is null
        /// </summary>
        /// <param name="i">array value</param>
        /// <returns>returns true if null false if not</returns>
private static bool isNull(int i)
{
 	 return (TextGen.RandomWord[i] == null);
}
           
           
         

       

        
    }
}
