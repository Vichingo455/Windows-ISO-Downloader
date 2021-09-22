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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("https://archive.org/download/Win7SP1AIOITA64BIT/it_windows_7_all_editions_with_sp1_x64_dvd_v2018.iso"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("https://archive.org/download/Win7SP1AIOITA32BIT/it_windows_7_all_editions_with_sp1_x86_dvd_v2018.iso"));
        }
    }
}
