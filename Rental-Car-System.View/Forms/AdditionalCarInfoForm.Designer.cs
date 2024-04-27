namespace Rental_Car_System.Forms
{
    partial class AdditionalCarInfoForm
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
            countryLabel = new Label();
            colorLabel = new Label();
            brandLabel = new Label();
            priceLabel = new Label();
            fuelConsumptionLabel = new Label();
            carPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.BackColor = Color.Transparent;
            countryLabel.Font = new Font("Roboto", 12F);
            countryLabel.Location = new Point(201, 477);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(208, 58);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "Country:";
            countryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colorLabel
            // 
            colorLabel.BackColor = Color.Transparent;
            colorLabel.Font = new Font("Roboto", 12F);
            colorLabel.Location = new Point(12, 372);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(183, 58);
            colorLabel.TabIndex = 10;
            colorLabel.Text = "Color: ";
            colorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // brandLabel
            // 
            brandLabel.BackColor = Color.Transparent;
            brandLabel.Font = new Font("Roboto", 12F);
            brandLabel.Location = new Point(12, 477);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(183, 58);
            brandLabel.TabIndex = 11;
            brandLabel.Text = "Brand:";
            brandLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Roboto", 12F);
            priceLabel.Location = new Point(201, 372);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(208, 58);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fuelConsumptionLabel
            // 
            fuelConsumptionLabel.BackColor = Color.Transparent;
            fuelConsumptionLabel.Font = new Font("Roboto", 12F);
            fuelConsumptionLabel.Location = new Point(12, 291);
            fuelConsumptionLabel.Name = "fuelConsumptionLabel";
            fuelConsumptionLabel.Size = new Size(291, 58);
            fuelConsumptionLabel.TabIndex = 13;
            fuelConsumptionLabel.Text = "Fuel Consumption:";
            fuelConsumptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carPictureBox
            // 
            carPictureBox.BackgroundImageLayout = ImageLayout.None;
            carPictureBox.Location = new Point(12, 91);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(397, 182);
            carPictureBox.TabIndex = 14;
            carPictureBox.TabStop = false;
            // 
            // AdditionalCarInfoForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(421, 540);
            Controls.Add(carPictureBox);
            Controls.Add(fuelConsumptionLabel);
            Controls.Add(priceLabel);
            Controls.Add(brandLabel);
            Controls.Add(colorLabel);
            Controls.Add(countryLabel);
            Name = "AdditionalCarInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdditionalCarInfoForm";
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label countryLabel;
        private Label colorLabel;
        private Label brandLabel;
        private Label priceLabel;
        private Label fuelConsumptionLabel;
        private PictureBox carPictureBox;
    }
}