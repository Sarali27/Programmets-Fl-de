using System;
using System.Threading;

namespace Countdown
{
    class Program
    {
        
         static void Main(string[] args)
        {
            Countdown clock = new Countdown();
           
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
                Countdown.RandomSleep();

                Console.WriteLine("Tryck igen...NU!");
                Countdown.StartTimer();
   
                Console.WriteLine("Din reaktionstid är:"+Countdown.StopTimer());

                Console.WriteLine("För att avsluta, tryck 'q', annars tryck något annat");
                var input = Console.ReadLine();
            }
            while (input != "q");


        }
    }
}