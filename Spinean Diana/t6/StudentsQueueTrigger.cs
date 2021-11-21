using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Tema6_Spinean
{
    public static class StudentsQueueTrigger
    {
        [FunctionName("StudentsQueueTrigger")]
        [return: Table("Studenti")]
        public static StudentEntity Run([QueueTrigger("students-queue", Connection = "storagedatc2021")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

            var student = JsonConvert.DeserializeObject<StudentEntity>(myQueueItem);

            return student;
        }
    }
}