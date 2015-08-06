using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CardBoard2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel_videoSharp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            url = ((LinkLabel)sender).Tag.ToString();
            System.Diagnostics.Process.Start(url);
        }

        private void linkLabel_vaenga_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // System.Diagnostics.Process.Start("http://vaenga.ru/forum/viewtopic.php?f=29&t=194&start=27060");
        }

        private void button_videoSharp_login_Click(object sender, EventArgs e)
        {
            string url;
            url = ((Button)sender).Tag.ToString();

            Clipboard.SetText(url);
        }

        private void button_videoSharp_pass_Click(object sender, EventArgs e)
        {
            string url;
            url = ((Button)sender).Tag.ToString();
            Clipboard.SetText(url);
            
        }

        private void button_vaenga_login_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button_vaenga_login.Text);
        }

        private void button_vaenga_pass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("04031979");
        }
    }
}
