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
            isCarDamagedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            sendApplicationButton = new Button();
            rejectionCommentTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            clientSurnameLabel = new Label();
            carModelLabel = new Label();
            confirmOrderButton = new Button();
            cancelOrderButton = new Button();
            carDamageFeeLabel = new Label();
            SuspendLayout();
            // 
            // isCarDamagedCheckBox
            // 
            isCarDamagedCheckBox.AutoSize = true;
            isCarDamagedCheckBox.Depth = 0;
            isCarDamagedCheckBox.Font = new Font("Roboto", 10F);
            isCarDamagedCheckBox.Location = new Point(12, 240);
            isCarDamagedCheckBox.Margin = new Padding(0);
            isCarDamagedCheckBox.MouseLocation = new Point(-1, -1);
            isCarDamagedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            isCarDamagedCheckBox.Name = "isCarDamagedCheckBox";
            isCarDamagedCheckBox.Ripple = true;
            isCarDamagedCheckBox.Size = new Size(149, 30);
            isCarDamagedCheckBox.TabIndex = 0;
            isCarDamagedCheckBox.Text = "Is car damaged";
            isCarDamagedCheckBox.UseVisualStyleBackColor = true;
            isCarDamagedCheckBox.Visible = false;
            // 
            // sendApplicationButton
            // 
            sendApplicationButton.BackColor = Color.DarkSlateGray;
            sendApplicationButton.Cursor = Cursors.Hand;
            sendApplicationButton.FlatAppearance.BorderSize = 0;
            sendApplicationButton.FlatStyle = FlatStyle.Flat;
            sendApplicationButton.Font = new Font("Roboto", 12F);
            sendApplicationButton.ForeColor = Color.White;
            sendApplicationButton.Location = new Point(146, 291);
            sendApplicationButton.Margin = new Padding(3, 4, 3, 4);
            sendApplicationButton.Name = "sendApplicationButton";
            sendApplicationButton.Size = new Size(176, 37);
            sendApplicationButton.TabIndex = 17;
            sendApplicationButton.Text = "Send Application";
            sendApplicationButton.UseVisualStyleBackColor = false;
            sendApplicationButton.Visible = false;
            sendApplicationButton.Click += sendApplicationButton_Click;
            // 
            // rejectionCommentTextField
            // 
            rejectionCommentTextField.Depth = 0;
            rejectionCommentTextField.Hint = "Rejection comment";
            rejectionCommentTextField.Location = new Point(12, 189);
            rejectionCommentTextField.Margin = new Padding(3, 4, 3, 4);
            rejectionCommentTextField.MaxLength = 32767;
            rejectionCommentTextField.MouseState = MaterialSkin.MouseState.HOVER;
            rejectionCommentTextField.Name = "rejectionCommentTextField";
            rejectionCommentTextField.PasswordChar = '\0';
            rejectionCommentTextField.SelectedText = "";
            rejectionCommentTextField.SelectionLength = 0;
            rejectionCommentTextField.SelectionStart = 0;
            rejectionCommentTextField.Size = new Size(374, 28);
            rejectionCommentTextField.TabIndex = 22;
            rejectionCommentTextField.TabStop = false;
            rejectionCommentTextField.UseSystemPasswordChar = false;
            rejectionCommentTextField.Visible = false;
            // 
            // clientSurnameLabel
            // 
            clientSurnameLabel.BackColor = Color.Transparent;
            clientSurnameLabel.Font = new Font("Roboto", 12F);
            clientSurnameLabel.Location = new Point(12, 71);
            clientSurnameLabel.Name = "clientSurnameLabel";
            clientSurnameLabel.Size = new Size(374, 38);
            clientSurnameLabel.TabIndex = 23;
            clientSurnameLabel.Text = "Client surname:";
            clientSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carModelLabel
            // 
            carModelLabel.BackColor = Color.Transparent;
            carModelLabel.Font = new Font("Roboto", 12F);
            carModelLabel.Location = new Point(12, 126);
            carModelLabel.Name = "carModelLabel";
            carModelLabel.Size = new Size(374, 41);
            carModelLabel.TabIndex = 24;
            carModelLabel.Text = "Car model:";
            carModelLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // confirmOrderButton
            // 
            confirmOrderButton.BackColor = Color.DarkSlateGray;
            confirmOrderButton.Cursor = Cursors.Hand;
            confirmOrderButton.FlatAppearance.BorderSize = 0;
            confirmOrderButton.FlatStyle = FlatStyle.Flat;
            confirmOrderButton.Font = new Font("Roboto", 12F);
            confirmOrderButton.ForeColor = Color.White;
            confirmOrderButton.Location = new Point(6, 291);
            confirmOrderButton.Margin = new Padding(3, 4, 3, 4);
            confirmOrderButton.Name = "confirmOrderButton";
            confirmOrderButton.Size = new Size(176, 37);
            confirmOrderButton.TabIndex = 25;
            confirmOrderButton.Text = "Confirm Order";
            confirmOrderButton.UseVisualStyleBackColor = false;
            confirmOrderButton.Visible = false;
            confirmOrderButton.Click += confirmOrderButton_Click;
            // 
            // cancelOrderButton
            // 
            cancelOrderButton.BackColor = Color.DarkSlateGray;
            cancelOrderButton.Cursor = Cursors.Hand;
            cancelOrderButton.FlatAppearance.BorderSize = 0;
            cancelOrderButton.FlatStyle = FlatStyle.Flat;
            cancelOrderButton.Font = new Font("Roboto", 12F);
            cancelOrderButton.ForeColor = Color.White;
            cancelOrderButton.Location = new Point(289, 291);
            cancelOrderButton.Margin = new Padding(3, 4, 3, 4);
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.Size = new Size(176, 37);
            cancelOrderButton.TabIndex = 26;
            cancelOrderButton.Text = "Cancel Order";
            cancelOrderButton.UseVisualStyleBackColor = false;
            cancelOrderButton.Visible = false;
            cancelOrderButton.Click += cancelOrderButton_Click;
            // 
            // carDamageFeeLabel
            // 
            carDamageFeeLabel.BackColor = Color.Transparent;
            carDamageFeeLabel.Font = new Font("Roboto", 12F);
            carDamageFeeLabel.Location = new Point(12, 179);
            carDamageFeeLabel.Name = "carDamageFeeLabel";
            carDamageFeeLabel.Size = new Size(374, 38);
            carDamageFeeLabel.TabIndex = 27;
            carDamageFeeLabel.Text = "Fee for car damage: ";
            carDamageFeeLabel.TextAlign = ContentAlignment.MiddleLeft;
            carDamageFeeLabel.Visible = false;
            // 
            // ApplicationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(478, 342);
            Controls.Add(cancelOrderButton);
            Controls.Add(confirmOrderButton);
            Controls.Add(carModelLabel);
            Controls.Add(clientSurnameLabel);
            Controls.Add(rejectionCommentTextField);
            Controls.Add(sendApplicationButton);
            Controls.Add(isCarDamagedCheckBox);
            Controls.Add(carDamageFeeLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicationForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox isCarDamagedCheckBox;
        private System.Windows.Forms.Button sendApplicationButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField rejectionCommentTextField;
        private System.Windows.Forms.Label clientSurnameLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private Label carDamageFeeLabel;
    }
}