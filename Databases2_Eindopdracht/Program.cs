using System;

namespace Databases2_Eindopdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new GenericTest[] { new ADOtest(), new MongoTest(), new EntityFrameworkTest() }; //  new ADOtest(), new MongoTest(), new EntityFrameworkTest()
            var amountArray = new int[] { 1, 1000, 100000, 1000000 }; // 1, 1000, 100000, 1000000

            foreach (GenericTest test in testArray)
            {
                Console.WriteLine(test.GetType().Name);

                Console.WriteLine("-------------------");
                foreach (int amount in amountArray)
                {
                    test.CleanDatabase();
                    Console.WriteLine("Create " + amount + ": " + test.RunCreate(amount));
                    Console.WriteLine("Read " + amount + ": " + test.RunRead(amount));
                    Console.WriteLine("Update " + amount + ": " + test.RunUpdate(amount));
                    Console.WriteLine("Delete " + amount + ": " + test.RunDelete(amount));
                    Console.WriteLine("-------------------");
                }
                Console.WriteLine();
            }
            Console.WriteLine("DONE!");
            Console.ReadLine();

        }
    }
}
