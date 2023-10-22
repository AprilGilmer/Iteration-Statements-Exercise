namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below



        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Print1000();
            Print3Thru999();
            TwoParameters();
            EvenOrOdd();
            PositiveOrNegative();
            AgeOfVoter();
        }
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print3Thru999()
        {
            for (int i = 3; i >= 999; i += 3)
            {
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void TwoParameters()
        {
            Console.WriteLine("Check to see if two numbers are equal or not.");
            Console.WriteLine("Enter your first number below.");
            string usersFirstNumber = Console.ReadLine();
            int usersFirstNumberParsed = Int32.Parse(usersFirstNumber);

            Console.WriteLine("Enter your second number below.");
            string usersSecondNumber = Console.ReadLine();
            int usersSecondNumberParsed = Int32.Parse(usersSecondNumber);

            if (usersFirstNumberParsed == usersSecondNumberParsed)
            {
                Console.WriteLine("These numbers are equal.");
            }
            else
            {
                Console.WriteLine("These numbers are not equal.");
            }

            Console.WriteLine();
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Check to see if your number is even or odd.");
            Console.WriteLine("Enter your number below.");
            string usersNumber = Console.ReadLine();
            int usersNumberParsed = Int32.Parse(usersNumber);

            if (usersNumberParsed % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }

            Console.WriteLine();
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Check to see if your number is positive or negative.");
            Console.WriteLine("Enter your number below.");
            string usersNumber = Console.ReadLine();
            int usersNumberParsed = Int32.Parse(usersNumber);

            if (usersNumberParsed >= 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else
            {
                Console.WriteLine("Your number is negative");
            }

            Console.WriteLine();

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void AgeOfVoter(/*string age*/)
        {
            Console.WriteLine("Write your age below to check if you're old enough to vote.");
            string age = Console.ReadLine();
            int parsedAge = Int32.Parse(age);

            if (parsedAge >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You're too young, kid.");
            }
        }
    }
}