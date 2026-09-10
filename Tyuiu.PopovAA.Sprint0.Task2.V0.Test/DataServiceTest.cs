using Tyuiu.PopovAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PopovAA.Sprint0.Task2.V0.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Артём";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Артём", res);
        }
    }
}