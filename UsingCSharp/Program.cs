using System;

namespace UsingCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = TakePersonalInfo();

            ShowCalculating(person);
        }

        private static Person TakePersonalInfo()
        {
            Person person = new Person(); //new Person("Tony Stark", "USD", 13750, 10);

            Console.Clear();
            Console.WriteLine("Welcome!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("What's your full name?");
            person.FullName = Console.ReadLine();                    
            person.UsualCurrency = "USD";       
            Console.WriteLine("What's your goal? (USD)");
            person.Goal = Convert.ToDecimal(Console.ReadLine()); 
            Console.WriteLine("How many months do you want to save money?");
            person.MonthsToSave = Convert.ToInt32(Console.ReadLine());                    

            return person;
        }

        private static void ShowCalculating(Person p)
        {
            Console.Clear();
            Console.WriteLine("Well, " + p.FullName + "!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Your Goal is: " + p.UsualCurrency + " " + p.Goal.ToString());
            Console.WriteLine("After " + p.MonthsToSave + " months you'll reach your goal is you save " + p.UsualCurrency + " " + p.GetMyAmount().ToString() + " every month!");
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}
