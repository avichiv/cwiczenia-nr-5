using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_5_v2
{
    class Osoba:IMuzyka,ISport
    {
        string IMuzyka.Graj()
        {
            return "muzyka";
        }

        string ISport.Graj()
        {
            return "sport";
        }
    }
}
