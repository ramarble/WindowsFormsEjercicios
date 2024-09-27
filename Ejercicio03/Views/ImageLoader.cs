using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class ImageLoader : Form


    {
        public ImageLoader()
        {
        InitializeComponent();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {

            Regex linuxFilePath = new Regex("^\\/.*(?! )");
            string wfp = @"^([A-Z]:\\).*";
            Regex windowsFilePath = new Regex(wfp);
            Regex imageFilePattern = new Regex("((\\.jpeg)|(\\.jpg)|(\\.png)|(\\.bmp)|(\\.avif))");


            if (linuxFilePath.IsMatch(URLInput.Text))
            {
                MessageBox.Show("Linux File Path is not supported :D");
            }
            else if (windowsFilePath.IsMatch(URLInput.Text))
            {
                if (File.Exists(URLInput.Text))
                {
                    if (imageFilePattern.IsMatch(URLInput.Text))
                    {
                        pictureBox.ImageLocation = URLInput.Text;
                    }
                }
            }
        }

        private void openButton_click(object sender, EventArgs e)
        {
            Regex linuxFilePath = new Regex("^\\/.*(?! )");
            string wfp = @"^([A-Z]:\\).*";
            Regex windowsFilePath = new Regex(wfp);
            Regex imageFilePattern = new Regex("((\\.jpeg)|(\\.jpg)|(\\.png)|(\\.bmp)|(\\.avif))");


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:";
            ofd.Filter = "Image Files| *.BMP; *.JPG; *.GIF; *.JPEG;)";

            if (linuxFilePath.IsMatch(URLInput.Text))
            {
                MessageBox.Show("Linux File Path is not supported :D");
            }
            else if (windowsFilePath.IsMatch(URLInput.Text))
            {
                try
                {
                    ofd.InitialDirectory = URLInput.Text;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        URLInput.Text = ofd.FileName;
                    }
                    pictureBox.ImageLocation = ofd.FileName;

                } catch (Exception) {
                    MessageBox.Show("Not Found");
                }
            } else
            {
                ofd.ShowDialog();
                if (File.Exists(ofd.FileName))
                {
                    URLInput.Text = ofd.FileName;
                    if (imageFilePattern.IsMatch(ofd.FileName))
                    {
                        pictureBox.ImageLocation = ofd.FileName;
                    }
                }                
            }
        }
    }
}
