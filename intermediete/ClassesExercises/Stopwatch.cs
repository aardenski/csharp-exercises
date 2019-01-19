using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete_Exercises
{
    //Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
    //provide two methods: Start and Stop.We call the start method first, and the stop method next.
    //Then we ask the stopwatch about the duration between start and stop. Duration should be a
    //value in TimeSpan.Display the duration on the console.
    //We should also be able to use a stopwatch multiple times.So we may start and stop it and then
    //start and stop it again. Make sure the duration value each time is calculated properly.
    //We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
    //start time). So the class should throw an InvalidOperationException if its started twice.

    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        public TimeSpan Duration { get; private set; }
        public bool IsWorking { get; set; }

        public void Start()
        {
            if (!IsWorking)
            {
                StartTime = DateTime.Now;
                IsWorking = true;
            }
            else
            {
                Console.WriteLine("Can't be started twice!");
                IsWorking = false;
            }
        }

        public void Stop()
        {
            if (!IsWorking)
            {
                Console.WriteLine("Can't be stopped if not working!");
            }
            else
            {
                StopTime = DateTime.Now;
                Duration = StopTime - StartTime;
                IsWorking = false;
                Console.WriteLine("Duration: {0}", Duration.Seconds);
            }
        }

        public void Work(string input)
        {
            var stopwatch = new Stopwatch();
            while (input != "1" || input != "2")
            {
                Console.WriteLine("1 - Start, 2 - Stop, Else - Exit");
                input = Console.ReadLine();
                if (input == "1")
                    stopwatch.Start();

                else if (input == "2")
                    stopwatch.Stop();

                else
                    break;
            }
        }
    }
}
