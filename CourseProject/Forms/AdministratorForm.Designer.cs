namespace CourseProject.Forms
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
            this.createOrderButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
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
            this.createOrderButton.Location = new System.Drawing.Point(245, 404);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(268, 34);
            this.createOrderButton.TabIndex = 17;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = false;
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarButton.FlatAppearance.BorderSize = 0;
            this.addCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.ForeColor = System.Drawing.Color.White;
            this.addCarButton.Location = new System.Drawing.Point(677, 32);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(111, 34);
            this.addCarButton.TabIndex = 18;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.createOrderButton);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button addCarButton;
    }
}