using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;
using System.ServiceModel;

namespace Host1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Activity workflow1 = new Workflow1();
            // WorkflowInvoker.Invoke(workflow1);

            using (ServiceHost host = new ServiceHost(typeof(ClassLibrary1.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
