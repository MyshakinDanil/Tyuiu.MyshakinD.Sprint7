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

        [TestMethod]
        public void CheckFileDataLoading()
        {
            string path = DataService.LoadBuses();

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }

        [TestMethod]
        public void CheckStopsLoading()
        {
            string bus_number = "3";
            string orientation = "A";
            string url = $"https://kudikina.ru/tmn/bus/{bus_number.Replace("к", "k").Replace("д", "d").Replace("ж", "zh").Replace("в", "v").Replace("а", "a").Replace("э", "e").Replace("р", "r").Replace("б", "b")}/{orientation}";

            string path = DataService.LoadBusStops(url, bus_number, orientation);

            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void CheckSearchingByStop()
        {
            string request = " удыкина гора";
            
            string[] res = DataService.SearchByStop(request);

            string[] wait = [];

            foreach (string str in res)
            {
                Console.WriteLine(str);
            }
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckStopsCount()
        {
            int res = Convert.ToInt32(DataService.StopsCount());

            int wait = 10;

            bool checkResult = res > wait;

            Assert.IsTrue(checkResult);
        }

        [TestMethod]
        public void CheckMinRoute()
        {
            int res = Convert.ToInt32(DataService.MinRoute());

            int wait = 3;
            bool checkResult = res <= wait;

            Assert.IsTrue(checkResult);
        }

        [TestMethod]
        public void CheckMaxRoute()
        {
            int res = Convert.ToInt32(DataService.MaxRoute());

            int wait = 27;
            bool checkResult = res >= wait;
            Assert.IsTrue(checkResult);
        }

        [TestMethod]
        public void CheckAvgRoute()
        {
            int res = Convert.ToInt32(DataService.AvgRoute());

            int wait = 15;
            bool checkResult = res >= wait;
            Assert.IsTrue(checkResult);
        }

        [TestMethod]
        public void CheckGetRouteLen()
        {
            string busNum = "1";

            int res = DataService.GetRouteLen(busNum);
            int wait = 27;

            Assert.AreEqual(res, wait);
        }
    }
}