namespace Rental_Car_System.Forms
{
    partial class ApplicationForm
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
            this.isCarDamagedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.sendApplicationButton = new System.Windows.Forms.Button();
            this.rejectionCommentTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rejectionCommentLabel = new System.Windows.Forms.Label();
            this.clientSurnameLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isCarDamagedCheckBox
            // 
            this.isCarDamagedCheckBox.AutoSize = true;
            this.isCarDamagedCheckBox.Depth = 0;
            this.isCarDamagedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.isCarDamagedCheckBox.Location = new System.Drawing.Point(18, 325);
            this.isCarDamagedCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.isCarDamagedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isCarDamagedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.isCarDamagedCheckBox.Name = "isCarDamagedCheckBox";
            this.isCarDamagedCheckBox.Ripple = true;
            this.isCarDamagedCheckBox.Size = new System.Drawing.Size(149, 30);
            this.isCarDamagedCheckBox.TabIndex = 0;
            this.isCarDamagedCheckBox.Text = "Is car damaged";
            this.isCarDamagedCheckBox.UseVisualStyleBackColor = true;
            this.isCarDamagedCheckBox.Visible = false;
            // 
            // sendApplicationButton
            // 
            this.sendApplicationButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sendApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendApplicationButton.FlatAppearance.BorderSize = 0;
            this.sendApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendApplicationButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendApplicationButton.ForeColor = System.Drawing.Color.White;
            this.sendApplicationButton.Location = new System.Drawing.Point(258, 404);
            this.sendApplicationButton.Name = "sendApplicationButton";
            this.sendApplicationButton.Size = new System.Drawing.Size(268, 34);
            this.sendApplicationButton.TabIndex = 17;
            this.sendApplicationButton.Text = "Send Application";
            this.sendApplicationButton.UseVisualStyleBackColor = false;
            this.sendApplicationButton.Visible = false;
            this.sendApplicationButton.Click += new System.EventHandler(this.sendApplicationButton_Click);
            // 
            // rejectionCommentTextField
            // 
            this.rejectionCommentTextField.Depth = 0;
            this.rejectionCommentTextField.Hint = "";
            this.rejectionCommentTextField.Location = new System.Drawing.Point(305, 252);
            this.rejectionCommentTextField.MaxLength = 32767;
            this.rejectionCommentTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.rejectionCommentTextField.Name = "rejectionCommentTextField";
            this.rejectionCommentTextField.PasswordChar = '\0';
            this.rejectionCommentTextField.SelectedText = "";
            this.rejectionCommentTextField.SelectionLength = 0;
            this.rejectionCommentTextField.SelectionStart = 0;
            this.rejectionCommentTextField.Size = new System.Drawing.Size(453, 28);
            this.rejectionCommentTextField.TabIndex = 22;
            this.rejectionCommentTextField.TabStop = false;
            this.rejectionCommentTextField.UseSystemPasswordChar = false;
            this.rejectionCommentTextField.Visible = false;
            // 
            // rejectionCommentLabel
            // 
            this.rejectionCommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.rejectionCommentLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectionCommentLabel.Location = new System.Drawing.Point(12, 243);
            this.rejectionCommentLabel.Name = "rejectionCommentLabel";
            this.rejectionCommentLabel.Size = new System.Drawing.Size(287, 46);
            this.rejectionCommentLabel.TabIndex = 21;
            this.rejectionCommentLabel.Text = "Rejection comment:";
            this.rejectionCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rejectionCommentLabel.Visible = false;
            // 
            // clientSurnameLabel
            // 
            this.clientSurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientSurnameLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSurnameLabel.Location = new System.Drawing.Point(12, 74);
            this.clientSurnameLabel.Name = "clientSurnameLabel";
            this.clientSurnameLabel.Size = new System.Drawing.Size(776, 46);
            this.clientSurnameLabel.TabIndex = 23;
            this.clientSurnameLabel.Text = "Client surname:";
            this.clientSurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carModelLabel
            // 
            this.carModelLabel.BackColor = System.Drawing.Color.Transparent;
            this.carModelLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLabel.Location = new System.Drawing.Point(12, 132);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(776, 46);
            this.carModelLabel.TabIndex = 24;
            this.carModelLabel.Text = "Car model:";
            this.carModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.confirmOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmOrderButton.FlatAppearance.BorderSize = 0;
            this.confirmOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmOrderButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderButton.ForeColor = System.Drawing.Color.White;
            this.confirmOrderButton.Location = new System.Drawing.Point(118, 404);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(268, 34);
            this.confirmOrderButton.TabIndex = 25;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = false;
            this.confirmOrderButton.Visible = false;
            this.confirmOrderButton.Click += new System.EventHandler(this.confirmOrderButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cancelOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelOrderButton.FlatAppearance.BorderSize = 0;
            this.cancelOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOrderButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.ForeColor = System.Drawing.Color.White;
            this.cancelOrderButton.Location = new System.Drawing.Point(401, 404);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(268, 34);
            this.cancelOrderButton.TabIndex = 26;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Visible = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.clientSurnameLabel);
            this.Controls.Add(this.rejectionCommentTextField);
            this.Controls.Add(this.rejectionCommentLabel);
            this.Controls.Add(this.sendApplicationButton);
            this.Controls.Add(this.isCarDamagedCheckBox);
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox isCarDamagedCheckBox;
        private System.Windows.Forms.Button sendApplicationButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField rejectionCommentTextField;
        private System.Windows.Forms.Label rejectionCommentLabel;
        private System.Windows.Forms.Label clientSurnameLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Button cancelOrderButton;
    }
}