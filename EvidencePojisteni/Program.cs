using EvidencePojisteni;
using System.Xml;


// instance pojišťovny
Pojistovna pojistovna = new Pojistovna();
char volba = '0';
// hlavní cyklus programu
while (volba != '4')
{
    pojistovna.VypisUvodniObrazovku();
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny záznamy");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
    // reakce na volbu  
    switch (volba)
    {
        case '1':
            pojistovna.PridejPojistence();
            break;
        case '2':
            pojistovna.VypisPojistence();
            break;
        case '3':
            pojistovna.NajdiPojistence();
            break;
        case '4':
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.ReadKey();
}


