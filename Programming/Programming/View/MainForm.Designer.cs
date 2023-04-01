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
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengtLlabel = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.FilmRatingTextBox = new System.Windows.Forms.TextBox();
            this.FilmRunTimeTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmNameLabel = new System.Windows.Forms.Label();
            this.FilmGenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmReleaseDateTextBox = new System.Windows.Forms.TextBox();
            this.FilmNameTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.EnumerationsTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.EnumerationTableLayoutPanel.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.ComponentsTableLayoutPanel.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumerationsTabControl
            // 
            this.EnumerationsTabControl.Controls.Add(this.EnumsTabControl);
            this.EnumerationsTabControl.Controls.Add(this.ClassesTabPage);
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
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(886, 473);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.FilmsGroupBox, 1, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 1;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(886, 473);
            this.ClassesTableLayoutPanel.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengtLlabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(437, 467);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(243, 116);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "Color:";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(242, 132);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleColorTextBox.TabIndex = 7;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(241, 312);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(75, 23);
            this.FindRectangleButton.TabIndex = 6;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(243, 67);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // LengtLlabel
            // 
            this.LengtLlabel.AutoSize = true;
            this.LengtLlabel.Location = new System.Drawing.Point(243, 19);
            this.LengtLlabel.Name = "LengtLlabel";
            this.LengtLlabel.Size = new System.Drawing.Size(43, 13);
            this.LengtLlabel.TabIndex = 4;
            this.LengtLlabel.Text = "Length:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(242, 83);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleWidthTextBox.TabIndex = 2;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(242, 35);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleLengthTextBox.TabIndex = 1;
            this.RectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.IntegralHeight = false;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(5, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.ScrollAlwaysVisible = true;
            this.RectanglesListBox.Size = new System.Drawing.Size(230, 316);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.FindFilmButton);
            this.FilmsGroupBox.Controls.Add(this.RatingLabel);
            this.FilmsGroupBox.Controls.Add(this.RunTimeLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmRatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmRunTimeTextBox);
            this.FilmsGroupBox.Controls.Add(this.GenreLabel);
            this.FilmsGroupBox.Controls.Add(this.ReleaseDateLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmNameLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmGenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmReleaseDateTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmNameTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsGroupBox.Location = new System.Drawing.Point(446, 3);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(437, 467);
            this.FilmsGroupBox.TabIndex = 1;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(242, 312);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(75, 23);
            this.FindFilmButton.TabIndex = 17;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(242, 217);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 16;
            this.RatingLabel.Text = "Rating:";
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.AutoSize = true;
            this.RunTimeLabel.Location = new System.Drawing.Point(242, 168);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(33, 13);
            this.RunTimeLabel.TabIndex = 15;
            this.RunTimeLabel.Text = "Time:";
            // 
            // FilmRatingTextBox
            // 
            this.FilmRatingTextBox.Location = new System.Drawing.Point(242, 233);
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmRatingTextBox.TabIndex = 14;
            this.FilmRatingTextBox.TextChanged += new System.EventHandler(this.FilmRatingTextBox_TextChanged);
            // 
            // FilmRunTimeTextBox
            // 
            this.FilmRunTimeTextBox.Location = new System.Drawing.Point(242, 184);
            this.FilmRunTimeTextBox.Name = "FilmRunTimeTextBox";
            this.FilmRunTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmRunTimeTextBox.TabIndex = 13;
            this.FilmRunTimeTextBox.TextChanged += new System.EventHandler(this.FilmRunTimeTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(242, 116);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 12;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(242, 67);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(32, 13);
            this.ReleaseDateLabel.TabIndex = 11;
            this.ReleaseDateLabel.Text = "Year:";
            // 
            // FilmNameLabel
            // 
            this.FilmNameLabel.AutoSize = true;
            this.FilmNameLabel.Location = new System.Drawing.Point(242, 19);
            this.FilmNameLabel.Name = "FilmNameLabel";
            this.FilmNameLabel.Size = new System.Drawing.Size(38, 13);
            this.FilmNameLabel.TabIndex = 10;
            this.FilmNameLabel.Text = "Name:";
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Location = new System.Drawing.Point(242, 132);
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmGenreTextBox.TabIndex = 7;
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged_1);
            // 
            // FilmReleaseDateTextBox
            // 
            this.FilmReleaseDateTextBox.Location = new System.Drawing.Point(242, 83);
            this.FilmReleaseDateTextBox.Name = "FilmReleaseDateTextBox";
            this.FilmReleaseDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmReleaseDateTextBox.TabIndex = 5;
            this.FilmReleaseDateTextBox.TextChanged += new System.EventHandler(this.FilmReleaseDateTextBox_TextChanged);
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Location = new System.Drawing.Point(242, 35);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmNameTextBox.TabIndex = 4;
            this.FilmNameTextBox.TextChanged += new System.EventHandler(this.FilmNameTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.IntegralHeight = false;
            this.FilmsListBox.Items.AddRange(new object[] {
            "Film 1",
            "Film 2",
            "Film 3",
            "Film 4",
            "Film 5"});
            this.FilmsListBox.Location = new System.Drawing.Point(6, 19);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.ScrollAlwaysVisible = true;
            this.FilmsListBox.Size = new System.Drawing.Size(230, 316);
            this.FilmsListBox.TabIndex = 1;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
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
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
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
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TableLayoutPanel ClassesTableLayoutPanel;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.TextBox FilmReleaseDateTextBox;
        private System.Windows.Forms.TextBox FilmNameTextBox;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.TextBox FilmGenreTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengtLlabel;
        private System.Windows.Forms.Label FilmNameLabel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.TextBox FilmRatingTextBox;
        private System.Windows.Forms.TextBox FilmRunTimeTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
    }
}

