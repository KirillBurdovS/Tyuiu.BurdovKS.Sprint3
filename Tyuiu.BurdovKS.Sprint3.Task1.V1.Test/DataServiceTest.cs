

using Tyuiu.BurdovKS.Sprint3.Task1.V1.Lib;


namespace Tyuiu.BurdovKS.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;

            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 5.311;

            Assert.AreEqual(res, wait);


           


            



        }
    }
}