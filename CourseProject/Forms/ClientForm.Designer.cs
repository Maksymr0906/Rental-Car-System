namespace CourseProject.Forms
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
            this.createOrderButton = new System.Windows.Forms.Button();
            this.transportDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfManufactureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelConsumptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDamagedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createOrderButton.FlatAppearance.BorderSize = 0;
            this.createOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.ForeColor = System.Drawing.Color.White;
            this.createOrderButton.Location = new System.Drawing.Point(423, 618);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(268, 34);
            this.createOrderButton.TabIndex = 16;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // transportDataGridView
            // 
            this.transportDataGridView.AllowUserToAddRows = false;
            this.transportDataGridView.AllowUserToResizeColumns = false;
            this.transportDataGridView.AllowUserToResizeRows = false;
            this.transportDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.transportDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.transportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.modelColumn,
            this.countryColumn,
            this.brandColumn,
            this.colorColumn,
            this.yearOfManufactureColumn,
            this.fuelConsumptionColumn,
            this.priceColumn,
            this.isDamagedColumn});
            this.transportDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.transportDataGridView.Location = new System.Drawing.Point(12, 80);
            this.transportDataGridView.MultiSelect = false;
            this.transportDataGridView.Name = "transportDataGridView";
            this.transportDataGridView.ReadOnly = true;
            this.transportDataGridView.RowHeadersVisible = false;
            this.transportDataGridView.RowHeadersWidth = 51;
            this.transportDataGridView.RowTemplate.Height = 24;
            this.transportDataGridView.RowTemplate.ReadOnly = true;
            this.transportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transportDataGridView.Size = new System.Drawing.Size(1094, 521);
            this.transportDataGridView.TabIndex = 17;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 125;
            // 
            // modelColumn
            // 
            this.modelColumn.HeaderText = "Model";
            this.modelColumn.MinimumWidth = 175;
            this.modelColumn.Name = "modelColumn";
            this.modelColumn.ReadOnly = true;
            this.modelColumn.Width = 175;
            // 
            // countryColumn
            // 
            this.countryColumn.HeaderText = "Country";
            this.countryColumn.MinimumWidth = 6;
            this.countryColumn.Name = "countryColumn";
            this.countryColumn.ReadOnly = true;
            this.countryColumn.Width = 125;
            // 
            // brandColumn
            // 
            this.brandColumn.HeaderText = "Brand";
            this.brandColumn.MinimumWidth = 150;
            this.brandColumn.Name = "brandColumn";
            this.brandColumn.ReadOnly = true;
            this.brandColumn.Width = 150;
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "Color";
            this.colorColumn.MinimumWidth = 100;
            this.colorColumn.Name = "colorColumn";
            this.colorColumn.ReadOnly = true;
            this.colorColumn.Width = 125;
            // 
            // yearOfManufactureColumn
            // 
            this.yearOfManufactureColumn.HeaderText = "Year";
            this.yearOfManufactureColumn.MinimumWidth = 50;
            this.yearOfManufactureColumn.Name = "yearOfManufactureColumn";
            this.yearOfManufactureColumn.ReadOnly = true;
            this.yearOfManufactureColumn.Width = 50;
            // 
            // fuelConsumptionColumn
            // 
            this.fuelConsumptionColumn.HeaderText = "Fuel";
            this.fuelConsumptionColumn.MinimumWidth = 50;
            this.fuelConsumptionColumn.Name = "fuelConsumptionColumn";
            this.fuelConsumptionColumn.ReadOnly = true;
            this.fuelConsumptionColumn.Width = 50;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 70;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 70;
            // 
            // isDamagedColumn
            // 
            this.isDamagedColumn.HeaderText = "Damaged";
            this.isDamagedColumn.MinimumWidth = 70;
            this.isDamagedColumn.Name = "isDamagedColumn";
            this.isDamagedColumn.ReadOnly = true;
            this.isDamagedColumn.Width = 70;
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLoginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.userLoginLabel.Location = new System.Drawing.Point(798, 21);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(308, 46);
            this.userLoginLabel.TabIndex = 23;
            this.userLoginLabel.Text = "Logged as: ";
            this.userLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 664);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.transportDataGridView);
            this.Controls.Add(this.createOrderButton);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.DataGridView transportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfManufactureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelConsumptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDamagedColumn;
        private System.Windows.Forms.Label userLoginLabel;
    }
}