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
            rejectionCommentLabel = new Label();
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
            isCarDamagedCheckBox.Location = new Point(18, 406);
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
            sendApplicationButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendApplicationButton.ForeColor = Color.White;
            sendApplicationButton.Location = new Point(258, 505);
            sendApplicationButton.Margin = new Padding(3, 4, 3, 4);
            sendApplicationButton.Name = "sendApplicationButton";
            sendApplicationButton.Size = new Size(268, 42);
            sendApplicationButton.TabIndex = 17;
            sendApplicationButton.Text = "Send Application";
            sendApplicationButton.UseVisualStyleBackColor = false;
            sendApplicationButton.Visible = false;
            sendApplicationButton.Click += sendApplicationButton_Click;
            // 
            // rejectionCommentTextField
            // 
            rejectionCommentTextField.Depth = 0;
            rejectionCommentTextField.Hint = "";
            rejectionCommentTextField.Location = new Point(305, 315);
            rejectionCommentTextField.Margin = new Padding(3, 4, 3, 4);
            rejectionCommentTextField.MaxLength = 32767;
            rejectionCommentTextField.MouseState = MaterialSkin.MouseState.HOVER;
            rejectionCommentTextField.Name = "rejectionCommentTextField";
            rejectionCommentTextField.PasswordChar = '\0';
            rejectionCommentTextField.SelectedText = "";
            rejectionCommentTextField.SelectionLength = 0;
            rejectionCommentTextField.SelectionStart = 0;
            rejectionCommentTextField.Size = new Size(453, 28);
            rejectionCommentTextField.TabIndex = 22;
            rejectionCommentTextField.TabStop = false;
            rejectionCommentTextField.UseSystemPasswordChar = false;
            rejectionCommentTextField.Visible = false;
            // 
            // rejectionCommentLabel
            // 
            rejectionCommentLabel.BackColor = Color.Transparent;
            rejectionCommentLabel.Font = new Font("Roboto", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rejectionCommentLabel.Location = new Point(12, 304);
            rejectionCommentLabel.Name = "rejectionCommentLabel";
            rejectionCommentLabel.Size = new Size(287, 58);
            rejectionCommentLabel.TabIndex = 21;
            rejectionCommentLabel.Text = "Rejection comment:";
            rejectionCommentLabel.TextAlign = ContentAlignment.MiddleLeft;
            rejectionCommentLabel.Visible = false;
            // 
            // clientSurnameLabel
            // 
            clientSurnameLabel.BackColor = Color.Transparent;
            clientSurnameLabel.Font = new Font("Roboto", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientSurnameLabel.Location = new Point(12, 92);
            clientSurnameLabel.Name = "clientSurnameLabel";
            clientSurnameLabel.Size = new Size(776, 58);
            clientSurnameLabel.TabIndex = 23;
            clientSurnameLabel.Text = "Client surname:";
            clientSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carModelLabel
            // 
            carModelLabel.BackColor = Color.Transparent;
            carModelLabel.Font = new Font("Roboto", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carModelLabel.Location = new Point(12, 165);
            carModelLabel.Name = "carModelLabel";
            carModelLabel.Size = new Size(776, 58);
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
            confirmOrderButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmOrderButton.ForeColor = Color.White;
            confirmOrderButton.Location = new Point(118, 505);
            confirmOrderButton.Margin = new Padding(3, 4, 3, 4);
            confirmOrderButton.Name = "confirmOrderButton";
            confirmOrderButton.Size = new Size(268, 42);
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
            cancelOrderButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelOrderButton.ForeColor = Color.White;
            cancelOrderButton.Location = new Point(401, 505);
            cancelOrderButton.Margin = new Padding(3, 4, 3, 4);
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.Size = new Size(268, 42);
            cancelOrderButton.TabIndex = 26;
            cancelOrderButton.Text = "Cancel Order";
            cancelOrderButton.UseVisualStyleBackColor = false;
            cancelOrderButton.Visible = false;
            cancelOrderButton.Click += cancelOrderButton_Click;
            // 
            // carDamageFeeLabel
            // 
            carDamageFeeLabel.BackColor = Color.Transparent;
            carDamageFeeLabel.Font = new Font("Roboto", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carDamageFeeLabel.Location = new Point(12, 304);
            carDamageFeeLabel.Name = "carDamageFeeLabel";
            carDamageFeeLabel.Size = new Size(287, 58);
            carDamageFeeLabel.TabIndex = 27;
            carDamageFeeLabel.Text = "Fee for car damage: ";
            carDamageFeeLabel.TextAlign = ContentAlignment.MiddleLeft;
            carDamageFeeLabel.Visible = false;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(carDamageFeeLabel);
            Controls.Add(cancelOrderButton);
            Controls.Add(confirmOrderButton);
            Controls.Add(carModelLabel);
            Controls.Add(clientSurnameLabel);
            Controls.Add(rejectionCommentTextField);
            Controls.Add(rejectionCommentLabel);
            Controls.Add(sendApplicationButton);
            Controls.Add(isCarDamagedCheckBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            ResumeLayout(false);
            PerformLayout();
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
        private Label carDamageFeeLabel;
    }
}