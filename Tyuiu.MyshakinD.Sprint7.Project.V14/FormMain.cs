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
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
