﻿// See https://aka.ms/new-console-template for more information


//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.


StreamReader file = File.OpenText("C:/.Net/csharp-lista-indirizzi/addresses.csv");


while (!file.EndOfStream)
{

    string line = file.ReadLine();
    Console.WriteLine(line);
}
file.Close();