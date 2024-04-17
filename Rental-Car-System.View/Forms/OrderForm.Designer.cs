namespace Rental_Car_System.Forms
{
    partial class OrderForm
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
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.rentToLabel = new System.Windows.Forms.Label();
            this.rentToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.surnameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTimePicker.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(285, 235);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(425, 40);
            this.dateOfBirthTimePicker.TabIndex = 0;
            // 
            // surnameLabel
            // 
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(42, 101);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(237, 46);
            this.surnameLabel.TabIndex = 8;
            this.surnameLabel.Text = "Surname:";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(42, 162);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(237, 46);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(42, 233);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(237, 46);
            this.dateOfBirthLabel.TabIndex = 10;
            this.dateOfBirthLabel.Text = "Date of birth:";
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentToLabel
            // 
            this.rentToLabel.BackColor = System.Drawing.Color.Transparent;
            this.rentToLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentToLabel.Location = new System.Drawing.Point(42, 299);
            this.rentToLabel.Name = "rentToLabel";
            this.rentToLabel.Size = new System.Drawing.Size(237, 46);
            this.rentToLabel.TabIndex = 11;
            this.rentToLabel.Text = "Rent to: ";
            this.rentToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rentToTimePicker
            // 
            this.rentToTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentToTimePicker.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentToTimePicker.Location = new System.Drawing.Point(285, 301);
            this.rentToTimePicker.Name = "rentToTimePicker";
            this.rentToTimePicker.Size = new System.Drawing.Size(425, 40);
            this.rentToTimePicker.TabIndex = 12;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CreateOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateOrderButton.FlatAppearance.BorderSize = 0;
            this.CreateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrderButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrderButton.ForeColor = System.Drawing.Color.White;
            this.CreateOrderButton.Location = new System.Drawing.Point(262, 404);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(268, 34);
            this.CreateOrderButton.TabIndex = 17;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = false;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // surnameTextField
            // 
            this.surnameTextField.Depth = 0;
            this.surnameTextField.Hint = "";
            this.surnameTextField.Location = new System.Drawing.Point(285, 110);
            this.surnameTextField.MaxLength = 32767;
            this.surnameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.surnameTextField.Name = "surnameTextField";
            this.surnameTextField.PasswordChar = '\0';
            this.surnameTextField.SelectedText = "";
            this.surnameTextField.SelectionLength = 0;
            this.surnameTextField.SelectionStart = 0;
            this.surnameTextField.Size = new System.Drawing.Size(503, 28);
            this.surnameTextField.TabIndex = 20;
            this.surnameTextField.TabStop = false;
            this.surnameTextField.UseSystemPasswordChar = false;
            this.surnameTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextField_KeyPress);
            // 
            // nameTextField
            // 
            this.nameTextField.Depth = 0;
            this.nameTextField.Hint = "";
            this.nameTextField.Location = new System.Drawing.Point(285, 180);
            this.nameTextField.MaxLength = 32767;
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(503, 28);
            this.nameTextField.TabIndex = 21;
            this.nameTextField.TabStop = false;
            this.nameTextField.UseSystemPasswordChar = false;
            this.nameTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextField_KeyPress);
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLoginLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.userLoginLabel.Location = new System.Drawing.Point(491, 23);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(308, 46);
            this.userLoginLabel.TabIndex = 22;
            this.userLoginLabel.Text = "Logged as: ";
            this.userLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.nameTextField);
            this.Controls.Add(this.surnameTextField);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.rentToTimePicker);
            this.Controls.Add(this.rentToLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.dateOfBirthTimePicker);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label rentToLabel;
        private System.Windows.Forms.DateTimePicker rentToTimePicker;
        private System.Windows.Forms.Button CreateOrderButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField surnameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private System.Windows.Forms.Label userLoginLabel;
    }
}