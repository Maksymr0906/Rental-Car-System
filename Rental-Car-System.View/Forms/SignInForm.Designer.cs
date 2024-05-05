namespace Rental_Car_System.Forms
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            signInButton = new Button();
            loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            signUpLinkLabel = new LinkLabel();
            seePasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            amIAdminCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.DarkSlateGray;
            signInButton.Cursor = Cursors.Hand;
            signInButton.FlatAppearance.BorderSize = 0;
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInButton.ForeColor = Color.White;
            signInButton.Location = new Point(20, 265);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(268, 42);
            signInButton.TabIndex = 9;
            signInButton.Text = "Sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
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
            loginTextField.TabIndex = 10;
            loginTextField.TabStop = false;
            loginTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            passwordTextField.Depth = 0;
            passwordTextField.Hint = "Password";
            passwordTextField.Location = new Point(20, 126);
            passwordTextField.Margin = new Padding(3, 4, 3, 4);
            passwordTextField.MaxLength = 32767;
            passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            passwordTextField.Name = "passwordTextField";
            passwordTextField.PasswordChar = '*';
            passwordTextField.SelectedText = "";
            passwordTextField.SelectionLength = 0;
            passwordTextField.SelectionStart = 0;
            passwordTextField.Size = new Size(268, 28);
            passwordTextField.TabIndex = 11;
            passwordTextField.TabStop = false;
            passwordTextField.UseSystemPasswordChar = false;
            // 
            // signUpLinkLabel
            // 
            signUpLinkLabel.AutoSize = true;
            signUpLinkLabel.Font = new Font("Roboto", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpLinkLabel.Location = new Point(89, 311);
            signUpLinkLabel.Name = "signUpLinkLabel";
            signUpLinkLabel.Size = new Size(139, 17);
            signUpLinkLabel.TabIndex = 14;
            signUpLinkLabel.TabStop = true;
            signUpLinkLabel.Text = "Not registered? Sign up";
            signUpLinkLabel.LinkClicked += signUpLinkLabel_LinkClicked;
            // 
            // seePasswordCheckBox
            // 
            seePasswordCheckBox.AutoSize = true;
            seePasswordCheckBox.Depth = 0;
            seePasswordCheckBox.Font = new Font("Roboto", 10F);
            seePasswordCheckBox.Location = new Point(20, 175);
            seePasswordCheckBox.Margin = new Padding(0);
            seePasswordCheckBox.MouseLocation = new Point(-1, -1);
            seePasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            seePasswordCheckBox.Name = "seePasswordCheckBox";
            seePasswordCheckBox.Ripple = true;
            seePasswordCheckBox.Size = new Size(139, 30);
            seePasswordCheckBox.TabIndex = 12;
            seePasswordCheckBox.Text = "See password";
            seePasswordCheckBox.UseVisualStyleBackColor = true;
            seePasswordCheckBox.CheckedChanged += seePasswordCheckBox_CheckedChanged;
            // 
            // amIAdminCheckBox
            // 
            amIAdminCheckBox.AutoSize = true;
            amIAdminCheckBox.Depth = 0;
            amIAdminCheckBox.Font = new Font("Roboto", 10F);
            amIAdminCheckBox.Location = new Point(20, 221);
            amIAdminCheckBox.Margin = new Padding(0);
            amIAdminCheckBox.MouseLocation = new Point(-1, -1);
            amIAdminCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            amIAdminCheckBox.Name = "amIAdminCheckBox";
            amIAdminCheckBox.Ripple = true;
            amIAdminCheckBox.Size = new Size(117, 30);
            amIAdminCheckBox.TabIndex = 13;
            amIAdminCheckBox.Text = "I am admin";
            amIAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            AcceptButton = signInButton;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(310, 337);
            Controls.Add(amIAdminCheckBox);
            Controls.Add(seePasswordCheckBox);
            Controls.Add(signUpLinkLabel);
            Controls.Add(passwordTextField);
            Controls.Add(loginTextField);
            Controls.Add(signInButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(310, 337);
            Name = "SignInForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button signInButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private MaterialSkin.Controls.MaterialCheckBox seePasswordCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox amIAdminCheckBox;
    }
}

