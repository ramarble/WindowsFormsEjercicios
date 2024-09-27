using WindowsFormsEjercicios01.Controladores;
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
            InsertNewUserButton = new Button();
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
            sendButton.Click += SendButton_Click;
            // 
            // clearButton
            // 
            InsertNewUserButton.Location = new Point(250, 200);
            InsertNewUserButton.Name = "clearButton";
            InsertNewUserButton.Size = new Size(75, 23);
            InsertNewUserButton.TabIndex = 5;
            InsertNewUserButton.Text = "Clear";
            InsertNewUserButton.UseVisualStyleBackColor = true;
            InsertNewUserButton.Click += this.NewUser_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(InsertNewUserButton);
            Controls.Add(labelPassword);
            Controls.Add(sendButton);
            Controls.Add(passwdInputBox);
            Controls.Add(userInputBox);
            Controls.Add(labelUsername);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InicioSesion";
            Text = "Formulario de Inicio de Sesión";
            Load += InicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Boolean success = UserClass.usernameMatch(userInputBox.Text, passwdInputBox.Text, DataUsers.userlist);

            if (success)
            {
                MessageBox.Show("Bienvenido " + userInputBox.Text);
            } else { 
                MessageBox.Show("Error");
            };
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            DataUsers.addUserClass(DataUsers.userlist, userInputBox.Text, passwdInputBox.Text);
            MessageBox.Show("Nuevo usuario añadido: " + userInputBox.Text);
        }
        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox userInputBox;
        private TextBox passwdInputBox;
        private Button sendButton;
        private Button InsertNewUserButton;
    }
}
