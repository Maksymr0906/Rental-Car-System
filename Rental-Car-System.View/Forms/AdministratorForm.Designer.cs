namespace Rental_Car_System.Forms
{
    partial class AdministratorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            CreateApplicationButton = new Button();
            addCarButton = new Button();
            ordersDataGridView = new DataGridView();
            orderIdColumn = new DataGridViewTextBoxColumn();
            clientNameColumn = new DataGridViewTextBoxColumn();
            clientSurnameColumn = new DataGridViewTextBoxColumn();
            carModelColumn = new DataGridViewTextBoxColumn();
            carColorColumn = new DataGridViewTextBoxColumn();
            CreateDateColumn = new DataGridViewTextBoxColumn();
            endRentDateColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            skipOrderTimeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CreateApplicationButton
            // 
            CreateApplicationButton.BackColor = Color.DarkSlateGray;
            CreateApplicationButton.Cursor = Cursors.Hand;
            CreateApplicationButton.FlatAppearance.BorderSize = 0;
            CreateApplicationButton.FlatStyle = FlatStyle.Flat;
            CreateApplicationButton.Font = new Font("Roboto", 12F);
            CreateApplicationButton.ForeColor = Color.White;
            CreateApplicationButton.Location = new Point(298, 499);
            CreateApplicationButton.Margin = new Padding(3, 4, 3, 4);
            CreateApplicationButton.Name = "CreateApplicationButton";
            CreateApplicationButton.Size = new Size(187, 42);
            CreateApplicationButton.TabIndex = 17;
            CreateApplicationButton.Text = "Create Application";
            CreateApplicationButton.UseVisualStyleBackColor = false;
            CreateApplicationButton.Click += CreateApplicationButton_Click;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.DarkSlateGray;
            addCarButton.Cursor = Cursors.Hand;
            addCarButton.FlatAppearance.BorderSize = 0;
            addCarButton.FlatStyle = FlatStyle.Flat;
            addCarButton.Font = new Font("Roboto", 12F);
            addCarButton.ForeColor = Color.White;
            addCarButton.Location = new Point(596, 499);
            addCarButton.Margin = new Padding(3, 4, 3, 4);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(111, 42);
            addCarButton.TabIndex = 18;
            addCarButton.Text = "Add Car";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.BackgroundColor = SystemColors.Window;
            ordersDataGridView.BorderStyle = BorderStyle.None;
            ordersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { orderIdColumn, clientNameColumn, clientSurnameColumn, carModelColumn, carColorColumn, CreateDateColumn, endRentDateColumn, priceColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ordersDataGridView.GridColor = SystemColors.Window;
            ordersDataGridView.Location = new Point(12, 102);
            ordersDataGridView.Margin = new Padding(3, 4, 3, 4);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ordersDataGridView.RowTemplate.Height = 24;
            ordersDataGridView.RowTemplate.ReadOnly = true;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.Size = new Size(714, 389);
            ordersDataGridView.TabIndex = 19;
            // 
            // orderIdColumn
            // 
            orderIdColumn.HeaderText = "Order Id";
            orderIdColumn.MinimumWidth = 6;
            orderIdColumn.Name = "orderIdColumn";
            orderIdColumn.ReadOnly = true;
            orderIdColumn.Visible = false;
            orderIdColumn.Width = 125;
            // 
            // clientNameColumn
            // 
            clientNameColumn.HeaderText = "Client Name";
            clientNameColumn.MinimumWidth = 6;
            clientNameColumn.Name = "clientNameColumn";
            clientNameColumn.ReadOnly = true;
            clientNameColumn.Width = 125;
            // 
            // clientSurnameColumn
            // 
            clientSurnameColumn.HeaderText = "Client Surname";
            clientSurnameColumn.MinimumWidth = 6;
            clientSurnameColumn.Name = "clientSurnameColumn";
            clientSurnameColumn.ReadOnly = true;
            clientSurnameColumn.Width = 125;
            // 
            // carModelColumn
            // 
            carModelColumn.HeaderText = "Car Model";
            carModelColumn.MinimumWidth = 6;
            carModelColumn.Name = "carModelColumn";
            carModelColumn.ReadOnly = true;
            carModelColumn.Width = 125;
            // 
            // carColorColumn
            // 
            carColorColumn.HeaderText = "Car Color";
            carColorColumn.MinimumWidth = 6;
            carColorColumn.Name = "carColorColumn";
            carColorColumn.ReadOnly = true;
            carColorColumn.Width = 125;
            // 
            // CreateDateColumn
            // 
            CreateDateColumn.HeaderText = "Created Date";
            CreateDateColumn.MinimumWidth = 6;
            CreateDateColumn.Name = "CreateDateColumn";
            CreateDateColumn.ReadOnly = true;
            CreateDateColumn.Width = 125;
            // 
            // endRentDateColumn
            // 
            endRentDateColumn.HeaderText = "End Rent Date";
            endRentDateColumn.MinimumWidth = 6;
            endRentDateColumn.Name = "endRentDateColumn";
            endRentDateColumn.ReadOnly = true;
            endRentDateColumn.Visible = false;
            endRentDateColumn.Width = 125;
            // 
            // priceColumn
            // 
            priceColumn.HeaderText = "Price";
            priceColumn.MinimumWidth = 70;
            priceColumn.Name = "priceColumn";
            priceColumn.ReadOnly = true;
            priceColumn.Width = 70;
            // 
            // skipOrderTimeButton
            // 
            skipOrderTimeButton.BackColor = Color.DarkSlateGray;
            skipOrderTimeButton.Cursor = Cursors.Hand;
            skipOrderTimeButton.FlatAppearance.BorderSize = 0;
            skipOrderTimeButton.FlatStyle = FlatStyle.Flat;
            skipOrderTimeButton.Font = new Font("Roboto", 12F);
            skipOrderTimeButton.ForeColor = Color.White;
            skipOrderTimeButton.Location = new Point(12, 499);
            skipOrderTimeButton.Margin = new Padding(3, 4, 3, 4);
            skipOrderTimeButton.Name = "skipOrderTimeButton";
            skipOrderTimeButton.Size = new Size(167, 42);
            skipOrderTimeButton.TabIndex = 20;
            skipOrderTimeButton.Text = "Skip Order Time";
            skipOrderTimeButton.UseVisualStyleBackColor = false;
            skipOrderTimeButton.Click += skipOrderTimeButton_Click;
            // 
            // AdministratorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(727, 554);
            Controls.Add(skipOrderTimeButton);
            Controls.Add(ordersDataGridView);
            Controls.Add(addCarButton);
            Controls.Add(CreateApplicationButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdministratorForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button CreateApplicationButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button skipOrderTimeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endRentDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
    }
}