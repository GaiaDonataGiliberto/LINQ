using System;
using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            string firstName = "Gaia"; //variabile tipo esplicita

            var lastName = "Giliberto"; //variabile tipo implicita

            //lastName = 0.4; --> ormai è stringa. Non accetta un double. 

            //using var file = new StreamWriter(); --> file è di tipo StreamWriter

            //var data = new List<int> { 1, 2, 3, 4 };

            //foreach (var value in data)
            //    Console.WriteLine("#" + value);

            /* gli anonymous type sono classi "usa e getta", sono data type - tipo dato.
                 non è una classe modello che si può usare o richiamare più volte.
                 viene creata, definita e conosciuta solo dal compilatore
            */

            Employee<int> pippo;
            Employee<string> pluto;

            var process = new BusinessProcess();
            process.Started += Process_Started;
            process.Started += Process_Started1;
            process.Completed += Process_Completed;
            process.ProcessData();

           
        

        }

        private static void Process_Completed(int duration)
        {
            Console.WriteLine($"Processo completato, durata: {duration}");
        }

        private static void Process_Started1()
        {
            Console.WriteLine("Altro handler");       
        }

        private static void Process_Started()
        {
            Console.WriteLine("Ricevuto - processo avviato!");        
        }
    }

    //1. cambiare il codice della sorgente originale (String)
    //2. class MyString : String --> non si può fare perché String è sealed
    //3. usare un exstension method

    internal class Employee
    {
        private string name { get; set; }
    }

    internal class Employee<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
    }

    internal class EmployeeInt
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    internal class EmployeeString
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
