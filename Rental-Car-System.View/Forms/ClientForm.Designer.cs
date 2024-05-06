namespace Rental_Car_System.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            balanceLabel = new Label();
            myProfileButton = new Button();
            carModelButton3 = new Button();
            carModelButton2 = new Button();
            carModelButton1 = new Button();
            carPictureBox3 = new PictureBox();
            carPictureBox2 = new PictureBox();
            nextButton = new Button();
            prevButton = new Button();
            carPictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)carPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // balanceLabel
            // 
            balanceLabel.BackColor = Color.Transparent;
            balanceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balanceLabel.ForeColor = SystemColors.Window;
            balanceLabel.Location = new Point(395, 26);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(308, 37);
            balanceLabel.TabIndex = 25;
            balanceLabel.Text = "Balance:";
            balanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // myProfileButton
            // 
            myProfileButton.BackColor = Color.DarkSlateGray;
            myProfileButton.Cursor = Cursors.Hand;
            myProfileButton.FlatAppearance.BorderSize = 0;
            myProfileButton.FlatStyle = FlatStyle.Flat;
            myProfileButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myProfileButton.ForeColor = Color.White;
            myProfileButton.Location = new Point(849, 26);
            myProfileButton.Margin = new Padding(3, 4, 3, 4);
            myProfileButton.Name = "myProfileButton";
            myProfileButton.Size = new Size(261, 33);
            myProfileButton.TabIndex = 14;
            myProfileButton.Tag = "2";
            myProfileButton.Text = "My Profile";
            myProfileButton.UseVisualStyleBackColor = false;
            myProfileButton.Click += myProfileButton_Click;
            // 
            // carModelButton3
            // 
            carModelButton3.BackColor = Color.DarkSlateGray;
            carModelButton3.Cursor = Cursors.Hand;
            carModelButton3.FlatAppearance.BorderSize = 0;
            carModelButton3.FlatStyle = FlatStyle.Flat;
            carModelButton3.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carModelButton3.ForeColor = Color.White;
            carModelButton3.Location = new Point(776, 435);
            carModelButton3.Margin = new Padding(3, 4, 3, 4);
            carModelButton3.Name = "carModelButton3";
            carModelButton3.Size = new Size(248, 42);
            carModelButton3.TabIndex = 33;
            carModelButton3.Tag = "2";
            carModelButton3.UseVisualStyleBackColor = false;
            carModelButton3.Click += carModelButton_Click;
            // 
            // carModelButton2
            // 
            carModelButton2.BackColor = Color.DarkSlateGray;
            carModelButton2.Cursor = Cursors.Hand;
            carModelButton2.FlatAppearance.BorderSize = 0;
            carModelButton2.FlatStyle = FlatStyle.Flat;
            carModelButton2.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carModelButton2.ForeColor = Color.White;
            carModelButton2.Location = new Point(438, 435);
            carModelButton2.Margin = new Padding(3, 4, 3, 4);
            carModelButton2.Name = "carModelButton2";
            carModelButton2.Size = new Size(248, 42);
            carModelButton2.TabIndex = 32;
            carModelButton2.Tag = "1";
            carModelButton2.UseVisualStyleBackColor = false;
            carModelButton2.Click += carModelButton_Click;
            // 
            // carModelButton1
            // 
            carModelButton1.BackColor = Color.DarkSlateGray;
            carModelButton1.Cursor = Cursors.Hand;
            carModelButton1.FlatAppearance.BorderSize = 0;
            carModelButton1.FlatStyle = FlatStyle.Flat;
            carModelButton1.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carModelButton1.ForeColor = Color.White;
            carModelButton1.Location = new Point(91, 435);
            carModelButton1.Margin = new Padding(3, 4, 3, 4);
            carModelButton1.Name = "carModelButton1";
            carModelButton1.Size = new Size(248, 42);
            carModelButton1.TabIndex = 31;
            carModelButton1.Tag = "0";
            carModelButton1.UseVisualStyleBackColor = false;
            carModelButton1.Click += carModelButton_Click;
            // 
            // carPictureBox3
            // 
            carPictureBox3.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox3.Cursor = Cursors.Hand;
            carPictureBox3.Location = new Point(747, 128);
            carPictureBox3.Name = "carPictureBox3";
            carPictureBox3.Size = new Size(300, 300);
            carPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            carPictureBox3.TabIndex = 30;
            carPictureBox3.TabStop = false;
            carPictureBox3.Tag = "2";
            carPictureBox3.Click += carPictureBox_Click;
            // 
            // carPictureBox2
            // 
            carPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox2.Cursor = Cursors.Hand;
            carPictureBox2.Location = new Point(409, 128);
            carPictureBox2.Name = "carPictureBox2";
            carPictureBox2.Size = new Size(300, 300);
            carPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            carPictureBox2.TabIndex = 29;
            carPictureBox2.TabStop = false;
            carPictureBox2.Tag = "1";
            carPictureBox2.Click += carPictureBox_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Transparent;
            nextButton.BackgroundImage = View.Properties.Resources.right_arrow_button;
            nextButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(1060, 266);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(46, 42);
            nextButton.TabIndex = 28;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // prevButton
            // 
            prevButton.BackColor = Color.Transparent;
            prevButton.BackgroundImage = View.Properties.Resources.left_arrow_button;
            prevButton.BackgroundImageLayout = ImageLayout.Stretch;
            prevButton.Cursor = Cursors.Hand;
            prevButton.FlatAppearance.BorderSize = 0;
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prevButton.ForeColor = Color.White;
            prevButton.Location = new Point(12, 266);
            prevButton.Margin = new Padding(3, 4, 3, 4);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(46, 42);
            prevButton.TabIndex = 27;
            prevButton.UseVisualStyleBackColor = false;
            prevButton.Click += prevButton_Click;
            // 
            // carPictureBox1
            // 
            carPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox1.Cursor = Cursors.Hand;
            carPictureBox1.Location = new Point(68, 128);
            carPictureBox1.Name = "carPictureBox1";
            carPictureBox1.Size = new Size(300, 300);
            carPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            carPictureBox1.TabIndex = 26;
            carPictureBox1.TabStop = false;
            carPictureBox1.Tag = "0";
            carPictureBox1.Click += carPictureBox_Click;
            // 
            // ClientForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1118, 515);
            Controls.Add(carModelButton3);
            Controls.Add(carModelButton2);
            Controls.Add(carModelButton1);
            Controls.Add(carPictureBox3);
            Controls.Add(carPictureBox2);
            Controls.Add(nextButton);
            Controls.Add(prevButton);
            Controls.Add(carPictureBox1);
            Controls.Add(myProfileButton);
            Controls.Add(balanceLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1118, 605);
            Name = "ClientForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)carPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfManufactureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelConsumptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDamagedColumn;
        private Label balanceLabel;
        private Button myProfileButton;
        private Button carModelButton3;
        private Button carModelButton2;
        private Button carModelButton1;
        private PictureBox carPictureBox3;
        private PictureBox carPictureBox2;
        private Button nextButton;
        private Button prevButton;
        private PictureBox carPictureBox1;
    }
}