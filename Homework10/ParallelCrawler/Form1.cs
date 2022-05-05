using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//TODO:查看时间，比较
namespace ParallelCrawler
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

            if(!url.Contains("://"))
                MessageBox.Show("Invalid URL!");

            Crawler crawler = new Crawler();
            crawler.LogHandler += PrintLog;
            crawler.StartCrawler();
        }
        private void PrintLog(string s)
        {
            lock (this)
            {
                if (this.txtBoxOutput.InvokeRequired)
                {
                    Action<string> action = this.AddLog;
                    this.Invoke(action, new object[] { s });
                }
                else
                {
                    txtBoxOutput.AppendText(s);
                }
            }
        }
        private void AddLog(string s)
        {
            txtBoxOutput.AppendText(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        } 
    }
}
