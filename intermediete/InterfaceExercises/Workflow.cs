using System.Collections.Generic;

namespace Intermediete_Exercises
{
    public class Workflow
    {
        public readonly IList<IActivity> activities;

        public Workflow()
        {
            activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
        }
    }
}