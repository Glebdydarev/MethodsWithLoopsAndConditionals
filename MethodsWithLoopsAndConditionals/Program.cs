using System;


namespace MethodsWithLoopsAndConditionals
{

    class Program

    {

        // Write a method that will print to the console all numbers 1000 through - 1000

        public static void Print1000s()



        {


            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }


        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void PrintThrees()
        {
            for (int i = 3; i <= 999; i += 3) //i =i + 3;


            {
                Console.WriteLine(i);
            }

        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.

        public static void TwoIntsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Those nubers are equal");
            }


            else
            {
                Console.WriteLine("Those numbers are NOT equal");
            }


        }
        //Write a method to check whether a given number is even or odd.
        public static void OddrEven(int number)
        {
            if (number % 5 == 0)
            {
                Console.WriteLine($"{number}is even");

            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }

        }
        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num)

        {

            if (num > 0)
            {
                Console.WriteLine($" {num} is positive.");
            }


            else if (num < 0)
            {
                Console.WriteLine($" {num} is negative");

            }

            else
            {
                Console.WriteLine($"{num} is neither posetive or negative");
            }

        }


        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void AgeCheck()
        {
            Console.WriteLine("What is your age?");
            bool oldenouugh = int.TryParse(Console.ReadLine(), out int result);

            if (result < 18)

            {
                Console.WriteLine("Very sorry. You are not old enouugh to vote");
            }
            else

            {
                Console.WriteLine("Congrants! Ypu can vote!");


            }

        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10.\
        public static void InRange()
        {
            Console.WriteLine("Enter an integer");

            var userResponse = int.TryParse(Console.ReadLine(), out int result);
            if (result >= -10 && result <= 10)
            {

                Console.WriteLine($"{result} is betwen 10 $ -10");

            }

            else
            {
                Console.WriteLine($"number out of range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer.

        public static void Multiply()
        {


            Console.WriteLine("Enter an integer");




            var userresponse = int.TryParse(Console.ReadLine(), out int result);


            for (int x = 1; x <= 12; x++)

            {
                Console.WriteLine($"{x} x {result} = {x * result}");

            }

        }
        static void Main(string[] args)
        {





            //Print1000s();
            //PrintThrees();
            //TwoIntsEqual(53, 84);
           // TwoIntsEqual(34, 34);

            //OddrEven(9);
            //OddrEven(24);

            //PositiveOrNegative(-47);

            //PositiveOrNegative(99);
            //PositiveOrNegative(0);

            //AgeCheck();
            //InRange();

           // InRange();




        }

    }

}       