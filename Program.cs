namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var max_value1= MaxOfThree.get_max(30,40,50);
            Console.WriteLine(max_value1);

            var max_value2 = MaxOfThree.get_max(3.5, 4.2, 5.8);
            Console.WriteLine(max_value2);

            var max_value3 = MaxOfThree.get_max("garg","ankit","kunal");
            Console.WriteLine(max_value3);
        }
    }
}