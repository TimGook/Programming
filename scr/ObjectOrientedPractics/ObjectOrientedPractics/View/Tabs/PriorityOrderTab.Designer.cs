namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrderTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.PriorityOptionsPanel = new System.Windows.Forms.Panel();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.AmountCostLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.PriorityOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedOrderGroupBox
            // 
            this.SelectedOrderGroupBox.Controls.Add(this.ClearOrderButton);
            this.SelectedOrderGroupBox.Controls.Add(this.RemoveItemButton);
            this.SelectedOrderGroupBox.Controls.Add(this.AddItemButton);
            this.SelectedOrderGroupBox.Controls.Add(this.PriorityOptionsPanel);
            this.SelectedOrderGroupBox.Controls.Add(this.AmountCostLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.AmountLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.OrderItemsListBox);
            this.SelectedOrderGroupBox.Controls.Add(this.OrderItemsLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.DeliveryAddressControl);
            this.SelectedOrderGroupBox.Controls.Add(this.StatusComboBox);
            this.SelectedOrderGroupBox.Controls.Add(this.CreatedTextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.DeliveryAddressLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.StatusLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.CreatedLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.IdLabel);
            this.SelectedOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(701, 704);
            this.SelectedOrderGroupBox.TabIndex = 4;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Location = new System.Drawing.Point(609, 442);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(86, 42);
            this.ClearOrderButton.TabIndex = 15;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(112, 442);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(86, 42);
            this.RemoveItemButton.TabIndex = 14;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(10, 442);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(86, 42);
            this.AddItemButton.TabIndex = 13;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // PriorityOptionsPanel
            // 
            this.PriorityOptionsPanel.Controls.Add(this.PriorityOptionsLabel);
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeComboBox);
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityOptionsPanel.Location = new System.Drawing.Point(242, 16);
            this.PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            this.PriorityOptionsPanel.Size = new System.Drawing.Size(340, 77);
            this.PriorityOptionsPanel.TabIndex = 12;
            this.PriorityOptionsPanel.Visible = false;
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(3, 4);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(77, 13);
            this.PriorityOptionsLabel.TabIndex = 2;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(83, 27);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(144, 21);
            this.DeliveryTimeComboBox.TabIndex = 1;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(3, 30);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.DeliveryTimeLabel.TabIndex = 0;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // AmountCostLabel
            // 
            this.AmountCostLabel.AutoSize = true;
            this.AmountCostLabel.Location = new System.Drawing.Point(536, 419);
            this.AmountCostLabel.Name = "AmountCostLabel";
            this.AmountCostLabel.Size = new System.Drawing.Size(22, 13);
            this.AmountCostLabel.TabIndex = 11;
            this.AmountCostLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(536, 393);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(46, 13);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(6, 256);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(689, 134);
            this.OrderItemsListBox.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Location = new System.Drawing.Point(7, 240);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(64, 13);
            this.OrderItemsLabel.TabIndex = 8;
            this.OrderItemsLabel.Text = "Order Items:";
            // 
            // DeliveryAddressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = 0;
            address1.Street = null;
            this.DeliveryAddressControl.Address = address1;
            this.DeliveryAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryAddressControl.Enabled = false;
            this.DeliveryAddressControl.Location = new System.Drawing.Point(6, 124);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(689, 113);
            this.DeliveryAddressControl.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(60, 70);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 6;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(60, 43);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(121, 20);
            this.CreatedTextBox.TabIndex = 5;
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(7, 108);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(89, 13);
            this.DeliveryAddressLabel.TabIndex = 4;
            this.DeliveryAddressLabel.Text = "Delivery Address:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(7, 72);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(7, 46);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(60, 17);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(121, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(7, 20);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // PriorityOrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedOrderGroupBox);
            this.Name = "PriorityOrderTab";
            this.Size = new System.Drawing.Size(701, 704);
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.PriorityOptionsPanel.ResumeLayout(false);
            this.PriorityOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectedOrderGroupBox;
        private System.Windows.Forms.Label AmountCostLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private Controls.AddressControl DeliveryAddressControl;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Panel PriorityOptionsPanel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
    }
}
