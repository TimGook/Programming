namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumerationsTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabControl = new System.Windows.Forms.TabPage();
            this.EnumerationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.IntValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ComponentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TypeValueForParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationsTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.EnumerationTableLayoutPanel.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.ComponentsTableLayoutPanel.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumerationsTabControl
            // 
            this.EnumerationsTabControl.Controls.Add(this.EnumsTabControl);
            this.EnumerationsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumerationsTabControl.Name = "EnumerationsTabControl";
            this.EnumerationsTabControl.SelectedIndex = 0;
            this.EnumerationsTabControl.Size = new System.Drawing.Size(894, 499);
            this.EnumerationsTabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumerationTableLayoutPanel);
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabControl.Size = new System.Drawing.Size(886, 473);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
            // 
            // EnumerationTableLayoutPanel
            // 
            this.EnumerationTableLayoutPanel.ColumnCount = 1;
            this.EnumerationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationTableLayoutPanel.Controls.Add(this.EnumsGroupBox, 0, 0);
            this.EnumerationTableLayoutPanel.Controls.Add(this.ComponentsTableLayoutPanel, 0, 1);
            this.EnumerationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EnumerationTableLayoutPanel.Name = "EnumerationTableLayoutPanel";
            this.EnumerationTableLayoutPanel.RowCount = 2;
            this.EnumerationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationTableLayoutPanel.Size = new System.Drawing.Size(880, 467);
            this.EnumerationTableLayoutPanel.TabIndex = 0;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumsGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumsGroupBox.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumsGroupBox.Controls.Add(this.IntValuesTextBox);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(874, 227);
            this.EnumsGroupBox.TabIndex = 0;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(430, 25);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(222, 25);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(14, 25);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumerationLabel.TabIndex = 3;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // IntValuesTextBox
            // 
            this.IntValuesTextBox.Location = new System.Drawing.Point(433, 41);
            this.IntValuesTextBox.Name = "IntValuesTextBox";
            this.IntValuesTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntValuesTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.Location = new System.Drawing.Point(225, 41);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(188, 169);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(17, 41);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(188, 169);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ComponentsTableLayoutPanel
            // 
            this.ComponentsTableLayoutPanel.ColumnCount = 2;
            this.ComponentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentsTableLayoutPanel.Controls.Add(this.HandleGroupBox, 1, 0);
            this.ComponentsTableLayoutPanel.Controls.Add(this.ParsingGroupBox, 0, 0);
            this.ComponentsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentsTableLayoutPanel.Location = new System.Drawing.Point(3, 236);
            this.ComponentsTableLayoutPanel.Name = "ComponentsTableLayoutPanel";
            this.ComponentsTableLayoutPanel.RowCount = 1;
            this.ComponentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentsTableLayoutPanel.Size = new System.Drawing.Size(874, 228);
            this.ComponentsTableLayoutPanel.TabIndex = 1;
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.HandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.HandleGroupBox.Controls.Add(this.GoButton);
            this.HandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleGroupBox.Location = new System.Drawing.Point(440, 3);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(431, 222);
            this.HandleGroupBox.TabIndex = 1;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Sesaon Handle";
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(6, 31);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseSeasonLabel.TabIndex = 6;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // ChooseSeasonComboBox
            // 
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(6, 47);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(240, 21);
            this.ChooseSeasonComboBox.TabIndex = 6;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(252, 45);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.ResultLabel);
            this.ParsingGroupBox.Controls.Add(this.TypeValueForParsingLabel);
            this.ParsingGroupBox.Controls.Add(this.WeekdayParsingButton);
            this.ParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.ParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParsingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(431, 222);
            this.ParsingGroupBox.TabIndex = 0;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = " Weekday Parsing";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(11, 88);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 6;
            // 
            // TypeValueForParsingLabel
            // 
            this.TypeValueForParsingLabel.AutoSize = true;
            this.TypeValueForParsingLabel.Location = new System.Drawing.Point(11, 31);
            this.TypeValueForParsingLabel.Name = "TypeValueForParsingLabel";
            this.TypeValueForParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeValueForParsingLabel.TabIndex = 5;
            this.TypeValueForParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(260, 45);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 23);
            this.WeekdayParsingButton.TabIndex = 4;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(14, 47);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(240, 20);
            this.WeekdayParsingTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(894, 499);
            this.Controls.Add(this.EnumerationsTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumerationsTabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumerationTableLayoutPanel.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ComponentsTableLayoutPanel.ResumeLayout(false);
            this.HandleGroupBox.ResumeLayout(false);
            this.HandleGroupBox.PerformLayout();
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumerationsTabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        private System.Windows.Forms.TableLayoutPanel EnumerationTableLayoutPanel;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.TextBox IntValuesTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.TableLayoutPanel ComponentsTableLayoutPanel;
        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label TypeValueForParsingLabel;
    }
}

