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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("https://archive.org/download/Win8.1AIOITA/Microsoft.Windows.8.1.AiO.6in1.Core.Prof.ProWMC.X86.X64.RTM.9600.ITA%2BACT.iso"));
        }
    }
}
