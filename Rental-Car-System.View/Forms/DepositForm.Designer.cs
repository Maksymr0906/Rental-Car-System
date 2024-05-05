namespace Rental_Car_System.View.Forms
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            depositTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            cancelButton = new Button();
            okButton = new Button();
            SuspendLayout();
            // 
            // depositTextField
            // 
            depositTextField.Depth = 0;
            depositTextField.Hint = "Deposit";
            depositTextField.Location = new Point(13, 84);
            depositTextField.Margin = new Padding(3, 4, 3, 4);
            depositTextField.MaxLength = 32767;
            depositTextField.MouseState = MaterialSkin.MouseState.HOVER;
            depositTextField.Name = "depositTextField";
            depositTextField.PasswordChar = '\0';
            depositTextField.SelectedText = "";
            depositTextField.SelectionLength = 0;
            depositTextField.SelectionStart = 0;
            depositTextField.Size = new Size(186, 28);
            depositTextField.TabIndex = 31;
            depositTextField.TabStop = false;
            depositTextField.UseSystemPasswordChar = false;
            depositTextField.KeyPress += depositTextField_KeyPress;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.DarkSlateGray;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Roboto", 12F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(109, 120);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 37);
            cancelButton.TabIndex = 30;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.BackColor = Color.DarkSlateGray;
            okButton.Cursor = Cursors.Hand;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("Roboto", 12F);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(13, 120);
            okButton.Margin = new Padding(3, 4, 3, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 37);
            okButton.TabIndex = 29;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // DepositForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(211, 169);
            ControlBox = false;
            Controls.Add(depositTextField);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DepositForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose the amount";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField depositTextField;
        private Button cancelButton;
        private Button okButton;
    }
}