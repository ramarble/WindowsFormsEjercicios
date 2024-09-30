using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        static Regex imageFilePattern = new Regex(".*((\\.jpeg)|(\\.jpg)|(\\.png)|(\\.bmp)|(\\.avif))");

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            string wfp = @"^([A-Z]:\\).*";
            Regex windowsFilePath = new Regex(wfp);
            Regex internetPath = new Regex("(https?).*\\.");

            if (windowsFilePath.IsMatch(URLInput.Text))
            {
                try
                {
                    if (File.Exists(URLInput.Text)) {
                        pictureBox.ImageLocation = URLInput.Text;
                    }
                } catch (Exception)
                {
                    MessageBox.Show("Not Found");
                }
            } else if (internetPath.IsMatch(URLInput.Text))
            {
                loadInternetFilePath();
            }
            else
            {
                MessageBox.Show("Invalid URL");
            }

        }

        private void openButton_click(object sender, EventArgs e)
        {
            Regex linuxFilePath = new Regex("^\\/.*(?! )");
            string wfp = @"^([A-Z]:\\).*";
            Regex windowsFilePath = new Regex(wfp);

            if (linuxFilePath.IsMatch(URLInput.Text))
            {
                MessageBox.Show("Linux File Path is not supported :D");
            }
            else if (windowsFilePath.IsMatch(URLInput.Text))
            {
                SearchLocalWindowsFilePath();
            }
            else
            {
                fileSearch();
            }
        }

        private void SearchLocalWindowsFilePath()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            
            //This tries and defaults to C:\ if it fails. good.
            ofd.InitialDirectory = URLInput.Text;

            ofd.Filter = "Image Files| *.BMP; *.JPG; *.GIF; *.JPEG;)";
            try
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.InitialDirectory = URLInput.Text;
                    URLInput.Text = ofd.FileName;
                }
                pictureBox.ImageLocation = ofd.FileName;

            }
            catch (Exception)
            {
                MessageBox.Show("Unknown Error");
            }
        }

        private void loadInternetFilePath()
        {

            if (imageFilePattern.IsMatch(URLInput.Text))
            {
                try
                {
                    pictureBox.Load(URLInput.Text);
                }
                catch
                {
                    MessageBox.Show("Not Found");
                }
            }


        }

        private void fileSearch()
        {


            OpenFileDialog ofd = new OpenFileDialog();
            //This should be the global variable for homepath
            ofd.ShowDialog();

            if (File.Exists(ofd.FileName))
            {
                if (imageFilePattern.IsMatch(ofd.FileName))
                {
                    //loads the loaded image as a path in the textbox
                    URLInput.Text = ofd.FileName;
                    //loads the image
                    pictureBox.ImageLocation = ofd.FileName;
                }
            }

        }

    }

}
