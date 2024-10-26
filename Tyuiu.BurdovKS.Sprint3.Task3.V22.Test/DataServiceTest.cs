



using Newtonsoft.Json.Linq;
using Tyuiu.BurdovKS.Sprint3.Task3.V22.Lib;




namespace Tyuiu.BurdovKS.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            string value = "tbtbbb dsfbg bbg";

            char item = 'b';

            double res = ds.GetMaxCharCount(value, item);

            double wait = 3;

            Assert.AreEqual(res, wait);










   


        }
    }
}