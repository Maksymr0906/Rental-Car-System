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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreateApplicationButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.skipOrderTimeButton = new System.Windows.Forms.Button();
            this.orderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endRentDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateApplicationButton
            // 
            this.CreateApplicationButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CreateApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateApplicationButton.FlatAppearance.BorderSize = 0;
            this.CreateApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateApplicationButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateApplicationButton.ForeColor = System.Drawing.Color.White;
            this.CreateApplicationButton.Location = new System.Drawing.Point(316, 497);
            this.CreateApplicationButton.Name = "CreateApplicationButton";
            this.CreateApplicationButton.Size = new System.Drawing.Size(268, 34);
            this.CreateApplicationButton.TabIndex = 17;
            this.CreateApplicationButton.Text = "Create Application";
            this.CreateApplicationButton.UseVisualStyleBackColor = false;
            this.CreateApplicationButton.Click += new System.EventHandler(this.CreateApplicationButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarButton.FlatAppearance.BorderSize = 0;
            this.addCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.ForeColor = System.Drawing.Color.White;
            this.addCarButton.Location = new System.Drawing.Point(828, 497);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(111, 34);
            this.addCarButton.TabIndex = 18;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdColumn,
            this.clientNameColumn,
            this.clientSurnameColumn,
            this.carModelColumn,
            this.carColorColumn,
            this.CreateDateColumn,
            this.endRentDateColumn,
            this.priceColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ordersDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 82);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.RowTemplate.ReadOnly = true;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(930, 409);
            this.ordersDataGridView.TabIndex = 19;
            // 
            // skipOrderTimeButton
            // 
            this.skipOrderTimeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.skipOrderTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipOrderTimeButton.FlatAppearance.BorderSize = 0;
            this.skipOrderTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipOrderTimeButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipOrderTimeButton.ForeColor = System.Drawing.Color.White;
            this.skipOrderTimeButton.Location = new System.Drawing.Point(12, 497);
            this.skipOrderTimeButton.Name = "skipOrderTimeButton";
            this.skipOrderTimeButton.Size = new System.Drawing.Size(249, 34);
            this.skipOrderTimeButton.TabIndex = 20;
            this.skipOrderTimeButton.Text = "Skip Order Time";
            this.skipOrderTimeButton.UseVisualStyleBackColor = false;
            this.skipOrderTimeButton.Click += new System.EventHandler(this.skipOrderTimeButton_Click);
            // 
            // orderIdColumn
            // 
            this.orderIdColumn.HeaderText = "Order Id";
            this.orderIdColumn.MinimumWidth = 6;
            this.orderIdColumn.Name = "orderIdColumn";
            this.orderIdColumn.ReadOnly = true;
            this.orderIdColumn.Visible = false;
            this.orderIdColumn.Width = 125;
            // 
            // clientNameColumn
            // 
            this.clientNameColumn.HeaderText = "Client Name";
            this.clientNameColumn.MinimumWidth = 6;
            this.clientNameColumn.Name = "clientNameColumn";
            this.clientNameColumn.ReadOnly = true;
            this.clientNameColumn.Width = 125;
            // 
            // clientSurnameColumn
            // 
            this.clientSurnameColumn.HeaderText = "Client Surname";
            this.clientSurnameColumn.MinimumWidth = 6;
            this.clientSurnameColumn.Name = "clientSurnameColumn";
            this.clientSurnameColumn.ReadOnly = true;
            this.clientSurnameColumn.Width = 125;
            // 
            // carModelColumn
            // 
            this.carModelColumn.HeaderText = "Car Model";
            this.carModelColumn.MinimumWidth = 6;
            this.carModelColumn.Name = "carModelColumn";
            this.carModelColumn.ReadOnly = true;
            this.carModelColumn.Width = 125;
            // 
            // carColorColumn
            // 
            this.carColorColumn.HeaderText = "Car Color";
            this.carColorColumn.MinimumWidth = 6;
            this.carColorColumn.Name = "carColorColumn";
            this.carColorColumn.ReadOnly = true;
            this.carColorColumn.Width = 125;
            // 
            // CreateDateColumn
            // 
            this.CreateDateColumn.HeaderText = "Created Date";
            this.CreateDateColumn.MinimumWidth = 6;
            this.CreateDateColumn.Name = "CreateDateColumn";
            this.CreateDateColumn.ReadOnly = true;
            this.CreateDateColumn.Width = 125;
            // 
            // endRentDateColumn
            // 
            this.endRentDateColumn.HeaderText = "End Rent Date";
            this.endRentDateColumn.MinimumWidth = 6;
            this.endRentDateColumn.Name = "endRentDateColumn";
            this.endRentDateColumn.ReadOnly = true;
            this.endRentDateColumn.Visible = false;
            this.endRentDateColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 70;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 70;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 543);
            this.Controls.Add(this.skipOrderTimeButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.CreateApplicationButton);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

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