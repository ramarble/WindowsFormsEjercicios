using System;
using System.Collections;
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

        private void sendButton_click(object sender, EventArgs e)
        {
            String checkedValues = "";
            switch (checkedListBox1.CheckedItems.Count) {
                case 1:
                    {
                        checkedValues = checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString();
                        break;
                    }
                case 0:
                    {
                        checkedValues = "Ninguno";
                        break;
                    };
                default:
                    {
                        foreach (String s in checkedListBox1.CheckedItems)
                        {
                            checkedValues += s;
                            checkedValues += ", ";

                        };
                        checkedValues = checkedValues.Substring(0, checkedValues.Length - 1);
                        break;
                    }
            }

            summaryLabel.Text = "Servicios del evento escogidos: ";
            summaryLabel.Text += checkedValues + "\n";
            if (fullDayEventCheck.Checked)
            {
                summaryLabel.Text += "En Fecha: " + dateTimePicker1.Value.ToShortDateString() + "\n";
            } else
            {
                summaryLabel.Text += "En Fecha: " + dateTimePicker1.Value.ToString() + "\n";
            }

            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                summaryLabel.Text += "Para un(a): " + comboBox1.Text;
            }
            else
                summaryLabel.Text += "No has seleccionado un tipo de evento";
        }
    }
}
