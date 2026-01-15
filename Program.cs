using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TaxisImporter;
using TaxisImporter.Models;
using ListTuples;
var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=TaxiDb;Trusted_Connection=True;";

var options = new DbContextOptionsBuilder<TaxiDbContext>()
    .UseSqlServer(connectionString)
    .Options;

using var context = new TaxiDbContext(options); // First check if Db is valid
// Apply most recent Migrations

// Check if file is present 
var csvPath = Path.Combine(Directory.GetCurrentDirectory(), "taxis.csv");

if (!File.Exists(csvPath))
{
    Console.WriteLine("File not present");
    return;
}
// Change header to lowercase
var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    PrepareHeaderForMatch = args => args.Header.ToLower(),
};

List<Taxis> csvRecord;  //IEnumerable<T>

// Read CSV file and convert to List<T>
using (var reader = new StreamReader(csvPath))
using (var csv = new CsvReader(reader, config))
{
    csvRecord = csv.GetRecords<Taxis>().ToList();                 // Get All CSV file and convert to <T> 
    Console.WriteLine($"Import complete. Rows imported: {csvRecord.Count}");
}

// Write to Database
try
{
    context.Taxis.AddRange(csvRecord);  // Save to DB
    context.SaveChanges();
    Console.WriteLine($"Save Successful");
}
catch (Exception ex)
{
    Console.WriteLine($"Save failed: {ex.Message}");
}


//TuplePractise tuple = new TuplePractise();  // run Tuple class in Program.cs
//tuple.Run();