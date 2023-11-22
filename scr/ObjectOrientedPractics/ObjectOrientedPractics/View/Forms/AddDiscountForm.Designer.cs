namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
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
            this.PercentDiscountLabel = new System.Windows.Forms.Label();
            this.DiscountCategoryLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DiscountCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            this.PercentDiscountLabel.AutoSize = true;
            this.PercentDiscountLabel.Location = new System.Drawing.Point(12, 9);
            this.PercentDiscountLabel.Name = "PercentDiscountLabel";
            this.PercentDiscountLabel.Size = new System.Drawing.Size(103, 15);
            this.PercentDiscountLabel.TabIndex = 0;
            this.PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // DiscountCategoryLabel
            // 
            this.DiscountCategoryLabel.AutoSize = true;
            this.DiscountCategoryLabel.Location = new System.Drawing.Point(12, 48);
            this.DiscountCategoryLabel.Name = "DiscountCategoryLabel";
            this.DiscountCategoryLabel.Size = new System.Drawing.Size(58, 15);
            this.DiscountCategoryLabel.TabIndex = 1;
            this.DiscountCategoryLabel.Text = "Category:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(193, 90);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 32);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(274, 90);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DiscountCategoryComboBox
            // 
            this.DiscountCategoryComboBox.FormattingEnabled = true;
            this.DiscountCategoryComboBox.Location = new System.Drawing.Point(76, 45);
            this.DiscountCategoryComboBox.Name = "DiscountCategoryComboBox";
            this.DiscountCategoryComboBox.Size = new System.Drawing.Size(260, 21);
            this.DiscountCategoryComboBox.TabIndex = 4;
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 134);
            this.Controls.Add(this.DiscountCategoryComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DiscountCategoryLabel);
            this.Controls.Add(this.PercentDiscountLabel);
            this.MaximumSize = new System.Drawing.Size(379, 181);
            this.MinimumSize = new System.Drawing.Size(379, 181);
            this.Name = "AddDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PercentDiscountLabel;
        private System.Windows.Forms.Label DiscountCategoryLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox DiscountCategoryComboBox;
    }
}