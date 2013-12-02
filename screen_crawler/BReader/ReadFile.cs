using System;
using Microsoft.VisualBasic.FileIO;
using screen_crawler.BSocial;
using System.Collections.Generic;

namespace screen_crawler.BReader
{
    class ReadFile
    {
        /// <summary>
        /// reads CSV file that contains random strings
        /// </summary>
        /// <returns> will return a string/texts for debugging</returns>
        internal static void ReadCSV()
        {
            

            using(TextFieldParser sd = new TextFieldParser(FilePath))
            {
                sd.TextFieldType = FieldType.Delimited;
                sd.SetDelimiters(",");
                List<string> ofField = new List<string>();
                // read csv file until empty
                while (!sd.EndOfData)
                {
                    
                    string[] ofFields = sd.ReadFields();

                    foreach (string datr in ofFields)
                    {
                        ofField.Add(datr);
                    }
                }
                TextGen.RandomWord = ofField.ToArray();


            }
           
        }

        public static string FilePath { get; set; }
    }
}
