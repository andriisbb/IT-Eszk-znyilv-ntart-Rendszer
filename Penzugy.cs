using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Eszköznyilvántartó_Rendszer
{
    public static class Penzugy
    {
        public static double BruttoArSzamitas(double nettoAr)
        {
            return nettoAr * 1.27;
        }
    }
}
