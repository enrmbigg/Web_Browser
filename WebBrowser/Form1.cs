using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //navigate the webbrower to the url typed in textBox1

            webBrowser1.Navigate(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Navigate the browser to the home page - in this case it is google.com

            webBrowser1.Navigate("www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Refreshes the page 

            webBrowser1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Stops the browser navigating

            webBrowser1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The browser will go back to the last navigated page if Avalaible

            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
