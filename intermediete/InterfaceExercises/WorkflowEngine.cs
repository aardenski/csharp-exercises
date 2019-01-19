using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete_Exercises
{
    //Design a workflow engine that takes a workflow object and runs it.A workflow is a series of steps
    //or activities. The workflow engine class should have one method called Run() that takes a
    //workflow, and then iterates over each activity in the workflow and runs it.
    //We want our workflows to be extensible, so we can create new activities without impacting the
    //existing activities.
    //Educational tip: we should represent the concept of an activity using an interface. Each activity
    //should have a method called Execute(). The workflow engine does not care about the concrete
    //implementation of activities.All it cares about is that these activities have a common interface:
    //they provide a method called Execute(). The engine simply calls this method and this way it
    //executes a series of activities in sequence.
    public class WorkflowEngine
    {
        public WorkflowEngine()
        {
        }

        public void Run(Workflow Workflow)
        {
            foreach (var activity in Workflow.activities)
            {
                activity.Execute();
            }
        }
    }
}
