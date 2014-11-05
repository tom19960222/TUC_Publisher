using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TUC_Publisher
{
    public partial class form_Preview : Form
    {
        public form_Preview(string HTML)
        {
            InitializeComponent();
            WebBrowser.DocumentText = String.Format("<html><body><div style='width={0}px; height={1}px;'>\n{2}\n</div></body></html>", WebBrowser.ClientSize.Width, WebBrowser.ClientSize.Height, HTML);
            WebBrowser.Refresh();
        }

        private void form_Preview_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
