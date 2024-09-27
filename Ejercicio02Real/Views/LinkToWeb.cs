using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02Real
{
    public partial class LinkToWeb : Form
    {
        public LinkToWeb()
        {
            InitializeComponent();
        }

        private void LinkToWebPage_Load(object sender, EventArgs e)
        {

        }

        private void visitButton_click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.google.com"));
        }

        private void emailLink_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("mailto:raul.marrupe1@educa.madrid.org"));
        }
    }
}
