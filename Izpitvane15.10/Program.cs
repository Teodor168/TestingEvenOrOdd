namespace Izpitvane15._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Even num = new Even();
            //with odd number
            bool res= num.IsEven(5);
            Console.WriteLine($"number 5 IsEven: {res}");
            // with even number
            bool result= num.IsEven(6);
            Console.WriteLine($"number 6 IsEven: {result}");
        }
    }
}
