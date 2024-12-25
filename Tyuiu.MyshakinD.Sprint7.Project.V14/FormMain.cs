using HtmlAgilityPack;
using System;
using System.IO;
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
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    public partial class FormMain : Form {
        public bool loadedFile;

        public FormMain()
        {
            InitializeComponent();
            loadedFile = false;
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
                FormNoInternetConnection form = new FormNoInternetConnection();
                this.Hide();
                form.ShowDialog();
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
            pictureBoxBusListLabel.Left = (panelBuses.Width - pictureBoxBusListLabel.Width) / 2;
        }

        private void panelBusStops_SizeChanged(object sender, EventArgs e)
        {
            dataGridViewStopsList.Height = panelBusStops.Height - 172;
            dataGridViewStopsList.Width = panelBusStops.Width - 53;
            dataGridViewBusListModified.Height = panelBusStops.Height - 172;
            dataGridViewBusListModified.Width = panelBusStops.Width - 53;
            pictureBoxStopsWindowUp.Width = dataGridViewStopsList.Width + 43;
            pictureBoxStopsWindowDown.Width = dataGridViewStopsList.Width + 43;
            pictureBoxStopsWindowLeft.Height = dataGridViewStopsList.Height;
            pictureBoxStopsWindowRight.Height = dataGridViewStopsList.Height;
            pictureBoxBusStopsLabel.Left = (panelBusStops.Width - pictureBoxBusStopsLabel.Width) / 2;
            pictureBoxBusNumberLabel.Left = (panelBusStops.Width - pictureBoxBusNumberLabel.Width) / 2 + 35;
            textBoxBusNumber.Left = (panelBusStops.Width - textBoxBusNumber.Width) / 2 + 35;
            textBoxAlert.Left = (panelBusStops.Width - textBoxAlert.Width) / 2;
        }

        private void dataGridViewBusesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void pictureBoxButtonUpdate_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxButtonUpdate.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_update_enter.png");
        }

        private void pictureBoxButtonUpdate_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxButtonUpdate.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_update_sleep.png");
        }

        private void pictureBoxButtonUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            loadedFile = false;

            textBoxAlert.Visible = true;
            radioButtonOrientation.Visible = true;
            pictureBoxBusNumberLabel.Visible = true;
            textBoxBusNumber.Visible = true;
            pictureBoxButtonDrop.Visible = false;

            pictureBoxBusListLabel.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\bus_list_label.png");
            pictureBoxBusStopsLabel.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\BusStopsLabel.png");

            dataGridViewBusListModified.Visible = false;

            pictureBoxButtonUpdate.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_update_click.png");

            textBoxBusNumber.Text = "";
            dataGridViewStopsList.Rows.Clear();

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
                FormNoInternetConnection form = new FormNoInternetConnection();
                this.Hide();
                form.ShowDialog();
            }
        }

        private void pictureBoxButtonUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButtonUpdate.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_update_enter.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxButtonSearch.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_enter.png");
        }

        private void pictureBoxButtonSearch_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxButtonSearch.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_sleep.png");
        }

        private void pictureBoxButtonSearch_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxButtonSearch.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_click.png");

            int k = 90;
            int x = 1;

            while (panelSearching.Left < 0)
            {
                panelSearching.Left += k / x;
                x++;
            }
        }

        private void pictureBoxButtonSearch_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButtonSearch.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_enter.png");
        }

        private void dataGridViewBusesList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewBusesList.Rows.Count > 0 && loadedFile == false)
            {
                textBoxAlert.Visible = false;

                string bus_number = dataGridViewBusesList[0, dataGridViewBusesList.CurrentCell.RowIndex].Value.ToString();
                string startStop = dataGridViewBusesList[1, dataGridViewBusesList.CurrentCell.RowIndex].Value.ToString();
                string endStop = dataGridViewBusesList[2, dataGridViewBusesList.CurrentCell.RowIndex].Value.ToString();


                string orientation;
                if (radioButtonOrientation.Checked == false) { orientation = "A"; }
                else { orientation = "B"; }

                if (orientation == "A")
                {
                    textBoxBusNumber.Text = $"№{bus_number} {startStop} - {endStop}";
                }
                else
                {
                    textBoxBusNumber.Text = $"№{bus_number} {endStop} - {startStop}";
                }

                string url_bus_stops = $"https://kudikina.ru/tmn/bus/{bus_number.Replace("к", "k").Replace("д", "d").Replace("ж", "zh").Replace("в", "v").Replace("а", "a").Replace("э", "e").Replace("р", "r").Replace("б", "b")}/{orientation}";

                try
                {
                    string path = DataService.LoadBusStops(url_bus_stops, bus_number, orientation);

                    int len = 0;
                    int maxRowLen = 0;

                    dataGridViewStopsList.Rows.Clear();
                    dataGridViewStopsList.Columns.Clear();

                    using (StreamReader reader = new StreamReader(path))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (maxRowLen < line.Split(";").Length)
                            {
                                maxRowLen = line.Split(";").Length;
                            }
                            len++;
                        }
                    }

                    for (int i = 0; i < maxRowLen - 1; i++)
                    {
                        dataGridViewStopsList.Columns.Add(new DataGridViewTextBoxColumn() { Name = $"column_{i}", HeaderText = $"Столбец {i}" });
                    }

                    dataGridViewStopsList.RowCount = len;

                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            for (int i = 0; i < len; i++)
                            {
                                string[] line = sr.ReadLine().Split(";");

                                dataGridViewStopsList.Rows[i].HeaderCell.Value = line[0];

                                for (int j = 1; j < maxRowLen; j++)
                                {
                                    try
                                    {
                                        dataGridViewStopsList[j - 1, i].Value = line[j];
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    FormNoInternetConnection form = new FormNoInternetConnection();
                    this.Hide();
                    form.ShowDialog();
                }
            }
        }

        private void radioButtonOrientation_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButtonOrientation.Checked == false)
            {
                radioButtonOrientation.Checked = true;
            }
            else { radioButtonOrientation.Checked = false; }
        }

        private void textBoxBusNumber_MouseMove(object sender, MouseEventArgs e)
        {
            panelBusStops.Focus();
            Cursor = Cursors.Arrow;
        }

        private void textBoxBusNumber_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void folderBrowserDialogSaveStopsList_HelpRequest(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBoxSaveButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSaveButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_save_enter.png");
        }

        private void pictureBoxSaveButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSaveButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_save_sleep.png");
        }

        private void pictureBoxSaveButton_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxSaveButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_save_click.png");

            if (loadedFile == false)
            {
                if (textBoxBusNumber.Text.Length > 0)
                {
                    string bus_number = textBoxBusNumber.Text.Split(" ")[0].Replace("№", "");

                    string orientation;
                    if (radioButtonOrientation.Checked == false) { orientation = "A"; }
                    else { orientation = "B"; }

                    FolderBrowserDialog folder = new FolderBrowserDialog();
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.Copy($@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_stops_lists\{bus_number}_stops_{orientation}.csv", Path.Combine(folder.SelectedPath, $"{bus_number}_stops_{orientation}.csv"));
                        MessageBox.Show("Файл сохранён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, сначала выберите необходимое расписание.", "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                saveFileDialogSaveModifiedTable.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";


                if (saveFileDialogSaveModifiedTable.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialogSaveModifiedTable.FileName.Replace(".csv", "") + ".csv";

                    try
                    {
                        int rows = dataGridViewBusListModified.RowCount;
                        int columns = dataGridViewBusListModified.Columns.Count;

                        string str;

                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }

                        for (int i = 0; i < rows - 1; i++)
                        {
                            str = "";

                            for (int j = 0; j < columns; j++)
                            {
                                if (j != columns - 1)
                                {
                                    str += dataGridViewBusListModified.Rows[i].Cells[j].Value + ";";
                                }
                                else
                                {
                                    str += dataGridViewBusListModified.Rows[i].Cells[j].Value;
                                }
                            }

                            System.IO.File.AppendAllText(path, str + Environment.NewLine);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении файла", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBoxSaveButton_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxSaveButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_save_enter.png");
        }

        private void pictureBoxSearchByBusNumberButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSearchByBusNumberButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_enter.png");
        }

        private void pictureBoxSearchByBusNumberButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSearchByBusNumberButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_sleep.png");
        }

        private void pictureBoxSearchByBusNumberButton_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxSearchByBusNumberButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_click.png");

            if (textBoxBusNumberSearch.Text.Length > 0)
            {
                if (loadedFile == false)
                {
                    string path = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";
                    dataGridViewBusesList.Rows.Clear();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string current_bus_number = line.Split(";")[0];
                            if (current_bus_number.Contains(textBoxBusNumberSearch.Text))
                            {
                                dataGridViewBusesList.Rows.Add(current_bus_number, line.Split(";")[1], line.Split(";")[2]);
                            }
                        }
                    }
                }
                else
                {
                    dataGridViewBusListModified.Rows.Clear();

                    int rows = dataGridViewBusesList.RowCount;
                    for (int i = 0; i < rows; i++)
                    {
                        string currentValue = dataGridViewBusesList.Rows[i].Cells[0].Value.ToString();

                        if (currentValue.Contains(textBoxBusNumberSearch.Text))
                        {
                            dataGridViewBusListModified.Rows.Add(currentValue, dataGridViewBusesList.Rows[i].Cells[1].Value.ToString(), dataGridViewBusesList.Rows[i].Cells[2].Value.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Для начала введите номер автобуса", "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pictureBoxSearchByBusNumberButton_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxSearchByBusNumberButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_enter.png");
        }

        private void pictureBoxSearchByStopNameButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSearchByStopNameButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_enter.png");
        }

        private void pictureBoxSearchByStopNameButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSearchByStopNameButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_sleep.png");
        }

        private void pictureBoxSearchByStopNameButton_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxSearchByStopNameButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_click.png");

            string request = textBoxStopNameSearch.Text.ToLower();

            if (request == "")
            {
                MessageBox.Show("Пожалуйста, сначала введите название остановки.", "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (loadedFile == false)
                {
                    string[] busList = DataService.SearchByStop(request);

                    string path = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\loaded_data\buses_list.csv";

                    dataGridViewBusesList.Rows.Clear();

                    foreach (string bus in busList)
                    {
                        using (StreamReader sr = new StreamReader(path))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                string currentBus = line.Split(";")[0];

                                if (currentBus == bus)
                                {
                                    dataGridViewBusesList.Rows.Add(currentBus, line.Split(";")[1], line.Split(";")[2]);
                                }
                            }
                        }
                    }
                }
                else
                {
                    dataGridViewBusListModified.Rows.Clear();

                    int rows = dataGridViewBusesList.Rows.Count;
                    for (int i = 0; i < rows; i++)
                    {
                        string startStop = dataGridViewBusesList.Rows[i].Cells[1].Value.ToString().ToLower();
                        string endstop = dataGridViewBusesList.Rows[i].Cells[2].Value.ToString().ToLower();

                        if (startStop.Contains(request) || endstop.Contains(request))
                        {
                            dataGridViewBusListModified.Rows.Add(dataGridViewBusesList.Rows[i].Cells[0].Value.ToString(), startStop, endstop);
                        }
                    }
                }
            }
        }

        private void pictureBoxSearchByStopNameButton_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxSearchByStopNameButton.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_search_enter.png");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int k = 90;
            int x = 1;
            while (panelSearching.Left > -344)
            {
                panelSearching.Left -= k / x;
                x++;
            }
        }

        private void textBoxAlert_MouseMove(object sender, MouseEventArgs e)
        {
            panelBusStops.Focus();
            Cursor = Cursors.Arrow;
        }

        private void textBoxAlert_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormInstruction form = new FormInstruction();
            form.ShowDialog();
        }

        private void pictureBoxButtonUpload_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxButtonUpload.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_upload_click.png");

            openFileDialogUploadData.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            if (openFileDialogUploadData.ShowDialog() == DialogResult.OK)
            {
                dataGridViewBusesList.Rows.Clear();
                dataGridViewStopsList.Rows.Clear();

                radioButtonOrientation.Visible = false;
                pictureBoxBusNumberLabel.Visible = false;
                textBoxBusNumber.Visible = false;
                pictureBoxButtonDrop.Visible = true;

                pictureBoxBusListLabel.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\source_table_label.png");
                pictureBoxBusStopsLabel.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\modified_table_label.png");

                dataGridViewBusListModified.Visible = true;

                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialogUploadData.FileName))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(";");

                            if (line.Length == 3)
                            {
                                string bus_number = line[0];
                                string startStop = line[1];
                                string endStop = line[2];

                                dataGridViewBusesList.Rows.Add(bus_number, startStop, endStop);
                                dataGridViewBusListModified.Rows.Add(bus_number, startStop, endStop);
                            }
                            else
                            {
                                MessageBox.Show("В файле приведены данные в неверном формате.", "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }

                        loadedFile = true;
                    }
                }
                catch
                {
                    MessageBox.Show("В файле приведены данные в неверном формате.", "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxButtonUpload_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxButtonUpload.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_upload_enter.png");
        }

        private void pictureBoxButtonUpload_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxButtonUpload.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_upload_sleep.png");
        }

        private void pictureBoxButtonUpload_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButtonUpload.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_upload_enter.png");
        }

        private void pictureBoxButtonDrop_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxButtonDrop.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_drop_click.png");

            int rows = dataGridViewBusesList.Rows.Count;

            dataGridViewBusListModified.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                dataGridViewBusListModified.Rows.Add(dataGridViewBusesList.Rows[i].Cells[0].Value.ToString(), dataGridViewBusesList.Rows[i].Cells[1].Value.ToString(), dataGridViewBusesList.Rows[i].Cells[2].Value.ToString());
            }
        }

        private void pictureBoxButtonDrop_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxButtonDrop.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_drop_enter.png");
        }

        private void pictureBoxButtonDrop_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxButtonDrop.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_drop_sleep.png");
        }

        private void pictureBoxButtonDrop_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButtonDrop.Image = Image.FromFile(@"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\button_drop_enter.png");
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic form = new FormStatistic();
            form.ShowDialog();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
