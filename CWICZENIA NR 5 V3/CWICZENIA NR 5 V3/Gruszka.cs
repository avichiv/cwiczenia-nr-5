﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_5_V3
{
    class Gruszka:Owoc,IJedzenie
    {
        public void Jedzenie()
        {
            Console.WriteLine("GRUSZKA");
        }
    }
}
