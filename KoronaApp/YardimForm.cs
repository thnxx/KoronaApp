using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoronaApp
{
    public partial class YardimForm : Form
    {
        public YardimForm()
        {
            InitializeComponent();
        }

        private void YardimForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.saglik.gov.tr/"); //Linki set ettik.
        }

        private void lbSaglikBakanligi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (webBrowser1.Visible==false)
            //{
            //    webBrowser1.Visible = true;//WebBrowser in gorunmesini sagladik.
            //}
            //else
            //{
            //    webBrowser1.Visible = false;//WebBrowser in gorunmemesini sagladik.
            //}
            webBrowser1.Visible = !webBrowser1.Visible;

        }
    }
}
