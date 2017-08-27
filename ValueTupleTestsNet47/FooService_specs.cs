using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueTupleLibrary;

namespace ValueTupleTestsNet47
{
    [TestClass]
    public class FooService_specs
    {
        [TestMethod]
        public void Bar_returns_value_tuple_correctly()
        {
            var sut = new FooService();

            var actual = sut.Bar();

            Assert.AreEqual(1, actual.a);
            Assert.AreEqual("Hello ValueTuple", actual.b);
        }
    }
}
