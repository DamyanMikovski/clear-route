using System;
using System.IO;

namespace ClearRoute
{
    class CustomersCheck
    {
        static void Main(string[] args)
        {
            const string INPUT_DATA = "InputData";
            const string OUTPUT_DATA = "OutputData";
            const string CUSTOMERS_DATA_FILE = "Customers.txt";
            const string ISSUED_CUSTOMERS_DATA_FILE = "IssuedCustomers.txt";

            //Get Project Root directory 
            string projectDir = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));

            // Get the path to directories where we store the Data.
            string inputData = Path.Combine(projectDir, INPUT_DATA);
            string outputData = Path.Combine(projectDir, OUTPUT_DATA);
            
            // Check if test Data directory exists
            if (!Directory.Exists(inputData)) { Directory.CreateDirectory(inputData); }
            if (!Directory.Exists(outputData)) { Directory.CreateDirectory(outputData); }

            // Specify the input and output file paths
            string inputFile = Path.Combine(inputData, CUSTOMERS_DATA_FILE);
            string outputFile = Path.Combine(outputData, ISSUED_CUSTOMERS_DATA_FILE);
            
            // Open the input file for reading
            using (StreamReader reader = new StreamReader(inputFile))
            {
                // Create a new StreamWriter for the output file
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    string line;

                    writer.Write("Issued customers: \n");
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into individual data elements
                        string[] data = line.Split(',');

                        // Extract the age from the data
                        if (int.TryParse(data[1], out int age))
                        {
                            // Check if age is between 40 and 59 (inclusive)
                            if (age >= 40 && age <= 59)
                            {
                                // Write the filtered data to the output file
                                writer.WriteLine(string.Join(",", data));
                            }
                        }
                    }
                }
            }

            Console.WriteLine(@"Filtering complete. Filtered customers data saved to IssuedCustomers.txt. The file can be found in project Output folder.");
            Console.ReadLine();
        }
    }
}
