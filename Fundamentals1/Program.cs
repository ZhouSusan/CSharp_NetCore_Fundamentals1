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
            Console.WriteLine("FizzBuzz2 without modulo Test");
            FizzBuzz2();
            Console.WriteLine("Generate Ten Random Number String Test");
            for (int r = 0; r < GenerateRandomNumberString().Length; r++)
            {
                Console.WriteLine(GenerateRandomNumberString()[r]);
            }
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

        //Program that prints value, Fizz(multiply of 3), Buzz(multiply of 5), or FizzBuzz(multiply of 3 & 5), between range 1 to 150
        static void FizzBuzz2()
        {
            const string FIZZ = "Fizz";
            const string BUZZ = "Buzz";
            const string FIZZBUZZ = "FizzBuzz";

            int k = 0;
            while (k < 150)
            {
                Console.WriteLine(++k);
                Console.WriteLine(++k);
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(BUZZ); ++k;
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(++k);
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(BUZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(++k);
                Console.WriteLine(FIZZBUZZ); ++k;
            }
        }

        //Generate 10 random values and output the respective word, in relation to step three, for the generated values
        static string[] GenerateRandomNumberString()
        {

            Random rand = new Random();

            Dictionary<int, string> Values_Dict = new Dictionary<int, string>();
            Values_Dict.Add(1, "One");
            Values_Dict.Add(2, "Two");
            Values_Dict.Add(3, "Three");
            Values_Dict.Add(4, "Four");
            Values_Dict.Add(5, "Five");
            Values_Dict.Add(6, "Six");
            Values_Dict.Add(7, "Seven");
            Values_Dict.Add(8, "Eight");
            Values_Dict.Add(9, "Nine");
            Values_Dict.Add(10, "Ten");
            Values_Dict.Add(11, "Eleven");
            Values_Dict.Add(12, "Tweleve");
            Values_Dict.Add(13, "Thirteen");
            Values_Dict.Add(14, "Fourteen");
            Values_Dict.Add(15, "Fiveteen");
            Values_Dict.Add(16, "Sixteen");
            Values_Dict.Add(17, "Seventeen");
            Values_Dict.Add(18, "Eightteen");
            Values_Dict.Add(19, "Nineteen");
            Values_Dict.Add(20, "Twenty");
            Values_Dict.Add(21, "Twenty-One");
            Values_Dict.Add(22, "Twenty-Two");
            Values_Dict.Add(23, "Twenty-Three");
            Values_Dict.Add(24, "Twenty-Four");
            Values_Dict.Add(25, "Twenty-Five");
            Values_Dict.Add(26, "Twenty-Six");
            Values_Dict.Add(27, "Twenty-Seven");
            Values_Dict.Add(28, "Twenty-Eight");
            Values_Dict.Add(29, "Twenty-Nine");
            Values_Dict.Add(30, "Thirty");

            string[] resultArr = new string[10];
            for (int x = 0; x < resultArr.Length; x++)
            {
                int temp = rand.Next(1, 31);
                if (Values_Dict.ContainsKey(temp))
                {
                    resultArr[x] = Values_Dict[temp];
                }
            }

            return resultArr;
        }
    }
}
