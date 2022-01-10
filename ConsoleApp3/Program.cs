using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };
            //UsingLINQFunctions Queries
            UsingLINQFuctions(names);
        }
        public static void UsingLINQFuctions(string[] names)
        {
            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extarct = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> query = names.Where(filter)
                .OrderBy(extarct)
                .Select(project);

            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();
        }

    }
}
