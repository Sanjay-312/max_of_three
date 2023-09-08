namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MaxOfThree<int> obj1=new MaxOfThree<int> (4,20,3);
            var value1=obj1.TestMaximun();
            Console.WriteLine(value1);

            MaxOfThree<float> obj2 = new MaxOfThree<float>(3.5f, 4.5f, 6.5f);   
            var value2 = obj2.TestMaximun();
            Console.WriteLine(value2);

            MaxOfThree<string> obj3 = new MaxOfThree<string>("sanjay", "viraj", "pavan");
            var value3 = obj3.TestMaximun();
            Console.WriteLine(value3);

        }
    }
}