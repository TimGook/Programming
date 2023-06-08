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
            this.WorkersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WorkersGroupBox = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.WorkersListBox = new System.Windows.Forms.ListBox();
            this.SelectedWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.EmploymentDateLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.EmploymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
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
            this.WorkersTableLayoutPanel.Size = new System.Drawing.Size(1111, 512);
            this.WorkersTableLayoutPanel.TabIndex = 0;
            // 
            // WorkersGroupBox
            // 
            this.WorkersGroupBox.Controls.Add(this.EditButton);
            this.WorkersGroupBox.Controls.Add(this.DeleteButton);
            this.WorkersGroupBox.Controls.Add(this.AddButton);
            this.WorkersGroupBox.Controls.Add(this.WorkersListBox);
            this.WorkersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WorkersGroupBox.Name = "WorkersGroupBox";
            this.WorkersGroupBox.Size = new System.Drawing.Size(421, 506);
            this.WorkersGroupBox.TabIndex = 1;
            this.WorkersGroupBox.TabStop = false;
            this.WorkersGroupBox.Text = "Workers";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(171, 452);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(90, 452);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 452);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // WorkersListBox
            // 
            this.WorkersListBox.FormattingEnabled = true;
            this.WorkersListBox.ItemHeight = 15;
            this.WorkersListBox.Location = new System.Drawing.Point(9, 22);
            this.WorkersListBox.Name = "WorkersListBox";
            this.WorkersListBox.Size = new System.Drawing.Size(387, 424);
            this.WorkersListBox.TabIndex = 0;
            // 
            // SelectedWorkerGroupBox
            // 
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
            this.SelectedWorkerGroupBox.Location = new System.Drawing.Point(430, 3);
            this.SelectedWorkerGroupBox.Name = "SelectedWorkerGroupBox";
            this.SelectedWorkerGroupBox.Size = new System.Drawing.Size(678, 506);
            this.SelectedWorkerGroupBox.TabIndex = 0;
            this.SelectedWorkerGroupBox.TabStop = false;
            this.SelectedWorkerGroupBox.Text = "SelectedWorker";
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
            this.EmploymentDateTimePicker.Location = new System.Drawing.Point(117, 102);
            this.EmploymentDateTimePicker.Name = "EmploymentDateTimePicker";
            this.EmploymentDateTimePicker.Size = new System.Drawing.Size(253, 23);
            this.EmploymentDateTimePicker.TabIndex = 3;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(117, 131);
            this.SalaryTextBox.MaxLength = 6;
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(253, 23);
            this.SalaryTextBox.TabIndex = 2;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(117, 73);
            this.PositionTextBox.MaxLength = 50;
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(506, 23);
            this.PositionTextBox.TabIndex = 1;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(117, 44);
            this.FullNameTextBox.MaxLength = 100;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(506, 23);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(117, 160);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 512);
            this.Controls.Add(this.WorkersTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "RegisterApp";
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
    }
}