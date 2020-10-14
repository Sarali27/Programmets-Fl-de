using System;
using System.Threading;

namespace Countdown
{
    class Program
    {
        GCNotificationStatus
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

                Console.WriteLine("Tryck igen...NU!");
                TimeMeasurement.StartStopWatch();
   
                Console.WriteLine("Din reaktionstid är:"+TimeMeasurement.StopStopWatch());

                Console.WriteLine("För att avsluta, tryck 'q', annars tryck något annat");
                var input = Console.ReadLine();
            }
            while (input != "q");


        }
    }
}