using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.components = new System.ComponentModel.Container();
            ObjectOrientedPractics.Model.Address address2 = new ObjectOrientedPractics.Model.Address();
            this.OrdersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
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
            this.PriorityOptionsPanel = new System.Windows.Forms.Panel();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeliveryTimePanel = new System.Windows.Forms.Panel();
            this.DesiredDeliveryTimeLabel = new System.Windows.Forms.Label();
            this.DesiredDeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.OrdersTableLayoutPanel.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.PriorityOptionsPanel.SuspendLayout();
            this.DeliveryTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersTableLayoutPanel
            // 
            this.OrdersTableLayoutPanel.ColumnCount = 2;
            this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.OrdersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.OrdersTableLayoutPanel.Controls.Add(this.OrdersGroupBox, 0, 0);
            this.OrdersTableLayoutPanel.Controls.Add(this.SelectedOrderGroupBox, 1, 0);
            this.OrdersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersTableLayoutPanel.Name = "OrdersTableLayoutPanel";
            this.OrdersTableLayoutPanel.RowCount = 1;
            this.OrdersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrdersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 720F));
            this.OrdersTableLayoutPanel.Size = new System.Drawing.Size(1080, 720);
            this.OrdersTableLayoutPanel.TabIndex = 0;
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.OrdersDataGridView);
            this.OrdersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(480, 714);
            this.OrdersGroupBox.TabIndex = 2;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.DateColumn,
            this.CustomerNameColumn,
            this.TotalColumn,
            this.AddressColumn,
            this.AmountCostColumn,
            this.OrderStatusColumn});
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.RowHeadersVisible = false;
            this.OrdersDataGridView.Size = new System.Drawing.Size(474, 695);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentClick);
            // 
            // IdColumn
            // 
            this.IdColumn.Frozen = true;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateColumn
            // 
            this.DateColumn.Frozen = true;
            this.DateColumn.HeaderText = "Created";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerNameColumn
            // 
            this.CustomerNameColumn.Frozen = true;
            this.CustomerNameColumn.HeaderText = "CustomerName";
            this.CustomerNameColumn.Name = "CustomerNameColumn";
            this.CustomerNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalColumn
            // 
            this.TotalColumn.Frozen = true;
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.Frozen = true;
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountCostColumn
            // 
            this.AmountCostColumn.Frozen = true;
            this.AmountCostColumn.HeaderText = "Amount";
            this.AmountCostColumn.Name = "AmountCostColumn";
            this.AmountCostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.Frozen = true;
            this.OrderStatusColumn.HeaderText = "Status";
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SelectedOrderGroupBox
            // 
            this.SelectedOrderGroupBox.Controls.Add(this.DeliveryTimePanel);
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
            this.SelectedOrderGroupBox.Location = new System.Drawing.Point(489, 3);
            this.SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(588, 714);
            this.SelectedOrderGroupBox.TabIndex = 3;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // AmountCostLabel
            // 
            this.AmountCostLabel.AutoSize = true;
            this.AmountCostLabel.Location = new System.Drawing.Point(509, 418);
            this.AmountCostLabel.Name = "AmountCostLabel";
            this.AmountCostLabel.Size = new System.Drawing.Size(24, 15);
            this.AmountCostLabel.TabIndex = 11;
            this.AmountCostLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(536, 393);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(52, 15);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(6, 256);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(576, 134);
            this.OrderItemsListBox.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Location = new System.Drawing.Point(7, 240);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(74, 15);
            this.OrderItemsLabel.TabIndex = 8;
            this.OrderItemsLabel.Text = "Order Items:";
            // 
            // DeliveryAddressControl
            // 
            address2.Apartment = null;
            address2.Building = null;
            address2.City = null;
            address2.Country = null;
            address2.Index = 0;
            address2.Street = null;
            this.DeliveryAddressControl.Address = address2;
            this.DeliveryAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryAddressControl.Enabled = false;
            this.DeliveryAddressControl.Location = new System.Drawing.Point(6, 124);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(576, 113);
            this.DeliveryAddressControl.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(60, 70);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 6;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            this.StatusComboBox.Enter += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(60, 43);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreatedTextBox.TabIndex = 5;
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(7, 108);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(100, 15);
            this.DeliveryAddressLabel.TabIndex = 4;
            this.DeliveryAddressLabel.Text = "Delivery Address:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(7, 72);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 15);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(7, 46);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(53, 15);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(60, 17);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(7, 20);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(22, 15);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
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
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(89, 15);
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
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(84, 15);
            this.DeliveryTimeLabel.TabIndex = 0;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DeliveryTimePanel
            // 
            this.DeliveryTimePanel.Controls.Add(this.DesiredDeliveryTimeComboBox);
            this.DeliveryTimePanel.Controls.Add(this.DesiredDeliveryTimeLabel);
            this.DeliveryTimePanel.Location = new System.Drawing.Point(220, 20);
            this.DeliveryTimePanel.Name = "DeliveryTimePanel";
            this.DeliveryTimePanel.Size = new System.Drawing.Size(362, 98);
            this.DeliveryTimePanel.TabIndex = 12;
            this.DeliveryTimePanel.Visible = false;
            // 
            // DesiredDeliveryTimeLabel
            // 
            this.DesiredDeliveryTimeLabel.AutoSize = true;
            this.DesiredDeliveryTimeLabel.Location = new System.Drawing.Point(12, 52);
            this.DesiredDeliveryTimeLabel.Name = "DesiredDeliveryTimeLabel";
            this.DesiredDeliveryTimeLabel.Size = new System.Drawing.Size(130, 15);
            this.DesiredDeliveryTimeLabel.TabIndex = 0;
            this.DesiredDeliveryTimeLabel.Text = "Desired Delivery Time:";
            // 
            // DesiredDeliveryTimeComboBox
            // 
            this.DesiredDeliveryTimeComboBox.FormattingEnabled = true;
            this.DesiredDeliveryTimeComboBox.Location = new System.Drawing.Point(148, 50);
            this.DesiredDeliveryTimeComboBox.Name = "DesiredDeliveryTimeComboBox";
            this.DesiredDeliveryTimeComboBox.Size = new System.Drawing.Size(200, 21);
            this.DesiredDeliveryTimeComboBox.TabIndex = 1;
            this.DesiredDeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DesiredDeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrdersTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1080, 720);
            this.OrdersTableLayoutPanel.ResumeLayout(false);
            this.OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.PriorityOptionsPanel.ResumeLayout(false);
            this.PriorityOptionsPanel.PerformLayout();
            this.DeliveryTimePanel.ResumeLayout(false);
            this.DeliveryTimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OrdersTableLayoutPanel;
        private System.Windows.Forms.GroupBox OrdersGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox SelectedOrderGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private Controls.AddressControl DeliveryAddressControl;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label AmountCostLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Panel PriorityOptionsPanel;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.Panel DeliveryTimePanel;
        private System.Windows.Forms.ComboBox DesiredDeliveryTimeComboBox;
        private System.Windows.Forms.Label DesiredDeliveryTimeLabel;
    }
}
