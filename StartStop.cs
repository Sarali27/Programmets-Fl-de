using System;
// TODO: Vilka usings krävs för Random och TimeSpan? "using System" fungerar som någon slags "allt-i-allo".
using System.Diagnostics;       // Stopwatch
using System.Threading;

namespace lessson6_pause_program
{
    class Countdown
    {
        private Random random = new Random();
        private Stopwatch stopwatch = new Stopwatch();
        private TimeSpan timeElapsed;

        public void RandomSleep()
        {
            int randomValue = random.Next(500, 5001);
            Thread.Sleep(randomValue);
        }

        public void StartTimer()
        {
            stopwatch.Start();
        }

        public TimeSpan StopTimer()
        {
            stopwatch.Stop();
            return timeElapsed = stopwatch.Elapsed;
        }

        public void ResetTimer()
        {
            stopwatch.Reset();
        }
    }
}
