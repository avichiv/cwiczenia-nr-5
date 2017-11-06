using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIE_NR_5
{
    class Samochod:Pojazd,IJazda
    {
        public void Jedz() //IMPLEMENTACJA NIEJAWNA
        {
            Console.WriteLine("Jade samochodem");
        }
    }
}
