using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            string userFrom = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, I am Matt, nice to meet you. I see that your favorite band is {userBand}, and you are {userAge} years old, and are from {userFrom}.");
            Console.WriteLine($"It is nice to meet you {userName}, I am also from {userFrom}, maybe one day we will meet.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number to multiply");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first number");
            int num4 = int.Parse(Console.ReadLine());

            int product = Multiply(num3, num4);
            Console.WriteLine($"The product of the two numbers you selected is {product}");

            Console.WriteLine("How many numbers do you want to add together?");
            int userAmount = int.Parse(Console.ReadLine());
            int[] numbers = new int[userAmount];

            for (int i = 0; i < userAmount; i++)
            {
                
                Console.WriteLine("Enter a number now please");
                int userNumber = int.Parse(Console.ReadLine());
                
                numbers[i] = userNumber;
                
            }

            int sumAll = Sum(numbers);

            Console.WriteLine($"Here is the value of the numbers you have selected - {sumAll}");
            Console.WriteLine("Thank you for reading through my program, press enter to end the demonstration.");
            Console.ReadLine();

        } 

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Sum(params int[] args)
        {
            int sum = 0; 

            foreach(int num in args)
            {
                sum += num;
            }

            return sum;
        }
    }
}
