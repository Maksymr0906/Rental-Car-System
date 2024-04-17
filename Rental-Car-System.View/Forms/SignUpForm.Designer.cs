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
            this.signInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.seePasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.iAmAdminCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // signInLinkLabel
            // 
            this.signInLinkLabel.AutoSize = true;
            this.signInLinkLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLinkLabel.Location = new System.Drawing.Point(323, 425);
            this.signInLinkLabel.Name = "signInLinkLabel";
            this.signInLinkLabel.Size = new System.Drawing.Size(157, 17);
            this.signInLinkLabel.TabIndex = 14;
            this.signInLinkLabel.TabStop = true;
            this.signInLinkLabel.Text = "Already registered? Sign in";
            this.signInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInLinkLabel_LinkClicked);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(266, 388);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(268, 34);
            this.signUpButton.TabIndex = 15;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Hint = "";
            this.passwordTextField.Location = new System.Drawing.Point(326, 215);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(268, 28);
            this.passwordTextField.TabIndex = 19;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Hint = "";
            this.loginTextField.Location = new System.Drawing.Point(326, 166);
            this.loginTextField.MaxLength = 32767;
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(268, 28);
            this.loginTextField.TabIndex = 18;
            this.loginTextField.TabStop = false;
            this.loginTextField.UseSystemPasswordChar = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(91, 197);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(165, 46);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(91, 151);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(165, 46);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "Login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // repeatPasswordTextField
            // 
            this.repeatPasswordTextField.Depth = 0;
            this.repeatPasswordTextField.Hint = "";
            this.repeatPasswordTextField.Location = new System.Drawing.Point(326, 264);
            this.repeatPasswordTextField.MaxLength = 32767;
            this.repeatPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.repeatPasswordTextField.Name = "repeatPasswordTextField";
            this.repeatPasswordTextField.PasswordChar = '*';
            this.repeatPasswordTextField.SelectedText = "";
            this.repeatPasswordTextField.SelectionLength = 0;
            this.repeatPasswordTextField.SelectionStart = 0;
            this.repeatPasswordTextField.Size = new System.Drawing.Size(268, 28);
            this.repeatPasswordTextField.TabIndex = 21;
            this.repeatPasswordTextField.TabStop = false;
            this.repeatPasswordTextField.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Repeat Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seePasswordCheckBox
            // 
            this.seePasswordCheckBox.AutoSize = true;
            this.seePasswordCheckBox.Depth = 0;
            this.seePasswordCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.seePasswordCheckBox.Location = new System.Drawing.Point(326, 309);
            this.seePasswordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.seePasswordCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.seePasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.seePasswordCheckBox.Name = "seePasswordCheckBox";
            this.seePasswordCheckBox.Ripple = true;
            this.seePasswordCheckBox.Size = new System.Drawing.Size(139, 30);
            this.seePasswordCheckBox.TabIndex = 22;
            this.seePasswordCheckBox.Text = "See password";
            this.seePasswordCheckBox.UseVisualStyleBackColor = true;
            this.seePasswordCheckBox.CheckedChanged += new System.EventHandler(this.seePasswordCheckBox_CheckedChanged);
            // 
            // iAmAdminCheckBox
            // 
            this.iAmAdminCheckBox.AutoSize = true;
            this.iAmAdminCheckBox.Depth = 0;
            this.iAmAdminCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.iAmAdminCheckBox.Location = new System.Drawing.Point(326, 348);
            this.iAmAdminCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.iAmAdminCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iAmAdminCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.iAmAdminCheckBox.Name = "iAmAdminCheckBox";
            this.iAmAdminCheckBox.Ripple = true;
            this.iAmAdminCheckBox.Size = new System.Drawing.Size(117, 30);
            this.iAmAdminCheckBox.TabIndex = 25;
            this.iAmAdminCheckBox.Text = "I am admin";
            this.iAmAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.signUpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iAmAdminCheckBox);
            this.Controls.Add(this.seePasswordCheckBox);
            this.Controls.Add(this.repeatPasswordTextField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInLinkLabel);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel signInLinkLabel;
        private System.Windows.Forms.Button signUpButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField repeatPasswordTextField;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCheckBox seePasswordCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox iAmAdminCheckBox;
    }
}