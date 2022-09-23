// See https://aka.ms/new-console-template for more information
using System.IO;

StreamReader addresses = File.OpenText("C:\\Users\\Daniele\\Downloads\\addresses.csv");

List<Address> addressesList = new List<Address>();



while (!addresses.EndOfStream)
{
    

    string row = addresses.ReadLine();

    string[] split = row.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        string zip = split[5];
        Address address = new Address(name, surname, street, city, province, zip);
        addressesList.Add(address);
        Console.WriteLine($"Indirizzo --> {name}, {surname}, {street}, {city}, {province}, {zip} <-- è stato letto correttamente");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine($"L'indirizzo non e' un indirizzo valido --> {row}");
    }
}

addresses.Close();



  
    foreach (Address address in addressesList)
    {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Nome: {address.Name}");
            Console.WriteLine($"Cognome: {address.Surname}");
            Console.WriteLine($"Via: {address.Street}");
            Console.WriteLine($"Città: {address.City}");
            Console.WriteLine($"Provincia: {address.Province}");
            Console.WriteLine($"CAP: {address.Zip}");
    }
   
    

