using RecurrentTasks;
using System;
using System.Threading;
using Microsoft.Extensions.Logging;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Diagnostics;
using Hl7.Fhir.Serialization;

namespace wcfcoretest
{
    public class RunnableTask : IRunnable
    {
        private ILogger logger;

        public RunnableTask(ILogger<RunnableTask> logger)
        {
            this.logger = logger;
        }

        public async System.Threading.Tasks.Task RunAsync(ITask currentTask, IServiceProvider scopeServiceProvider, CancellationToken cancellationToken)
        {
            //var URL = "http://hapi.fhir.org/baseDstu3";

            /*
            

            var obs= new Observation();
            obs.Status = ObservationStatus.Preliminary;
            obs.Code = new CodeableConcept("http://example.org","my-example-code");

            var result = client.Create<Observation>(obs);
            */



            //ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            //ServiceReference1.Student newStudent =

            //   new ServiceReference1.Student()

            //   {

            //       StudentId = 0,

            //       FirstName = "Mark",

            //       LastName = "Dallas",

            //       RegisterNo = "278589243579432",

            //       Department = "DEPT"

            //   };
             

           // await proxy.AddStudentsAsync(newStudent);
            //hapi fhir starts here
            //var client = new FhirClient("http://vonk.fire.ly");
            //client.PreferredFormat = ResourceFormat.Json;
            //Debug.WriteLine("LINE WRITE");
            //var q = new SearchParams().LimitTo(10);
            //Bundle result = client.Search<Claim>();

            //FhirJsonSerializer sr = new FhirJsonSerializer();




            //while (result != null)
            //{
            //    foreach (var e in result.Entry)
            //    {
            //        Claim p = (Claim)e.Resource;
            //        var bundlexml = sr.SerializeToString(p);

            //        Debug.WriteLine(bundlexml);
            //    }

            //    result = client.Continue(result, PageDirection.Next);
            //}

            //currentTask.Interval = currentTask.Interval.Add(TimeSpan.FromSeconds(20));
            //await System.Threading.Tasks.Task.CompletedTask;

            //ends here
            
        }
    }
}
