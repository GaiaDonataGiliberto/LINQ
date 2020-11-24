using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public static class StringExstensions //deve essere static
    {
        // di solito si fa una classe per ogni classe che voglio estendere
        // e ci metto tutti i metodi di estensione


        public static double ToDouble(this string value) //string si riferisce alla classe String
        {
            return 0;
        }

        //il primo valore degli extension method deve essere la classe estesa
        // e si chima sempre value
        public static string WithPrefix(this string value, string prefix)
        {
            return $"{prefix}-{value}"; //String interpolation

            // return prefix + "-" + value;
        }

        

        public static string ToString(this double value) //doublesi riferisce alla classe double
        { 
        return "";
        }
    }
}
