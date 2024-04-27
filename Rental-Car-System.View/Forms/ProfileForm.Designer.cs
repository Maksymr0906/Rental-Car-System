namespace Rental_Car_System.View.Forms
{
    partial class ProfileForm
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
            components = new System.ComponentModel.Container();
            nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            surnameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            dateOfBirthLabel = new Label();
            dateOfBirthTimePicker = new DateTimePicker();
            updateProfileButton = new Button();
            profileToolTip = new ToolTip(components);
            myOrdersButton = new Button();
            SuspendLayout();
            // 
            // nameTextField
            // 
            nameTextField.Depth = 0;
            nameTextField.Hint = "Name";
            nameTextField.Location = new Point(12, 135);
            nameTextField.Margin = new Padding(3, 4, 3, 4);
            nameTextField.MaxLength = 32767;
            nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            nameTextField.Name = "nameTextField";
            nameTextField.PasswordChar = '\0';
            nameTextField.SelectedText = "";
            nameTextField.SelectionLength = 0;
            nameTextField.SelectionStart = 0;
            nameTextField.Size = new Size(503, 28);
            nameTextField.TabIndex = 23;
            nameTextField.TabStop = false;
            profileToolTip.SetToolTip(nameTextField, "Name");
            nameTextField.UseSystemPasswordChar = false;
            nameTextField.KeyPress += nameTextField_KeyPress;
            // 
            // surnameTextField
            // 
            surnameTextField.Depth = 0;
            surnameTextField.Hint = "Surname";
            surnameTextField.Location = new Point(12, 89);
            surnameTextField.Margin = new Padding(3, 4, 3, 4);
            surnameTextField.MaxLength = 32767;
            surnameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            surnameTextField.Name = "surnameTextField";
            surnameTextField.PasswordChar = '\0';
            surnameTextField.SelectedText = "";
            surnameTextField.SelectionLength = 0;
            surnameTextField.SelectionStart = 0;
            surnameTextField.Size = new Size(503, 28);
            surnameTextField.TabIndex = 22;
            surnameTextField.TabStop = false;
            profileToolTip.SetToolTip(surnameTextField, "Surname");
            surnameTextField.UseSystemPasswordChar = false;
            surnameTextField.KeyPress += surnameTextField_KeyPress;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.BackColor = Color.Transparent;
            dateOfBirthLabel.Font = new Font("Roboto", 12F);
            dateOfBirthLabel.Location = new Point(12, 182);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(237, 32);
            dateOfBirthLabel.TabIndex = 25;
            dateOfBirthLabel.Text = "Date of birth:";
            dateOfBirthLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateOfBirthTimePicker
            // 
            dateOfBirthTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateOfBirthTimePicker.Font = new Font("Roboto", 12F);
            dateOfBirthTimePicker.Location = new Point(221, 182);
            dateOfBirthTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            dateOfBirthTimePicker.Size = new Size(294, 32);
            dateOfBirthTimePicker.TabIndex = 24;
            profileToolTip.SetToolTip(dateOfBirthTimePicker, "Date of birth");
            // 
            // updateProfileButton
            // 
            updateProfileButton.BackColor = Color.DarkSlateGray;
            updateProfileButton.Cursor = Cursors.Hand;
            updateProfileButton.FlatAppearance.BorderSize = 0;
            updateProfileButton.FlatStyle = FlatStyle.Flat;
            updateProfileButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateProfileButton.ForeColor = Color.White;
            updateProfileButton.Location = new Point(267, 236);
            updateProfileButton.Margin = new Padding(3, 4, 3, 4);
            updateProfileButton.Name = "updateProfileButton";
            updateProfileButton.Size = new Size(248, 42);
            updateProfileButton.TabIndex = 1;
            updateProfileButton.Tag = "1";
            updateProfileButton.Text = "Update";
            updateProfileButton.UseVisualStyleBackColor = false;
            updateProfileButton.Click += updateProfileButton_Click;
            // 
            // myOrdersButton
            // 
            myOrdersButton.BackColor = Color.DarkSlateGray;
            myOrdersButton.Cursor = Cursors.Hand;
            myOrdersButton.FlatAppearance.BorderSize = 0;
            myOrdersButton.FlatStyle = FlatStyle.Flat;
            myOrdersButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myOrdersButton.ForeColor = Color.White;
            myOrdersButton.Location = new Point(12, 236);
            myOrdersButton.Margin = new Padding(3, 4, 3, 4);
            myOrdersButton.Name = "myOrdersButton";
            myOrdersButton.Size = new Size(248, 42);
            myOrdersButton.TabIndex = 26;
            myOrdersButton.Tag = "1";
            myOrdersButton.Text = "My Orders";
            myOrdersButton.UseVisualStyleBackColor = false;
            myOrdersButton.Click += myOrdersButton_Click;
            // 
            // ProfileForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(532, 291);
            Controls.Add(myOrdersButton);
            Controls.Add(updateProfileButton);
            Controls.Add(dateOfBirthTimePicker);
            Controls.Add(nameTextField);
            Controls.Add(surnameTextField);
            Controls.Add(dateOfBirthLabel);
            Name = "ProfileForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField surnameTextField;
        private Label dateOfBirthLabel;
        private DateTimePicker dateOfBirthTimePicker;
        private Button updateProfileButton;
        private ToolTip profileToolTip;
        private Button myOrdersButton;
    }
}