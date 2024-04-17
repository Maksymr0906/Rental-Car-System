namespace Rental_Car_System.Forms
{
    partial class AddCarForm
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
            this.brandTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.brandLabel = new System.Windows.Forms.Label();
            this.countryTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.modelTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.countryLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.fuelConsumptionTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fuelConsumptionLabel = new System.Windows.Forms.Label();
            this.yearOfManufactureLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.priceTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.yearOfManufactureTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // brandTextField
            // 
            this.brandTextField.Depth = 0;
            this.brandTextField.Hint = "";
            this.brandTextField.Location = new System.Drawing.Point(217, 180);
            this.brandTextField.MaxLength = 32767;
            this.brandTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.brandTextField.Name = "brandTextField";
            this.brandTextField.PasswordChar = '\0';
            this.brandTextField.SelectedText = "";
            this.brandTextField.SelectionLength = 0;
            this.brandTextField.SelectionStart = 0;
            this.brandTextField.Size = new System.Drawing.Size(358, 28);
            this.brandTextField.TabIndex = 27;
            this.brandTextField.TabStop = false;
            this.brandTextField.UseSystemPasswordChar = false;
            // 
            // brandLabel
            // 
            this.brandLabel.BackColor = System.Drawing.Color.Transparent;
            this.brandLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(12, 180);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(177, 28);
            this.brandLabel.TabIndex = 26;
            this.brandLabel.Text = "Brand:";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryTextField
            // 
            this.countryTextField.Depth = 0;
            this.countryTextField.Hint = "";
            this.countryTextField.Location = new System.Drawing.Point(217, 130);
            this.countryTextField.MaxLength = 32767;
            this.countryTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.countryTextField.Name = "countryTextField";
            this.countryTextField.PasswordChar = '\0';
            this.countryTextField.SelectedText = "";
            this.countryTextField.SelectionLength = 0;
            this.countryTextField.SelectionStart = 0;
            this.countryTextField.Size = new System.Drawing.Size(358, 28);
            this.countryTextField.TabIndex = 25;
            this.countryTextField.TabStop = false;
            this.countryTextField.UseSystemPasswordChar = false;
            this.countryTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countryTextField_KeyPress);
            // 
            // modelTextField
            // 
            this.modelTextField.Depth = 0;
            this.modelTextField.Hint = "";
            this.modelTextField.Location = new System.Drawing.Point(217, 80);
            this.modelTextField.MaxLength = 32767;
            this.modelTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.modelTextField.Name = "modelTextField";
            this.modelTextField.PasswordChar = '\0';
            this.modelTextField.SelectedText = "";
            this.modelTextField.SelectionLength = 0;
            this.modelTextField.SelectionStart = 0;
            this.modelTextField.Size = new System.Drawing.Size(358, 28);
            this.modelTextField.TabIndex = 24;
            this.modelTextField.TabStop = false;
            this.modelTextField.UseSystemPasswordChar = false;
            // 
            // countryLabel
            // 
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(12, 130);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(177, 28);
            this.countryLabel.TabIndex = 23;
            this.countryLabel.Text = "Country:";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelLabel
            // 
            this.modelLabel.BackColor = System.Drawing.Color.Transparent;
            this.modelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(12, 80);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(177, 28);
            this.modelLabel.TabIndex = 22;
            this.modelLabel.Text = "Model:";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fuelConsumptionTextField
            // 
            this.fuelConsumptionTextField.Depth = 0;
            this.fuelConsumptionTextField.Hint = "";
            this.fuelConsumptionTextField.Location = new System.Drawing.Point(217, 230);
            this.fuelConsumptionTextField.MaxLength = 32767;
            this.fuelConsumptionTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fuelConsumptionTextField.Name = "fuelConsumptionTextField";
            this.fuelConsumptionTextField.PasswordChar = '\0';
            this.fuelConsumptionTextField.SelectedText = "";
            this.fuelConsumptionTextField.SelectionLength = 0;
            this.fuelConsumptionTextField.SelectionStart = 0;
            this.fuelConsumptionTextField.Size = new System.Drawing.Size(358, 28);
            this.fuelConsumptionTextField.TabIndex = 33;
            this.fuelConsumptionTextField.TabStop = false;
            this.fuelConsumptionTextField.UseSystemPasswordChar = false;
            this.fuelConsumptionTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fuelConsumptionTextField_KeyPress);
            // 
            // fuelConsumptionLabel
            // 
            this.fuelConsumptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.fuelConsumptionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelConsumptionLabel.Location = new System.Drawing.Point(12, 230);
            this.fuelConsumptionLabel.Name = "fuelConsumptionLabel";
            this.fuelConsumptionLabel.Size = new System.Drawing.Size(177, 28);
            this.fuelConsumptionLabel.TabIndex = 32;
            this.fuelConsumptionLabel.Text = "Fuel Consumption:";
            this.fuelConsumptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearOfManufactureLabel
            // 
            this.yearOfManufactureLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearOfManufactureLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfManufactureLabel.Location = new System.Drawing.Point(12, 330);
            this.yearOfManufactureLabel.Name = "yearOfManufactureLabel";
            this.yearOfManufactureLabel.Size = new System.Drawing.Size(199, 28);
            this.yearOfManufactureLabel.TabIndex = 29;
            this.yearOfManufactureLabel.Text = "Year of Manufacture:";
            this.yearOfManufactureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(12, 380);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(165, 28);
            this.colorLabel.TabIndex = 28;
            this.colorLabel.Text = "Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceTextField
            // 
            this.priceTextField.Depth = 0;
            this.priceTextField.Hint = "";
            this.priceTextField.Location = new System.Drawing.Point(217, 280);
            this.priceTextField.MaxLength = 32767;
            this.priceTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceTextField.Name = "priceTextField";
            this.priceTextField.PasswordChar = '\0';
            this.priceTextField.SelectedText = "";
            this.priceTextField.SelectionLength = 0;
            this.priceTextField.SelectionStart = 0;
            this.priceTextField.Size = new System.Drawing.Size(358, 28);
            this.priceTextField.TabIndex = 35;
            this.priceTextField.TabStop = false;
            this.priceTextField.UseSystemPasswordChar = false;
            this.priceTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextField_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Blue",
            "Cyan",
            "Green",
            "Black",
            "White",
            "Silver",
            "Red",
            "Yellow",
            "Gold",
            "Brown"});
            this.colorComboBox.Location = new System.Drawing.Point(217, 380);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(268, 31);
            this.colorComboBox.TabIndex = 36;
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarButton.FlatAppearance.BorderSize = 0;
            this.addCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.ForeColor = System.Drawing.Color.White;
            this.addCarButton.Location = new System.Drawing.Point(615, 380);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(173, 34);
            this.addCarButton.TabIndex = 38;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // yearOfManufactureTextField
            // 
            this.yearOfManufactureTextField.Depth = 0;
            this.yearOfManufactureTextField.Hint = "";
            this.yearOfManufactureTextField.Location = new System.Drawing.Point(217, 330);
            this.yearOfManufactureTextField.MaxLength = 32767;
            this.yearOfManufactureTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearOfManufactureTextField.Name = "yearOfManufactureTextField";
            this.yearOfManufactureTextField.PasswordChar = '\0';
            this.yearOfManufactureTextField.SelectedText = "";
            this.yearOfManufactureTextField.SelectionLength = 0;
            this.yearOfManufactureTextField.SelectionStart = 0;
            this.yearOfManufactureTextField.Size = new System.Drawing.Size(358, 28);
            this.yearOfManufactureTextField.TabIndex = 39;
            this.yearOfManufactureTextField.TabStop = false;
            this.yearOfManufactureTextField.UseSystemPasswordChar = false;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearOfManufactureTextField);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.priceTextField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuelConsumptionTextField);
            this.Controls.Add(this.fuelConsumptionLabel);
            this.Controls.Add(this.yearOfManufactureLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.brandTextField);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.countryTextField);
            this.Controls.Add(this.modelTextField);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.modelLabel);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Car";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField brandTextField;
        private System.Windows.Forms.Label brandLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField countryTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField modelTextField;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label modelLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField fuelConsumptionTextField;
        private System.Windows.Forms.Label fuelConsumptionLabel;
        private System.Windows.Forms.Label yearOfManufactureLabel;
        private System.Windows.Forms.Label colorLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField priceTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button addCarButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField yearOfManufactureTextField;
    }
}