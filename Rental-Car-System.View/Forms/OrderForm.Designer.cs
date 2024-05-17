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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            rentToLabel = new Label();
            rentToTimePicker = new DateTimePicker();
            CreateOrderButton = new Button();
            balanceLabel = new Label();
            priceLabel = new Label();
            modelLabel = new Label();
            brandLabel = new Label();
            carPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // rentToLabel
            // 
            rentToLabel.BackColor = Color.Transparent;
            rentToLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentToLabel.Location = new Point(12, 395);
            rentToLabel.Name = "rentToLabel";
            rentToLabel.Size = new Size(97, 32);
            rentToLabel.TabIndex = 11;
            rentToLabel.Text = "Rent to: ";
            rentToLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rentToTimePicker
            // 
            rentToTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentToTimePicker.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentToTimePicker.Location = new Point(109, 395);
            rentToTimePicker.Margin = new Padding(3, 4, 3, 4);
            rentToTimePicker.Name = "rentToTimePicker";
            rentToTimePicker.Size = new Size(254, 32);
            rentToTimePicker.TabIndex = 12;
            rentToTimePicker.ValueChanged += rentToTimePicker_ValueChanged;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.BackColor = Color.DarkSlateGray;
            CreateOrderButton.Cursor = Cursors.Hand;
            CreateOrderButton.FlatAppearance.BorderSize = 0;
            CreateOrderButton.FlatStyle = FlatStyle.Flat;
            CreateOrderButton.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateOrderButton.ForeColor = Color.White;
            CreateOrderButton.Location = new Point(52, 477);
            CreateOrderButton.Margin = new Padding(3, 4, 3, 4);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(268, 42);
            CreateOrderButton.TabIndex = 17;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = false;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.BackColor = Color.White;
            balanceLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceLabel.ForeColor = SystemColors.ControlText;
            balanceLabel.Location = new Point(12, 66);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(221, 33);
            balanceLabel.TabIndex = 26;
            balanceLabel.Text = "Balance:";
            balanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(52, 441);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(268, 32);
            priceLabel.TabIndex = 27;
            priceLabel.Text = "Price: ";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modelLabel
            // 
            modelLabel.BackColor = Color.Transparent;
            modelLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modelLabel.Location = new Point(12, 309);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(421, 32);
            modelLabel.TabIndex = 28;
            modelLabel.Text = "Model:";
            modelLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // brandLabel
            // 
            brandLabel.BackColor = Color.Transparent;
            brandLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brandLabel.Location = new Point(12, 353);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(421, 32);
            brandLabel.TabIndex = 29;
            brandLabel.Text = "Brand:";
            brandLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carPictureBox
            // 
            carPictureBox.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox.Location = new Point(92, 102);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(205, 205);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 30;
            carPictureBox.TabStop = false;
            carPictureBox.Tag = "0";
            // 
            // OrderForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(379, 533);
            Controls.Add(carPictureBox);
            Controls.Add(brandLabel);
            Controls.Add(modelLabel);
            Controls.Add(priceLabel);
            Controls.Add(balanceLabel);
            Controls.Add(CreateOrderButton);
            Controls.Add(rentToTimePicker);
            Controls.Add(rentToLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(379, 533);
            Name = "OrderForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label rentToLabel;
        private System.Windows.Forms.DateTimePicker rentToTimePicker;
        private System.Windows.Forms.Button CreateOrderButton;
        private Label balanceLabel;
        private Label priceLabel;
        private Label modelLabel;
        private Label brandLabel;
        private PictureBox carPictureBox;
    }
}