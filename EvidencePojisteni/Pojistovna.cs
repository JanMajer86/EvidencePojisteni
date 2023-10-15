using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída reprezentuje pojišťovnu
    /// </summary>
    class Pojistovna
    {
        private List<Pojistenec> pojistenci;

        public Pojistovna() 
        {
            pojistenci = new List<Pojistenec>();
        }
        /// <summary>
        /// Přidá nově pojištěnou osobu na seznam
        /// </summary>
        public void PridejPojistence()
        {
            // Uživatelský vstup
            Console.WriteLine("Zadejte jméno pojištěného");
            string jmeno = OsetriTextovyVstup();
            Console.WriteLine("Zadejte příjmení pojištěného");
            string prijmeni = OsetriTextovyVstup();
            Console.WriteLine("Zadejte telefonní číslo");
            string telefon = OsetriTextovyVstup();
            Console.WriteLine("Zadejte věk");
            int vek = int.Parse(Console.ReadLine());
            
            // Přidání pojištěné osoby na seznam
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, vek));
            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Vypíše všechny pojištěné osoby ze seznamu
        /// </summary>
        public void VypisPojistence()
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                Console.WriteLine(pojistenec);
            }
        }
        /// <summary>
        /// Vyhledá ze seznamu pojištěnou osobu podle jména a příjmení
        /// </summary>
        public void NajdiPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = OsetriTextovyVstup();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = OsetriTextovyVstup();

            var hledanyPojistenec = pojistenci.Find(p => p.Jmeno == jmeno && p.Prijmeni == prijmeni);

            Console.WriteLine(hledanyPojistenec);
        }
        /// <summary>
        /// Ošetří uživatelský textový vstup
        /// </summary>
        /// <returns>Ošetřený text</returns>
        public string OsetriTextovyVstup()
        {
            string text;
            while (string.IsNullOrWhiteSpace(text = Console.ReadLine()))
                Console.WriteLine("Neplatný vstup, zadej znovu:");


            text = text.ToLower().Trim();
            return $"{char.ToUpper(text[0])}{text[1..]}";
        }

        
        /// <summary>
        /// Úvodní obrazovka
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------");
        }
    }
}
