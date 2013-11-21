using System;
using Microsoft.VisualBasic.FileIO;

namespace screen_crawler
{
    class ReadFile
    {
        /// <summary>
        /// reads CSV file that contains random strings
        /// </summary>
        /// <returns> will return a string/array of texts</returns>
        internal static string ReadCSV()
        {
            string data ="";

            using(TextFieldParser sd = new TextFieldParser(FilePath))
            {
                sd.TextFieldType = FieldType.Delimited;
                sd.SetDelimiters(",");

                // read csv file until empty
                while (!sd.EndOfData)
                {
                    string[] ofFields = sd.ReadFields();
                    foreach (string datr in ofFields)
                    {
                        data += datr + Environment.NewLine;
                    }
                }


            }
            return data;
        }

        public static string FilePath { get; set; }
    }
}
