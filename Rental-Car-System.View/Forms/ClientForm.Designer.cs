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
            userLoginLabel = new Label();
            tabControl = new TabControl();
            availableCarsTabPage = new TabPage();
            carModelButton3 = new Button();
            carModelButton2 = new Button();
            carModelButton1 = new Button();
            carPictureBox3 = new PictureBox();
            carPictureBox2 = new PictureBox();
            nextButton = new Button();
            prevButton = new Button();
            carPictureBox1 = new PictureBox();
            myOrdersTabPage = new TabPage();
            orderedCarsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            commentColumn = new DataGridViewTextBoxColumn();
            balanceLabel = new Label();
            tabControl.SuspendLayout();
            availableCarsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox1).BeginInit();
            myOrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderedCarsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userLoginLabel
            // 
            userLoginLabel.BackColor = Color.Transparent;
            userLoginLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLoginLabel.ForeColor = SystemColors.Window;
            userLoginLabel.Location = new Point(798, 26);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new Size(308, 58);
            userLoginLabel.TabIndex = 23;
            userLoginLabel.Text = "Logged as: ";
            userLoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(availableCarsTabPage);
            tabControl.Controls.Add(myOrdersTabPage);
            tabControl.Font = new Font("Roboto", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(2, 88);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1119, 750);
            tabControl.TabIndex = 24;
            // 
            // availableCarsTabPage
            // 
            availableCarsTabPage.Controls.Add(carModelButton3);
            availableCarsTabPage.Controls.Add(carModelButton2);
            availableCarsTabPage.Controls.Add(carModelButton1);
            availableCarsTabPage.Controls.Add(carPictureBox3);
            availableCarsTabPage.Controls.Add(carPictureBox2);
            availableCarsTabPage.Controls.Add(nextButton);
            availableCarsTabPage.Controls.Add(prevButton);
            availableCarsTabPage.Controls.Add(carPictureBox1);
            availableCarsTabPage.Location = new Point(4, 26);
            availableCarsTabPage.Name = "availableCarsTabPage";
            availableCarsTabPage.Padding = new Padding(3);
            availableCarsTabPage.Size = new Size(1111, 720);
            availableCarsTabPage.TabIndex = 2;
            availableCarsTabPage.Text = "Available Cars";
            availableCarsTabPage.UseVisualStyleBackColor = true;
            // 
            // carModelButton3
            // 
            carModelButton3.BackColor = Color.DarkSlateGray;
            carModelButton3.Cursor = Cursors.Hand;
            carModelButton3.FlatAppearance.BorderSize = 0;
            carModelButton3.FlatStyle = FlatStyle.Flat;
            carModelButton3.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carModelButton3.ForeColor = Color.White;
            carModelButton3.Location = new Point(773, 419);
            carModelButton3.Margin = new Padding(3, 4, 3, 4);
            carModelButton3.Name = "carModelButton3";
            carModelButton3.Size = new Size(248, 42);
            carModelButton3.TabIndex = 13;
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
            carModelButton2.Location = new Point(435, 419);
            carModelButton2.Margin = new Padding(3, 4, 3, 4);
            carModelButton2.Name = "carModelButton2";
            carModelButton2.Size = new Size(248, 42);
            carModelButton2.TabIndex = 12;
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
            carModelButton1.Location = new Point(88, 419);
            carModelButton1.Margin = new Padding(3, 4, 3, 4);
            carModelButton1.Name = "carModelButton1";
            carModelButton1.Size = new Size(248, 42);
            carModelButton1.TabIndex = 11;
            carModelButton1.Tag = "0";
            carModelButton1.UseVisualStyleBackColor = false;
            carModelButton1.Click += carModelButton_Click;
            // 
            // carPictureBox3
            // 
            carPictureBox3.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox3.Cursor = Cursors.Hand;
            carPictureBox3.Location = new Point(744, 112);
            carPictureBox3.Name = "carPictureBox3";
            carPictureBox3.Size = new Size(300, 300);
            carPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox3.TabIndex = 10;
            carPictureBox3.TabStop = false;
            carPictureBox3.Tag = "2";
            carPictureBox3.Click += carPictureBox_Click;
            // 
            // carPictureBox2
            // 
            carPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox2.Cursor = Cursors.Hand;
            carPictureBox2.Location = new Point(406, 112);
            carPictureBox2.Name = "carPictureBox2";
            carPictureBox2.Size = new Size(300, 300);
            carPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox2.TabIndex = 9;
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
            nextButton.Location = new Point(1057, 250);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(46, 42);
            nextButton.TabIndex = 8;
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
            prevButton.Location = new Point(9, 250);
            prevButton.Margin = new Padding(3, 4, 3, 4);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(46, 42);
            prevButton.TabIndex = 7;
            prevButton.UseVisualStyleBackColor = false;
            prevButton.Click += prevButton_Click;
            // 
            // carPictureBox1
            // 
            carPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox1.Cursor = Cursors.Hand;
            carPictureBox1.Location = new Point(65, 112);
            carPictureBox1.Name = "carPictureBox1";
            carPictureBox1.Size = new Size(300, 300);
            carPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox1.TabIndex = 0;
            carPictureBox1.TabStop = false;
            carPictureBox1.Tag = "0";
            carPictureBox1.Click += carPictureBox_Click;
            // 
            // myOrdersTabPage
            // 
            myOrdersTabPage.Controls.Add(orderedCarsDataGridView);
            myOrdersTabPage.Location = new Point(4, 26);
            myOrdersTabPage.Margin = new Padding(3, 4, 3, 4);
            myOrdersTabPage.Name = "myOrdersTabPage";
            myOrdersTabPage.Padding = new Padding(3, 4, 3, 4);
            myOrdersTabPage.Size = new Size(1111, 720);
            myOrdersTabPage.TabIndex = 1;
            myOrdersTabPage.Text = "My Orders";
            myOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // orderedCarsDataGridView
            // 
            orderedCarsDataGridView.AllowUserToAddRows = false;
            orderedCarsDataGridView.AllowUserToResizeColumns = false;
            orderedCarsDataGridView.AllowUserToResizeRows = false;
            orderedCarsDataGridView.BackgroundColor = SystemColors.Window;
            orderedCarsDataGridView.BorderStyle = BorderStyle.None;
            orderedCarsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            orderedCarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderedCarsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Column1, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn9, statusColumn, commentColumn });
            orderedCarsDataGridView.GridColor = SystemColors.Window;
            orderedCarsDataGridView.Location = new Point(8, 8);
            orderedCarsDataGridView.Margin = new Padding(3, 4, 3, 4);
            orderedCarsDataGridView.MultiSelect = false;
            orderedCarsDataGridView.Name = "orderedCarsDataGridView";
            orderedCarsDataGridView.ReadOnly = true;
            orderedCarsDataGridView.RowHeadersVisible = false;
            orderedCarsDataGridView.RowHeadersWidth = 51;
            orderedCarsDataGridView.RowTemplate.Height = 24;
            orderedCarsDataGridView.RowTemplate.ReadOnly = true;
            orderedCarsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderedCarsDataGridView.Size = new Size(1094, 699);
            orderedCarsDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Model";
            dataGridViewTextBoxColumn3.MinimumWidth = 175;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 175;
            // 
            // Column1
            // 
            Column1.HeaderText = "Brand";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Color";
            dataGridViewTextBoxColumn6.MinimumWidth = 100;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Price";
            dataGridViewTextBoxColumn9.MinimumWidth = 70;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 70;
            // 
            // statusColumn
            // 
            statusColumn.HeaderText = "Status";
            statusColumn.MinimumWidth = 6;
            statusColumn.Name = "statusColumn";
            statusColumn.ReadOnly = true;
            statusColumn.Width = 125;
            // 
            // commentColumn
            // 
            commentColumn.HeaderText = "Administrator's Comment";
            commentColumn.MinimumWidth = 6;
            commentColumn.Name = "commentColumn";
            commentColumn.ReadOnly = true;
            commentColumn.Width = 125;
            // 
            // balanceLabel
            // 
            balanceLabel.BackColor = Color.Transparent;
            balanceLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceLabel.ForeColor = SystemColors.Window;
            balanceLabel.Location = new Point(388, 26);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(308, 58);
            balanceLabel.TabIndex = 25;
            balanceLabel.Text = "Balance:";
            balanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 840);
            Controls.Add(balanceLabel);
            Controls.Add(userLoginLabel);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            tabControl.ResumeLayout(false);
            availableCarsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)carPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox1).EndInit();
            myOrdersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderedCarsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage myOrdersTabPage;
        private System.Windows.Forms.DataGridView orderedCarsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfManufactureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelConsumptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDamagedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentColumn;
        private TabPage availableCarsTabPage;
        private PictureBox carPictureBox1;
        private Button nextButton;
        private Button prevButton;
        private PictureBox carPictureBox3;
        private PictureBox carPictureBox2;
        private Button carModelButton3;
        private Button carModelButton2;
        private Button carModelButton1;
        private Label balanceLabel;
    }
}