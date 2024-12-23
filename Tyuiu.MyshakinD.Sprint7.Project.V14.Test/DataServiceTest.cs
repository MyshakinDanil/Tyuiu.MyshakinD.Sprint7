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
            string url = $"https://kudikina.ru/tmn/bus/{bus_number.Replace("�", "k").Replace("�", "d").Replace("�", "zh").Replace("�", "v").Replace("�", "a").Replace("�", "e").Replace("�", "r").Replace("�", "b")}/{orientation}";

            string path = DataService.LoadBusStops(url, bus_number, orientation);

            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void CheckSearchingByStop()
        {
            string request = "�������� ����";
            
            string[] res = DataService.SearchByStop(request);

            string[] wait = [];

            foreach (string str in res)
            {
                Console.WriteLine(str);
            }
            CollectionAssert.AreEqual(wait, res);
        }
    }
}