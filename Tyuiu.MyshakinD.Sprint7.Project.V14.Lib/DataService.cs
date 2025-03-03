﻿using HtmlAgilityPack;
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
                    }

                }
            }

            return path;
        } 

        public static string LoadBusStops(string url, string bus_number, string orientation)
        {
            string path = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{bus_number}_stops_{orientation}.csv";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            var web = new HtmlWeb();
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();

            htmlDoc.LoadHtml(web.Load(url).Text);

            HtmlNodeCollection nodes_stops;

            var stops_time_null = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='container']//div[@class='row']//div[@class='alert alert-info']");

            bool none_time = false;

            if (stops_time_null != null)
            {
                if (stops_time_null.InnerText == "Расписания по данному маршруту указаны без учета дней недели")
                {
                    nodes_stops = htmlDoc.DocumentNode.SelectNodes("//div[@class='container']//div[@class='row']//div[@class='bus-stops oneline']//div[@class='row']");
                    none_time = true;
                }
                else
                {
                    nodes_stops = null;
                }
            }
            else
            {
                nodes_stops = htmlDoc.DocumentNode.SelectNodes("//div[@class='container']//div[@class='row']//div[@class='bus-stops ']//div[@class='row']");
            }

            using (StreamWriter streamWriterStops = new StreamWriter(path))
            {
                if (nodes_stops != null && none_time == false)
                {
                    foreach (var node_stops in nodes_stops)
                    {
                        var stops = node_stops.SelectNodes("//div[@class='container']//div[@class='row']//div[@class='bus-stops ']//div[@class='row']//div[@class='bus-stop col-xs-12 col-sm-6 col-md-6']");
                        var stops_time = node_stops.SelectNodes("//div[@class='container']//div[@class='row']//div[@class='bus-stops ']//div[@class='row']//div[@class='col-xs-12 col-sm-6 col-md-6 text-right']");
                        for (int i = 0; i < stops.ToList().Count; i++)
                        {
                            string times = stops_time[i].InnerText.Trim().Replace("Показать все", "");
                            int timesLenght = times.Length / 5;

                            int current_res_time = 0;
                            string res_times = "";

                            for (int j = 0; j < timesLenght; j++)
                            {
                                if (j != timesLenght - 1)
                                {
                                    res_times += $"{times[(0 + current_res_time)..(5 + current_res_time)]};";
                                    current_res_time += 5;
                                }
                                else
                                {
                                    res_times += $"{times[(0 + current_res_time)..(5 + current_res_time)]}";
                                }
                            }

                            string[] stop_number = stops[i].InnerText.Trim().Split(" ", 2);

                            streamWriterStops.WriteLine($"{stop_number[0].Replace(")", "")};{stop_number[1]};{res_times}");
                        }

                        break;

                    }
                }
                else if (nodes_stops != null && none_time == true)
                {
                    foreach (var node_stops in nodes_stops)
                    {
                        streamWriterStops.WriteLine($"{node_stops.InnerText.Trim().Split(" ", 2)[0].Replace(")", "")};{node_stops.InnerText.Trim().Split(" ", 2)[1]}");
                    }
                }
                else
                {
                    streamWriterStops.WriteLine("Для данного автобуса расписание отсутствует :(");
                }
            }

            return path;
        }

        public static string[] SearchByStop(string request)
        {
            string pathToBuses = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int lenght = 0;

            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line1 = sr1.ReadLine();

                    string busNum = line1.Split(";")[0];
                    string pathToBusStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{busNum}_stops_A.csv";

                    try
                    {

                        using (StreamReader sr2 = new StreamReader(pathToBusStops))
                        {
                            while (!sr2.EndOfStream)
                            {
                                string line2 = sr2.ReadLine();

                                if (line2.Contains("Для данного автобуса расписание отсутствует :("))
                                {
                                    break;
                                }
                                else
                                {
                                    string currentStop = line2.Split(";")[1];

                                    if (currentStop.ToLower().Contains(request.ToLower()))
                                    {
                                        lenght++;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        string url = $"https://kudikina.ru/tmn/bus/{busNum}/A";
                        string orientation = "A";

                        
                        LoadBusStops(url, busNum, orientation);

                        using (StreamReader sr2 = new StreamReader(pathToBusStops))
                        {
                            while (!sr2.EndOfStream)
                            {
                                string line = sr2.ReadLine();
                                
                                if (line.Contains("Для данного автобуса расписание отсутствует :("))
                                {
                                    break;
                                }
                                else
                                {
                                    string currentStop = line.Split(";")[1];

                                    if (currentStop.ToLower().Contains(request.ToLower()))
                                    {
                                        lenght++;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string[] res = new string[lenght];

            int i = 0;
            
            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line1 = sr1.ReadLine();

                    string busNum = line1.Split(";")[0];
                    string pathToBusStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{busNum}_stops_A.csv";

                    try
                    {

                        using (StreamReader sr2 = new StreamReader(pathToBusStops))
                        {
                            while (!sr2.EndOfStream)
                            {
                                string line2 = sr2.ReadLine();

                                if (line2.Contains("Для данного автобуса расписание отсутствует :("))
                                {
                                    break;
                                }
                                else
                                {
                                    string currentStop = line2.Split(";")[1];

                                    if (currentStop.ToLower().Contains(request.ToLower()))
                                    {
                                        res[i] = busNum;
                                        i++;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        string url = $"https://kudikina.ru/tmn/bus/{busNum}/A";
                        string orientation = "A";


                        LoadBusStops(url, busNum, orientation);

                        using (StreamReader sr2 = new StreamReader(pathToBusStops))
                        {
                            while (!sr2.EndOfStream)
                            {
                                string line = sr2.ReadLine();

                                if (line.Contains("Для данного автобуса расписание отсутствует :("))
                                {
                                    break;
                                }
                                else
                                {
                                    string currentStop = line.Split(";")[1];

                                    if (currentStop.ToLower().Contains(request.ToLower()))
                                    {
                                        res[i] = busNum;
                                        i++;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string[] result = res.Distinct().ToArray();
            
            return result;
        }

        public static string BusesCount()
        {
            string path = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int busCount = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    busCount++;
                }
            }

            return busCount.ToString();
        }

        public static string StopsCount()
        {
            string pathToBuses = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int lenght = 0;

            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    string currentBus = line.Split(";")[0];

                    string pathToStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{currentBus}_stops_A.csv";

                    using (StreamReader sr2 = new StreamReader(pathToStops))
                    {
                        while (!sr2.EndOfStream)
                        {
                            string line2 = sr2.ReadLine();
                            if (!line2.Contains("Для данного автобуса расписание отсутствует: ("))
                            {
                                lenght++;
                            }
                        }
                    }
                }
            }

            string[] stops = new string[lenght];
            int index = 0;

            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    string currentBus = line.Split(";")[0];

                    string pathToStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{currentBus}_stops_A.csv";

                    using (StreamReader sr2 = new StreamReader(pathToStops))
                    {
                        while (!sr2.EndOfStream)
                        {
                            string line2 = sr2.ReadLine();
                            if (line2 != "Для данного автобуса расписание отсутствует :(")
                            {
                                stops[index] = line2.Split(";")[1];
                                index++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            string[] res = stops.Distinct().ToArray();
            
            return res.Length.ToString();
        }

        public static string MinRoute()
        {
            string pathToBuses = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int res = 99999999;

            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    string currentBus = line.Split(";")[0];

                    string pathToStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{currentBus}_stops_A.csv";

                    int lineLenght = 0;

                    using (StreamReader sr2 = new StreamReader(pathToStops))
                    {
                        while (!sr2.EndOfStream)
                        {
                            string line2 = sr2.ReadLine();
                            if (line2 != "Для данного автобуса расписание отсутствует :(")
                            {
                                lineLenght++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (lineLenght < res && lineLenght != 0)
                    {
                        res = lineLenght;
                    }
                }
            }

            return res.ToString();
        }

        public static string MaxRoute()
        {
            string pathToBuses = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int res = 0;

            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    string currentBus = line.Split(";")[0];

                    string pathToStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{currentBus}_stops_A.csv";

                    int lineLenght = 0;

                    using (StreamReader sr2 = new StreamReader(pathToStops))
                    {
                        while (!sr2.EndOfStream)
                        {
                            string line2 = sr2.ReadLine();
                            if (line2 != "Для данного автобуса расписание отсутствует :(")
                            {
                                lineLenght++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (lineLenght > res && lineLenght != 0)
                    {
                        res = lineLenght;
                    }
                }
            }

            return res.ToString();
        }

        public static string AvgRoute()
        {
            string pathToBuses = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int res = 0;

            int sum = 0;
            int count = 0;

            using (StreamReader sr1 = new StreamReader(pathToBuses))
            {
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    string currentBus = line.Split(";")[0];

                    string pathToStops = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{currentBus}_stops_A.csv";

                    int lineLenght = 0;

                    using (StreamReader sr2 = new StreamReader(pathToStops))
                    {
                        while (!sr2.EndOfStream)
                        {
                            string line2 = sr2.ReadLine();
                            if (line2 != "Для данного автобуса расписание отсутствует :(")
                            {
                                lineLenght++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (lineLenght != 0)
                    {
                        sum += lineLenght;
                        count++;
                    }
                }
            }

            res = sum / count;
            
            return res.ToString();
        }

        public static int GetRouteLen(string busNumber)
        {
            string path = $@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{busNumber}_stops_A.csv";

            int lenght = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line2 = sr.ReadLine();
                    if (line2 != "Для данного автобуса расписание отсутствует :(")
                    {
                        lenght++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return lenght;
        }
    }
}
