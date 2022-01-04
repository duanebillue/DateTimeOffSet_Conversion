using System;

namespace DateTimeOffSet_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset startDate = DateTime.Now;
            DateTimeOffset endDate = DateTime.Now;

            DateTime dtStartDate = DateTime.Now;
            DateTime dtEndDate = DateTime.Now;

            startDate = DateTime.Parse(startDate.ToString("yyyy-MM-dd"));
            dtStartDate = DateTime.Parse(dtStartDate.ToString("yyyy-MM-dd"));

            Console.WriteLine("{0}" + Environment.NewLine + "{1}", startDate.ToString(), endDate.ToString());
            Console.WriteLine("{0}", startDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("{0}" + Environment.NewLine + "{1}", dtStartDate.ToString(), dtEndDate.ToString());
            Console.WriteLine("{0}", dtStartDate.ToString("yyyy-MM-dd"));
            Console.ReadLine();
        }
    }
}
