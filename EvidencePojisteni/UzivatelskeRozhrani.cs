using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class UzivatelskeRozhrani
    {
        /// <summary>
        /// Databáze pojišťovny
        /// </summary>
        private Pojistovna pojistovna;

        /// <summary>
        /// Vytvoří instanci databáze pojišťovny
        /// </summary>
        public UzivatelskeRozhrani() 
        { 
            pojistovna = new Pojistovna();
        }
        /// <summary>
        /// Vyzve uživatele k přidání záznamu a uloží ho do databáze
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
            int vek = OsetriCiselnyVstup();

            Console.WriteLine();


            pojistovna.PridejPojistence(jmeno, prijmeni, telefon, vek);
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
        }

        public void VypisPojistence()
        { 
            List<Pojistenec>? pojistenci = pojistovna.VypisPojistence();
            if (pojistenci != null)
                foreach (Pojistenec pojistenec in pojistenci)
                {
                    Console.WriteLine(pojistenec);
                }
            else
                Console.WriteLine("Databáze je prázdná");

        }

        public void NajdiPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = OsetriTextovyVstup();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = OsetriTextovyVstup();

            Pojistenec? hledanyPojistenec = pojistovna.NajdiPojistence(jmeno, prijmeni);
            if (hledanyPojistenec != null)
                Console.WriteLine(hledanyPojistenec);
            else
                Console.WriteLine("Hledaný pojištěnec nenalezen");
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
        /// Ošetří uživatelský číselný vstup
        /// </summary>
        /// <returns>Věk pojištěnce</returns>
        public int OsetriCiselnyVstup()
        {
            int vek;
            while (!(int.TryParse(Console.ReadLine(), out vek) && vek >= 0))
                Console.WriteLine("Neplatný vstup, zadej znovu:");

            return vek;
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
