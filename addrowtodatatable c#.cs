using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable.
        DataTable dt = new DataTable("Customers");

        // Add columns to the DataTable.
        dt.Columns.Add("ID", typeof(int));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Email", typeof(string));

        // Create a new row using the NewRow method.
        DataRow newRow = dt.NewRow();

        // Set values for the new row.
        newRow["ID"] = 1;
        newRow["Name"] = "John Doe";
        newRow["Email"] = "john.doe@example.com";

        // Add the new row to the DataTable.
        dt.Rows.Add(newRow);

        // Add another row directly.
        dt.Rows.Add(2, "Jane Smith", "jane.smith@example.com");

        // Display the DataTable content.
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Email"]}");
        }
    }
}
