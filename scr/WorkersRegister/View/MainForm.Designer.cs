namespace WorkersRegister
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WorkersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WorkersGroupBox = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.WorkersListBox = new System.Windows.Forms.ListBox();
            this.SelectedWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.ApplyErrorLabel = new System.Windows.Forms.Label();
            this.SalaryErrorLabel = new System.Windows.Forms.Label();
            this.EmploymentDateErrorLabel = new System.Windows.Forms.Label();
            this.PositionErrorLabel = new System.Windows.Forms.Label();
            this.FullNameErrorLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.EmploymentDateLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.EmploymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkersTableLayoutPanel.SuspendLayout();
            this.WorkersGroupBox.SuspendLayout();
            this.SelectedWorkerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkersTableLayoutPanel
            // 
            this.WorkersTableLayoutPanel.ColumnCount = 2;
            this.WorkersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.43384F));
            this.WorkersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.56616F));
            this.WorkersTableLayoutPanel.Controls.Add(this.WorkersGroupBox, 0, 0);
            this.WorkersTableLayoutPanel.Controls.Add(this.SelectedWorkerGroupBox, 1, 0);
            this.WorkersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkersTableLayoutPanel.Name = "WorkersTableLayoutPanel";
            this.WorkersTableLayoutPanel.RowCount = 1;
            this.WorkersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WorkersTableLayoutPanel.Size = new System.Drawing.Size(1264, 521);
            this.WorkersTableLayoutPanel.TabIndex = 0;
            // 
            // WorkersGroupBox
            // 
            this.WorkersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkersGroupBox.Controls.Add(this.EditButton);
            this.WorkersGroupBox.Controls.Add(this.DeleteButton);
            this.WorkersGroupBox.Controls.Add(this.AddButton);
            this.WorkersGroupBox.Controls.Add(this.WorkersListBox);
            this.WorkersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WorkersGroupBox.Name = "WorkersGroupBox";
            this.WorkersGroupBox.Size = new System.Drawing.Size(479, 515);
            this.WorkersGroupBox.TabIndex = 1;
            this.WorkersGroupBox.TabStop = false;
            this.WorkersGroupBox.Text = "Workers";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Location = new System.Drawing.Point(177, 461);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(96, 461);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(15, 461);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // WorkersListBox
            // 
            this.WorkersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkersListBox.FormattingEnabled = true;
            this.WorkersListBox.IntegralHeight = false;
            this.WorkersListBox.ItemHeight = 15;
            this.WorkersListBox.Location = new System.Drawing.Point(16, 22);
            this.WorkersListBox.Name = "WorkersListBox";
            this.WorkersListBox.Size = new System.Drawing.Size(446, 433);
            this.WorkersListBox.TabIndex = 0;
            this.WorkersListBox.SelectedIndexChanged += new System.EventHandler(this.WorkersListBox_SelectedIndexChanged);
            // 
            // SelectedWorkerGroupBox
            // 
            this.SelectedWorkerGroupBox.Controls.Add(this.ApplyErrorLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.SalaryErrorLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.EmploymentDateErrorLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.PositionErrorLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.FullNameErrorLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.ApplyButton);
            this.SelectedWorkerGroupBox.Controls.Add(this.SalaryLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.EmploymentDateLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.PositionLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.EmploymentDateTimePicker);
            this.SelectedWorkerGroupBox.Controls.Add(this.SalaryTextBox);
            this.SelectedWorkerGroupBox.Controls.Add(this.PositionTextBox);
            this.SelectedWorkerGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedWorkerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedWorkerGroupBox.Location = new System.Drawing.Point(488, 3);
            this.SelectedWorkerGroupBox.Name = "SelectedWorkerGroupBox";
            this.SelectedWorkerGroupBox.Size = new System.Drawing.Size(773, 515);
            this.SelectedWorkerGroupBox.TabIndex = 0;
            this.SelectedWorkerGroupBox.TabStop = false;
            this.SelectedWorkerGroupBox.Text = "SelectedWorker";
            // 
            // ApplyErrorLabel
            // 
            this.ApplyErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyErrorLabel.AutoSize = true;
            this.ApplyErrorLabel.Location = new System.Drawing.Point(203, 164);
            this.ApplyErrorLabel.Name = "ApplyErrorLabel";
            this.ApplyErrorLabel.Size = new System.Drawing.Size(218, 15);
            this.ApplyErrorLabel.TabIndex = 12;
            this.ApplyErrorLabel.Text = "You need to input all data about worker.";
            this.ApplyErrorLabel.Visible = false;
            // 
            // SalaryErrorLabel
            // 
            this.SalaryErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryErrorLabel.AutoSize = true;
            this.SalaryErrorLabel.Location = new System.Drawing.Point(319, 134);
            this.SalaryErrorLabel.Name = "SalaryErrorLabel";
            this.SalaryErrorLabel.Size = new System.Drawing.Size(328, 15);
            this.SalaryErrorLabel.TabIndex = 11;
            this.SalaryErrorLabel.Text = "The salary should be a number in the range from 0 to 500000.";
            this.SalaryErrorLabel.Visible = false;
            // 
            // EmploymentDateErrorLabel
            // 
            this.EmploymentDateErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmploymentDateErrorLabel.AutoSize = true;
            this.EmploymentDateErrorLabel.Location = new System.Drawing.Point(319, 106);
            this.EmploymentDateErrorLabel.Name = "EmploymentDateErrorLabel";
            this.EmploymentDateErrorLabel.Size = new System.Drawing.Size(316, 15);
            this.EmploymentDateErrorLabel.TabIndex = 10;
            this.EmploymentDateErrorLabel.Text = "The date of employment cannot be later than today\'s date.";
            this.EmploymentDateErrorLabel.Visible = false;
            // 
            // PositionErrorLabel
            // 
            this.PositionErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionErrorLabel.AutoSize = true;
            this.PositionErrorLabel.Location = new System.Drawing.Point(432, 74);
            this.PositionErrorLabel.Name = "PositionErrorLabel";
            this.PositionErrorLabel.Size = new System.Drawing.Size(229, 15);
            this.PositionErrorLabel.TabIndex = 9;
            this.PositionErrorLabel.Text = "The position should only consist of letters.";
            this.PositionErrorLabel.Visible = false;
            // 
            // FullNameErrorLabel
            // 
            this.FullNameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameErrorLabel.AutoSize = true;
            this.FullNameErrorLabel.Location = new System.Drawing.Point(432, 45);
            this.FullNameErrorLabel.Name = "FullNameErrorLabel";
            this.FullNameErrorLabel.Size = new System.Drawing.Size(216, 15);
            this.FullNameErrorLabel.TabIndex = 8;
            this.FullNameErrorLabel.Text = "The name should only consist of letters.";
            this.FullNameErrorLabel.Visible = false;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(122, 160);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(70, 134);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(41, 15);
            this.SalaryLabel.TabIndex = 7;
            this.SalaryLabel.Text = "Salary:";
            // 
            // EmploymentDateLabel
            // 
            this.EmploymentDateLabel.AutoSize = true;
            this.EmploymentDateLabel.Location = new System.Drawing.Point(6, 108);
            this.EmploymentDateLabel.Name = "EmploymentDateLabel";
            this.EmploymentDateLabel.Size = new System.Drawing.Size(105, 15);
            this.EmploymentDateLabel.TabIndex = 6;
            this.EmploymentDateLabel.Text = "Employment Date:";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(58, 76);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(53, 15);
            this.PositionLabel.TabIndex = 5;
            this.PositionLabel.Text = "Position:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(47, 47);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // EmploymentDateTimePicker
            // 
            this.EmploymentDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmploymentDateTimePicker.Location = new System.Drawing.Point(122, 103);
            this.EmploymentDateTimePicker.Name = "EmploymentDateTimePicker";
            this.EmploymentDateTimePicker.Size = new System.Drawing.Size(193, 23);
            this.EmploymentDateTimePicker.TabIndex = 3;
            this.EmploymentDateTimePicker.ValueChanged += new System.EventHandler(this.EmploymentDateTimePicker_ValueChanged);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTextBox.Location = new System.Drawing.Point(122, 132);
            this.SalaryTextBox.MaxLength = 6;
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(193, 23);
            this.SalaryTextBox.TabIndex = 2;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(122, 74);
            this.PositionTextBox.MaxLength = 50;
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(304, 23);
            this.PositionTextBox.TabIndex = 1;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.PositionTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(122, 45);
            this.FullNameTextBox.MaxLength = 100;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(304, 23);
            this.FullNameTextBox.TabIndex = 0;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 521);
            this.Controls.Add(this.WorkersTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1280, 558);
            this.Name = "MainForm";
            this.Text = "WorkersApp";
            this.WorkersTableLayoutPanel.ResumeLayout(false);
            this.WorkersGroupBox.ResumeLayout(false);
            this.SelectedWorkerGroupBox.ResumeLayout(false);
            this.SelectedWorkerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel WorkersTableLayoutPanel;
        private GroupBox SelectedWorkerGroupBox;
        private GroupBox WorkersGroupBox;
        private Button EditButton;
        private Button DeleteButton;
        private Button AddButton;
        private ListBox WorkersListBox;
        private Label FullNameLabel;
        private DateTimePicker EmploymentDateTimePicker;
        private TextBox SalaryTextBox;
        private TextBox PositionTextBox;
        private TextBox FullNameTextBox;
        private Label SalaryLabel;
        private Label EmploymentDateLabel;
        private Label PositionLabel;
        private Button ApplyButton;
        private Label SalaryErrorLabel;
        private Label EmploymentDateErrorLabel;
        private Label PositionErrorLabel;
        private Label FullNameErrorLabel;
        private Label ApplyErrorLabel;
    }
}