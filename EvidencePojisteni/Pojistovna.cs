using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída reprezentuje pojišťovnu
    /// </summary>
    class Pojistovna
    {
        /// <summary>
        /// Kolekce záznamů pojištěných osob
        /// </summary>
        private List<Pojistenec> pojistenci;
        
        /// <summary>
        /// Vytvoří novou instanci kolekce záznamů pojištěných osob
        /// </summary>
        public Pojistovna() 
        {
            pojistenci = new List<Pojistenec>();
        }
        /// <summary>
        /// Přidá nově pojištěnou osobu na seznam
        /// </summary>
        /// <param name="jmeno">Jméno pojištěnce</param>
        /// <param name="prijmeni">Příjmení pojištěnce</param>
        /// <param name="telefon">Telefonní číslo pojištěnce</param>
        /// <param name="vek">Stáří pojištěnce</param>
        public void PridejPojistence(string jmeno, string prijmeni, string telefon, int vek)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, vek));

        }
        /// <summary>
        /// Vypíše všechny pojištěné osoby ze seznamu
        /// </summary>
        public List<Pojistenec>? VypisPojistence()
        {

            if (pojistenci.Count == 0)
                return null;
            else return pojistenci;


        }
        /// <summary>
        /// Vyhledá ze seznamu pojištěnou osobu podle jména a příjmení
        /// </summary>
        /// <param name="jmeno">Jméno pojištěnce</param>
        /// <param name="prijmeni">Příjmení pojištěnce</param>
        /// <returns></returns>
        public Pojistenec? NajdiPojistence(string jmeno, string prijmeni)
        {
            Pojistenec? hledanyPojistenec = pojistenci.Find(p => p.Jmeno == jmeno && p.Prijmeni == prijmeni);
            if (hledanyPojistenec != null)
                return hledanyPojistenec;
            else
                return null;
           
        }






    }
}
