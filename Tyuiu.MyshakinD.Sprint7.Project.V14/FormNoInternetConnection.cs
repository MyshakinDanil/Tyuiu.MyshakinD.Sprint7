using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MyshakinD.Sprint7.Project.V14.Lib;

namespace Tyuiu.MyshakinD.Sprint7.Project.V14 {
    public partial class FormNoInternetConnection : Form {
        public FormNoInternetConnection()
        {
            InitializeComponent();
        }

        private void FormNoInternetConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReconnect_Click(object sender, EventArgs e)
        {
            if (!DataService.ConnectionAvailable())
            {
                textBoxReconnectFailed.Visible = true;
            }
            else
            {
                FormMain form = new FormMain();
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
