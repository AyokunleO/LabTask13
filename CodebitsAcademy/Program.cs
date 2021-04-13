using System;
using System.Collections.Generic;
using System.Collections;

namespace CodebitsAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var exhibitInfo = new ArrayList(){
                new Exhibit("Ecommerce", "David Brown", "Javascript", "Floor 1", "Primary"),
                new Exhibit("Robotics", "Neh Busting", "C#", "Floor 2", "Higher"),
                new Exhibit("Enterprise Solution", "John Davies", "Python", "Floor 3", "Labs"),
                new Exhibit("Fintech", "Stephen Lido", "Flutter", "Floor 2", "Primary"),
                new Exhibit("WebApp", "Donald Carr", "C#", "Floor 3", "Higher"),
                new Exhibit("Fintec Solution", "John Stephens", "Java", "Floor 3", "Labs"),
                new Exhibit("Ecommerce", "Abigail David", "Javascript", "Floor 1", "Primary"),
                new Exhibit("Space TEch", "Kay Trump", "C#", "Floor 2", "Higher"),
                new Exhibit("Enterprise Solution", "James Dafidi", "Python", "Floor 3", "Labs"),
                new Exhibit("Web Dev", "Yemi Banjo", "Flutter", "Floor 2", "Primary"),
                new Exhibit("WebApp", "Sean Carr", "C#", "Floor 3", "Higher"),
                new Exhibit("Fintec", "Etebe Banks", "Java", "Floor 3", "Labs"),
                new Exhibit("Web Dev", "Lionel Daniels", "Django", "Floor 2", "Primary"),
                new Exhibit("WebApp", "Sean Carr", "C++", "Floor 3", "Higher"),
                new Exhibit("Fintec", "Tope Banks", "Laravel", "Floor 3", "Labs"),  
            };
                exhibitInfo.RemoveAt(14);
            foreach (Exhibit info in exhibitInfo)
            {
                Console.WriteLine($"{info}");
            }
            Console.WriteLine("Toprankers in the Last Two Years:");
            Hashtable TopRankers = new Hashtable(){
                {"Tola Seedy", "75%, 2020"},
                {"James Bond", "77%, 2021"}
            };
            foreach (DictionaryEntry ranker in TopRankers)
            {
                Console.WriteLine($"Name: {ranker.Key}, Percentage and Year: {ranker.Value}");
            }

            Console.WriteLine("\nHighest Scorers in the Last Two Years:");
            Hashtable highScorers = new Hashtable(){
                {"Tola Seedy", "C#, 80%, 2020"},
                {"James Bond", "Java, 78%, 2020"},
                {"James Brown", "Python, 80%, 2020"},
                {"Anthony Ryan", "C#, 76%, 2021"},
                {"Dan Dove", "Java, 80%, 2021"},
                {"James Bender", "Python, 78%, 2021"},
            };
            foreach (DictionaryEntry scorer in highScorers)
            {
                Console.WriteLine($"Name: {scorer.Key}, {scorer.Value}\n");
            }
            if(highScorers.ContainsKey("Tola Seedy"))
            {
                Console.WriteLine($"Student has gained admission to one of the Nation's top colleges with a very high score");
            }else{
                Console.WriteLine("Student not found!");
            }
        }
    }
}
