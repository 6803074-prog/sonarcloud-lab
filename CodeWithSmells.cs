using System;

namespace NetSdrClient
{
    // 🔴 ПРОБЛЕМА 1: Клас з приватним конструктором, але не статичний
    public class UtilityClass
    {
        private UtilityClass() { }
        
        public static void DoWork()
        {
            Console.WriteLine("Working...");
        }
    }
    
    // 🔴 ПРОБЛЕМА 2: Magic Numbers
    public class AgeChecker
    {
        public bool CanDrink(int age)
        {
            return age >= 21;
        }
        
        public bool IsAdult(int age)
        {
            return age >= 18;
        }
        
        public bool IsSenior(int age)
        {
            return age >= 65;
        }
    }
    
    // 🔴 ПРОБЛЕМА 3: Довгий метод
    public class LongMethodExample
    {
        public void ProcessData()
        {
            Console.WriteLine("Step 1");
            Console.WriteLine("Step 2");
            Console.WriteLine("Step 3");
            Console.WriteLine("Step 4");
            Console.WriteLine("Step 5");
            Console.WriteLine("Step 6");
            Console.WriteLine("Step 7");
            Console.WriteLine("Step 8");
            Console.WriteLine("Step 9");
            Console.WriteLine("Step 10");
            Console.WriteLine("Step 11");
            Console.WriteLine("Step 12");
            Console.WriteLine("Step 13");
            Console.WriteLine("Step 14");
            Console.WriteLine("Step 15");
            Console.WriteLine("Step 16");
            Console.WriteLine("Step 17");
            Console.WriteLine("Step 18");
            Console.WriteLine("Step 19");
            Console.WriteLine("Step 20");
        }
    }
    
    // 🔴 ПРОБЛЕМА 4: Дубльований код
    public class Calculator
    {
        public void CalculateSumA(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The sum is: {result}");
            Console.WriteLine($"Time: {DateTime.Now}");
        }
        
        public void CalculateSumB(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"The sum is: {result}");
            Console.WriteLine($"Time: {DateTime.Now}");
        }
    }
    
    // 🔴 ПРОБЛЕМА 5: Невикористовуваний параметр
    public class UnusedParamExample
    {
        public void Process(string notUsed)
        {
            Console.WriteLine("Processing...");
        }
    }
}
