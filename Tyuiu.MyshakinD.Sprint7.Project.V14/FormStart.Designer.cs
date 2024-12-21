namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    partial class FormStart {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            axWindowsMediaPlayerStartAnimation = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerStartAnimation).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayerStartAnimation
            // 
            axWindowsMediaPlayerStartAnimation.Dock = DockStyle.Fill;
            axWindowsMediaPlayerStartAnimation.Enabled = true;
            axWindowsMediaPlayerStartAnimation.Location = new Point(0, 0);
            axWindowsMediaPlayerStartAnimation.Name = "axWindowsMediaPlayerStartAnimation";
            axWindowsMediaPlayerStartAnimation.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayerStartAnimation.OcxState");
            axWindowsMediaPlayerStartAnimation.Size = new Size(540, 500);
            axWindowsMediaPlayerStartAnimation.TabIndex = 0;
            axWindowsMediaPlayerStartAnimation.PlayStateChange += axWindowsMediaPlayerStartAnimation_PlayStateChange;
            axWindowsMediaPlayerStartAnimation.MouseDownEvent += axWindowsMediaPlayerStartAnimation_MouseDownEvent;
            axWindowsMediaPlayerStartAnimation.Enter += axWindowsMediaPlayerStartAnimation_Enter;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 500);
            Controls.Add(axWindowsMediaPlayerStartAnimation);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Click += FormStart_Click;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerStartAnimation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerStartAnimation;
    }
}
