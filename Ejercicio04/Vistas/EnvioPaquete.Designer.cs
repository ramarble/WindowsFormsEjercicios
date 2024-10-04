namespace Ejercicio04
{
    partial class FormEnvioPaquetes
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
            this.numeric_numeroPaquetes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_Grande = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radio_Mediano = new System.Windows.Forms.RadioButton();
            this.radio_Pequeno = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.send_button = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numeroPaquetes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeric_numeroPaquetes
            // 
            this.numeric_numeroPaquetes.Location = new System.Drawing.Point(41, 47);
            this.numeric_numeroPaquetes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_numeroPaquetes.Name = "numeric_numeroPaquetes";
            this.numeric_numeroPaquetes.Size = new System.Drawing.Size(50, 20);
            this.numeric_numeroPaquetes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de paquetes a enviar:";
            // 
            // radio_Grande
            // 
            this.radio_Grande.AutoSize = true;
            this.radio_Grande.Checked = true;
            this.radio_Grande.Location = new System.Drawing.Point(3, 3);
            this.radio_Grande.Name = "radio_Grande";
            this.radio_Grande.Size = new System.Drawing.Size(60, 17);
            this.radio_Grande.TabIndex = 2;
            this.radio_Grande.TabStop = true;
            this.radio_Grande.Text = "Grande";
            this.radio_Grande.UseVisualStyleBackColor = true;
            this.radio_Grande.Click += new System.EventHandler(this.radioCheckSanity);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radio_Grande);
            this.flowLayoutPanel1.Controls.Add(this.radio_Mediano);
            this.flowLayoutPanel1.Controls.Add(this.radio_Pequeno);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(217, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // radio_Mediano
            // 
            this.radio_Mediano.AutoSize = true;
            this.radio_Mediano.Location = new System.Drawing.Point(3, 26);
            this.radio_Mediano.Name = "radio_Mediano";
            this.radio_Mediano.Size = new System.Drawing.Size(66, 17);
            this.radio_Mediano.TabIndex = 3;
            this.radio_Mediano.Text = "Mediano";
            this.radio_Mediano.UseVisualStyleBackColor = true;
            this.radio_Mediano.Click += new System.EventHandler(this.radioCheckSanity);
            // 
            // radio_Pequeno
            // 
            this.radio_Pequeno.AutoSize = true;
            this.radio_Pequeno.Location = new System.Drawing.Point(3, 49);
            this.radio_Pequeno.Name = "radio_Pequeno";
            this.radio_Pequeno.Size = new System.Drawing.Size(68, 17);
            this.radio_Pequeno.TabIndex = 4;
            this.radio_Pequeno.Text = "Pequeño";
            this.radio_Pequeno.UseVisualStyleBackColor = true;
            this.radio_Pequeno.Click += new System.EventHandler(this.radioCheckSanity);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.listBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(361, 31);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(137, 100);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Grande",
            "Mediano",
            "Pequeño"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SetSelected(0, true);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listbox1_IndexChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBox1);
            this.flowLayoutPanel3.Controls.Add(this.checkBox2);
            this.flowLayoutPanel3.Controls.Add(this.checkBox3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(504, 31);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(137, 100);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Seguro";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Internacional";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Rápido";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(44, 426);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 6;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_onClick);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.summaryLabel.Location = new System.Drawing.Point(41, 200);
            this.summaryLabel.MinimumSize = new System.Drawing.Size(600, 200);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(600, 200);
            this.summaryLabel.TabIndex = 7;
            this.summaryLabel.Text = " ";
            // 
            // FormEnvioPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_numeroPaquetes);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "FormEnvioPaquetes";
            this.Text = "Envío Paquetes";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numeroPaquetes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_numeroPaquetes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_Grande;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radio_Mediano;
        private System.Windows.Forms.RadioButton radio_Pequeno;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label summaryLabel;
    }
}

