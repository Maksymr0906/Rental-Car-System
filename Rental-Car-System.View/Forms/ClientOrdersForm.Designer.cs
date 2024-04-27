namespace Rental_Car_System.View.Forms
{
    partial class ClientOrdersForm
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
            orderedCarsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            commentColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)orderedCarsDataGridView).BeginInit();
            SuspendLayout();
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
            orderedCarsDataGridView.Location = new Point(12, 68);
            orderedCarsDataGridView.Margin = new Padding(3, 4, 3, 4);
            orderedCarsDataGridView.MultiSelect = false;
            orderedCarsDataGridView.Name = "orderedCarsDataGridView";
            orderedCarsDataGridView.ReadOnly = true;
            orderedCarsDataGridView.RowHeadersVisible = false;
            orderedCarsDataGridView.RowHeadersWidth = 51;
            orderedCarsDataGridView.RowTemplate.Height = 24;
            orderedCarsDataGridView.RowTemplate.ReadOnly = true;
            orderedCarsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderedCarsDataGridView.Size = new Size(745, 471);
            orderedCarsDataGridView.TabIndex = 19;
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
            // ClientOrdersForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(769, 552);
            Controls.Add(orderedCarsDataGridView);
            Name = "ClientOrdersForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Orders";
            ((System.ComponentModel.ISupportInitialize)orderedCarsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView orderedCarsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn statusColumn;
        private DataGridViewTextBoxColumn commentColumn;
    }
}