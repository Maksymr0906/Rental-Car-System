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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            brandTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            countryTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            modelTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            fuelConsumptionTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            priceTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            colorComboBox = new ComboBox();
            addCarButton = new Button();
            yearOfManufactureTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            colorToolTip = new ToolTip(components);
            userPictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // brandTextField
            // 
            brandTextField.Depth = 0;
            brandTextField.Hint = "Brand";
            brandTextField.Location = new Point(12, 178);
            brandTextField.Margin = new Padding(3, 4, 3, 4);
            brandTextField.MaxLength = 32767;
            brandTextField.MouseState = MaterialSkin.MouseState.HOVER;
            brandTextField.Name = "brandTextField";
            brandTextField.PasswordChar = '\0';
            brandTextField.SelectedText = "";
            brandTextField.SelectionLength = 0;
            brandTextField.SelectionStart = 0;
            brandTextField.Size = new Size(351, 28);
            brandTextField.TabIndex = 27;
            brandTextField.TabStop = false;
            brandTextField.UseSystemPasswordChar = false;
            // 
            // countryTextField
            // 
            countryTextField.Depth = 0;
            countryTextField.Hint = "Country";
            countryTextField.Location = new Point(12, 135);
            countryTextField.Margin = new Padding(3, 4, 3, 4);
            countryTextField.MaxLength = 32767;
            countryTextField.MouseState = MaterialSkin.MouseState.HOVER;
            countryTextField.Name = "countryTextField";
            countryTextField.PasswordChar = '\0';
            countryTextField.SelectedText = "";
            countryTextField.SelectionLength = 0;
            countryTextField.SelectionStart = 0;
            countryTextField.Size = new Size(351, 28);
            countryTextField.TabIndex = 25;
            countryTextField.TabStop = false;
            countryTextField.UseSystemPasswordChar = false;
            countryTextField.KeyPress += countryTextField_KeyPress;
            // 
            // modelTextField
            // 
            modelTextField.Depth = 0;
            modelTextField.Hint = "Model";
            modelTextField.Location = new Point(12, 95);
            modelTextField.Margin = new Padding(3, 4, 3, 4);
            modelTextField.MaxLength = 32767;
            modelTextField.MouseState = MaterialSkin.MouseState.HOVER;
            modelTextField.Name = "modelTextField";
            modelTextField.PasswordChar = '\0';
            modelTextField.SelectedText = "";
            modelTextField.SelectionLength = 0;
            modelTextField.SelectionStart = 0;
            modelTextField.Size = new Size(351, 28);
            modelTextField.TabIndex = 24;
            modelTextField.TabStop = false;
            modelTextField.UseSystemPasswordChar = false;
            // 
            // fuelConsumptionTextField
            // 
            fuelConsumptionTextField.Depth = 0;
            fuelConsumptionTextField.Hint = "Fuel Consumption";
            fuelConsumptionTextField.Location = new Point(12, 221);
            fuelConsumptionTextField.Margin = new Padding(3, 4, 3, 4);
            fuelConsumptionTextField.MaxLength = 32767;
            fuelConsumptionTextField.MouseState = MaterialSkin.MouseState.HOVER;
            fuelConsumptionTextField.Name = "fuelConsumptionTextField";
            fuelConsumptionTextField.PasswordChar = '\0';
            fuelConsumptionTextField.SelectedText = "";
            fuelConsumptionTextField.SelectionLength = 0;
            fuelConsumptionTextField.SelectionStart = 0;
            fuelConsumptionTextField.Size = new Size(351, 28);
            fuelConsumptionTextField.TabIndex = 33;
            fuelConsumptionTextField.TabStop = false;
            fuelConsumptionTextField.UseSystemPasswordChar = false;
            fuelConsumptionTextField.KeyPress += fuelConsumptionTextField_KeyPress;
            // 
            // priceTextField
            // 
            priceTextField.Depth = 0;
            priceTextField.Hint = "Price";
            priceTextField.Location = new Point(12, 264);
            priceTextField.Margin = new Padding(3, 4, 3, 4);
            priceTextField.MaxLength = 32767;
            priceTextField.MouseState = MaterialSkin.MouseState.HOVER;
            priceTextField.Name = "priceTextField";
            priceTextField.PasswordChar = '\0';
            priceTextField.SelectedText = "";
            priceTextField.SelectionLength = 0;
            priceTextField.SelectionStart = 0;
            priceTextField.Size = new Size(351, 28);
            priceTextField.TabIndex = 35;
            priceTextField.TabStop = false;
            priceTextField.UseSystemPasswordChar = false;
            priceTextField.KeyPress += priceTextField_KeyPress;
            // 
            // colorComboBox
            // 
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorComboBox.ForeColor = SystemColors.ControlText;
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "Blue", "Cyan", "Green", "Black", "White", "Silver", "Red", "Yellow", "Gold", "Brown" });
            colorComboBox.Location = new Point(12, 350);
            colorComboBox.Margin = new Padding(3, 4, 3, 4);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(351, 31);
            colorComboBox.TabIndex = 36;
            colorToolTip.SetToolTip(colorComboBox, "Choose the color");
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.DarkSlateGray;
            addCarButton.Cursor = Cursors.Hand;
            addCarButton.FlatAppearance.BorderSize = 0;
            addCarButton.FlatStyle = FlatStyle.Flat;
            addCarButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCarButton.ForeColor = Color.White;
            addCarButton.Location = new Point(93, 406);
            addCarButton.Margin = new Padding(3, 4, 3, 4);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(189, 42);
            addCarButton.TabIndex = 23;
            addCarButton.Text = "Add Car";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // yearOfManufactureTextField
            // 
            yearOfManufactureTextField.Depth = 0;
            yearOfManufactureTextField.Hint = "Year Of Manufacture";
            yearOfManufactureTextField.Location = new Point(12, 307);
            yearOfManufactureTextField.Margin = new Padding(3, 4, 3, 4);
            yearOfManufactureTextField.MaxLength = 32767;
            yearOfManufactureTextField.MouseState = MaterialSkin.MouseState.HOVER;
            yearOfManufactureTextField.Name = "yearOfManufactureTextField";
            yearOfManufactureTextField.PasswordChar = '\0';
            yearOfManufactureTextField.SelectedText = "";
            yearOfManufactureTextField.SelectionLength = 0;
            yearOfManufactureTextField.SelectionStart = 0;
            yearOfManufactureTextField.Size = new Size(351, 28);
            yearOfManufactureTextField.TabIndex = 39;
            yearOfManufactureTextField.TabStop = false;
            yearOfManufactureTextField.UseSystemPasswordChar = false;
            yearOfManufactureTextField.KeyPress += yearOfManufactureTextField_KeyPress;
            // 
            // userPictureBox
            // 
            userPictureBox.BackgroundImage = View.Properties.Resources.user_icon;
            userPictureBox.Image = View.Properties.Resources.car_icon1;
            userPictureBox.Location = new Point(288, 403);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(75, 60);
            userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userPictureBox.TabIndex = 40;
            userPictureBox.TabStop = false;
            userPictureBox.Tag = "1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = View.Properties.Resources.user_icon;
            pictureBox1.Image = View.Properties.Resources.car_icon1;
            pictureBox1.Location = new Point(12, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "1";
            // 
            // AddCarForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(374, 461);
            Controls.Add(pictureBox1);
            Controls.Add(userPictureBox);
            Controls.Add(yearOfManufactureTextField);
            Controls.Add(addCarButton);
            Controls.Add(colorComboBox);
            Controls.Add(priceTextField);
            Controls.Add(fuelConsumptionTextField);
            Controls.Add(brandTextField);
            Controls.Add(countryTextField);
            Controls.Add(modelTextField);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCarForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Car";
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField brandTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField countryTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField modelTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField fuelConsumptionTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField priceTextField;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button addCarButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField yearOfManufactureTextField;
        private ToolTip colorToolTip;
        private PictureBox userPictureBox;
        private PictureBox pictureBox1;
    }
}