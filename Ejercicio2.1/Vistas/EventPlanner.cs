using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2._1
{
    public partial class EventPlanner : Form
    {
        public EventPlanner()
        {
            InitializeComponent();
        }

        private void salirStripDown_click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void acercaDeStripDown_click(object sender, EventArgs e)
        {
            MessageBox.Show("SARUになって　ZUBUになっていく");
        }

        private void fullDayEvent_click(object sender, EventArgs e)
        {
            if (fullDayEventCheck.Checked)
            {
                this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            } else
            {
                this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            }
        }

    }
}
