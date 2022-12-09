namespace Fundaamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Print All Values from 1 to 255");
            printAllValues(255);
        }

        //A program that prints all the values from 1-255
        static void printAllValues(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
