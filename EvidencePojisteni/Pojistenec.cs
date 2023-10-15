using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída reprezentující pojištěnou osobu
    /// </summary>
    class Pojistenec
    {
        public string Jmeno {  get; set; }
        public string Prijmeni { get; set; }
        public string Telefon { get; set; }
        public int Vek {  get; set; }
        /// <summary>
        /// Vytvorí novou instanci pojištěné osoby
        /// </summary>
        /// <param name="Jméno"></param>
        /// <param name="Příjmení"></param>
        /// <param name="Telefonní číslo"></param>
        /// <param name="Stáří"></param>
        public Pojistenec(string jmeno, string prijmeni, string telefon, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Vek = vek;
        }
        /// <summary>
        /// Vrátí textovou reprezentaci pojištěné osoby
        /// </summary>
        /// <returns>Textová reprezentace pojištěné osoby</returns>
        public override string ToString()
        {
            return Jmeno.PadRight(25) + Prijmeni.PadRight(25) + Vek.ToString().PadRight(25) + Telefon;
        }
    }
}
