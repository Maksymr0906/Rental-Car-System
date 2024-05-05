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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalCarInfoForm));
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
            countryLabel.Location = new Point(201, 361);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(190, 35);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "Country:";
            countryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colorLabel
            // 
            colorLabel.BackColor = Color.Transparent;
            colorLabel.Font = new Font("Roboto", 12F);
            colorLabel.Location = new Point(12, 305);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(183, 35);
            colorLabel.TabIndex = 10;
            colorLabel.Text = "Color: ";
            colorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // brandLabel
            // 
            brandLabel.BackColor = Color.Transparent;
            brandLabel.Font = new Font("Roboto", 12F);
            brandLabel.Location = new Point(12, 361);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(183, 35);
            brandLabel.TabIndex = 11;
            brandLabel.Text = "Brand:";
            brandLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Roboto", 12F);
            priceLabel.Location = new Point(201, 305);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(190, 35);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fuelConsumptionLabel
            // 
            fuelConsumptionLabel.BackColor = Color.Transparent;
            fuelConsumptionLabel.Font = new Font("Roboto", 12F);
            fuelConsumptionLabel.Location = new Point(12, 254);
            fuelConsumptionLabel.Name = "fuelConsumptionLabel";
            fuelConsumptionLabel.Size = new Size(291, 36);
            fuelConsumptionLabel.TabIndex = 13;
            fuelConsumptionLabel.Text = "Fuel Consumption:";
            fuelConsumptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carPictureBox
            // 
            carPictureBox.BackgroundImageLayout = ImageLayout.None;
            carPictureBox.Location = new Point(12, 69);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(379, 182);
            carPictureBox.TabIndex = 14;
            carPictureBox.TabStop = false;
            // 
            // AdditionalCarInfoForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(404, 406);
            Controls.Add(carPictureBox);
            Controls.Add(fuelConsumptionLabel);
            Controls.Add(priceLabel);
            Controls.Add(brandLabel);
            Controls.Add(colorLabel);
            Controls.Add(countryLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdditionalCarInfoForm";
            Sizable = false;
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