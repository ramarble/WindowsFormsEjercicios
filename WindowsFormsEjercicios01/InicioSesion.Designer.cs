using WindowsFormsEjercicios01.Modelos;

namespace WindowsFormsEjercicios01
{
    partial class InicioSesion
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
            labelUsername = new Label();
            labelPassword = new Label();
            userInputBox = new TextBox();
            passwdInputBox = new TextBox();
            sendButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(50, 50);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(47, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Usuario";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(50, 100);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(72, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Constraseña";
            // 
            // userInputBox
            // 
            userInputBox.Location = new Point(200, 50);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(100, 23);
            userInputBox.TabIndex = 2;
            // 
            // passwdInputBox
            // 
            passwdInputBox.Location = new Point(200, 100);
            passwdInputBox.Name = "passwdInputBox";
            passwdInputBox.PasswordChar = '*';
            passwdInputBox.Size = new Size(100, 23);
            passwdInputBox.TabIndex = 3;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(50, 200);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 4;
            sendButton.Text = "Log In";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += new EventHandler(SendButton_Click);
            // 
            // clearButton
            // 
            clearButton.Location = new Point(250, 200);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(clearButton);
            Controls.Add(labelPassword);
            Controls.Add(sendButton);
            Controls.Add(passwdInputBox);
            Controls.Add(userInputBox);
            Controls.Add(labelUsername);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InicioSesion";
            Text = "Formulario de Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //out :)
            Boolean success = UserClass.usernameMatch(userInputBox.Text, passwdInputBox.Text);

            if (success)
            {
                MessageBox.Show("Success");
            } else { 
                MessageBox.Show("Failure");
            };
        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox userInputBox;
        private TextBox passwdInputBox;
        private Button sendButton;
        private Button clearButton;
    }
}
