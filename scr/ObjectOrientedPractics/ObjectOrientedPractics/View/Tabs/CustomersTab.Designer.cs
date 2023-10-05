namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.ApplyCustomerInfoChangesButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SelectedCustomerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerErrorsLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerAddressLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerFullNameLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CustomersTableLayoutPanel.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.SelectedCustomerTableLayoutPanel.SuspendLayout();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersTableLayoutPanel
            // 
            this.CustomersTableLayoutPanel.ColumnCount = 2;
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.SelectedCustomerTableLayoutPanel, 1, 0);
            this.CustomersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            this.CustomersTableLayoutPanel.RowCount = 1;
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomersTableLayoutPanel.Size = new System.Drawing.Size(650, 490);
            this.CustomersTableLayoutPanel.TabIndex = 0;
            this.CustomersTableLayoutPanel.Click += new System.EventHandler(this.ApplyCustomerInfoChangesButton_Click);
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.EditCustomerButton);
            this.CustomersGroupBox.Controls.Add(this.ApplyCustomerInfoChangesButton);
            this.CustomersGroupBox.Controls.Add(this.RemoveCustomerButton);
            this.CustomersGroupBox.Controls.Add(this.AddCustomerButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(254, 484);
            this.CustomersGroupBox.TabIndex = 1;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditCustomerButton.Enabled = false;
            this.EditCustomerButton.Location = new System.Drawing.Point(128, 442);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(55, 36);
            this.EditCustomerButton.TabIndex = 5;
            this.EditCustomerButton.Text = "Edit";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // ApplyCustomerInfoChangesButton
            // 
            this.ApplyCustomerInfoChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyCustomerInfoChangesButton.Enabled = false;
            this.ApplyCustomerInfoChangesButton.Location = new System.Drawing.Point(189, 442);
            this.ApplyCustomerInfoChangesButton.Name = "ApplyCustomerInfoChangesButton";
            this.ApplyCustomerInfoChangesButton.Size = new System.Drawing.Size(55, 36);
            this.ApplyCustomerInfoChangesButton.TabIndex = 4;
            this.ApplyCustomerInfoChangesButton.Text = "Apply";
            this.ApplyCustomerInfoChangesButton.UseVisualStyleBackColor = true;
            this.ApplyCustomerInfoChangesButton.Visible = false;
            this.ApplyCustomerInfoChangesButton.Click += new System.EventHandler(this.ApplyCustomerInfoChangesButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCustomerButton.Location = new System.Drawing.Point(67, 442);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(55, 36);
            this.RemoveCustomerButton.TabIndex = 3;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCustomerButton.Location = new System.Drawing.Point(6, 442);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(55, 36);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 19);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(242, 417);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // SelectedCustomerTableLayoutPanel
            // 
            this.SelectedCustomerTableLayoutPanel.ColumnCount = 1;
            this.SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.SelectedCustomerGroupBox, 0, 0);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.SelectedCustomerPanel, 0, 1);
            this.SelectedCustomerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerTableLayoutPanel.Location = new System.Drawing.Point(263, 3);
            this.SelectedCustomerTableLayoutPanel.Name = "SelectedCustomerTableLayoutPanel";
            this.SelectedCustomerTableLayoutPanel.RowCount = 2;
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.SelectedCustomerTableLayoutPanel.Size = new System.Drawing.Size(384, 484);
            this.SelectedCustomerTableLayoutPanel.TabIndex = 2;
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerErrorsLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.SelectedCustomerIdTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.SelectedCustomerAddressTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.SelectedCustomerFullNameTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.SelectedCustomerAddressLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.SelectedCustomerFullNameLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerIdLabel);
            this.SelectedCustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(378, 187);
            this.SelectedCustomerGroupBox.TabIndex = 0;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // CustomerErrorsLabel
            // 
            this.CustomerErrorsLabel.AutoSize = true;
            this.CustomerErrorsLabel.Location = new System.Drawing.Point(15, 164);
            this.CustomerErrorsLabel.Name = "CustomerErrorsLabel";
            this.CustomerErrorsLabel.Size = new System.Drawing.Size(29, 13);
            this.CustomerErrorsLabel.TabIndex = 6;
            this.CustomerErrorsLabel.Text = "Error";
            // 
            // SelectedCustomerIdTextBox
            // 
            this.SelectedCustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerIdTextBox.Enabled = false;
            this.SelectedCustomerIdTextBox.Location = new System.Drawing.Point(70, 17);
            this.SelectedCustomerIdTextBox.Name = "SelectedCustomerIdTextBox";
            this.SelectedCustomerIdTextBox.ReadOnly = true;
            this.SelectedCustomerIdTextBox.Size = new System.Drawing.Size(120, 20);
            this.SelectedCustomerIdTextBox.TabIndex = 5;
            // 
            // SelectedCustomerAddressTextBox
            // 
            this.SelectedCustomerAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerAddressTextBox.Enabled = false;
            this.SelectedCustomerAddressTextBox.Location = new System.Drawing.Point(69, 69);
            this.SelectedCustomerAddressTextBox.MaxLength = 1000;
            this.SelectedCustomerAddressTextBox.Multiline = true;
            this.SelectedCustomerAddressTextBox.Name = "SelectedCustomerAddressTextBox";
            this.SelectedCustomerAddressTextBox.Size = new System.Drawing.Size(303, 97);
            this.SelectedCustomerAddressTextBox.TabIndex = 4;
            this.SelectedCustomerAddressTextBox.TextChanged += new System.EventHandler(this.CustomerAddressTextBox_TextChanged);
            // 
            // SelectedCustomerFullNameTextBox
            // 
            this.SelectedCustomerFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullNameTextBox.Enabled = false;
            this.SelectedCustomerFullNameTextBox.Location = new System.Drawing.Point(69, 43);
            this.SelectedCustomerFullNameTextBox.MaxLength = 200;
            this.SelectedCustomerFullNameTextBox.Name = "SelectedCustomerFullNameTextBox";
            this.SelectedCustomerFullNameTextBox.Size = new System.Drawing.Size(303, 20);
            this.SelectedCustomerFullNameTextBox.TabIndex = 3;
            this.SelectedCustomerFullNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // SelectedCustomerAddressLabel
            // 
            this.SelectedCustomerAddressLabel.AutoSize = true;
            this.SelectedCustomerAddressLabel.Location = new System.Drawing.Point(7, 72);
            this.SelectedCustomerAddressLabel.Name = "SelectedCustomerAddressLabel";
            this.SelectedCustomerAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.SelectedCustomerAddressLabel.TabIndex = 2;
            this.SelectedCustomerAddressLabel.Text = "Address:";
            // 
            // SelectedCustomerFullNameLabel
            // 
            this.SelectedCustomerFullNameLabel.AutoSize = true;
            this.SelectedCustomerFullNameLabel.Location = new System.Drawing.Point(6, 46);
            this.SelectedCustomerFullNameLabel.Name = "SelectedCustomerFullNameLabel";
            this.SelectedCustomerFullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.SelectedCustomerFullNameLabel.TabIndex = 1;
            this.SelectedCustomerFullNameLabel.Text = "Full Name:";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(7, 16);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(21, 13);
            this.CustomerIdLabel.TabIndex = 0;
            this.CustomerIdLabel.Text = "ID:";
            // 
            // SelectedCustomerPanel
            // 
            this.SelectedCustomerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerPanel.Location = new System.Drawing.Point(3, 196);
            this.SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            this.SelectedCustomerPanel.Size = new System.Drawing.Size(378, 285);
            this.SelectedCustomerPanel.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(650, 490);
            this.CustomersTableLayoutPanel.ResumeLayout(false);
            this.CustomersGroupBox.ResumeLayout(false);
            this.SelectedCustomerTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.SelectedCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CustomersTableLayoutPanel;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.TableLayoutPanel SelectedCustomerTableLayoutPanel;
        private System.Windows.Forms.GroupBox SelectedCustomerGroupBox;
        private System.Windows.Forms.Panel SelectedCustomerPanel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.TextBox SelectedCustomerIdTextBox;
        private System.Windows.Forms.TextBox SelectedCustomerAddressTextBox;
        private System.Windows.Forms.TextBox SelectedCustomerFullNameTextBox;
        private System.Windows.Forms.Label SelectedCustomerAddressLabel;
        private System.Windows.Forms.Label SelectedCustomerFullNameLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ApplyCustomerInfoChangesButton;
        private System.Windows.Forms.Label CustomerErrorsLabel;
        private System.Windows.Forms.Button EditCustomerButton;
    }
}
