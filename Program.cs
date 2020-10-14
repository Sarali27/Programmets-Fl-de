using System;
using System.Threading;

namespace Countdown
{
    class Program
    {
        
         static void Main(string[] args)
        {
            Countdown clock = new Countdown();
           string input = "";
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
                clock.RandomSleep();
               
                Console.Clear();
                Console.WriteLine("Tryck igen...NU!");
                clock.StartTimer();
                Console.ReadLine();
               
               
                int score = clock.StopTimer().Milliseconds;
               
                Console.WriteLine("Din reaktionstid är: "+ score +" ms!");

                Console.WriteLine("För att avsluta, tryck 'q', annars tryck något annat");
                input = Console.ReadLine();
            }
            while (input != "q");


        }
    }
}