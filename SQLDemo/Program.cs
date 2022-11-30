using Microsoft.Data.SqlClient;

string connectionString = "Server=localhost;Database=everyloop;Trusted_Connection=True;TrustServerCertificate=True";

using SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

while (true)
{
    Console.Write("Enter search string: ");
    string searchString = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(searchString)) break;
    FetchAirports(connection, searchString, 8);
}

static void FetchAirports(SqlConnection connection, string searchString, int max)
{
    try
    {
        string query = "select top (@maxCount) Iata, [Airport Name], [Location Served] from airports where [airport name] like concat('%', @searchString ,'%')";

        Console.WriteLine($"Sending query: {query}");
        Console.WriteLine();

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.Add("searchString", System.Data.SqlDbType.NVarChar).Value = searchString;
        command.Parameters.Add("maxCount", System.Data.SqlDbType.Int).Value = max;

        using SqlDataReader reader = command.ExecuteReader();
        Console.Write(reader.GetName(0).ToString().PadRight(10).ToUpper());
        Console.Write(reader.GetName(1).ToString().PadRight(50).ToUpper());
        Console.Write(reader.GetName(2).ToString().PadRight(50).ToUpper());
        Console.WriteLine();

        while (reader.Read())
        {
            Console.Write(reader.GetValue(0).ToString().PadRight(10));
            Console.Write(reader.GetValue(1).ToString().PadRight(50));
            Console.Write(reader.GetValue(2).ToString().PadRight(50));
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
