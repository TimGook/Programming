namespace Programming.View.Panels
{
    partial class FilmsInfoControl
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
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.FilmsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(525, 574);
            this.FilmsGroupBox.TabIndex = 2;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(6, 341);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(230, 23);
            this.FindFilmButton.TabIndex = 17;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FilmFindButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(242, 217);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 16;
            this.RatingLabel.Text = "Rating:";
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.GenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(242, 116);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 12;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(242, 67);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(32, 13);
            this.ReleaseDateLabel.TabIndex = 11;
            this.ReleaseDateLabel.Text = "Year:";
            // 
            // FilmNameLabel
            // 
            this.FilmNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged);
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
            // FilmsInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmsGroupBox);
            this.Name = "FilmsInfoControl";
            this.Size = new System.Drawing.Size(525, 574);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.TextBox FilmRatingTextBox;
        private System.Windows.Forms.TextBox FilmRunTimeTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label FilmNameLabel;
        private System.Windows.Forms.TextBox FilmGenreTextBox;
        private System.Windows.Forms.TextBox FilmReleaseDateTextBox;
        private System.Windows.Forms.TextBox FilmNameTextBox;
        private System.Windows.Forms.ListBox FilmsListBox;
    }
}
