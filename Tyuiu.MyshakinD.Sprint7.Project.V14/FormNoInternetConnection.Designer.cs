namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    partial class FormNoInternetConnection {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoInternetConnection));
            pictureBox4chan = new PictureBox();
            pictureBoxNoInternet = new PictureBox();
            textBoxMessageToReconnect = new TextBox();
            buttonReconnect = new Button();
            buttonClose = new Button();
            textBoxReconnectFailed = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4chan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNoInternet).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4chan
            // 
            pictureBox4chan.Image = (Image)resources.GetObject("pictureBox4chan.Image");
            pictureBox4chan.Location = new Point(-152, -2);
            pictureBox4chan.Name = "pictureBox4chan";
            pictureBox4chan.Size = new Size(616, 452);
            pictureBox4chan.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4chan.TabIndex = 0;
            pictureBox4chan.TabStop = false;
            // 
            // pictureBoxNoInternet
            // 
            pictureBoxNoInternet.BackColor = SystemColors.Control;
            pictureBoxNoInternet.BackgroundImageLayout = ImageLayout.None;
            pictureBoxNoInternet.Image = (Image)resources.GetObject("pictureBoxNoInternet.Image");
            pictureBoxNoInternet.Location = new Point(291, 21);
            pictureBoxNoInternet.Name = "pictureBoxNoInternet";
            pictureBoxNoInternet.Size = new Size(229, 181);
            pictureBoxNoInternet.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNoInternet.TabIndex = 1;
            pictureBoxNoInternet.TabStop = false;
            // 
            // textBoxMessageToReconnect
            // 
            textBoxMessageToReconnect.BorderStyle = BorderStyle.None;
            textBoxMessageToReconnect.Font = new Font("Consolas", 14F, FontStyle.Bold);
            textBoxMessageToReconnect.Location = new Point(489, 80);
            textBoxMessageToReconnect.Multiline = true;
            textBoxMessageToReconnect.Name = "textBoxMessageToReconnect";
            textBoxMessageToReconnect.ReadOnly = true;
            textBoxMessageToReconnect.Size = new Size(309, 79);
            textBoxMessageToReconnect.TabIndex = 2;
            textBoxMessageToReconnect.TabStop = false;
            textBoxMessageToReconnect.Text = "Нет соединения с интерентом.\r\nПожалуйста, проверьте подключение.";
            textBoxMessageToReconnect.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonReconnect
            // 
            buttonReconnect.Font = new Font("Consolas", 9F);
            buttonReconnect.Location = new Point(565, 271);
            buttonReconnect.Name = "buttonReconnect";
            buttonReconnect.Size = new Size(146, 34);
            buttonReconnect.TabIndex = 3;
            buttonReconnect.Text = "Повторить попытку";
            buttonReconnect.UseVisualStyleBackColor = true;
            buttonReconnect.Click += buttonReconnect_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Consolas", 9F);
            buttonClose.Location = new Point(565, 338);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(146, 34);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Выход";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxReconnectFailed
            // 
            textBoxReconnectFailed.BorderStyle = BorderStyle.None;
            textBoxReconnectFailed.Font = new Font("Consolas", 14F);
            textBoxReconnectFailed.ForeColor = Color.Red;
            textBoxReconnectFailed.Location = new Point(355, 269);
            textBoxReconnectFailed.Multiline = true;
            textBoxReconnectFailed.Name = "textBoxReconnectFailed";
            textBoxReconnectFailed.ReadOnly = true;
            textBoxReconnectFailed.Size = new Size(194, 103);
            textBoxReconnectFailed.TabIndex = 5;
            textBoxReconnectFailed.TabStop = false;
            textBoxReconnectFailed.Text = "Переподключение не удалось";
            textBoxReconnectFailed.TextAlign = HorizontalAlignment.Center;
            textBoxReconnectFailed.Visible = false;
            textBoxReconnectFailed.TextChanged += textBox1_TextChanged;
            // 
            // FormNoInternetConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxReconnectFailed);
            Controls.Add(buttonClose);
            Controls.Add(buttonReconnect);
            Controls.Add(textBoxMessageToReconnect);
            Controls.Add(pictureBoxNoInternet);
            Controls.Add(pictureBox4chan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNoInternetConnection";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += FormNoInternetConnection_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox4chan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNoInternet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4chan;
        private PictureBox pictureBoxNoInternet;
        private TextBox textBoxMessageToReconnect;
        private Button buttonReconnect;
        private Button buttonClose;
        private TextBox textBoxReconnectFailed;
    }
}