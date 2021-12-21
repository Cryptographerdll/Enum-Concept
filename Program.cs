using System;

namespace Enums_Concept
{
    class Program
    {
        public enum ProductCodes
        {
            Milk = 0, 
            Juice = 1, 
            Tea = 2 
          // Constantes
        }
        static void Main(string[] args)
        {
            ProductCodes test = ProductCodes.Milk;
            Console.WriteLine((int)test); // 0

            int test2 = 1;
            Console.WriteLine((ProductCodes)test2); // Juice

            Console.WriteLine(test.ToString()); // Milk

            string test3 = "Tea";
            ProductCodes getParse;

            bool checkParse = Enum.TryParse(test3, out getParse);
            Console.WriteLine(getParse); // Tea
            Console.WriteLine(checkParse); // True
        }
    }
}
