using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_duben123
{
    internal class Class1
    {
        public Random generator = new Random();
        public string[] PoleZTextu(string adresaSouboru)
        {
            string obsahTxt = File.ReadAllText(adresaSouboru);
            string[] PoleZSouboru = obsahTxt.Split(";");
            return PoleZSouboru;
        }

        public string VygenerujSpellname(string[] poleFarma, string[] poleTypy)
        {
            int randomName = generator.Next(23);
            string spellName = $"{poleFarma[randomName]} {poleTypy[randomName]}";
            return spellName;
        }

        public int VygenerujCislo(int max)
        {
            int randomCislo = generator.Next(max);
            return randomCislo;

        }
    }
}
