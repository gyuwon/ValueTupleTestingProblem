namespace ValueTupleLibrary
{
    public class FooService
    {
        public (int a, string b) Bar()
        {
            return (a: 1, b: "Hello ValueTuple");
        }
    }
}
