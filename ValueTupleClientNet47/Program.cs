using ValueTupleLibrary;

namespace ValueTupleClientNet47
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new FooService();
            var result = service.Bar();
            System.Console.WriteLine(result.b);
        }
    }
}
