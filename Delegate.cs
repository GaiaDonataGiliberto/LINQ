using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Delegate
    {
        
        public delegate int Sum(int val1, int val2);
        //il delegate crea un nuovo tipo che rappresenta
        //la firma di una funzione

        public static int PrimaSomma(int valore1, int valore2)
        {
            return valore1 + valore2;
        }
         
        // questa non è di tipo Sum poiché la firma è diversa
        public static int SecondaSomma(int valore1, double valore2)
        {
            return valore1 + (int)valore2;
        }

        // dato che è Sum un tipo posso passarlo come parametro
        public static void Chiamami(Sum funzioneDaChiamare)
        {
            funzioneDaChiamare(1, 2); 
        }

        static void Stamp()
        {
            Sum laMiaSomma = new Sum(PrimaSomma);
            // oppure
            // Sum laMiaSomma = PrimaSomma;

            // laMiaSomma = SecondaSomma; --> non si può fare perché
            // la firma è diversa
        }




    }
}
