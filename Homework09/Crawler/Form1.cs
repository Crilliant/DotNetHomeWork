using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Crawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string url = txtBoxURL.Text;
            string pattern = @"^(https|http)://";

            if (!Regex.IsMatch(url, pattern))
                MessageBox.Show("Invalid URL!");

            SimpleCrawler crawler = new SimpleCrawler();
            crawler.BeginHandler += PrintLog;
            crawler.StartCrawler();
            
        }
        private void PrintLog(string s)
        {
            txtBoxOutput.AppendText(s);
        }
   
    }
}
