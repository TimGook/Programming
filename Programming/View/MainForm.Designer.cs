namespace Programming
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseSeasonButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel1 = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParseButton = new System.Windows.Forms.Button();
            this.WeekdayParsingResultLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonHandleGroupBox);
            this.Enums.Controls.Add(this.WeekdayParsingGroupBox);
            this.Enums.Controls.Add(this.EnumerationsGroupBox);
            this.Enums.Location = new System.Drawing.Point(4, 24);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(698, 579);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel1);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(353, 340);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(309, 156);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // ChooseSeasonButton
            // 
            this.ChooseSeasonButton.Location = new System.Drawing.Point(217, 47);
            this.ChooseSeasonButton.Name = "ChooseSeasonButton";
            this.ChooseSeasonButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseSeasonButton.TabIndex = 2;
            this.ChooseSeasonButton.Text = "Go!";
            this.ChooseSeasonButton.UseVisualStyleBackColor = true;
            // 
            // ChooseSeasonLabel1
            // 
            this.ChooseSeasonLabel1.AutoSize = true;
            this.ChooseSeasonLabel1.Location = new System.Drawing.Point(15, 30);
            this.ChooseSeasonLabel1.Name = "ChooseSeasonLabel1";
            this.ChooseSeasonLabel1.Size = new System.Drawing.Size(89, 15);
            this.ChooseSeasonLabel1.TabIndex = 1;
            this.ChooseSeasonLabel1.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(15, 48);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(196, 23);
            this.SeasonComboBox.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingResultLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(17, 340);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(309, 156);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParseButton
            // 
            this.WeekdayParseButton.Location = new System.Drawing.Point(217, 47);
            this.WeekdayParseButton.Name = "WeekdayParseButton";
            this.WeekdayParseButton.Size = new System.Drawing.Size(75, 23);
            this.WeekdayParseButton.TabIndex = 3;
            this.WeekdayParseButton.Text = "Parse";
            this.WeekdayParseButton.UseVisualStyleBackColor = true;
            // 
            // WeekdayParsingResultLabel
            // 
            this.WeekdayParsingResultLabel.AutoSize = true;
            this.WeekdayParsingResultLabel.Location = new System.Drawing.Point(15, 86);
            this.WeekdayParsingResultLabel.Name = "WeekdayParsingResultLabel";
            this.WeekdayParsingResultLabel.Size = new System.Drawing.Size(0, 15);
            this.WeekdayParsingResultLabel.TabIndex = 2;
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(15, 30);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(125, 15);
            this.WeekdayParsingLabel.TabIndex = 1;
            this.WeekdayParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(15, 48);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(196, 23);
            this.WeekdayParsingTextBox.TabIndex = 0;
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(17, 20);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(673, 304);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(412, 27);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(55, 15);
            this.IntLabel.TabIndex = 5;
            this.IntLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(215, 27);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(15, 27);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(121, 15);
            this.EnumsLabel.TabIndex = 3;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(412, 45);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(108, 23);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(215, 45);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(178, 244);
            this.ValuesListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(15, 45);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(178, 244);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.Click += new System.EventHandler(this.EnumsListBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private GroupBox SeasonHandleGroupBox;
        private Button ChooseSeasonButton;
        private Label ChooseSeasonLabel1;
        private ComboBox SeasonComboBox;
        private GroupBox WeekdayParsingGroupBox;
        private Button WeekdayParseButton;
        private Label WeekdayParsingResultLabel;
        private Label WeekdayParsingLabel;
        private TextBox WeekdayParsingTextBox;
        private GroupBox EnumerationsGroupBox;
        private Label IntLabel;
        private Label ValueLabel;
        private Label EnumsLabel;
        private TextBox IntValueTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}