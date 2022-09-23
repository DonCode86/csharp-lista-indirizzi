// See https://aka.ms/new-console-template for more information
public class Address
{
    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public string Name { get; }
    public string Surname { get; }
    public string Street { get; }
    public string City { get; }
    public string Province { get; }
    public string Zip { get; }
}







