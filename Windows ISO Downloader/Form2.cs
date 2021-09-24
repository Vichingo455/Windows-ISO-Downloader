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
            webBrowser1.Navigate(string.Format("https://archive.org/download/cccoma-x-64-fre-it-it-dv-9/CCCOMA_X64FRE_IT-IT_DV9.iso"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Format("https://archive.org/download/cccoma-x-64-fre-it-it-dv-9/CCCOMA_X86FRE_IT-IT_DV9.iso"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
