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
    catch (Exception ex)
    {
        if (ex is IndexOutOfRangeException || ex is PathTooLongException)
        Console.WriteLine($"L'indirizzo non e' un indirizzo valido --> {row}");
    }
}

addresses.Close();



  
    foreach (Address address in addressesList)
    {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            if (address.Name != "")
            {
                Console.WriteLine($"Nome: {address.Name}");
            }else
            {
                Console.WriteLine("Nome: >> non presente <<");
            }

            if (address.Surname != "")
            {
                Console.WriteLine($"Cognome: {address.Surname}");
            }
            else
            {
                Console.WriteLine("Cognome: >> non presente <<");
            }

            if (address.Street != "")
            {
                Console.WriteLine($"Via: {address.Street}");
            }
            else
            {
                Console.WriteLine("Via: >> non presente <<");
            }

            if (address.City != "")
            {
                Console.WriteLine($"Città: {address.City}");
            }
            else
            {
                Console.WriteLine("Città: >> non presente <<");
            }

            if (address.Province != "")
            {
                Console.WriteLine($"Provincia: {address.Province}");
            }
            else
            {
                Console.WriteLine("Provincia: >> non presente <<");
            }

            if (address.Zip != "" && address.Zip.Length == 5)
            {
                Console.WriteLine($"CAP: {address.Zip}");
            }
            else if (address.Zip.Length < 5)
            {
                Console.WriteLine($"CAP: {address.Zip} ---> Questo cap e' errato");
            }else 
            {
                Console.WriteLine("CAP: >> non presente <<");
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
   
    

