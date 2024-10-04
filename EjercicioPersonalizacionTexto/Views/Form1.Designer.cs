using System;

namespace EjercicioPersonalizacionTexto
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backdrop_color_button = new System.Windows.Forms.Button();
            this.font_color_button = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.changeFontButton = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 12);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = DateTime.Today.ToShortDateString();
            this.dateToolTip.SetToolTip(this.maskedTextBox1, "dd/mm/yyyy");
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 457);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // backdrop_color_button
            // 
            this.backdrop_color_button.Location = new System.Drawing.Point(118, 12);
            this.backdrop_color_button.Name = "backdrop_color_button";
            this.backdrop_color_button.Size = new System.Drawing.Size(82, 20);
            this.backdrop_color_button.TabIndex = 2;
            this.backdrop_color_button.Text = "Back Color";
            this.backdrop_color_button.UseVisualStyleBackColor = true;
            this.backdrop_color_button.Click += new System.EventHandler(this.changeColor_background);
            // 
            // font_color_button
            // 
            this.font_color_button.Location = new System.Drawing.Point(202, 12);
            this.font_color_button.Name = "font_color_button";
            this.font_color_button.Size = new System.Drawing.Size(82, 20);
            this.font_color_button.TabIndex = 3;
            this.font_color_button.Text = "Font Color";
            this.font_color_button.UseVisualStyleBackColor = true;
            this.font_color_button.Click += new System.EventHandler(this.changeColor_Font);
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(287, 12);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(82, 20);
            this.changeFontButton.TabIndex = 4;
            this.changeFontButton.Text = "Change Font";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.changeFont_Button);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(287, 526);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Save_button);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.changeFontButton);
            this.Controls.Add(this.font_color_button);
            this.Controls.Add(this.backdrop_color_button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "mainForm";
            this.Text = "Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip dateToolTip;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button backdrop_color_button;
        private System.Windows.Forms.Button font_color_button;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button changeFontButton;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

