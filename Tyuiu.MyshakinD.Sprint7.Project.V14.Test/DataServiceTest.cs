using Tyuiu.MyshakinD.Sprint7.Project.V14.Lib;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void CheckInternetConnection()
        {
            bool res = DataService.ConnectionAvailable();
            Assert.IsTrue(res);
        }
    }
}