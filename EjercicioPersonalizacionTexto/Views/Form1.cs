using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPersonalizacionTexto
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void changeColor_Font(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void changeColor_background(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }

        }

        private void changeFont_Button(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void Save_button(object sender, EventArgs e)
        {
            Regex r = new Regex("(0[1-9]|[12][0-9]|3[01])\\/(0[1-9]|1[0,1,2])\\/(19|20)\\d{2}");
            string saveFileName = maskedTextBox1.Text;
            if (!r.IsMatch(maskedTextBox1.Text)) {
                saveFileName = DateTime.Today.ToShortDateString();
            }
            
            saveFileDialog1.DefaultExt = ".txt";
            saveFileName = saveFileName.Replace("/", "-");
            saveFileDialog1.FileName = saveFileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {   
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }
    }
}
