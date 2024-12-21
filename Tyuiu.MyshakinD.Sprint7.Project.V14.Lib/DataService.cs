using HtmlAgilityPack;
using System.Net;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14.Lib {
    public class DataService {

        public static bool ConnectionAvailable() {
            try
            {
                HttpWebRequest httpReq = (HttpWebRequest)HttpWebRequest.Create("http://www.google.com");
                HttpWebResponse httpWeb = (HttpWebResponse)httpReq.GetResponse();

                if (HttpStatusCode.OK == httpWeb.StatusCode)
                {
                    httpWeb.Close();
                    return true;
                }
                else
                {
                    httpWeb.Close();
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
}
        public static string LoadBuses()
        {
            string path = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";


            var web = new HtmlWeb();
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            string url_buses = "https://kudikina.ru/tmn/bus";
            htmlDoc.LoadHtml(web.Load(url_buses).Text);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='container']//div[@class='row']//div[@class='text-center']//a[@class='bus-item bus-icon']");

            FileInfo fileinfo = new FileInfo(path);

            bool fileexists = fileinfo.Exists;

            if (fileexists)
            {
                File.Delete(path);
            }

            string[] not_real_buses = ["тест", "12345", "7777"];
            bool is_not_include = true;

            using (StreamWriter streamwriter = new StreamWriter(path))
            {
                foreach (var node in nodes)
                {
                    is_not_include = true;

                    string bus_number = node.InnerHtml.Split("<span>")[0].Trim().Split(" ")[1].Trim();


                    foreach (string not_real_bus in not_real_buses)
                    {
                        if (bus_number == not_real_bus)
                        {
                            is_not_include = false;

                        }

                    }

                    if (is_not_include)
                    {
                        string[] stops = node.InnerHtml.Split("<span>")[1].Trim().Split(" - ");
                        if (stops.Length == 1)
                        {
                            stops = stops[0].Split(" -");
                            if (stops.Length == 1)
                            {
                                stops = stops[0].Split("-");
                            }
                        }

                        string start_stop = stops[0];
                        string end_stop = stops[1].Replace("</span>", "");

                        streamwriter.WriteLine($"{bus_number};{start_stop};{end_stop}");

                        string path_to_stops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{bus_number}.csv";

                        var web_stops = new HtmlWeb();
                        var htmldoc_stops = new HtmlAgilityPack.HtmlDocument();
                        string url_bus_stops = $"https://kudikina.ru/tmn/bus/{bus_number}/A";
                        htmldoc_stops.LoadHtml(web.Load(url_bus_stops).Text);

                        var nodes_stops = htmldoc_stops.DocumentNode.SelectNodes("//div[@class='container']//div[@class='row']//div[@class='bus-stops ']//div[@class='row']");

                        bool file_stops_exists = File.Exists(path_to_stops);

                        if (file_stops_exists)
                        {
                            File.Delete(path_to_stops);
                        }

                        using (StreamWriter streamwriter_stops = new StreamWriter(path_to_stops))
                        {
                            foreach (var node_stops in nodes_stops)
                            {

                            }
                        }
                    }

                }
            }

            return path;
        } 

    }
}
