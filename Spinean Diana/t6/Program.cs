using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace Tema6_Spinean
{
    class Program
    {
        private static CloudTableClient tableClient;
        private static CloudTable studentsTable;

        static void Main(string[] args)
        {
            Task.Run(async () => { await Initialize(); })
                .GetAwaiter()
                .GetResult();
        }

        static async Task Initialize()
        {
            string storageConnectionString = "DefaultEndpointsProtocol=https;"
                + "AccountName=storagedatc2021"
                + ";AccountKey=FTQUnNiDjfmAtqyWVoW1PiyMebTdm2rkxv+cADhBEgB28rtER0C6UTC50ulgkvBjwhQtFVcL2CWZaovZUgg5Lg=="
                + ";EndpointSuffix=core.windows.net";

            var account = CloudStorageAccount.Parse(storageConnectionString);
            tableClient = account.CreateCloudTableClient();

            studentsTable = tableClient.GetTableReference("Studenti");

            await studentsTable.CreateIfNotExistsAsync();

            await AddNewStudent();
            //await GetAllStudents();

        }

        private static async Task AddNewStudent()
        {


            var student = new StudentEntity("student2", "1971020020012");
            student.FirstName = "Madalina";
            student.LastName = "Mot";
            student.Email = "madalina1234@yahoo.com";
            student.PhoneNumber = "0745674534";
            student.Year = '4';
            student.Faculty = "AC";
            var insertOperation = TableOperation.Insert(student);
            await studentsTable.ExecuteAsync(insertOperation);

        }
    }
}
