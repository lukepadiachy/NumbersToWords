namespace NumbersToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 333;
            NumberChanger NumberSwitch = new NumberChanger();
            string result = NumberSwitch.ConvertNumbersToWords(number);
            Console.WriteLine(result);
        }
    }
}