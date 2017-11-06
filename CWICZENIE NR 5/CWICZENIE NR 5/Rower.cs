using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIE_NR_5
{
    class Rower:Pojazd,IJazda,IMuzyka
    {
        public void Jedz()
        {
            Console.WriteLine("Jade rowerem");
        }
        public void Klakson()
        {
            Console.Beep(20000, 400);
        }
    }
}
