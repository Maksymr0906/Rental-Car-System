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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientOrdersForm));
            orderedCarsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            commentColumn = new DataGridViewTextBoxColumn();
            createdDateColumn = new DataGridViewTextBoxColumn();
            endRentDateColumn = new DataGridViewTextBoxColumn();
            prevButton = new Button();
            nextButton = new Button();
            currentPageLabel = new Label();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderedCarsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderedCarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderedCarsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Column1, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn9, statusColumn, commentColumn, createdDateColumn, endRentDateColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            orderedCarsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
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
            orderedCarsDataGridView.Size = new Size(998, 384);
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
            // createdDateColumn
            // 
            createdDateColumn.HeaderText = "Created Date";
            createdDateColumn.MinimumWidth = 6;
            createdDateColumn.Name = "createdDateColumn";
            createdDateColumn.ReadOnly = true;
            createdDateColumn.Width = 125;
            // 
            // endRentDateColumn
            // 
            endRentDateColumn.HeaderText = "End Rent Date";
            endRentDateColumn.MinimumWidth = 6;
            endRentDateColumn.Name = "endRentDateColumn";
            endRentDateColumn.ReadOnly = true;
            endRentDateColumn.Width = 125;
            // 
            // prevButton
            // 
            prevButton.BackColor = Color.Transparent;
            prevButton.BackgroundImage = Properties.Resources.left_arrow_button;
            prevButton.BackgroundImageLayout = ImageLayout.Stretch;
            prevButton.Cursor = Cursors.Hand;
            prevButton.FlatAppearance.BorderSize = 0;
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prevButton.ForeColor = Color.White;
            prevButton.Location = new Point(396, 410);
            prevButton.Margin = new Padding(3, 4, 3, 4);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(46, 42);
            prevButton.TabIndex = 28;
            prevButton.UseVisualStyleBackColor = false;
            prevButton.Click += prevButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Transparent;
            nextButton.BackgroundImage = Properties.Resources.right_arrow_button;
            nextButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(580, 410);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(46, 42);
            nextButton.TabIndex = 30;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // currentPageLabel
            // 
            currentPageLabel.BackColor = Color.Transparent;
            currentPageLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentPageLabel.ForeColor = SystemColors.ActiveCaptionText;
            currentPageLabel.Location = new Point(448, 410);
            currentPageLabel.Name = "currentPageLabel";
            currentPageLabel.Size = new Size(126, 42);
            currentPageLabel.TabIndex = 31;
            currentPageLabel.Text = "1";
            currentPageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientOrdersForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1022, 465);
            Controls.Add(currentPageLabel);
            Controls.Add(nextButton);
            Controls.Add(prevButton);
            Controls.Add(orderedCarsDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private DataGridViewTextBoxColumn createdDateColumn;
        private DataGridViewTextBoxColumn endRentDateColumn;
        private Button prevButton;
        private Button nextButton;
        private Label currentPageLabel;
    }
}