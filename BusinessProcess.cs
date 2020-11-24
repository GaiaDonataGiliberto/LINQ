using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LINQ
{
    // 1. dichiaro il delegate

   public delegate void ProcessStarted();
   public delegate void ProcessCompleted(int duration);


    

        
   public class BusinessProcess
   {
        // 2. dichiaro l'evento
        public event ProcessStarted Started;
        public event ProcessCompleted Completed;

        // EventHandler è un delegate già esistente in .NET
        
        // questo vuole il sender (this class che crea l'evento)
        // e no parametri, quindi si usa EventArgs.Empty
        public event EventHandler StartedCore;

        //questo invece prevede una lista di parametri, per cui vuole
        // il sender e la lista di params
        public event EventHandler<ProcessEndEventArgs> CompletedCore;


        public void ProcessData()
        {
            Console.WriteLine("STARTING PROCESS");
            Thread.Sleep(2000);

            Console.WriteLine("PROCESS STARTED");
            // 3. sollevo l'evento
            if (Started != null) //evitiamo di sollevare l'evento
                Started();       //se nessuno si è iscritto ad esso
            if (StartedCore != null)
                 StartedCore(this, EventArgs.Empty); //si specifica SEMPRE che è empty


            Thread.Sleep(3000);
            Console.WriteLine("PROCESS COMPLETED");
            // 3. sollevo l'evento
            if(Completed != null)
                Completed(8000);
            if (CompletedCore != null)
                CompletedCore(this, new ProcessEndEventArgs { duration = 4500 });
             
        }
    
   }

    public class ProcessEndEventArgs
    {

        public int duration { get; set; }
            
    }
}