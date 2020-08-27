using System;

namespace _11.Null检测
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            System.Console.WriteLine(s?.Length); // 使用?.Null检测可以避免报错

            try
            {
                //System.Console.WriteLine(s.Length); // 报错:System.NullReferenceException
            }
            catch (Exception e) when (LogException(e))
            {
            }

            static bool LogException(Exception e)
            {
                Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
                Console.WriteLine($"\tMessage: {e.Message}");
                return false;
            }


            dynamic d = 1;
            var testSum = d + 3;
            // Rest the mouse pointer over testSum in the following statement.
            System.Console.WriteLine(testSum);

        }
    }
}
