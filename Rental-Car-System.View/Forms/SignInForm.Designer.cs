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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.seePasswordCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.iAmAdminCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the way to run a program:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to the Car Rental System.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(266, 431);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(268, 34);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(119, 205);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(165, 46);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(119, 251);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(165, 46);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Hint = "";
            this.loginTextField.Location = new System.Drawing.Point(266, 220);
            this.loginTextField.MaxLength = 32767;
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(268, 28);
            this.loginTextField.TabIndex = 10;
            this.loginTextField.TabStop = false;
            this.loginTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Hint = "";
            this.passwordTextField.Location = new System.Drawing.Point(266, 269);
            this.passwordTextField.MaxLength = 32767;
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(268, 28);
            this.passwordTextField.TabIndex = 11;
            this.passwordTextField.TabStop = false;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.Location = new System.Drawing.Point(324, 473);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(139, 17);
            this.signUpLinkLabel.TabIndex = 13;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Not registered? Sign up";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // seePasswordCheckBox
            // 
            this.seePasswordCheckBox.AutoSize = true;
            this.seePasswordCheckBox.Depth = 0;
            this.seePasswordCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.seePasswordCheckBox.Location = new System.Drawing.Point(266, 315);
            this.seePasswordCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.seePasswordCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.seePasswordCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.seePasswordCheckBox.Name = "seePasswordCheckBox";
            this.seePasswordCheckBox.Ripple = true;
            this.seePasswordCheckBox.Size = new System.Drawing.Size(139, 30);
            this.seePasswordCheckBox.TabIndex = 23;
            this.seePasswordCheckBox.Text = "See password";
            this.seePasswordCheckBox.UseVisualStyleBackColor = true;
            this.seePasswordCheckBox.CheckedChanged += new System.EventHandler(this.seePasswordCheckBox_CheckedChanged);
            // 
            // iAmAdminCheckBox
            // 
            this.iAmAdminCheckBox.AutoSize = true;
            this.iAmAdminCheckBox.Depth = 0;
            this.iAmAdminCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.iAmAdminCheckBox.Location = new System.Drawing.Point(266, 355);
            this.iAmAdminCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.iAmAdminCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iAmAdminCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.iAmAdminCheckBox.Name = "iAmAdminCheckBox";
            this.iAmAdminCheckBox.Ripple = true;
            this.iAmAdminCheckBox.Size = new System.Drawing.Size(117, 30);
            this.iAmAdminCheckBox.TabIndex = 24;
            this.iAmAdminCheckBox.Text = "I am admin";
            this.iAmAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            this.AcceptButton = this.signInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.iAmAdminCheckBox);
            this.Controls.Add(this.seePasswordCheckBox);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 498);
            this.Name = "SignInForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private MaterialSkin.Controls.MaterialCheckBox seePasswordCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox iAmAdminCheckBox;
    }
}

