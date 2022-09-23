// See https://aka.ms/new-console-template for more information


//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.




public class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        if(name == "")
        {
            throw new Exception("Name not insered");
        }
        else
        {
            Name = name;
        }

        if (surname == "")
        {
            throw new Exception("Surname not insered");
        }
        else
        {
            Surname = surname;
        }

        if (street == "")
        {
            throw new Exception("Street not insered");
        }
        else
        {
            Street = street;
        }

        if (city == "")
        {
            throw new Exception("City not insered");
        }
        else
        {
            City = city;
        }

        if (province == "")
        {
            throw new Exception("Province not insered");
        }
        else
        {
            Province = province;
        }

        if (zip == "")
        {
            throw new Exception("Zip not insered");
        }
        else
        {
            Zip = zip;
        }
    }
}