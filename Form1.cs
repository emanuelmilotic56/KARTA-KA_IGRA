using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARTAŠKA_IGRA_EMANUEL
{
    class Program
    {
        static void Main(string[] args)
        {

            int Karte = 0;
            int CardCounter = "0";


            while (CardCounter < 31)
            {


                Console.WriteLine(Unesi kartu od 1 do 13);



            }

            if (Karte > 13)
            {
                Console.WriteLine("Vas broj je veći od 13");
            }
            else
            {

                CardCounter + = Karte;
            }

        }
          if (CardCounter< 30){

            Console.Writeline("Pobjeda!"+CardCounter++);

           
    }
}