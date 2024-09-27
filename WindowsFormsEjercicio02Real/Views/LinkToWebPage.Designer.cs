using System;
using System.Diagnostics;
namespace WindowsFormsEjercicio02
{
    partial class LinkToWebPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webPageLink = new LinkLabel();
            SuspendLayout();
            // 
            // webPageLink
            // 
            webPageLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webPageLink.AutoSize = true;
            webPageLink.Font = new Font("Segoe UI", 15F);
            webPageLink.Location = new Point(25, 100);
            webPageLink.Name = "webPageLink";
            webPageLink.Size = new Size(234, 28);
            webPageLink.TabIndex = 0;
            webPageLink.TabStop = true;
            webPageLink.Text = "Visita nuestra página web";
            webPageLink.TextAlign = ContentAlignment.MiddleCenter;
            webPageLink.LinkClicked += this.clickLink;
            // 
            // LinkToWebPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(webPageLink);
            Location = new Point(100, 0);
            Name = "LinkToWebPage";
            Text = "Form1";
            Load += LinkToWebPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void clickLink(object sender, EventArgs e) {

            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.google.com"));
        }

        #endregion

        private LinkLabel webPageLink;
    }
}
