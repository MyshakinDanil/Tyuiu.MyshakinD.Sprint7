namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    partial class FormStatistic {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistic));
            textBoxBusesCountName = new TextBox();
            textBoxBusesCount = new TextBox();
            textBoxStopsCountName = new TextBox();
            textBoxStopsCount = new TextBox();
            textBoxRoutesInfo = new TextBox();
            textBoxMinRouteName = new TextBox();
            textBoxMinRoute = new TextBox();
            textBoxAvgRouteName = new TextBox();
            textBoxMaxRouteName = new TextBox();
            textBoxAvgRoute = new TextBox();
            textBoxMaxRoute = new TextBox();
            chartBusesRoutesLen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartBusesRoutesLen).BeginInit();
            SuspendLayout();
            // 
            // textBoxBusesCountName
            // 
            textBoxBusesCountName.Font = new Font("Segoe UI", 13F);
            textBoxBusesCountName.Location = new Point(12, 30);
            textBoxBusesCountName.Name = "textBoxBusesCountName";
            textBoxBusesCountName.ReadOnly = true;
            textBoxBusesCountName.Size = new Size(147, 31);
            textBoxBusesCountName.TabIndex = 0;
            textBoxBusesCountName.TabStop = false;
            textBoxBusesCountName.Text = " Всего автобусов:";
            // 
            // textBoxBusesCount
            // 
            textBoxBusesCount.BackColor = SystemColors.ControlLightLight;
            textBoxBusesCount.Font = new Font("Segoe UI", 13F);
            textBoxBusesCount.Location = new Point(165, 30);
            textBoxBusesCount.Name = "textBoxBusesCount";
            textBoxBusesCount.ReadOnly = true;
            textBoxBusesCount.Size = new Size(100, 31);
            textBoxBusesCount.TabIndex = 1;
            textBoxBusesCount.TabStop = false;
            // 
            // textBoxStopsCountName
            // 
            textBoxStopsCountName.Font = new Font("Segoe UI", 13F);
            textBoxStopsCountName.Location = new Point(12, 67);
            textBoxStopsCountName.Name = "textBoxStopsCountName";
            textBoxStopsCountName.ReadOnly = true;
            textBoxStopsCountName.Size = new Size(147, 31);
            textBoxStopsCountName.TabIndex = 2;
            textBoxStopsCountName.TabStop = false;
            textBoxStopsCountName.Text = "Всего остановок:";
            // 
            // textBoxStopsCount
            // 
            textBoxStopsCount.BackColor = SystemColors.ControlLightLight;
            textBoxStopsCount.Font = new Font("Segoe UI", 13F);
            textBoxStopsCount.Location = new Point(165, 67);
            textBoxStopsCount.Name = "textBoxStopsCount";
            textBoxStopsCount.ReadOnly = true;
            textBoxStopsCount.Size = new Size(100, 31);
            textBoxStopsCount.TabIndex = 3;
            textBoxStopsCount.TabStop = false;
            // 
            // textBoxRoutesInfo
            // 
            textBoxRoutesInfo.Font = new Font("Segoe UI", 13F);
            textBoxRoutesInfo.Location = new Point(12, 157);
            textBoxRoutesInfo.Name = "textBoxRoutesInfo";
            textBoxRoutesInfo.ReadOnly = true;
            textBoxRoutesInfo.Size = new Size(317, 31);
            textBoxRoutesInfo.TabIndex = 4;
            textBoxRoutesInfo.TabStop = false;
            textBoxRoutesInfo.Text = "Длина пути (по количеству остановок):";
            // 
            // textBoxMinRouteName
            // 
            textBoxMinRouteName.Font = new Font("Segoe UI", 13F);
            textBoxMinRouteName.Location = new Point(12, 216);
            textBoxMinRouteName.Name = "textBoxMinRouteName";
            textBoxMinRouteName.ReadOnly = true;
            textBoxMinRouteName.Size = new Size(147, 31);
            textBoxMinRouteName.TabIndex = 5;
            textBoxMinRouteName.TabStop = false;
            textBoxMinRouteName.Text = "Минимальная:";
            // 
            // textBoxMinRoute
            // 
            textBoxMinRoute.BackColor = SystemColors.ControlLightLight;
            textBoxMinRoute.Font = new Font("Segoe UI", 13F);
            textBoxMinRoute.Location = new Point(165, 216);
            textBoxMinRoute.Name = "textBoxMinRoute";
            textBoxMinRoute.ReadOnly = true;
            textBoxMinRoute.Size = new Size(100, 31);
            textBoxMinRoute.TabIndex = 6;
            textBoxMinRoute.TabStop = false;
            // 
            // textBoxAvgRouteName
            // 
            textBoxAvgRouteName.Font = new Font("Segoe UI", 13F);
            textBoxAvgRouteName.Location = new Point(12, 267);
            textBoxAvgRouteName.Name = "textBoxAvgRouteName";
            textBoxAvgRouteName.ReadOnly = true;
            textBoxAvgRouteName.Size = new Size(147, 31);
            textBoxAvgRouteName.TabIndex = 7;
            textBoxAvgRouteName.TabStop = false;
            textBoxAvgRouteName.Text = "Средняя:";
            // 
            // textBoxMaxRouteName
            // 
            textBoxMaxRouteName.Font = new Font("Segoe UI", 13F);
            textBoxMaxRouteName.Location = new Point(12, 320);
            textBoxMaxRouteName.Name = "textBoxMaxRouteName";
            textBoxMaxRouteName.ReadOnly = true;
            textBoxMaxRouteName.Size = new Size(147, 31);
            textBoxMaxRouteName.TabIndex = 8;
            textBoxMaxRouteName.TabStop = false;
            textBoxMaxRouteName.Text = "Максимальная:";
            // 
            // textBoxAvgRoute
            // 
            textBoxAvgRoute.BackColor = SystemColors.ControlLightLight;
            textBoxAvgRoute.Font = new Font("Segoe UI", 13F);
            textBoxAvgRoute.Location = new Point(165, 267);
            textBoxAvgRoute.Name = "textBoxAvgRoute";
            textBoxAvgRoute.ReadOnly = true;
            textBoxAvgRoute.Size = new Size(100, 31);
            textBoxAvgRoute.TabIndex = 9;
            textBoxAvgRoute.TabStop = false;
            // 
            // textBoxMaxRoute
            // 
            textBoxMaxRoute.BackColor = SystemColors.ControlLightLight;
            textBoxMaxRoute.Font = new Font("Segoe UI", 13F);
            textBoxMaxRoute.Location = new Point(165, 320);
            textBoxMaxRoute.Name = "textBoxMaxRoute";
            textBoxMaxRoute.ReadOnly = true;
            textBoxMaxRoute.Size = new Size(100, 31);
            textBoxMaxRoute.TabIndex = 10;
            textBoxMaxRoute.TabStop = false;
            // 
            // chartBusesRoutesLen
            // 
            chartArea1.Name = "ChartArea1";
            chartBusesRoutesLen.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartBusesRoutesLen.Legends.Add(legend1);
            chartBusesRoutesLen.Location = new Point(351, 12);
            chartBusesRoutesLen.Name = "chartBusesRoutesLen";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBusesRoutesLen.Series.Add(series1);
            chartBusesRoutesLen.Size = new Size(1060, 537);
            chartBusesRoutesLen.TabIndex = 11;
            chartBusesRoutesLen.TabStop = false;
            chartBusesRoutesLen.Text = "chart";
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 561);
            Controls.Add(chartBusesRoutesLen);
            Controls.Add(textBoxMaxRoute);
            Controls.Add(textBoxAvgRoute);
            Controls.Add(textBoxMaxRouteName);
            Controls.Add(textBoxAvgRouteName);
            Controls.Add(textBoxMinRoute);
            Controls.Add(textBoxMinRouteName);
            Controls.Add(textBoxRoutesInfo);
            Controls.Add(textBoxStopsCount);
            Controls.Add(textBoxStopsCountName);
            Controls.Add(textBoxBusesCount);
            Controls.Add(textBoxBusesCountName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStatistic";
            Text = "Статистика";
            Load += FormStatistic_Load;
            ((System.ComponentModel.ISupportInitialize)chartBusesRoutesLen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBusesCountName;
        private TextBox textBoxBusesCount;
        private TextBox textBoxStopsCountName;
        private TextBox textBoxStopsCount;
        private TextBox textBoxRoutesInfo;
        private TextBox textBoxMinRouteName;
        private TextBox textBoxMinRoute;
        private TextBox textBoxAvgRouteName;
        private TextBox textBoxMaxRouteName;
        private TextBox textBoxAvgRoute;
        private TextBox textBoxMaxRoute;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBusesRoutesLen;
    }
}