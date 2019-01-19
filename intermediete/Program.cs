namespace Intermediete_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "";

            //   1
            //var stopwatch = new Stopwatch();
            //stopwatch.Work(input);

            //   2
            //var post = new Post("Example", "An interesting text.");
            //post.Work(input);

            //   3
            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop()); // Exception trigger

            //   4
            //var dbCommand = new DbCommand(new SqlConnection("a@aardenski.com"), "Maintain");
            //dbCommand.Execute();
            //dbCommand = new DbCommand(new OracleConnection("b@bbrdenski.com"), "Test");
            //dbCommand.Execute();

            //   5
            var workflowEngine = new WorkflowEngine();
            var workflow = new Workflow();
            workflow.AddActivity(new SendEmail());
            workflow.AddActivity(new CallService());
            workflow.AddActivity(new UploadVideo());
            workflowEngine.Run(workflow);

        }
    }
}
