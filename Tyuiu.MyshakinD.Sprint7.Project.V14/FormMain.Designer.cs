namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
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
            panelAbout = new Panel();
            panelTop = new Panel();
            panelHello = new Panel();
            textBoxHello = new TextBox();
            pictureBoxBackgroundHello = new PictureBox();
            panelChangeCity = new Panel();
            textBoxCurrentTime = new TextBox();
            textBoxCityName = new TextBox();
            pictureBox1 = new PictureBox();
            panelBuses = new Panel();
            splitterBusesAndBusStops = new Splitter();
            panelBusStops = new Panel();
            timerCurrentTime = new System.Windows.Forms.Timer(components);
            panelTop.SuspendLayout();
            panelHello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundHello).BeginInit();
            panelChangeCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.LightSteelBlue;
            panelAbout.Dock = DockStyle.Bottom;
            panelAbout.Location = new Point(0, 611);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1317, 29);
            panelAbout.TabIndex = 4;
            panelAbout.MouseMove += panelAbout_MouseMove;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelHello);
            panelTop.Controls.Add(panelChangeCity);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1317, 100);
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
            panelHello.Size = new Size(1117, 100);
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
            textBoxHello.Size = new Size(1055, 99);
            textBoxHello.TabIndex = 1;
            textBoxHello.TabStop = false;
            textBoxHello.Text = "Добро пожаловать в Bus_Is_Gone!\r\nБлагодаря данной программе вы можете узнать информацию об автобусах и их остановках, а также ближайшее время прибытия.";
            textBoxHello.TextAlign = HorizontalAlignment.Center;
            textBoxHello.MouseMove += textBoxHello_MouseMove;
            // 
            // pictureBoxBackgroundHello
            // 
            pictureBoxBackgroundHello.Dock = DockStyle.Fill;
            pictureBoxBackgroundHello.Image = (Image)resources.GetObject("pictureBoxBackgroundHello.Image");
            pictureBoxBackgroundHello.Location = new Point(0, 0);
            pictureBoxBackgroundHello.Name = "pictureBoxBackgroundHello";
            pictureBoxBackgroundHello.Size = new Size(1115, 98);
            pictureBoxBackgroundHello.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackgroundHello.TabIndex = 0;
            pictureBoxBackgroundHello.TabStop = false;
            // 
            // panelChangeCity
            // 
            panelChangeCity.BackColor = Color.LightSteelBlue;
            panelChangeCity.BackgroundImage = (Image)resources.GetObject("panelChangeCity.BackgroundImage");
            panelChangeCity.BorderStyle = BorderStyle.FixedSingle;
            panelChangeCity.Controls.Add(textBoxCurrentTime);
            panelChangeCity.Controls.Add(textBoxCityName);
            panelChangeCity.Controls.Add(pictureBox1);
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
            textBoxCurrentTime.Size = new Size(100, 21);
            textBoxCurrentTime.TabIndex = 2;
            textBoxCurrentTime.TabStop = false;
            textBoxCurrentTime.TextAlign = HorizontalAlignment.Center;
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
            textBoxCityName.MouseEnter += textBoxCityName_MouseEnter;
            textBoxCityName.MouseMove += textBoxCityName_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 233, 197);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBuses
            // 
            panelBuses.Dock = DockStyle.Left;
            panelBuses.Location = new Point(0, 100);
            panelBuses.Name = "panelBuses";
            panelBuses.Size = new Size(620, 511);
            panelBuses.TabIndex = 6;
            panelBuses.MouseMove += panelBuses_MouseMove;
            // 
            // splitterBusesAndBusStops
            // 
            splitterBusesAndBusStops.Location = new Point(620, 100);
            splitterBusesAndBusStops.Name = "splitterBusesAndBusStops";
            splitterBusesAndBusStops.Size = new Size(3, 511);
            splitterBusesAndBusStops.TabIndex = 7;
            splitterBusesAndBusStops.TabStop = false;
            // 
            // panelBusStops
            // 
            panelBusStops.Dock = DockStyle.Fill;
            panelBusStops.Location = new Point(623, 100);
            panelBusStops.Name = "panelBusStops";
            panelBusStops.Size = new Size(694, 511);
            panelBusStops.TabIndex = 8;
            panelBusStops.MouseMove += panelBusStops_MouseMove;
            // 
            // timerCurrentTime
            // 
            timerCurrentTime.Enabled = true;
            timerCurrentTime.Tick += timerCurrentTime_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 640);
            Controls.Add(panelBusStops);
            Controls.Add(splitterBusesAndBusStops);
            Controls.Add(panelBuses);
            Controls.Add(panelTop);
            Controls.Add(panelAbout);
            Font = new Font("Consolas", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1333, 679);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bus_Is_Gone";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            SizeChanged += FormMain_SizeChanged;
            MouseHover += FormMain_MouseHover;
            MouseMove += FormMain_MouseMove;
            panelTop.ResumeLayout(false);
            panelHello.ResumeLayout(false);
            panelHello.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundHello).EndInit();
            panelChangeCity.ResumeLayout(false);
            panelChangeCity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private TextBox textBoxCurrentTime;
        private System.Windows.Forms.Timer timerCurrentTime;
        private PictureBox pictureBoxBackgroundHello;
        private TextBox textBoxHello;
    }
}