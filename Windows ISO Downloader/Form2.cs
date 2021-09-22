using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ISO_Downloader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("https://software-download.microsoft.com/db/Win10_21H1_Italian_x64.iso?t=72df96b8-b03f-4ccf-bd2a-6eb467d941b8&e=1632394920&h=4c81f479e001b2189d5962e4eeb5e679"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("https://software-download.microsoft.com/db/Win10_21H1_Italian_x32.iso?t=72df96b8-b03f-4ccf-bd2a-6eb467d941b8&e=1632394920&h=3996c93dd2cc1bb5716d998887aa8868"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
