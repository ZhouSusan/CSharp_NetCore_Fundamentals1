namespace Fundaamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Print All Values from 1 to 255");
            PrintAllValues(255);
            Console.WriteLine("FizzBuzz Test");
            FizzBuzz(100);
        }

        //A program that prints all the values from 1-255
        static void PrintAllValues(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }

        /* FizzBuzz 
             new loop that prints all values from 1-100 that are divisible by 3 or 5,
            but not both Modify the previous loop to print "Fizz" for multiples of 3,
            "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5 */
        static void FizzBuzz(int x)
        {
            for (int j = 1; j <= x; j++)
            {
                if (j % 5 == 0 && j % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } 
                    else if (j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } 
                    else if (j % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                    else
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
