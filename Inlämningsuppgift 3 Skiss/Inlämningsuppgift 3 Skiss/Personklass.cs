using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_3_Skiss
{
    internal class Personklass
    {
        // Attributen i klassen
        public string förnamn;
        public string efternamn;
        public string personnummer;


        // Metod Algortim 21. Endast de siffror som kan bli större än 10, går igenom if > 9 och adderas. 
        public string Algoritm21()
        {
            // - 48 behövs för att få den faktiska siffran, och inte bara siffrans plats. 
            int siffra1 = (personnummer[0] - 48) * 2;

            if (siffra1 > 9)
            {
                string siffror1 = siffra1.ToString();
                siffra1 = (siffror1[0] - 48) + (siffror1[1] - 48);
            }
            int siffra2 = (personnummer[1] - 48) * 1;
            int siffra3 = (personnummer[2] - 48) * 2;
            int siffra4 = (personnummer[3] - 48) * 1;
            int siffra5 = (personnummer[4] - 48) * 2;
            int siffra6 = (personnummer[5] - 48) * 1;

            int siffra7 = (personnummer[6] - 48) * 2;
            if (siffra7 > 9)
            {
                string siffror7 = siffra7.ToString();
                siffra7 = (siffror7[0] - 48) + (siffror7[1] - 48);
            }

            int siffra8 = (personnummer[7] - 48) * 1;

            int siffra9 = (personnummer[8] - 48) * 2;
            if (siffra9 > 9)
            {
                string siffror9 = siffra9.ToString();
                siffra9 = (siffror9[0] - 48) + (siffror9[1] - 48);
            }
            int siffra10 = (personnummer[9] - 48) * 1;

            int summa = siffra1 + siffra2 + siffra3 + siffra4 + siffra5 + siffra6 + siffra7 + siffra8 + siffra9 + siffra10;

            if (summa % 10 == 0)
            {
                string korrekt = "Korrekt personnummer!";
                return korrekt;

            }
            else
            {

                string ejKorrekt = "Felaktigt personnummer!";
                return ejKorrekt;

            }



        }

        // Om siffra nummer 8 i personnumret är en jämn siffra, returnera string Kvinna, annars string Man. 
        public string Kön()

        {
            if (personnummer[8] % 2 == 0)
            {
                string kvinna = "Kvinna";
                return kvinna;
            }
            else
            {
                string man = "Man";
                return man;
            }
        }
    }
}
