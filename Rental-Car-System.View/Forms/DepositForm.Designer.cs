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
			pictureBox1 = new PictureBox();
			cardNumberTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			cvvTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			surnameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			monthTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			yearTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// depositTextField
			// 
			depositTextField.Depth = 0;
			depositTextField.Hint = "Deposit";
			depositTextField.Location = new Point(489, 174);
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
			cancelButton.Location = new Point(585, 220);
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
			okButton.Location = new Point(489, 220);
			okButton.Margin = new Padding(3, 4, 3, 4);
			okButton.Name = "okButton";
			okButton.Size = new Size(90, 37);
			okButton.TabIndex = 29;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = false;
			okButton.Click += okButton_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.plastic_card_template;
			pictureBox1.Location = new Point(13, 74);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(454, 284);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 32;
			pictureBox1.TabStop = false;
			// 
			// cardNumberTextField
			// 
			cardNumberTextField.Depth = 0;
			cardNumberTextField.Hint = "Card Number";
			cardNumberTextField.Location = new Point(28, 220);
			cardNumberTextField.Margin = new Padding(3, 4, 3, 4);
			cardNumberTextField.MaxLength = 32767;
			cardNumberTextField.MouseState = MaterialSkin.MouseState.HOVER;
			cardNumberTextField.Name = "cardNumberTextField";
			cardNumberTextField.PasswordChar = '\0';
			cardNumberTextField.SelectedText = "";
			cardNumberTextField.SelectionLength = 0;
			cardNumberTextField.SelectionStart = 0;
			cardNumberTextField.Size = new Size(422, 28);
			cardNumberTextField.TabIndex = 33;
			cardNumberTextField.TabStop = false;
			cardNumberTextField.UseSystemPasswordChar = false;
			cardNumberTextField.KeyPress += cardNumberTextField_KeyPress;
			// 
			// cvvTextField
			// 
			cvvTextField.Depth = 0;
			cvvTextField.Hint = "CVV";
			cvvTextField.Location = new Point(28, 293);
			cvvTextField.Margin = new Padding(3, 4, 3, 4);
			cvvTextField.MaxLength = 32767;
			cvvTextField.MouseState = MaterialSkin.MouseState.HOVER;
			cvvTextField.Name = "cvvTextField";
			cvvTextField.PasswordChar = '\0';
			cvvTextField.SelectedText = "";
			cvvTextField.SelectionLength = 0;
			cvvTextField.SelectionStart = 0;
			cvvTextField.Size = new Size(108, 28);
			cvvTextField.TabIndex = 35;
			cvvTextField.TabStop = false;
			cvvTextField.UseSystemPasswordChar = false;
			cvvTextField.KeyPress += cvvTextField_KeyPress;
			// 
			// nameTextField
			// 
			nameTextField.Depth = 0;
			nameTextField.Hint = "Name";
			nameTextField.Location = new Point(28, 257);
			nameTextField.Margin = new Padding(3, 4, 3, 4);
			nameTextField.MaxLength = 32767;
			nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
			nameTextField.Name = "nameTextField";
			nameTextField.PasswordChar = '\0';
			nameTextField.SelectedText = "";
			nameTextField.SelectionLength = 0;
			nameTextField.SelectionStart = 0;
			nameTextField.Size = new Size(117, 28);
			nameTextField.TabIndex = 36;
			nameTextField.TabStop = false;
			nameTextField.UseSystemPasswordChar = false;
			nameTextField.KeyPress += nameTextField_KeyPress;
			// 
			// surnameTextField
			// 
			surnameTextField.Depth = 0;
			surnameTextField.Hint = "Surname";
			surnameTextField.Location = new Point(162, 257);
			surnameTextField.Margin = new Padding(3, 4, 3, 4);
			surnameTextField.MaxLength = 32767;
			surnameTextField.MouseState = MaterialSkin.MouseState.HOVER;
			surnameTextField.Name = "surnameTextField";
			surnameTextField.PasswordChar = '\0';
			surnameTextField.SelectedText = "";
			surnameTextField.SelectionLength = 0;
			surnameTextField.SelectionStart = 0;
			surnameTextField.Size = new Size(171, 28);
			surnameTextField.TabIndex = 37;
			surnameTextField.TabStop = false;
			surnameTextField.UseSystemPasswordChar = false;
			surnameTextField.KeyPress += surnameTextField_KeyPress;
			// 
			// monthTextField
			// 
			monthTextField.Depth = 0;
			monthTextField.Hint = "Month";
			monthTextField.Location = new Point(184, 293);
			monthTextField.Margin = new Padding(3, 4, 3, 4);
			monthTextField.MaxLength = 32767;
			monthTextField.MouseState = MaterialSkin.MouseState.HOVER;
			monthTextField.Name = "monthTextField";
			monthTextField.PasswordChar = '\0';
			monthTextField.SelectedText = "";
			monthTextField.SelectionLength = 0;
			monthTextField.SelectionStart = 0;
			monthTextField.Size = new Size(65, 28);
			monthTextField.TabIndex = 39;
			monthTextField.TabStop = false;
			monthTextField.UseSystemPasswordChar = false;
			monthTextField.KeyPress += monthTextField_KeyPress;
			// 
			// yearTextField
			// 
			yearTextField.Depth = 0;
			yearTextField.Hint = "Year";
			yearTextField.Location = new Point(252, 293);
			yearTextField.Margin = new Padding(3, 4, 3, 4);
			yearTextField.MaxLength = 32767;
			yearTextField.MouseState = MaterialSkin.MouseState.HOVER;
			yearTextField.Name = "yearTextField";
			yearTextField.PasswordChar = '\0';
			yearTextField.SelectedText = "";
			yearTextField.SelectionLength = 0;
			yearTextField.SelectionStart = 0;
			yearTextField.Size = new Size(65, 28);
			yearTextField.TabIndex = 40;
			yearTextField.TabStop = false;
			yearTextField.UseSystemPasswordChar = false;
			yearTextField.KeyPress += yearTextField_KeyPress;
			// 
			// DepositForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(701, 378);
			ControlBox = false;
			Controls.Add(yearTextField);
			Controls.Add(monthTextField);
			Controls.Add(surnameTextField);
			Controls.Add(nameTextField);
			Controls.Add(cvvTextField);
			Controls.Add(cardNumberTextField);
			Controls.Add(depositTextField);
			Controls.Add(cancelButton);
			Controls.Add(okButton);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(701, 378);
			Name = "DepositForm";
			Sizable = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Choose the amount";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private MaterialSkin.Controls.MaterialSingleLineTextField depositTextField;
        private Button cancelButton;
        private Button okButton;
		private PictureBox pictureBox1;
		private MaterialSkin.Controls.MaterialSingleLineTextField cardNumberTextField;
		private MaterialSkin.Controls.MaterialSingleLineTextField cvvTextField;
		private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
		private MaterialSkin.Controls.MaterialSingleLineTextField surnameTextField;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private MaterialSkin.Controls.MaterialSingleLineTextField monthTextField;
		private MaterialSkin.Controls.MaterialSingleLineTextField yearTextField;
	}
}