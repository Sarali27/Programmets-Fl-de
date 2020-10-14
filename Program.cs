using System;
using System.Threading;

namespace Countdown
{
    class Program
    {
         static void Main(string[] args)
        {
            TimeMeasurement clock = new TimeMeasurement();

            do
            {
                Console.WriteLine("Tryck på en tangent för att starta");
                Console.ReadLine();
                Console.Write("Vänta lite");
                
                for (int i=0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                } 
                TimeMeasurement.Pause();

                //text

                TimeMeasurement.StartStopWatch()
   
                //text

                //stoppa 
            }
            while (var input != "q");


        }
    }
}