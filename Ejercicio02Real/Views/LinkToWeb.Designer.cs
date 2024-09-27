using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
namespace Ejercicio02Real
{
    partial class LinkToWeb
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
            this.webPageLink = new System.Windows.Forms.LinkLabel();
            this.OpenNewPageButton = new System.Windows.Forms.Button();
            this.linkCorreo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // webPageLink
            // 
            this.webPageLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webPageLink.AutoSize = true;
            this.webPageLink.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.webPageLink.Location = new System.Drawing.Point(21, 87);
            this.webPageLink.Name = "webPageLink";
            this.webPageLink.Size = new System.Drawing.Size(234, 28);
            this.webPageLink.TabIndex = 0;
            this.webPageLink.TabStop = true;
            this.webPageLink.Text = "Visita nuestra página web";
            this.webPageLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenNewPageButton
            // 
            this.OpenNewPageButton.Location = new System.Drawing.Point(103, 235);
            this.OpenNewPageButton.Name = "OpenNewPageButton";
            this.OpenNewPageButton.Size = new System.Drawing.Size(75, 23);
            this.OpenNewPageButton.TabIndex = 1;
            this.OpenNewPageButton.Text = "Visita";
            this.OpenNewPageButton.UseVisualStyleBackColor = true;
            this.OpenNewPageButton.Click += new System.EventHandler(this.visitButton_click);
            // 
            // linkCorreo
            // 
            this.linkCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkCorreo.AutoSize = true;
            this.linkCorreo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.linkCorreo.Location = new System.Drawing.Point(45, 147);
            this.linkCorreo.Name = "linkCorreo";
            this.linkCorreo.Size = new System.Drawing.Size(189, 28);
            this.linkCorreo.TabIndex = 2;
            this.linkCorreo.TabStop = true;
            this.linkCorreo.Text = "Mándame un correo";
            this.linkCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkCorreo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_click);
            // 
            // LinkToWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.linkCorreo);
            this.Controls.Add(this.OpenNewPageButton);
            this.Controls.Add(this.webPageLink);
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "LinkToWeb";
            this.Text = "Visita Nuestra Página Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void clickLink(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.google.com"));
        }

        #endregion

        private LinkLabel webPageLink;
        private Button OpenNewPageButton;
        private LinkLabel linkCorreo;
    }
}
