using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using Tyuiu.MyshakinD.Sprint7.Project.V14.Lib;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!DataService.ConnectionAvailable())
            {
                FormNoInternetConnection form = new FormNoInternetConnection();
                this.Hide();
                form.ShowDialog();
            }

            textBoxHello.Width = panelHello.Width - 50;
            textBoxHello.Height = panelHello.Height - 20;

            try
            {
                string path = DataService.LoadBuses();

                int linesCount = 0;
                
                using (StreamReader streamreader = new StreamReader(path))
                {
                    while (!streamreader.EndOfStream)
                    {
                        var line = streamreader.ReadLine();
                        linesCount++;
                    }
                }

                dataGridViewBusesList.Rows.Clear();
                dataGridViewBusesList.RowCount = linesCount;

                using (StreamReader streamreader = new StreamReader(path))
                {
                    while (!streamreader.EndOfStream)
                    {
                        for (int row = 0; row <= dataGridViewBusesList.RowCount - 1; row++)
                        {
                            string[] currentData = streamreader.ReadLine().Split(";");

                            for (int column = 0; column <= dataGridViewBusesList.ColumnCount - 1; column++)
                            {
                                dataGridViewBusesList[column, row].Value = currentData[column];
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxCityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCityName_MouseMove(object sender, MouseEventArgs e)
        {
            panelChangeCity.Focus();
            Cursor = Cursors.Arrow;
        }

        private void textBoxCityName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBoxCurrentTime_MouseMove(object sender, MouseEventArgs e)
        {
            panelChangeCity.Focus();
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panelBuses_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panelHello_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panelChangeCity_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panelBusStops_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panelAbout_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void FormMain_MouseHover(object sender, EventArgs e)
        {
        }

        private void panelChangeCity_MouseHover(object sender, EventArgs e)
        {
        }

        private void textBoxCurrentTime_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxCurrentTime_MouseMove_1(object sender, MouseEventArgs e)
        {
            panelChangeCity.Focus();
            Cursor = Cursors.Arrow;
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            textBoxCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            textBoxHello.Width = panelHello.Width - 50;
        }

        private void textBoxHello_MouseMove(object sender, MouseEventArgs e)
        {
            panelHello.Focus();
            Cursor = Cursors.Arrow;
        }

        private void textBoxHello_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void textBoxCityName_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void textBoxCurrentTime_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void pictureBoxHelloLeft_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void panelBusStops_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBuses_SizeChanged(object sender, EventArgs e)
        {
            dataGridViewBusesList.Height = panelBuses.Height - 163;
            dataGridViewBusesList.Width = panelBuses.Width - 61;
            pictureBoxBusesWindowUp.Width = dataGridViewBusesList.Width + 43;
            pictureBoxBusesWindowDown.Width = dataGridViewBusesList.Width + 43;
            pictureBoxBusesWindowLeft.Height = dataGridViewBusesList.Height - 9;
            pictureBoxBusesWindowRight.Height = dataGridViewBusesList.Height - 9;
        }

        private void panelBusStops_SizeChanged(object sender, EventArgs e)
        {
            dataGridViewStopsList.Height = panelBusStops.Height - 172;
            dataGridViewStopsList.Width = panelBusStops.Width - 53;
            pictureBoxStopsWindowUp.Width = dataGridViewStopsList.Width + 43;
            pictureBoxStopsWindowDown.Width = dataGridViewStopsList.Width + 43;
            pictureBoxStopsWindowLeft.Height = dataGridViewStopsList.Height;
            pictureBoxStopsWindowRight.Height = dataGridViewStopsList.Height;
        }
    }
}
