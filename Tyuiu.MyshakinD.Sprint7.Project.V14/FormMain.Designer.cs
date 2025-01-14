﻿namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelAbout = new Panel();
            buttonAbout = new Button();
            buttonHelp = new Button();
            panelTop = new Panel();
            panelHello = new Panel();
            textBoxHello = new TextBox();
            pictureBoxBackgroundHello = new PictureBox();
            panelChangeCity = new Panel();
            textBoxCurrentTime = new TextBox();
            textBoxCityName = new TextBox();
            pictureBoxCity = new PictureBox();
            panelBuses = new Panel();
            pictureBoxButtonUpload = new PictureBox();
            panelSearching = new Panel();
            pictureBoxSearchByStopNameButton = new PictureBox();
            pictureBoxSearchByBusNumberButton = new PictureBox();
            textBoxStopNameSearch = new TextBox();
            textBoxBusNumberSearch = new TextBox();
            pictureBoxSearchByStopNameLabel = new PictureBox();
            pictureBoxSearchByBusNumberLabel = new PictureBox();
            buttonCancel = new Button();
            pictureBoxSearchLabel = new PictureBox();
            pictureBoxBusListLabel = new PictureBox();
            pictureBoxButtonSearch = new PictureBox();
            pictureBoxButtonUpdate = new PictureBox();
            pictureBoxBusesWindowDown = new PictureBox();
            pictureBoxBusesWindowRight = new PictureBox();
            pictureBoxBusesWindowLeft = new PictureBox();
            pictureBoxBusesWindowUp = new PictureBox();
            dataGridViewBusesList = new DataGridView();
            BusNumber = new DataGridViewTextBoxColumn();
            BusStartStop = new DataGridViewTextBoxColumn();
            BusEndStop = new DataGridViewTextBoxColumn();
            splitterBusesAndBusStops = new Splitter();
            panelBusStops = new Panel();
            buttonStatistic = new Button();
            pictureBoxButtonDrop = new PictureBox();
            dataGridViewBusListModified = new DataGridView();
            BusNumberModified = new DataGridViewTextBoxColumn();
            startStopModified = new DataGridViewTextBoxColumn();
            endStopModified = new DataGridViewTextBoxColumn();
            textBoxAlert = new TextBox();
            pictureBoxSaveButton = new PictureBox();
            textBoxBusNumber = new TextBox();
            pictureBoxBusNumberLabel = new PictureBox();
            pictureBoxBusStopsLabel = new PictureBox();
            radioButtonOrientation = new RadioButton();
            pictureBoxStopsWindowDown = new PictureBox();
            pictureBoxStopsWindowRight = new PictureBox();
            pictureBoxStopsWindowLeft = new PictureBox();
            pictureBoxStopsWindowUp = new PictureBox();
            dataGridViewStopsList = new DataGridView();
            timerCurrentTime = new System.Windows.Forms.Timer(components);
            folderBrowserDialogSaveStopsList = new FolderBrowserDialog();
            openFileDialogUploadData = new OpenFileDialog();
            saveFileDialogSaveModifiedTable = new SaveFileDialog();
            toolTipMain = new ToolTip(components);
            panelAbout.SuspendLayout();
            panelTop.SuspendLayout();
            panelHello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundHello).BeginInit();
            panelChangeCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCity).BeginInit();
            panelBuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonUpload).BeginInit();
            panelSearching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByStopNameButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByBusNumberButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByStopNameLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByBusNumberLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusListLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesList).BeginInit();
            panelBusStops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonDrop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusListModified).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaveButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusNumberLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusStopsLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStopsList).BeginInit();
            SuspendLayout();
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.SeaGreen;
            panelAbout.BorderStyle = BorderStyle.FixedSingle;
            panelAbout.Controls.Add(buttonAbout);
            panelAbout.Controls.Add(buttonHelp);
            panelAbout.Dock = DockStyle.Bottom;
            panelAbout.Location = new Point(0, 729);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1468, 29);
            panelAbout.TabIndex = 4;
            panelAbout.MouseMove += panelAbout_MouseMove;
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Consolas", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            buttonAbout.Location = new Point(1302, -1);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(153, 29);
            buttonAbout.TabIndex = 1;
            buttonAbout.TabStop = false;
            buttonAbout.Text = "О программе";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackgroundImageLayout = ImageLayout.None;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(-1, -1);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(36, 29);
            buttonHelp.TabIndex = 0;
            buttonHelp.TabStop = false;
            toolTipMain.SetToolTip(buttonHelp, "Инструкция по программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelHello);
            panelTop.Controls.Add(panelChangeCity);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1468, 100);
            panelTop.TabIndex = 5;
            // 
            // panelHello
            // 
            panelHello.BackColor = Color.LightSteelBlue;
            panelHello.BorderStyle = BorderStyle.FixedSingle;
            panelHello.Controls.Add(textBoxHello);
            panelHello.Controls.Add(pictureBoxBackgroundHello);
            panelHello.Dock = DockStyle.Fill;
            panelHello.Location = new Point(200, 0);
            panelHello.Name = "panelHello";
            panelHello.Size = new Size(1268, 100);
            panelHello.TabIndex = 1;
            panelHello.MouseMove += panelHello_MouseMove;
            // 
            // textBoxHello
            // 
            textBoxHello.BackColor = Color.FromArgb(255, 233, 197);
            textBoxHello.BorderStyle = BorderStyle.None;
            textBoxHello.Font = new Font("Consolas", 15F);
            textBoxHello.Location = new Point(21, 11);
            textBoxHello.Multiline = true;
            textBoxHello.Name = "textBoxHello";
            textBoxHello.ReadOnly = true;
            textBoxHello.ShortcutsEnabled = false;
            textBoxHello.Size = new Size(1161, 99);
            textBoxHello.TabIndex = 1;
            textBoxHello.TabStop = false;
            textBoxHello.Text = "Добро пожаловать в Bus_Is_Gone!\r\nБлагодаря данной программе вы можете узнать информацию об автобусах и их остановках, а также ближайшее время прибытия.";
            textBoxHello.TextAlign = HorizontalAlignment.Center;
            textBoxHello.MouseDown += textBoxHello_MouseDown;
            textBoxHello.MouseMove += textBoxHello_MouseMove;
            // 
            // pictureBoxBackgroundHello
            // 
            pictureBoxBackgroundHello.BackColor = Color.SeaGreen;
            pictureBoxBackgroundHello.Dock = DockStyle.Fill;
            pictureBoxBackgroundHello.Image = (Image)resources.GetObject("pictureBoxBackgroundHello.Image");
            pictureBoxBackgroundHello.Location = new Point(0, 0);
            pictureBoxBackgroundHello.Name = "pictureBoxBackgroundHello";
            pictureBoxBackgroundHello.Size = new Size(1266, 98);
            pictureBoxBackgroundHello.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackgroundHello.TabIndex = 0;
            pictureBoxBackgroundHello.TabStop = false;
            // 
            // panelChangeCity
            // 
            panelChangeCity.BackColor = Color.SeaGreen;
            panelChangeCity.BackgroundImage = (Image)resources.GetObject("panelChangeCity.BackgroundImage");
            panelChangeCity.BorderStyle = BorderStyle.FixedSingle;
            panelChangeCity.Controls.Add(textBoxCurrentTime);
            panelChangeCity.Controls.Add(textBoxCityName);
            panelChangeCity.Controls.Add(pictureBoxCity);
            panelChangeCity.Dock = DockStyle.Left;
            panelChangeCity.Location = new Point(0, 0);
            panelChangeCity.Name = "panelChangeCity";
            panelChangeCity.Size = new Size(200, 100);
            panelChangeCity.TabIndex = 0;
            panelChangeCity.MouseLeave += panelChangeCity_MouseLeave;
            panelChangeCity.MouseHover += panelChangeCity_MouseHover;
            // 
            // textBoxCurrentTime
            // 
            textBoxCurrentTime.BackColor = Color.FromArgb(255, 233, 197);
            textBoxCurrentTime.BorderStyle = BorderStyle.None;
            textBoxCurrentTime.Font = new Font("Consolas", 13F);
            textBoxCurrentTime.Location = new Point(93, 53);
            textBoxCurrentTime.Name = "textBoxCurrentTime";
            textBoxCurrentTime.ReadOnly = true;
            textBoxCurrentTime.ShortcutsEnabled = false;
            textBoxCurrentTime.Size = new Size(100, 21);
            textBoxCurrentTime.TabIndex = 2;
            textBoxCurrentTime.TabStop = false;
            textBoxCurrentTime.TextAlign = HorizontalAlignment.Center;
            textBoxCurrentTime.MouseDown += textBoxCurrentTime_MouseDown;
            textBoxCurrentTime.MouseMove += textBoxCurrentTime_MouseMove_1;
            // 
            // textBoxCityName
            // 
            textBoxCityName.BackColor = Color.FromArgb(255, 233, 197);
            textBoxCityName.BorderStyle = BorderStyle.None;
            textBoxCityName.Font = new Font("Consolas", 15F, FontStyle.Bold);
            textBoxCityName.Location = new Point(106, 20);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.ReadOnly = true;
            textBoxCityName.ShortcutsEnabled = false;
            textBoxCityName.Size = new Size(66, 24);
            textBoxCityName.TabIndex = 1;
            textBoxCityName.TabStop = false;
            textBoxCityName.Text = "Тюмень";
            textBoxCityName.TextAlign = HorizontalAlignment.Center;
            textBoxCityName.TextChanged += textBoxCityName_TextChanged;
            textBoxCityName.MouseDown += textBoxCityName_MouseDown;
            textBoxCityName.MouseEnter += textBoxCityName_MouseEnter;
            textBoxCityName.MouseMove += textBoxCityName_MouseMove;
            // 
            // pictureBoxCity
            // 
            pictureBoxCity.BackColor = Color.FromArgb(255, 233, 197);
            pictureBoxCity.Image = (Image)resources.GetObject("pictureBoxCity.Image");
            pictureBoxCity.Location = new Point(3, 20);
            pictureBoxCity.Name = "pictureBoxCity";
            pictureBoxCity.Size = new Size(85, 55);
            pictureBoxCity.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCity.TabIndex = 0;
            pictureBoxCity.TabStop = false;
            // 
            // panelBuses
            // 
            panelBuses.BackColor = Color.FromArgb(15, 90, 48);
            panelBuses.BorderStyle = BorderStyle.FixedSingle;
            panelBuses.Controls.Add(pictureBoxButtonUpload);
            panelBuses.Controls.Add(panelSearching);
            panelBuses.Controls.Add(pictureBoxBusListLabel);
            panelBuses.Controls.Add(pictureBoxButtonSearch);
            panelBuses.Controls.Add(pictureBoxButtonUpdate);
            panelBuses.Controls.Add(pictureBoxBusesWindowDown);
            panelBuses.Controls.Add(pictureBoxBusesWindowRight);
            panelBuses.Controls.Add(pictureBoxBusesWindowLeft);
            panelBuses.Controls.Add(pictureBoxBusesWindowUp);
            panelBuses.Controls.Add(dataGridViewBusesList);
            panelBuses.Dock = DockStyle.Left;
            panelBuses.Location = new Point(0, 100);
            panelBuses.Name = "panelBuses";
            panelBuses.Size = new Size(733, 629);
            panelBuses.TabIndex = 6;
            panelBuses.SizeChanged += panelBuses_SizeChanged;
            panelBuses.MouseMove += panelBuses_MouseMove;
            // 
            // pictureBoxButtonUpload
            // 
            pictureBoxButtonUpload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxButtonUpload.Image = (Image)resources.GetObject("pictureBoxButtonUpload.Image");
            pictureBoxButtonUpload.Location = new Point(613, 26);
            pictureBoxButtonUpload.Name = "pictureBoxButtonUpload";
            pictureBoxButtonUpload.Size = new Size(113, 26);
            pictureBoxButtonUpload.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxButtonUpload.TabIndex = 12;
            pictureBoxButtonUpload.TabStop = false;
            toolTipMain.SetToolTip(pictureBoxButtonUpload, "Загрузить свой .csv файл расписания");
            pictureBoxButtonUpload.MouseDown += pictureBoxButtonUpload_MouseDown;
            pictureBoxButtonUpload.MouseEnter += pictureBoxButtonUpload_MouseEnter;
            pictureBoxButtonUpload.MouseLeave += pictureBoxButtonUpload_MouseLeave;
            pictureBoxButtonUpload.MouseUp += pictureBoxButtonUpload_MouseUp;
            // 
            // panelSearching
            // 
            panelSearching.BorderStyle = BorderStyle.FixedSingle;
            panelSearching.Controls.Add(pictureBoxSearchByStopNameButton);
            panelSearching.Controls.Add(pictureBoxSearchByBusNumberButton);
            panelSearching.Controls.Add(textBoxStopNameSearch);
            panelSearching.Controls.Add(textBoxBusNumberSearch);
            panelSearching.Controls.Add(pictureBoxSearchByStopNameLabel);
            panelSearching.Controls.Add(pictureBoxSearchByBusNumberLabel);
            panelSearching.Controls.Add(buttonCancel);
            panelSearching.Controls.Add(pictureBoxSearchLabel);
            panelSearching.Location = new Point(-344, 150);
            panelSearching.Name = "panelSearching";
            panelSearching.Size = new Size(343, 406);
            panelSearching.TabIndex = 11;
            // 
            // pictureBoxSearchByStopNameButton
            // 
            pictureBoxSearchByStopNameButton.BackColor = Color.FromArgb(255, 233, 197);
            pictureBoxSearchByStopNameButton.Image = (Image)resources.GetObject("pictureBoxSearchByStopNameButton.Image");
            pictureBoxSearchByStopNameButton.Location = new Point(118, 306);
            pictureBoxSearchByStopNameButton.Name = "pictureBoxSearchByStopNameButton";
            pictureBoxSearchByStopNameButton.Size = new Size(113, 26);
            pictureBoxSearchByStopNameButton.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearchByStopNameButton.TabIndex = 10;
            pictureBoxSearchByStopNameButton.TabStop = false;
            pictureBoxSearchByStopNameButton.MouseDown += pictureBoxSearchByStopNameButton_MouseDown;
            pictureBoxSearchByStopNameButton.MouseEnter += pictureBoxSearchByStopNameButton_MouseEnter;
            pictureBoxSearchByStopNameButton.MouseLeave += pictureBoxSearchByStopNameButton_MouseLeave;
            pictureBoxSearchByStopNameButton.MouseUp += pictureBoxSearchByStopNameButton_MouseUp;
            // 
            // pictureBoxSearchByBusNumberButton
            // 
            pictureBoxSearchByBusNumberButton.BackColor = Color.FromArgb(255, 233, 197);
            pictureBoxSearchByBusNumberButton.Image = (Image)resources.GetObject("pictureBoxSearchByBusNumberButton.Image");
            pictureBoxSearchByBusNumberButton.Location = new Point(118, 150);
            pictureBoxSearchByBusNumberButton.Name = "pictureBoxSearchByBusNumberButton";
            pictureBoxSearchByBusNumberButton.Size = new Size(113, 26);
            pictureBoxSearchByBusNumberButton.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearchByBusNumberButton.TabIndex = 9;
            pictureBoxSearchByBusNumberButton.TabStop = false;
            pictureBoxSearchByBusNumberButton.MouseDown += pictureBoxSearchByBusNumberButton_MouseDown;
            pictureBoxSearchByBusNumberButton.MouseEnter += pictureBoxSearchByBusNumberButton_MouseEnter;
            pictureBoxSearchByBusNumberButton.MouseLeave += pictureBoxSearchByBusNumberButton_MouseLeave;
            pictureBoxSearchByBusNumberButton.MouseUp += pictureBoxSearchByBusNumberButton_MouseUp;
            // 
            // textBoxStopNameSearch
            // 
            textBoxStopNameSearch.Font = new Font("Consolas", 12F);
            textBoxStopNameSearch.Location = new Point(60, 265);
            textBoxStopNameSearch.Name = "textBoxStopNameSearch";
            textBoxStopNameSearch.Size = new Size(217, 26);
            textBoxStopNameSearch.TabIndex = 8;
            // 
            // textBoxBusNumberSearch
            // 
            textBoxBusNumberSearch.Font = new Font("Consolas", 12F);
            textBoxBusNumberSearch.Location = new Point(60, 109);
            textBoxBusNumberSearch.Name = "textBoxBusNumberSearch";
            textBoxBusNumberSearch.Size = new Size(217, 26);
            textBoxBusNumberSearch.TabIndex = 7;
            // 
            // pictureBoxSearchByStopNameLabel
            // 
            pictureBoxSearchByStopNameLabel.Image = (Image)resources.GetObject("pictureBoxSearchByStopNameLabel.Image");
            pictureBoxSearchByStopNameLabel.Location = new Point(3, 224);
            pictureBoxSearchByStopNameLabel.Name = "pictureBoxSearchByStopNameLabel";
            pictureBoxSearchByStopNameLabel.Size = new Size(332, 117);
            pictureBoxSearchByStopNameLabel.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearchByStopNameLabel.TabIndex = 6;
            pictureBoxSearchByStopNameLabel.TabStop = false;
            // 
            // pictureBoxSearchByBusNumberLabel
            // 
            pictureBoxSearchByBusNumberLabel.Image = (Image)resources.GetObject("pictureBoxSearchByBusNumberLabel.Image");
            pictureBoxSearchByBusNumberLabel.Location = new Point(3, 68);
            pictureBoxSearchByBusNumberLabel.Name = "pictureBoxSearchByBusNumberLabel";
            pictureBoxSearchByBusNumberLabel.Size = new Size(332, 117);
            pictureBoxSearchByBusNumberLabel.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearchByBusNumberLabel.TabIndex = 5;
            pictureBoxSearchByBusNumberLabel.TabStop = false;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.BackgroundImageLayout = ImageLayout.None;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(296, -1);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(46, 36);
            buttonCancel.TabIndex = 2;
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pictureBoxSearchLabel
            // 
            pictureBoxSearchLabel.Image = (Image)resources.GetObject("pictureBoxSearchLabel.Image");
            pictureBoxSearchLabel.Location = new Point(82, 10);
            pictureBoxSearchLabel.Name = "pictureBoxSearchLabel";
            pictureBoxSearchLabel.Size = new Size(187, 43);
            pictureBoxSearchLabel.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearchLabel.TabIndex = 1;
            pictureBoxSearchLabel.TabStop = false;
            // 
            // pictureBoxBusListLabel
            // 
            pictureBoxBusListLabel.Image = (Image)resources.GetObject("pictureBoxBusListLabel.Image");
            pictureBoxBusListLabel.Location = new Point(130, 44);
            pictureBoxBusListLabel.Name = "pictureBoxBusListLabel";
            pictureBoxBusListLabel.Size = new Size(477, 37);
            pictureBoxBusListLabel.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxBusListLabel.TabIndex = 10;
            pictureBoxBusListLabel.TabStop = false;
            // 
            // pictureBoxButtonSearch
            // 
            pictureBoxButtonSearch.Image = (Image)resources.GetObject("pictureBoxButtonSearch.Image");
            pictureBoxButtonSearch.Location = new Point(11, 58);
            pictureBoxButtonSearch.Name = "pictureBoxButtonSearch";
            pictureBoxButtonSearch.Size = new Size(113, 26);
            pictureBoxButtonSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxButtonSearch.TabIndex = 8;
            pictureBoxButtonSearch.TabStop = false;
            toolTipMain.SetToolTip(pictureBoxButtonSearch, "Открыть панель поиска");
            pictureBoxButtonSearch.MouseDown += pictureBoxButtonSearch_MouseDown;
            pictureBoxButtonSearch.MouseEnter += pictureBox1_MouseEnter;
            pictureBoxButtonSearch.MouseLeave += pictureBoxButtonSearch_MouseLeave;
            pictureBoxButtonSearch.MouseUp += pictureBoxButtonSearch_MouseUp;
            // 
            // pictureBoxButtonUpdate
            // 
            pictureBoxButtonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxButtonUpdate.Image = (Image)resources.GetObject("pictureBoxButtonUpdate.Image");
            pictureBoxButtonUpdate.Location = new Point(613, 58);
            pictureBoxButtonUpdate.Name = "pictureBoxButtonUpdate";
            pictureBoxButtonUpdate.Size = new Size(113, 26);
            pictureBoxButtonUpdate.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxButtonUpdate.TabIndex = 7;
            pictureBoxButtonUpdate.TabStop = false;
            toolTipMain.SetToolTip(pictureBoxButtonUpdate, "Обновить данные о списке автобусов (сбрасывает параметры поиска)");
            pictureBoxButtonUpdate.MouseDown += pictureBoxButtonUpdate_MouseDown;
            pictureBoxButtonUpdate.MouseEnter += pictureBoxButtonUpdate_MouseEnter;
            pictureBoxButtonUpdate.MouseLeave += pictureBoxButtonUpdate_MouseLeave;
            pictureBoxButtonUpdate.MouseUp += pictureBoxButtonUpdate_MouseUp;
            // 
            // pictureBoxBusesWindowDown
            // 
            pictureBoxBusesWindowDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxBusesWindowDown.Image = (Image)resources.GetObject("pictureBoxBusesWindowDown.Image");
            pictureBoxBusesWindowDown.Location = new Point(11, 595);
            pictureBoxBusesWindowDown.Name = "pictureBoxBusesWindowDown";
            pictureBoxBusesWindowDown.Size = new Size(715, 27);
            pictureBoxBusesWindowDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBusesWindowDown.TabIndex = 4;
            pictureBoxBusesWindowDown.TabStop = false;
            // 
            // pictureBoxBusesWindowRight
            // 
            pictureBoxBusesWindowRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxBusesWindowRight.Image = (Image)resources.GetObject("pictureBoxBusesWindowRight.Image");
            pictureBoxBusesWindowRight.Location = new Point(700, 141);
            pictureBoxBusesWindowRight.Name = "pictureBoxBusesWindowRight";
            pictureBoxBusesWindowRight.Size = new Size(26, 457);
            pictureBoxBusesWindowRight.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBusesWindowRight.TabIndex = 3;
            pictureBoxBusesWindowRight.TabStop = false;
            // 
            // pictureBoxBusesWindowLeft
            // 
            pictureBoxBusesWindowLeft.Image = (Image)resources.GetObject("pictureBoxBusesWindowLeft.Image");
            pictureBoxBusesWindowLeft.Location = new Point(11, 141);
            pictureBoxBusesWindowLeft.Name = "pictureBoxBusesWindowLeft";
            pictureBoxBusesWindowLeft.Size = new Size(24, 457);
            pictureBoxBusesWindowLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBusesWindowLeft.TabIndex = 2;
            pictureBoxBusesWindowLeft.TabStop = false;
            // 
            // pictureBoxBusesWindowUp
            // 
            pictureBoxBusesWindowUp.Image = (Image)resources.GetObject("pictureBoxBusesWindowUp.Image");
            pictureBoxBusesWindowUp.Location = new Point(11, 90);
            pictureBoxBusesWindowUp.Name = "pictureBoxBusesWindowUp";
            pictureBoxBusesWindowUp.Size = new Size(715, 55);
            pictureBoxBusesWindowUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBusesWindowUp.TabIndex = 1;
            pictureBoxBusesWindowUp.TabStop = false;
            // 
            // dataGridViewBusesList
            // 
            dataGridViewBusesList.AllowUserToAddRows = false;
            dataGridViewBusesList.AllowUserToDeleteRows = false;
            dataGridViewBusesList.AllowUserToResizeColumns = false;
            dataGridViewBusesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewBusesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBusesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBusesList.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewBusesList.ColumnHeadersHeight = 30;
            dataGridViewBusesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBusesList.Columns.AddRange(new DataGridViewColumn[] { BusNumber, BusStartStop, BusEndStop });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewBusesList.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBusesList.Location = new Point(31, 141);
            dataGridViewBusesList.MultiSelect = false;
            dataGridViewBusesList.Name = "dataGridViewBusesList";
            dataGridViewBusesList.ReadOnly = true;
            dataGridViewBusesList.RowHeadersVisible = false;
            dataGridViewBusesList.Size = new Size(672, 457);
            dataGridViewBusesList.TabIndex = 0;
            dataGridViewBusesList.TabStop = false;
            dataGridViewBusesList.CellMouseClick += dataGridViewBusesList_CellMouseClick;
            dataGridViewBusesList.ColumnHeaderMouseClick += dataGridViewBusesList_ColumnHeaderMouseClick;
            // 
            // BusNumber
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BusNumber.DefaultCellStyle = dataGridViewCellStyle2;
            BusNumber.Frozen = true;
            BusNumber.HeaderText = "№";
            BusNumber.Name = "BusNumber";
            BusNumber.ReadOnly = true;
            BusNumber.Width = 39;
            // 
            // BusStartStop
            // 
            BusStartStop.Frozen = true;
            BusStartStop.HeaderText = "Начальная остановка";
            BusStartStop.Name = "BusStartStop";
            BusStartStop.ReadOnly = true;
            BusStartStop.Width = 165;
            // 
            // BusEndStop
            // 
            BusEndStop.Frozen = true;
            BusEndStop.HeaderText = "Конечная остановка";
            BusEndStop.Name = "BusEndStop";
            BusEndStop.ReadOnly = true;
            BusEndStop.Width = 158;
            // 
            // splitterBusesAndBusStops
            // 
            splitterBusesAndBusStops.BackColor = Color.SeaGreen;
            splitterBusesAndBusStops.Location = new Point(733, 100);
            splitterBusesAndBusStops.MinExtra = 733;
            splitterBusesAndBusStops.MinSize = 733;
            splitterBusesAndBusStops.Name = "splitterBusesAndBusStops";
            splitterBusesAndBusStops.Size = new Size(10, 629);
            splitterBusesAndBusStops.TabIndex = 7;
            splitterBusesAndBusStops.TabStop = false;
            // 
            // panelBusStops
            // 
            panelBusStops.BackColor = Color.FromArgb(15, 90, 48);
            panelBusStops.BorderStyle = BorderStyle.FixedSingle;
            panelBusStops.Controls.Add(buttonStatistic);
            panelBusStops.Controls.Add(pictureBoxButtonDrop);
            panelBusStops.Controls.Add(dataGridViewBusListModified);
            panelBusStops.Controls.Add(textBoxAlert);
            panelBusStops.Controls.Add(pictureBoxSaveButton);
            panelBusStops.Controls.Add(textBoxBusNumber);
            panelBusStops.Controls.Add(pictureBoxBusNumberLabel);
            panelBusStops.Controls.Add(pictureBoxBusStopsLabel);
            panelBusStops.Controls.Add(radioButtonOrientation);
            panelBusStops.Controls.Add(pictureBoxStopsWindowDown);
            panelBusStops.Controls.Add(pictureBoxStopsWindowRight);
            panelBusStops.Controls.Add(pictureBoxStopsWindowLeft);
            panelBusStops.Controls.Add(pictureBoxStopsWindowUp);
            panelBusStops.Controls.Add(dataGridViewStopsList);
            panelBusStops.Dock = DockStyle.Fill;
            panelBusStops.Location = new Point(743, 100);
            panelBusStops.Name = "panelBusStops";
            panelBusStops.Size = new Size(725, 629);
            panelBusStops.TabIndex = 8;
            panelBusStops.SizeChanged += panelBusStops_SizeChanged;
            panelBusStops.Paint += panelBusStops_Paint;
            panelBusStops.MouseMove += panelBusStops_MouseMove;
            // 
            // buttonStatistic
            // 
            buttonStatistic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStatistic.FlatAppearance.BorderSize = 0;
            buttonStatistic.FlatStyle = FlatStyle.Flat;
            buttonStatistic.Image = (Image)resources.GetObject("buttonStatistic.Image");
            buttonStatistic.Location = new Point(673, -1);
            buttonStatistic.Name = "buttonStatistic";
            buttonStatistic.Size = new Size(51, 45);
            buttonStatistic.TabIndex = 15;
            buttonStatistic.TabStop = false;
            toolTipMain.SetToolTip(buttonStatistic, "Показать статистику");
            buttonStatistic.UseVisualStyleBackColor = true;
            buttonStatistic.Click += buttonStatistic_Click;
            // 
            // pictureBoxButtonDrop
            // 
            pictureBoxButtonDrop.Image = (Image)resources.GetObject("pictureBoxButtonDrop.Image");
            pictureBoxButtonDrop.Location = new Point(5, 55);
            pictureBoxButtonDrop.Name = "pictureBoxButtonDrop";
            pictureBoxButtonDrop.Size = new Size(113, 26);
            pictureBoxButtonDrop.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxButtonDrop.TabIndex = 14;
            pictureBoxButtonDrop.TabStop = false;
            toolTipMain.SetToolTip(pictureBoxButtonDrop, "Сбросить все изменения");
            pictureBoxButtonDrop.Visible = false;
            pictureBoxButtonDrop.MouseDown += pictureBoxButtonDrop_MouseDown;
            pictureBoxButtonDrop.MouseEnter += pictureBoxButtonDrop_MouseEnter;
            pictureBoxButtonDrop.MouseLeave += pictureBoxButtonDrop_MouseLeave;
            pictureBoxButtonDrop.MouseUp += pictureBoxButtonDrop_MouseUp;
            // 
            // dataGridViewBusListModified
            // 
            dataGridViewBusListModified.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBusListModified.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewBusListModified.ColumnHeadersHeight = 30;
            dataGridViewBusListModified.Columns.AddRange(new DataGridViewColumn[] { BusNumberModified, startStopModified, endStopModified });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Consolas", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewBusListModified.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBusListModified.Location = new Point(27, 141);
            dataGridViewBusListModified.Name = "dataGridViewBusListModified";
            dataGridViewBusListModified.RowHeadersVisible = false;
            dataGridViewBusListModified.Size = new Size(672, 457);
            dataGridViewBusListModified.TabIndex = 13;
            dataGridViewBusListModified.TabStop = false;
            dataGridViewBusListModified.Visible = false;
            // 
            // BusNumberModified
            // 
            BusNumberModified.HeaderText = "№";
            BusNumberModified.Name = "BusNumberModified";
            BusNumberModified.Width = 39;
            // 
            // startStopModified
            // 
            startStopModified.HeaderText = "Начальная остановка";
            startStopModified.Name = "startStopModified";
            startStopModified.Width = 165;
            // 
            // endStopModified
            // 
            endStopModified.HeaderText = "Конечная остановка";
            endStopModified.Name = "endStopModified";
            endStopModified.Width = 158;
            // 
            // textBoxAlert
            // 
            textBoxAlert.BackColor = Color.DarkSeaGreen;
            textBoxAlert.BorderStyle = BorderStyle.None;
            textBoxAlert.Font = new Font("Consolas", 15F, FontStyle.Bold);
            textBoxAlert.Location = new Point(168, 301);
            textBoxAlert.Multiline = true;
            textBoxAlert.Name = "textBoxAlert";
            textBoxAlert.ReadOnly = true;
            textBoxAlert.Size = new Size(391, 96);
            textBoxAlert.TabIndex = 12;
            textBoxAlert.TabStop = false;
            textBoxAlert.Text = "Нажмите на строку с необходимым номером автобуса, для отображения его остановок.";
            textBoxAlert.TextAlign = HorizontalAlignment.Center;
            textBoxAlert.MouseDown += textBoxAlert_MouseDown;
            textBoxAlert.MouseMove += textBoxAlert_MouseMove;
            // 
            // pictureBoxSaveButton
            // 
            pictureBoxSaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxSaveButton.Image = (Image)resources.GetObject("pictureBoxSaveButton.Image");
            pictureBoxSaveButton.Location = new Point(579, 58);
            pictureBoxSaveButton.Name = "pictureBoxSaveButton";
            pictureBoxSaveButton.Size = new Size(133, 23);
            pictureBoxSaveButton.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSaveButton.TabIndex = 11;
            pictureBoxSaveButton.TabStop = false;
            toolTipMain.SetToolTip(pictureBoxSaveButton, "Сохранить текущий файл расписания автобуса в указанную папку (для загруженного расписания требуется ввести имя файла)");
            pictureBoxSaveButton.DragEnter += pictureBox1_DragEnter;
            pictureBoxSaveButton.MouseDown += pictureBoxSaveButton_MouseDown;
            pictureBoxSaveButton.MouseEnter += pictureBoxSaveButton_MouseEnter;
            pictureBoxSaveButton.MouseLeave += pictureBoxSaveButton_MouseLeave;
            pictureBoxSaveButton.MouseUp += pictureBoxSaveButton_MouseUp;
            // 
            // textBoxBusNumber
            // 
            textBoxBusNumber.BackColor = Color.FromArgb(255, 233, 197);
            textBoxBusNumber.BorderStyle = BorderStyle.None;
            textBoxBusNumber.Font = new Font("Consolas", 11F);
            textBoxBusNumber.Location = new Point(236, 61);
            textBoxBusNumber.Name = "textBoxBusNumber";
            textBoxBusNumber.ReadOnly = true;
            textBoxBusNumber.Size = new Size(323, 18);
            textBoxBusNumber.TabIndex = 9;
            textBoxBusNumber.TabStop = false;
            textBoxBusNumber.TextAlign = HorizontalAlignment.Center;
            textBoxBusNumber.MouseDown += textBoxBusNumber_MouseDown;
            textBoxBusNumber.MouseMove += textBoxBusNumber_MouseMove;
            // 
            // pictureBoxBusNumberLabel
            // 
            pictureBoxBusNumberLabel.Image = (Image)resources.GetObject("pictureBoxBusNumberLabel.Image");
            pictureBoxBusNumberLabel.Location = new Point(217, 58);
            pictureBoxBusNumberLabel.Name = "pictureBoxBusNumberLabel";
            pictureBoxBusNumberLabel.Size = new Size(356, 23);
            pictureBoxBusNumberLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBusNumberLabel.TabIndex = 8;
            pictureBoxBusNumberLabel.TabStop = false;
            // 
            // pictureBoxBusStopsLabel
            // 
            pictureBoxBusStopsLabel.Image = (Image)resources.GetObject("pictureBoxBusStopsLabel.Image");
            pictureBoxBusStopsLabel.Location = new Point(130, 15);
            pictureBoxBusStopsLabel.Name = "pictureBoxBusStopsLabel";
            pictureBoxBusStopsLabel.Size = new Size(477, 37);
            pictureBoxBusStopsLabel.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxBusStopsLabel.TabIndex = 6;
            pictureBoxBusStopsLabel.TabStop = false;
            // 
            // radioButtonOrientation
            // 
            radioButtonOrientation.AutoCheck = false;
            radioButtonOrientation.AutoSize = true;
            radioButtonOrientation.BackgroundImage = (Image)resources.GetObject("radioButtonOrientation.BackgroundImage");
            radioButtonOrientation.FlatStyle = FlatStyle.Flat;
            radioButtonOrientation.Font = new Font("Consolas", 12F, FontStyle.Bold);
            radioButtonOrientation.Location = new Point(5, 58);
            radioButtonOrientation.Name = "radioButtonOrientation";
            radioButtonOrientation.Size = new Size(206, 23);
            radioButtonOrientation.TabIndex = 5;
            radioButtonOrientation.Text = "Обратное направление";
            toolTipMain.SetToolTip(radioButtonOrientation, "Изменить направление маршрута (требуется заного нажать на строку с интересующим автобусом)");
            radioButtonOrientation.UseVisualStyleBackColor = true;
            radioButtonOrientation.MouseClick += radioButtonOrientation_MouseClick;
            // 
            // pictureBoxStopsWindowDown
            // 
            pictureBoxStopsWindowDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxStopsWindowDown.Image = (Image)resources.GetObject("pictureBoxStopsWindowDown.Image");
            pictureBoxStopsWindowDown.Location = new Point(5, 597);
            pictureBoxStopsWindowDown.Name = "pictureBoxStopsWindowDown";
            pictureBoxStopsWindowDown.Size = new Size(715, 27);
            pictureBoxStopsWindowDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStopsWindowDown.TabIndex = 4;
            pictureBoxStopsWindowDown.TabStop = false;
            // 
            // pictureBoxStopsWindowRight
            // 
            pictureBoxStopsWindowRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxStopsWindowRight.Image = (Image)resources.GetObject("pictureBoxStopsWindowRight.Image");
            pictureBoxStopsWindowRight.Location = new Point(694, 141);
            pictureBoxStopsWindowRight.Name = "pictureBoxStopsWindowRight";
            pictureBoxStopsWindowRight.Size = new Size(26, 457);
            pictureBoxStopsWindowRight.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStopsWindowRight.TabIndex = 3;
            pictureBoxStopsWindowRight.TabStop = false;
            // 
            // pictureBoxStopsWindowLeft
            // 
            pictureBoxStopsWindowLeft.Image = (Image)resources.GetObject("pictureBoxStopsWindowLeft.Image");
            pictureBoxStopsWindowLeft.Location = new Point(5, 141);
            pictureBoxStopsWindowLeft.Name = "pictureBoxStopsWindowLeft";
            pictureBoxStopsWindowLeft.Size = new Size(24, 457);
            pictureBoxStopsWindowLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStopsWindowLeft.TabIndex = 2;
            pictureBoxStopsWindowLeft.TabStop = false;
            // 
            // pictureBoxStopsWindowUp
            // 
            pictureBoxStopsWindowUp.Image = (Image)resources.GetObject("pictureBoxStopsWindowUp.Image");
            pictureBoxStopsWindowUp.Location = new Point(5, 90);
            pictureBoxStopsWindowUp.Name = "pictureBoxStopsWindowUp";
            pictureBoxStopsWindowUp.Size = new Size(715, 55);
            pictureBoxStopsWindowUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStopsWindowUp.TabIndex = 1;
            pictureBoxStopsWindowUp.TabStop = false;
            // 
            // dataGridViewStopsList
            // 
            dataGridViewStopsList.AllowUserToAddRows = false;
            dataGridViewStopsList.AllowUserToDeleteRows = false;
            dataGridViewStopsList.AllowUserToResizeColumns = false;
            dataGridViewStopsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewStopsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewStopsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewStopsList.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewStopsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStopsList.ColumnHeadersVisible = false;
            dataGridViewStopsList.Location = new Point(27, 141);
            dataGridViewStopsList.Name = "dataGridViewStopsList";
            dataGridViewStopsList.ReadOnly = true;
            dataGridViewStopsList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewStopsList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewStopsList.Size = new Size(672, 457);
            dataGridViewStopsList.TabIndex = 0;
            dataGridViewStopsList.TabStop = false;
            // 
            // timerCurrentTime
            // 
            timerCurrentTime.Enabled = true;
            timerCurrentTime.Tick += timerCurrentTime_Tick;
            // 
            // folderBrowserDialogSaveStopsList
            // 
            folderBrowserDialogSaveStopsList.HelpRequest += folderBrowserDialogSaveStopsList_HelpRequest;
            // 
            // openFileDialogUploadData
            // 
            openFileDialogUploadData.FileName = "openFileDialogUploadData";
            // 
            // toolTipMain
            // 
            toolTipMain.ToolTipIcon = ToolTipIcon.Info;
            toolTipMain.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 758);
            Controls.Add(panelBusStops);
            Controls.Add(splitterBusesAndBusStops);
            Controls.Add(panelBuses);
            Controls.Add(panelTop);
            Controls.Add(panelAbout);
            Font = new Font("Consolas", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1484, 797);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bus_Is_Gone";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            SizeChanged += FormMain_SizeChanged;
            MouseHover += FormMain_MouseHover;
            MouseMove += FormMain_MouseMove;
            panelAbout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelHello.ResumeLayout(false);
            panelHello.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundHello).EndInit();
            panelChangeCity.ResumeLayout(false);
            panelChangeCity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCity).EndInit();
            panelBuses.ResumeLayout(false);
            panelBuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonUpload).EndInit();
            panelSearching.ResumeLayout(false);
            panelSearching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByStopNameButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByBusNumberButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByStopNameLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchByBusNumberLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusListLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusesWindowUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusesList).EndInit();
            panelBusStops.ResumeLayout(false);
            panelBusStops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonDrop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusListModified).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaveButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusNumberLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBusStopsLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStopsWindowUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStopsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbout;
        private Panel panelTop;
        private Panel panelHello;
        private Panel panelBuses;
        private Splitter splitterBusesAndBusStops;
        private Panel panelBusStops;
        private Panel panelChangeCity;
        private TextBox textBoxCityName;
        private PictureBox pictureBoxCity;
        private TextBox textBoxCurrentTime;
        private System.Windows.Forms.Timer timerCurrentTime;
        private PictureBox pictureBoxBackgroundHello;
        private TextBox textBoxHello;
        private DataGridView dataGridViewBusesList;
        private PictureBox pictureBoxBusesWindowUp;
        private PictureBox pictureBoxBusesWindowDown;
        private PictureBox pictureBoxBusesWindowRight;
        private PictureBox pictureBoxBusesWindowLeft;
        private PictureBox pictureBoxStopsWindowUp;
        private DataGridView dataGridViewStopsList;
        private PictureBox pictureBoxStopsWindowDown;
        private PictureBox pictureBoxStopsWindowRight;
        private PictureBox pictureBoxStopsWindowLeft;
        private Button buttonHelp;
        private DataGridViewTextBoxColumn BusNumber;
        private DataGridViewTextBoxColumn BusStartStop;
        private DataGridViewTextBoxColumn BusEndStop;
        private PictureBox pictureBoxButtonUpdate;
        private PictureBox pictureBoxButtonSearch;
        private RadioButton radioButtonOrientation;
        private PictureBox pictureBoxBusListLabel;
        private PictureBox pictureBoxBusStopsLabel;
        private TextBox textBoxBusNumber;
        private PictureBox pictureBoxBusNumberLabel;
        private FolderBrowserDialog folderBrowserDialogSaveStopsList;
        private PictureBox pictureBoxSaveButton;
        private Panel panelSearching;
        private Button buttonCancel;
        private PictureBox pictureBoxSearchLabel;
        private PictureBox pictureBoxSearchByBusNumberLabel;
        private PictureBox pictureBoxSearchByStopNameLabel;
        private PictureBox pictureBoxSearchByStopNameButton;
        private PictureBox pictureBoxSearchByBusNumberButton;
        private TextBox textBoxStopNameSearch;
        private TextBox textBoxBusNumberSearch;
        private TextBox textBoxAlert;
        private PictureBox pictureBoxButtonUpload;
        private OpenFileDialog openFileDialogUploadData;
        private DataGridView dataGridViewBusListModified;
        private DataGridViewTextBoxColumn BusNumberModified;
        private DataGridViewTextBoxColumn startStopModified;
        private DataGridViewTextBoxColumn endStopModified;
        private SaveFileDialog saveFileDialogSaveModifiedTable;
        private PictureBox pictureBoxButtonDrop;
        private Button buttonStatistic;
        private ToolTip toolTipMain;
        private Button buttonAbout;
    }
}