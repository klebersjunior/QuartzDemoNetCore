using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuartzDemo.Jobs
{
    public class DemoJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Debug.WriteLine($"DemoJob: {DateTime.Now}");
            Debug.WriteLine($"JobKey: {context.JobDetail.Key}");

            //Regra do Scheduller
            

            return Task.CompletedTask;
        }
    }
}
