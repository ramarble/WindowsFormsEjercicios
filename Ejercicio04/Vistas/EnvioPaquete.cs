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

namespace Ejercicio04
{
    public partial class FormEnvioPaquetes : Form
    {
        public FormEnvioPaquetes()
        {
            InitializeComponent();
        }

        private void listbox1_IndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    radio_Grande.Checked = true; break;
                case 1:
                    radio_Mediano.Checked = true; break;
                case 2:
                    radio_Pequeno.Checked = true; break;
            }
        }

        
        private void radioCheckSanity(object sender, EventArgs e)
        {
            if (sender.Equals(radio_Grande))
            {
                listBox1.SetSelected(0, true);
            } else if (sender.Equals(radio_Mediano)) 
            {
                listBox1.SetSelected(1, true);
            } else if (sender.Equals(radio_Pequeno))
            {
                listBox1.SetSelected(2, true);
            }
        }

        private void send_onClick(object sender, EventArgs e)
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            LinkedList<string> checkeds = new LinkedList<string>();
            foreach (CheckBox c in flowLayoutPanel3.Controls)
            {
                if(c.Checked) { 
                    stringBuilder.Append(c.Text);
                    stringBuilder.Append(", ");
                }
            }
            if (stringBuilder.Length > 2)
            {
                stringBuilder.Remove(stringBuilder.Length - 2, 2);
            }

            string fullmessage = "Número de paquetes a enviar: " +
                numeric_numeroPaquetes.Value + "\nde tamaño: " +
                listBox1.Text + "\nCon opciones de envío: " + stringBuilder;
            MessageBox.Show(fullmessage);
            summaryLabel.Text = fullmessage;

        }
    }
}
