using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class BookOperations
    {
        private string ReadFromFile()
        {
            string pathSource = @"c:\Users\CheshireK\Documents\GitHub\TheLearningProject\AddressBook\AddressBook\Addresses.txt";

            try
            {

                using (FileStream fsSource = new FileStream(pathSource,
                    FileMode.Open, FileAccess.Read))
                {

                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;

                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;
                    var str = Encoding.Default.GetString(bytes);
                    return str;


                    //using (FileStream fsNew = new FileStream(pathNew, FileMode.Create, FileAccess.Write))
                    //{
                    //    fsNew.Write(bytes, 0, numBytesToRead);
                    //}

                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
            return "No results found";
        }


        private bool WriteToFile()
            {
                return true;

            }

        public string AddToBook(string record)
            {
                // this will call writeToFile with the new record
                return "";
            }

        public string DeleteFromBook(string record)
            {
                // This will call read from file, find the line we want to delete
                // Delete the string, then re-write to the file
                return "";
            }

        public Dictionary<string, string> getAddressBook()
            {
            // this will call readFromFile
            // Then it will split the strings by name followed by address
            // Then it will create a dictionary with name as key and address as value
            // return said dictionary
            // this will cover string.split() and string.substring() (GOOGLE THESE)

            var addressString = ReadFromFile();
            var lines = addressString.Split('\n').ToList();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            foreach(var line in lines)
            {
                var keyValue = line.Split(':');
                dict.Add(keyValue[0], keyValue[1]);
            }

            return dict;
            }
        
    }
}
