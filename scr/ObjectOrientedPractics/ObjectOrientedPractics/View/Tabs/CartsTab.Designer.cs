namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.CartsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountCostLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DiscountsPanel = new System.Windows.Forms.Panel();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DiscountAmountCostLabel = new System.Windows.Forms.Label();
            this.TotalAmountCostLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.CartsTableLayoutPanel.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.DiscountsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartsTableLayoutPanel
            // 
            this.CartsTableLayoutPanel.ColumnCount = 2;
            this.CartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.CartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.CartsTableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.CartsTableLayoutPanel.Controls.Add(this.CustomerGroupBox, 1, 0);
            this.CartsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CartsTableLayoutPanel.Name = "CartsTableLayoutPanel";
            this.CartsTableLayoutPanel.RowCount = 1;
            this.CartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CartsTableLayoutPanel.Size = new System.Drawing.Size(1080, 720);
            this.CartsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.AddToCartButton);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(426, 714);
            this.ItemsGroupBox.TabIndex = 0;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToCartButton.Location = new System.Drawing.Point(6, 668);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(92, 40);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
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
            this.ItemsListBox.Size = new System.Drawing.Size(414, 643);
            this.ItemsListBox.TabIndex = 1;
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.TotalAmountCostLabel);
            this.CustomerGroupBox.Controls.Add(this.TotalAmountLabel);
            this.CustomerGroupBox.Controls.Add(this.DiscountsPanel);
            this.CustomerGroupBox.Controls.Add(this.AmountCostLabel);
            this.CustomerGroupBox.Controls.Add(this.AmountLabel);
            this.CustomerGroupBox.Controls.Add(this.ClearCartButton);
            this.CustomerGroupBox.Controls.Add(this.RemoveItemButton);
            this.CustomerGroupBox.Controls.Add(this.CreateOrderButton);
            this.CustomerGroupBox.Controls.Add(this.CartListBox);
            this.CustomerGroupBox.Controls.Add(this.CartLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomersComboBox);
            this.CustomerGroupBox.Controls.Add(this.CustomerLabel);
            this.CustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerGroupBox.Location = new System.Drawing.Point(435, 3);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(642, 714);
            this.CustomerGroupBox.TabIndex = 1;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "CustomerCart";
            // 
            // AmountCostLabel
            // 
            this.AmountCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountCostLabel.AutoSize = true;
            this.AmountCostLabel.Location = new System.Drawing.Point(603, 332);
            this.AmountCostLabel.Name = "AmountCostLabel";
            this.AmountCostLabel.Size = new System.Drawing.Size(24, 15);
            this.AmountCostLabel.TabIndex = 8;
            this.AmountCostLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(590, 307);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(52, 15);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount:";
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(544, 359);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(92, 40);
            this.ClearCartButton.TabIndex = 6;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(433, 359);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(92, 40);
            this.RemoveItemButton.TabIndex = 5;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateOrderButton.Location = new System.Drawing.Point(6, 359);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(92, 40);
            this.CreateOrderButton.TabIndex = 4;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(6, 79);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(630, 225);
            this.CartListBox.TabIndex = 3;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(6, 63);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(32, 15);
            this.CartLabel.TabIndex = 2;
            this.CartLabel.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(67, 32);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(569, 21);
            this.CustomersComboBox.TabIndex = 1;
            this.CustomersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(6, 32);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(63, 15);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer:";
            // 
            // DiscountsPanel
            // 
            this.DiscountsPanel.Controls.Add(this.DiscountAmountCostLabel);
            this.DiscountsPanel.Controls.Add(this.DiscountsCheckedListBox);
            this.DiscountsPanel.Controls.Add(this.DiscountAmountLabel);
            this.DiscountsPanel.Controls.Add(this.DiscountsLabel);
            this.DiscountsPanel.Location = new System.Drawing.Point(7, 419);
            this.DiscountsPanel.Name = "DiscountsPanel";
            this.DiscountsPanel.Size = new System.Drawing.Size(629, 166);
            this.DiscountsPanel.TabIndex = 9;
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Location = new System.Drawing.Point(4, 4);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(64, 15);
            this.DiscountsLabel.TabIndex = 0;
            this.DiscountsLabel.Text = "Discounts:";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(523, 4);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(103, 15);
            this.DiscountAmountLabel.TabIndex = 1;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsCheckedListBox
            // 
            this.DiscountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountsCheckedListBox.CheckOnClick = true;
            this.DiscountsCheckedListBox.FormattingEnabled = true;
            this.DiscountsCheckedListBox.Location = new System.Drawing.Point(7, 23);
            this.DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            this.DiscountsCheckedListBox.Size = new System.Drawing.Size(292, 120);
            this.DiscountsCheckedListBox.TabIndex = 2;
            this.DiscountsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsCheckedListBox_SelectedIndexChanged);
            // 
            // DiscountAmountCostLabel
            // 
            this.DiscountAmountCostLabel.AutoSize = true;
            this.DiscountAmountCostLabel.Location = new System.Drawing.Point(583, 23);
            this.DiscountAmountCostLabel.Name = "DiscountAmountCostLabel";
            this.DiscountAmountCostLabel.Size = new System.Drawing.Size(24, 15);
            this.DiscountAmountCostLabel.TabIndex = 3;
            this.DiscountAmountCostLabel.Text = "0.0";
            // 
            // TotalAmountCostLabel
            // 
            this.TotalAmountCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountCostLabel.AutoSize = true;
            this.TotalAmountCostLabel.Location = new System.Drawing.Point(590, 693);
            this.TotalAmountCostLabel.Name = "TotalAmountCostLabel";
            this.TotalAmountCostLabel.Size = new System.Drawing.Size(24, 15);
            this.TotalAmountCostLabel.TabIndex = 11;
            this.TotalAmountCostLabel.Text = "0,0";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(577, 668);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(37, 15);
            this.TotalAmountLabel.TabIndex = 10;
            this.TotalAmountLabel.Text = "Total:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartsTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(1080, 720);
            this.CartsTableLayoutPanel.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.DiscountsPanel.ResumeLayout(false);
            this.DiscountsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CartsTableLayoutPanel;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomersComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label AmountCostLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Panel DiscountsPanel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.Label DiscountAmountCostLabel;
        private System.Windows.Forms.CheckedListBox DiscountsCheckedListBox;
        private System.Windows.Forms.Label TotalAmountCostLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
    }
}
