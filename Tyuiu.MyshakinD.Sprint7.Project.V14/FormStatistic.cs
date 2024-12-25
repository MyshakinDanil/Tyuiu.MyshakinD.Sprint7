using Tyuiu.MyshakinD.Sprint7.Project.V14.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    public partial class FormStatistic : Form {
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            string busCount = DataService.BusesCount();
            textBoxBusesCount.Text = busCount;

            string stopsCount = DataService.StopsCount();
            textBoxStopsCount.Text = stopsCount;

            string minRoute = DataService.MinRoute();
            textBoxMinRoute.Text = minRoute;

            string maxRoute = DataService.MaxRoute();
            textBoxMaxRoute.Text = maxRoute;

            string avgRoute = DataService.AvgRoute();
            textBoxAvgRoute.Text = avgRoute;

            chartBusesRoutesLen.Titles.Add("Автобусы по длине машрутов");

            string path = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

            int xPos = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string busNum = line.Split(";")[0];

                    int routeLen = DataService.GetRouteLen(busNum);

                    try
                    {
                        Series series = chartBusesRoutesLen.Series.Add(busNum);
                        series.Points.AddXY(xPos, routeLen);
                        xPos++;
                    }
                    catch
                    {
                        Series series = chartBusesRoutesLen.Series.Add(busNum+" (2)");
                        series.Points.AddXY(xPos, routeLen);
                        xPos++;
                    }
                }
            }
        }
    }
}
