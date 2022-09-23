// See https://aka.ms/new-console-template for more information


//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

using System.Net;

List<Address> addressesList = new List<Address>();

string path = "C:/.Net/csharp-lista-indirizzi/addresses.csv";

if (File.Exists(path))
{
    StreamReader file = File.OpenText(path);

    bool finish = false;

    int count = 0;

    try
    {

        while (!file.EndOfStream)
        {
            if (finish != true) {
                try
                {
                    string row = file.ReadLine();

                    string[] data = row.Split(",");

                    if (data.Count() == 6)
                    {
                        addressesList.Add(new Address(data[0], data[1], data[2], data[3], data[4], data[5]));

                        finish = false;
                    }

                    else
                    {
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine($"Error: Invalid data number in line {count + 1}");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine($"Error: {e.Message} in line {count + 1}");
                }

            }

            count++;
        }

    }
    catch (IndexOutOfRangeException)
    {
        finish = true;
    }

    finally
    {
        file.Close();
    }
}

Console.WriteLine(Environment.NewLine);
Console.WriteLine("***************Apartment's List***************");
Console.WriteLine(Environment.NewLine);
foreach (Address address in addressesList)
{
    Console.WriteLine("**********************************************");
    Console.WriteLine($" Name: {address.Name}");
    Console.WriteLine($" Surname: {address.Surname}");
    Console.WriteLine($" City: {address.City}");
    Console.WriteLine($" Province: {address.Province}");
    Console.WriteLine($" Street: {address.Street}");
    Console.WriteLine($" Zip Code: {address.Zip}");
    Console.WriteLine(Environment.NewLine);
}
