using System;

namespace SampleConsole_Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            bool isEligible = true;

            // Output to console
            ////Console.WriteLine("Enter Your Name: ");
            ////// Input from console
            ////name = Console.ReadLine();
            ////Console.WriteLine("Your name is: " + name);

            ////Console.WriteLine("Enter Your Age: ");
            ////age = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine($"Your age is: {age}");

            //////Interpolation
            ////Console.WriteLine($"Your name is {name} and your age is {age}");

            // cout << "Your Name: " << name << endl
            // printf("Your name: %s", name)
            // cin >> name
            //scanf("%s", name)

            // Operators
            // + / * - && || == ++ -- () % ! != <>

            // Data types
            // int, double, float, bool, string, char, DateTime
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.Ticks);
            Console.WriteLine($"Your delivery date is: {date.AddDays(2)}");

            switch (isEligible)
            {
                case true:
                    break;

                default:
                    break;
            }

            

            // Control Structures
            // Sequence
            // Repition - for loop, while, do while, foreach
            // Decision - if statements, switch, ternary operators

            ////if (age > 18)
            ////{
            ////    isEligible = true;
            ////}
            ////else
            ////{
            ////    isEligible = false;
            ////}

            //ternary operator
            ////isEligible = age > 18 ? true : false;

            //Arrays
            // int[10] numberArray;
            int[] numberArray = new int[10];
            int[] numArray = { 1, 1, 2, 3, 3, 7, 4, 5, 8, 9, 6, 3, 2, 5 };

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i == 2)
                    continue;

                if(i == 8)
                    break;
            }

            while (true)
            {

            }

            do
            {

            } while (true);

            foreach (var item in numArray)
            {

            }

            // C#: Person p = new Person();
            // Person p;
            // Person p(10);
        }
    }
}
