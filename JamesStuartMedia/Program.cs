using System;
using System.Collections.Generic;

namespace JamesStuartMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> workers = new Dictionary<string, string>();
                workers.Add("Tom Lee", "Training");
                workers.Add("James Anderson", "HR");
                workers.Add("Michael Chan", "Content Development");
                workers.Add("Jackie Jakson", "Training");
                workers.Add("Bruce Douglas", "Graphics");
                workers.Add("Kim Date", "HR");
                workers.Add("Joseph Matthews", "Content Development");
                workers.Add("Rose Dorson", "Marketing");
                workers.Add("Andrews Stephan", "Graphics");
            

            SortedList<string, string> workersList = new SortedList<string, string>(){
                {"Tom Lee", "Training"},
                {"James Anderson", "HR"},
                {"Michael Chan", "Content Development"},
                {"Jackie Jakson", "Training"},
                {"Bruce Douglas", "Graphics"},
                {"Kim Date", "HR"},
                {"Joseph Matthews", "Content Development"},
                {"Rose Dorson", "Marketing"},
                {"Andrews Stephan", "Graphics"}
            };

            if (workersList.ContainsValue("Graphics"))
            {
                workersList.Remove("Andrews Stephan");
            }
            foreach (var worker in workersList)
            {
                Console.WriteLine($"Name: {worker.Key}, Department: {worker.Value}");
            }


        }
    }
}
