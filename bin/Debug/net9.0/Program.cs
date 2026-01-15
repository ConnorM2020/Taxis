using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TaxisImporter;
using TaxisImporter.Models;
using ListTuples;
//var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=TaxiDb;Trusted_Connection=True;";

//var options = new DbContextOptionsBuilder<TaxiDbContext>()
//    .UseSqlServer(connectionString)
//    .Options;

//using var context = new TaxiDbContext(options); // First check if Db is valid
//// Apply most recent Migrations

//// Check if file is present 
//var csvPath = Path.Combine(Directory.GetCurrentDirectory(), "taxis.csv");

//if (!File.Exists(csvPath))
//{
//    Console.WriteLine("File not present");
//    return;
//}
//// Change header to lowercase
//var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//{
//    PrepareHeaderForMatch = args => args.Header.ToLower(),
//};

// List<Taxis> csvRecord;  //IEnumerable<T>

//// Read CSV file and convert to List<T>
//using (var reader = new StreamReader(csvPath))
//using (var csv = new CsvReader(reader, config))
//{
//    csvRecord = csv.GetRecords<Taxis>().ToList();                 // Get All CSV file and convert to <T> 
//    Console.WriteLine($"Import complete. Rows imported: {csvRecord.Count}");
//}

//// Write to Database
//try
//{
//    context.Taxis.AddRange(csvRecord);  // Save to DB
//    context.SaveChanges();
//    Console.WriteLine($"Save Successful");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Save failed: {ex.Message}");
//}

//List<(int Num1, int Num2, int Num3)> Values = new List<(int Num1, int Num2, int Num3)>();

//int it1 = 1;
//int it2 = 2;
//int it3 = 3;
//for (int i = 0; i < 5; i++)
//{
//    Values.Add((it1, it2, it3));    // add indivudal tuple: (int Num1, int Num2, int Num3)
//    it1++;
//    it2++;
//    it3++;

//}
//Console.WriteLine("Writing List: ");
//foreach (var tuple in Values)
//{
//    Console.WriteLine($"{tuple.Num1}, {tuple.Num2}, {tuple.Num3}");
//}

TuplePractise tuple = new TuplePractise();  // run Tuple class in Program.cs
tuple.Run();