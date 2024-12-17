namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    public partial class FormStart : Form {
        public FormStart()
        {
            InitializeComponent();
            string f = @"C:\Users\mysha\source\repos\Tyuiu.MyshakinD.Sprint7\data\start_animation.mp4";
            axWindowsMediaPlayerStartAnimation.uiMode = "none";
            axWindowsMediaPlayerStartAnimation.URL = f;
        }

        private void axWindowsMediaPlayerStartAnimation_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayerStartAnimation_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayerStartAnimation.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                FormMain form = new FormMain();
                this.Hide();
                form.Show();
            }
        }
    }
}
