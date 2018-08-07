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


        public string WriteToFile(string name, string address)
            {
            Dictionary<string, string> dict = getAddressBook();
            string newAddress = name + ": " + address;
            List<string> lines = new List<string>();

            foreach(var record in dict)
            {
                lines.Add(record.Key + ": " + record.Value);
            }
            lines.Add(newAddress);

            
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, @"c:\Users\CheshireK\Documents\GitHub\TheLearningProject\AddressBook\AddressBook\Addresses.txt")))
            {
                foreach (string line in lines)
                {
                    //if the current line is not the last line
                    if (line != lines[lines.Count()-1])
                    {
                        outputFile.WriteLine(line);
                    }
                    else
                    {
                        outputFile.Write(line);
                    }
                }                    
            }

            return "";

            }

        public string AddToBook()
            {
            Dictionary<string, string> dict = getAddressBook();
            Console.Write("Write the name person you wish to add: ");
            string userName = Console.ReadLine();
            Console.Write("Write the address you wish to add: ");
            string userAddress = Console.ReadLine();


            if (dict.ContainsKey(userName) || dict.ContainsValue(userAddress))
            {
                Console.WriteLine("This address or user already exists!");
            }
            else
            {
                WriteToFile(userName, userAddress);
            }
                

            Console.ReadLine();

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
                int index = line.IndexOf(":");
                var noSpace = line.Remove(index + 1, 1);
                var stripped = noSpace.Trim('\r');
                var keyValue = stripped.Split(':');

                dict.Add(keyValue[0], keyValue[1]);
            }

            return dict;
            }
        
    }
}
