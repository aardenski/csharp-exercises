using System;

namespace Intermediete_Exercises
{
    public class CallService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service..");
        }
    }
}
