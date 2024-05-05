namespace Rental_Car_System.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            signInLinkLabel = new LinkLabel();
            signUpButton = new Button();
            passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            repeatPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            seePasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            iAmAdminCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            SuspendLayout();
            // 
            // signInLinkLabel
            // 
            signInLinkLabel.AutoSize = true;
            signInLinkLabel.Font = new Font("Roboto", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInLinkLabel.Location = new Point(76, 316);
            signInLinkLabel.Name = "signInLinkLabel";
            signInLinkLabel.Size = new Size(157, 17);
            signInLinkLabel.TabIndex = 14;
            signInLinkLabel.TabStop = true;
            signInLinkLabel.Text = "Already registered? Sign in";
            signInLinkLabel.LinkClicked += signInLinkLabel_LinkClicked;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.DarkSlateGray;
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = Color.White;
            signUpButton.Location = new Point(20, 270);
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(268, 42);
            signUpButton.TabIndex = 15;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // passwordTextField
            // 
            passwordTextField.Depth = 0;
            passwordTextField.Hint = "Password";
            passwordTextField.Location = new Point(20, 116);
            passwordTextField.Margin = new Padding(3, 4, 3, 4);
            passwordTextField.MaxLength = 32767;
            passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            passwordTextField.Name = "passwordTextField";
            passwordTextField.PasswordChar = '*';
            passwordTextField.SelectedText = "";
            passwordTextField.SelectionLength = 0;
            passwordTextField.SelectionStart = 0;
            passwordTextField.Size = new Size(268, 28);
            passwordTextField.TabIndex = 19;
            passwordTextField.TabStop = false;
            passwordTextField.UseSystemPasswordChar = false;
            // 
            // loginTextField
            // 
            loginTextField.Depth = 0;
            loginTextField.Hint = "Login";
            loginTextField.Location = new Point(20, 80);
            loginTextField.Margin = new Padding(3, 4, 3, 4);
            loginTextField.MaxLength = 32767;
            loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            loginTextField.Name = "loginTextField";
            loginTextField.PasswordChar = '\0';
            loginTextField.SelectedText = "";
            loginTextField.SelectionLength = 0;
            loginTextField.SelectionStart = 0;
            loginTextField.Size = new Size(268, 28);
            loginTextField.TabIndex = 18;
            loginTextField.TabStop = false;
            loginTextField.UseSystemPasswordChar = false;
            // 
            // repeatPasswordTextField
            // 
            repeatPasswordTextField.Depth = 0;
            repeatPasswordTextField.Hint = "Repeat Password";
            repeatPasswordTextField.Location = new Point(20, 152);
            repeatPasswordTextField.Margin = new Padding(3, 4, 3, 4);
            repeatPasswordTextField.MaxLength = 32767;
            repeatPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            repeatPasswordTextField.Name = "repeatPasswordTextField";
            repeatPasswordTextField.PasswordChar = '*';
            repeatPasswordTextField.SelectedText = "";
            repeatPasswordTextField.SelectionLength = 0;
            repeatPasswordTextField.SelectionStart = 0;
            repeatPasswordTextField.Size = new Size(268, 28);
            repeatPasswordTextField.TabIndex = 21;
            repeatPasswordTextField.TabStop = false;
            repeatPasswordTextField.UseSystemPasswordChar = false;
            // 
            // seePasswordCheckBox
            // 
            seePasswordCheckBox.AutoSize = true;
            seePasswordCheckBox.Depth = 0;
            seePasswordCheckBox.Font = new Font("Roboto", 10F);
            seePasswordCheckBox.Location = new Point(20, 195);
            seePasswordCheckBox.Margin = new Padding(0);
            seePasswordCheckBox.MouseLocation = new Point(-1, -1);
            seePasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            seePasswordCheckBox.Name = "seePasswordCheckBox";
            seePasswordCheckBox.Ripple = true;
            seePasswordCheckBox.Size = new Size(139, 30);
            seePasswordCheckBox.TabIndex = 22;
            seePasswordCheckBox.Text = "See password";
            seePasswordCheckBox.UseVisualStyleBackColor = true;
            seePasswordCheckBox.CheckedChanged += seePasswordCheckBox_CheckedChanged;
            // 
            // iAmAdminCheckBox
            // 
            iAmAdminCheckBox.AutoSize = true;
            iAmAdminCheckBox.Depth = 0;
            iAmAdminCheckBox.Font = new Font("Roboto", 10F);
            iAmAdminCheckBox.Location = new Point(20, 225);
            iAmAdminCheckBox.Margin = new Padding(0);
            iAmAdminCheckBox.MouseLocation = new Point(-1, -1);
            iAmAdminCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            iAmAdminCheckBox.Name = "iAmAdminCheckBox";
            iAmAdminCheckBox.Ripple = true;
            iAmAdminCheckBox.Size = new Size(117, 30);
            iAmAdminCheckBox.TabIndex = 25;
            iAmAdminCheckBox.Text = "I am admin";
            iAmAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            AcceptButton = signUpButton;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(310, 338);
            Controls.Add(iAmAdminCheckBox);
            Controls.Add(seePasswordCheckBox);
            Controls.Add(repeatPasswordTextField);
            Controls.Add(passwordTextField);
            Controls.Add(loginTextField);
            Controls.Add(signUpButton);
            Controls.Add(signInLinkLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(310, 350);
            Name = "SignUpForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.LinkLabel signInLinkLabel;
        private System.Windows.Forms.Button signUpButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField repeatPasswordTextField;
        private MaterialSkin.Controls.MaterialCheckBox seePasswordCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox iAmAdminCheckBox;
    }
}