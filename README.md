# ClearRoute Console Application

The ClearRoute console application filters customer data based on their age and generates a new file with the filtered data. This README provides an overview of the application and instructions for usage.

## Description

ClearRoute is a .NET C# console application that reads customer data from an input file, filters the data based on age criteria, and saves the filtered data to an output file. The application assumes that the input file is named "Customers.txt" and is located in the "InputData" directory. The filtered data is saved to the "IssuedCustomers.txt" file in the "OutputData" directory.

## Prerequisites

To run the ClearRoute application, you need the following:

- .NET Core SDK installed on your machine.
- Input file named "Customers.txt" with comma-separated customer data in the format "name, age" in the "InputData" directory.

## Usage

1. Ensure that you have the input file "Customers.txt" available in the "InputData" directory.
2. Open a command prompt or terminal.
3. Navigate to the project directory containing the ClearRoute application files.
4. Build the application by running the following command:
```dotnet build```
5. Run the application using the following command:
```dotnet run```
6. The application will filter the customer data based on the age criteria (40 to 59 years) and generate the "IssuedCustomers.txt" file in the "OutputData" directory.
7. After the filtering process is complete, the application will display a success message and wait for you to press Enter to exit.

