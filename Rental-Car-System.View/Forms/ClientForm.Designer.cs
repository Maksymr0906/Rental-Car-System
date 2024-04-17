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
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.availableCarsTabPage = new System.Windows.Forms.TabPage();
            this.availableCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfManufactureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelConsumptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDamagedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myOrdersTabPage = new System.Windows.Forms.TabPage();
            this.orderedCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.availableCarsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCarsDataGridView)).BeginInit();
            this.myOrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderedCarsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CreateOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateOrderButton.FlatAppearance.BorderSize = 0;
            this.CreateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrderButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrderButton.ForeColor = System.Drawing.Color.White;
            this.CreateOrderButton.Location = new System.Drawing.Point(421, 531);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(268, 34);
            this.CreateOrderButton.TabIndex = 16;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = false;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLoginLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.userLoginLabel.Location = new System.Drawing.Point(798, 21);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(308, 46);
            this.userLoginLabel.TabIndex = 23;
            this.userLoginLabel.Text = "Logged as: ";
            this.userLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.availableCarsTabPage);
            this.tabControl.Controls.Add(this.myOrdersTabPage);
            this.tabControl.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 90);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1119, 600);
            this.tabControl.TabIndex = 24;
            // 
            // availableCarsTabPage
            // 
            this.availableCarsTabPage.Controls.Add(this.availableCarsDataGridView);
            this.availableCarsTabPage.Controls.Add(this.CreateOrderButton);
            this.availableCarsTabPage.Location = new System.Drawing.Point(4, 26);
            this.availableCarsTabPage.Name = "availableCarsTabPage";
            this.availableCarsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.availableCarsTabPage.Size = new System.Drawing.Size(1111, 570);
            this.availableCarsTabPage.TabIndex = 0;
            this.availableCarsTabPage.Text = "Available Cars";
            this.availableCarsTabPage.UseVisualStyleBackColor = true;
            // 
            // availableCarsDataGridView
            // 
            this.availableCarsDataGridView.AllowUserToAddRows = false;
            this.availableCarsDataGridView.AllowUserToResizeColumns = false;
            this.availableCarsDataGridView.AllowUserToResizeRows = false;
            this.availableCarsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.availableCarsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableCarsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.availableCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableCarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.modelColumn,
            this.countryColumn,
            this.brandColumn,
            this.colorColumn,
            this.yearOfManufactureColumn,
            this.fuelConsumptionColumn,
            this.priceColumn,
            this.isDamagedColumn});
            this.availableCarsDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.availableCarsDataGridView.Location = new System.Drawing.Point(8, 6);
            this.availableCarsDataGridView.MultiSelect = false;
            this.availableCarsDataGridView.Name = "availableCarsDataGridView";
            this.availableCarsDataGridView.ReadOnly = true;
            this.availableCarsDataGridView.RowHeadersVisible = false;
            this.availableCarsDataGridView.RowHeadersWidth = 51;
            this.availableCarsDataGridView.RowTemplate.Height = 24;
            this.availableCarsDataGridView.RowTemplate.ReadOnly = true;
            this.availableCarsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableCarsDataGridView.Size = new System.Drawing.Size(1094, 506);
            this.availableCarsDataGridView.TabIndex = 17;
            this.availableCarsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableCarsDataGridView_CellDoubleClick);
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
            // myOrdersTabPage
            // 
            this.myOrdersTabPage.Controls.Add(this.orderedCarsDataGridView);
            this.myOrdersTabPage.Location = new System.Drawing.Point(4, 26);
            this.myOrdersTabPage.Name = "myOrdersTabPage";
            this.myOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myOrdersTabPage.Size = new System.Drawing.Size(1111, 570);
            this.myOrdersTabPage.TabIndex = 1;
            this.myOrdersTabPage.Text = "My Orders";
            this.myOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // orderedCarsDataGridView
            // 
            this.orderedCarsDataGridView.AllowUserToAddRows = false;
            this.orderedCarsDataGridView.AllowUserToResizeColumns = false;
            this.orderedCarsDataGridView.AllowUserToResizeRows = false;
            this.orderedCarsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orderedCarsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderedCarsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.orderedCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderedCarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.statusColumn,
            this.commentColumn});
            this.orderedCarsDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.orderedCarsDataGridView.Location = new System.Drawing.Point(8, 6);
            this.orderedCarsDataGridView.MultiSelect = false;
            this.orderedCarsDataGridView.Name = "orderedCarsDataGridView";
            this.orderedCarsDataGridView.ReadOnly = true;
            this.orderedCarsDataGridView.RowHeadersVisible = false;
            this.orderedCarsDataGridView.RowHeadersWidth = 51;
            this.orderedCarsDataGridView.RowTemplate.Height = 24;
            this.orderedCarsDataGridView.RowTemplate.ReadOnly = true;
            this.orderedCarsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderedCarsDataGridView.Size = new System.Drawing.Size(1094, 559);
            this.orderedCarsDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 175;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Brand";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Color";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Width = 125;
            // 
            // commentColumn
            // 
            this.commentColumn.HeaderText = "Administrator\'s Comment";
            this.commentColumn.MinimumWidth = 6;
            this.commentColumn.Name = "commentColumn";
            this.commentColumn.ReadOnly = true;
            this.commentColumn.Width = 125;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 702);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.tabControl);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.tabControl.ResumeLayout(false);
            this.availableCarsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableCarsDataGridView)).EndInit();
            this.myOrdersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderedCarsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage myOrdersTabPage;
        private System.Windows.Forms.TabPage availableCarsTabPage;
        private System.Windows.Forms.DataGridView orderedCarsDataGridView;
        private System.Windows.Forms.DataGridView availableCarsDataGridView;
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
    }
}