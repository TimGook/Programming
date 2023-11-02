namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ItemErrorsLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.ItemIdTextBox = new System.Windows.Forms.TextBox();
            this.ItemCostLabel = new System.Windows.Forms.Label();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.ApplyItemInfoChangesButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ItemTableLayoutPanel.SuspendLayout();
            this.SelectedItemGroupBox.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTableLayoutPanel
            // 
            this.ItemTableLayoutPanel.ColumnCount = 2;
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ItemTableLayoutPanel.Controls.Add(this.SelectedItemGroupBox, 1, 0);
            this.ItemTableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.ItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemTableLayoutPanel.MinimumSize = new System.Drawing.Size(640, 480);
            this.ItemTableLayoutPanel.Name = "ItemTableLayoutPanel";
            this.ItemTableLayoutPanel.RowCount = 1;
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLayoutPanel.Size = new System.Drawing.Size(1080, 720);
            this.ItemTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedItemGroupBox
            // 
            this.SelectedItemGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedItemGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedItemGroupBox.Controls.Add(this.ItemErrorsLabel);
            this.SelectedItemGroupBox.Controls.Add(this.ItemDescriptionTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.ItemDescriptionLabel);
            this.SelectedItemGroupBox.Controls.Add(this.ItemNameTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.ItemNameLabel);
            this.SelectedItemGroupBox.Controls.Add(this.ItemCostTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.ItemIdTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.ItemCostLabel);
            this.SelectedItemGroupBox.Controls.Add(this.ItemIdLabel);
            this.SelectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemGroupBox.Location = new System.Drawing.Point(435, 3);
            this.SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            this.SelectedItemGroupBox.Size = new System.Drawing.Size(642, 714);
            this.SelectedItemGroupBox.TabIndex = 0;
            this.SelectedItemGroupBox.TabStop = false;
            this.SelectedItemGroupBox.Text = "Selected Item";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(9, 82);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 10;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.Enabled = false;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(63, 79);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(397, 21);
            this.CategoryComboBox.TabIndex = 9;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ItemErrorsLabel
            // 
            this.ItemErrorsLabel.AutoSize = true;
            this.ItemErrorsLabel.Location = new System.Drawing.Point(9, 653);
            this.ItemErrorsLabel.Name = "ItemErrorsLabel";
            this.ItemErrorsLabel.Size = new System.Drawing.Size(29, 13);
            this.ItemErrorsLabel.TabIndex = 8;
            this.ItemErrorsLabel.Text = "Error";
            this.ItemErrorsLabel.Visible = false;
            // 
            // ItemDescriptionTextBox
            // 
            this.ItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDescriptionTextBox.Enabled = false;
            this.ItemDescriptionTextBox.Location = new System.Drawing.Point(12, 230);
            this.ItemDescriptionTextBox.MaxLength = 1000;
            this.ItemDescriptionTextBox.Multiline = true;
            this.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            this.ItemDescriptionTextBox.Size = new System.Drawing.Size(624, 372);
            this.ItemDescriptionTextBox.TabIndex = 7;
            this.ItemDescriptionTextBox.TextChanged += new System.EventHandler(this.ItemDescriptionTextBox_TextChanged);
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(9, 214);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.ItemDescriptionLabel.TabIndex = 6;
            this.ItemDescriptionLabel.Text = "Description:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameTextBox.Enabled = false;
            this.ItemNameTextBox.Location = new System.Drawing.Point(12, 127);
            this.ItemNameTextBox.MaxLength = 200;
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(624, 75);
            this.ItemNameTextBox.TabIndex = 5;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(9, 110);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ItemNameLabel.TabIndex = 4;
            this.ItemNameLabel.Text = "Name:";
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemCostTextBox.Enabled = false;
            this.ItemCostTextBox.Location = new System.Drawing.Point(63, 53);
            this.ItemCostTextBox.MaxLength = 6;
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(397, 20);
            this.ItemCostTextBox.TabIndex = 3;
            this.ItemCostTextBox.TextChanged += new System.EventHandler(this.ItemCostTextBox_TextChanged);
            // 
            // ItemIdTextBox
            // 
            this.ItemIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemIdTextBox.Enabled = false;
            this.ItemIdTextBox.Location = new System.Drawing.Point(64, 28);
            this.ItemIdTextBox.Name = "ItemIdTextBox";
            this.ItemIdTextBox.ReadOnly = true;
            this.ItemIdTextBox.Size = new System.Drawing.Size(396, 20);
            this.ItemIdTextBox.TabIndex = 2;
            // 
            // ItemCostLabel
            // 
            this.ItemCostLabel.AutoSize = true;
            this.ItemCostLabel.Location = new System.Drawing.Point(9, 56);
            this.ItemCostLabel.Name = "ItemCostLabel";
            this.ItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.ItemCostLabel.TabIndex = 1;
            this.ItemCostLabel.Text = "Cost:";
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Location = new System.Drawing.Point(9, 31);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.ItemIdLabel.TabIndex = 0;
            this.ItemIdLabel.Text = "ID:";
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.EditItemButton);
            this.ItemsGroupBox.Controls.Add(this.ApplyItemInfoChangesButton);
            this.ItemsGroupBox.Controls.Add(this.RemoveItemButton);
            this.ItemsGroupBox.Controls.Add(this.AddItemButton);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(426, 714);
            this.ItemsGroupBox.TabIndex = 1;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // EditItemButton
            // 
            this.EditItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditItemButton.Enabled = false;
            this.EditItemButton.Location = new System.Drawing.Point(128, 672);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(55, 36);
            this.EditItemButton.TabIndex = 5;
            this.EditItemButton.Text = "Edit";
            this.EditItemButton.UseVisualStyleBackColor = true;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // ApplyItemInfoChangesButton
            // 
            this.ApplyItemInfoChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyItemInfoChangesButton.Enabled = false;
            this.ApplyItemInfoChangesButton.Location = new System.Drawing.Point(189, 672);
            this.ApplyItemInfoChangesButton.Name = "ApplyItemInfoChangesButton";
            this.ApplyItemInfoChangesButton.Size = new System.Drawing.Size(55, 36);
            this.ApplyItemInfoChangesButton.TabIndex = 4;
            this.ApplyItemInfoChangesButton.Text = "Apply";
            this.ApplyItemInfoChangesButton.UseVisualStyleBackColor = true;
            this.ApplyItemInfoChangesButton.Visible = false;
            this.ApplyItemInfoChangesButton.Click += new System.EventHandler(this.ApplyItemInfoChangesButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Location = new System.Drawing.Point(67, 672);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(55, 36);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(6, 672);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(55, 36);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 19);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(414, 647);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1080, 720);
            this.ItemTableLayoutPanel.ResumeLayout(false);
            this.SelectedItemGroupBox.ResumeLayout(false);
            this.SelectedItemGroupBox.PerformLayout();
            this.ItemsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemTableLayoutPanel;
        private System.Windows.Forms.GroupBox SelectedItemGroupBox;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.TextBox ItemIdTextBox;
        private System.Windows.Forms.Label ItemCostLabel;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.TextBox ItemDescriptionTextBox;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.Button ApplyItemInfoChangesButton;
        private System.Windows.Forms.Label ItemErrorsLabel;
        private System.Windows.Forms.Button EditItemButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}
