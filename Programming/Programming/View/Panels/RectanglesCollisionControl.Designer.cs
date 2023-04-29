namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.RectanglesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.DrawnRectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.DrawnRectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.DrawnRectangleYTextBox = new System.Windows.Forms.TextBox();
            this.DrawnRectangleXTextBox = new System.Windows.Forms.TextBox();
            this.DrawnRectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.DrawnRectangleLengthLabel = new System.Windows.Forms.Label();
            this.DrawnRectangleYLabel = new System.Windows.Forms.Label();
            this.DrawnRextangleXLabel = new System.Windows.Forms.Label();
            this.SelectedDrawnRectangledLabel = new System.Windows.Forms.Label();
            this.DrawnRectangleIdLabel = new System.Windows.Forms.Label();
            this.DrawnRectangleWidthLabel = new System.Windows.Forms.Label();
            this.Rectangleslabel = new System.Windows.Forms.Label();
            this.DrawnRectanglesListBox = new System.Windows.Forms.ListBox();
            this.DeleteDrawnRectangleButton = new System.Windows.Forms.Button();
            this.AddDrawnRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.RectanglesTableLayoutPanel.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesTableLayoutPanel
            // 
            this.RectanglesTableLayoutPanel.ColumnCount = 2;
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesTableLayoutPanel.Controls.Add(this.RectangleGroupBox, 0, 0);
            this.RectanglesTableLayoutPanel.Controls.Add(this.RectanglesPanel, 1, 0);
            this.RectanglesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RectanglesTableLayoutPanel.Name = "RectanglesTableLayoutPanel";
            this.RectanglesTableLayoutPanel.RowCount = 1;
            this.RectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RectanglesTableLayoutPanel.Size = new System.Drawing.Size(1053, 709);
            this.RectanglesTableLayoutPanel.TabIndex = 1;
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleLengthTextBox);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleWidthTextBox);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleYTextBox);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleXTextBox);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleIdTextBox);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleLengthLabel);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleYLabel);
            this.RectangleGroupBox.Controls.Add(this.DrawnRextangleXLabel);
            this.RectangleGroupBox.Controls.Add(this.SelectedDrawnRectangledLabel);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleIdLabel);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectangleWidthLabel);
            this.RectangleGroupBox.Controls.Add(this.Rectangleslabel);
            this.RectangleGroupBox.Controls.Add(this.DrawnRectanglesListBox);
            this.RectangleGroupBox.Controls.Add(this.DeleteDrawnRectangleButton);
            this.RectangleGroupBox.Controls.Add(this.AddDrawnRectangleButton);
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(520, 703);
            this.RectangleGroupBox.TabIndex = 1;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangle";
            // 
            // DrawnRectangleLengthTextBox
            // 
            this.DrawnRectangleLengthTextBox.Location = new System.Drawing.Point(49, 418);
            this.DrawnRectangleLengthTextBox.Name = "DrawnRectangleLengthTextBox";
            this.DrawnRectangleLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DrawnRectangleLengthTextBox.TabIndex = 18;
            this.DrawnRectangleLengthTextBox.TextChanged += new System.EventHandler(this.DrawnRectangleLengthTextBox_TextChanged);
            // 
            // DrawnRectangleWidthTextBox
            // 
            this.DrawnRectangleWidthTextBox.Location = new System.Drawing.Point(49, 392);
            this.DrawnRectangleWidthTextBox.Name = "DrawnRectangleWidthTextBox";
            this.DrawnRectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DrawnRectangleWidthTextBox.TabIndex = 17;
            this.DrawnRectangleWidthTextBox.TextChanged += new System.EventHandler(this.DrawnRectangleWidthTextBox_TextChanged);
            // 
            // DrawnRectangleYTextBox
            // 
            this.DrawnRectangleYTextBox.Location = new System.Drawing.Point(49, 366);
            this.DrawnRectangleYTextBox.Name = "DrawnRectangleYTextBox";
            this.DrawnRectangleYTextBox.Size = new System.Drawing.Size(100, 20);
            this.DrawnRectangleYTextBox.TabIndex = 16;
            this.DrawnRectangleYTextBox.TextChanged += new System.EventHandler(this.DrawnRectangleYTextBox_TextChanged);
            // 
            // DrawnRectangleXTextBox
            // 
            this.DrawnRectangleXTextBox.Location = new System.Drawing.Point(49, 340);
            this.DrawnRectangleXTextBox.Name = "DrawnRectangleXTextBox";
            this.DrawnRectangleXTextBox.Size = new System.Drawing.Size(100, 20);
            this.DrawnRectangleXTextBox.TabIndex = 15;
            this.DrawnRectangleXTextBox.TextChanged += new System.EventHandler(this.DrawnRectangleXTextBox_TextChanged);
            // 
            // DrawnRectangleIdTextBox
            // 
            this.DrawnRectangleIdTextBox.Location = new System.Drawing.Point(49, 314);
            this.DrawnRectangleIdTextBox.Name = "DrawnRectangleIdTextBox";
            this.DrawnRectangleIdTextBox.ReadOnly = true;
            this.DrawnRectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DrawnRectangleIdTextBox.TabIndex = 14;
            // 
            // DrawnRectangleLengthLabel
            // 
            this.DrawnRectangleLengthLabel.AutoSize = true;
            this.DrawnRectangleLengthLabel.Location = new System.Drawing.Point(3, 425);
            this.DrawnRectangleLengthLabel.Name = "DrawnRectangleLengthLabel";
            this.DrawnRectangleLengthLabel.Size = new System.Drawing.Size(43, 13);
            this.DrawnRectangleLengthLabel.TabIndex = 13;
            this.DrawnRectangleLengthLabel.Text = "Length:";
            // 
            // DrawnRectangleYLabel
            // 
            this.DrawnRectangleYLabel.AutoSize = true;
            this.DrawnRectangleYLabel.Location = new System.Drawing.Point(29, 373);
            this.DrawnRectangleYLabel.Name = "DrawnRectangleYLabel";
            this.DrawnRectangleYLabel.Size = new System.Drawing.Size(17, 13);
            this.DrawnRectangleYLabel.TabIndex = 12;
            this.DrawnRectangleYLabel.Text = "Y:";
            // 
            // DrawnRextangleXLabel
            // 
            this.DrawnRextangleXLabel.AutoSize = true;
            this.DrawnRextangleXLabel.Location = new System.Drawing.Point(26, 347);
            this.DrawnRextangleXLabel.Name = "DrawnRextangleXLabel";
            this.DrawnRextangleXLabel.Size = new System.Drawing.Size(17, 13);
            this.DrawnRextangleXLabel.TabIndex = 11;
            this.DrawnRextangleXLabel.Text = "X:";
            // 
            // SelectedDrawnRectangledLabel
            // 
            this.SelectedDrawnRectangledLabel.AutoSize = true;
            this.SelectedDrawnRectangledLabel.Location = new System.Drawing.Point(6, 288);
            this.SelectedDrawnRectangledLabel.Name = "SelectedDrawnRectangledLabel";
            this.SelectedDrawnRectangledLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedDrawnRectangledLabel.TabIndex = 10;
            this.SelectedDrawnRectangledLabel.Text = "Selected Rectangle:";
            // 
            // DrawnRectangleIdLabel
            // 
            this.DrawnRectangleIdLabel.AutoSize = true;
            this.DrawnRectangleIdLabel.Location = new System.Drawing.Point(27, 321);
            this.DrawnRectangleIdLabel.Name = "DrawnRectangleIdLabel";
            this.DrawnRectangleIdLabel.Size = new System.Drawing.Size(19, 13);
            this.DrawnRectangleIdLabel.TabIndex = 9;
            this.DrawnRectangleIdLabel.Text = "Id:";
            // 
            // DrawnRectangleWidthLabel
            // 
            this.DrawnRectangleWidthLabel.AutoSize = true;
            this.DrawnRectangleWidthLabel.Location = new System.Drawing.Point(5, 399);
            this.DrawnRectangleWidthLabel.Name = "DrawnRectangleWidthLabel";
            this.DrawnRectangleWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.DrawnRectangleWidthLabel.TabIndex = 8;
            this.DrawnRectangleWidthLabel.Text = "Width:";
            // 
            // Rectangleslabel
            // 
            this.Rectangleslabel.AutoSize = true;
            this.Rectangleslabel.Location = new System.Drawing.Point(6, 17);
            this.Rectangleslabel.Name = "Rectangleslabel";
            this.Rectangleslabel.Size = new System.Drawing.Size(64, 13);
            this.Rectangleslabel.TabIndex = 7;
            this.Rectangleslabel.Text = "Rectangles:";
            // 
            // DrawnRectanglesListBox
            // 
            this.DrawnRectanglesListBox.FormattingEnabled = true;
            this.DrawnRectanglesListBox.Location = new System.Drawing.Point(6, 36);
            this.DrawnRectanglesListBox.Name = "DrawnRectanglesListBox";
            this.DrawnRectanglesListBox.Size = new System.Drawing.Size(282, 173);
            this.DrawnRectanglesListBox.TabIndex = 6;
            this.DrawnRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.DrawnRectanglesListBox_SelectedIndexChanged);
            // 
            // DeleteDrawnRectangleButton
            // 
            this.DeleteDrawnRectangleButton.BackColor = System.Drawing.Color.White;
            this.DeleteDrawnRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteDrawnRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDrawnRectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.DeleteDrawnRectangleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteDrawnRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDrawnRectangleButton.Image")));
            this.DeleteDrawnRectangleButton.Location = new System.Drawing.Point(108, 215);
            this.DeleteDrawnRectangleButton.Name = "DeleteDrawnRectangleButton";
            this.DeleteDrawnRectangleButton.Size = new System.Drawing.Size(41, 41);
            this.DeleteDrawnRectangleButton.TabIndex = 5;
            this.DeleteDrawnRectangleButton.UseMnemonic = false;
            this.DeleteDrawnRectangleButton.UseVisualStyleBackColor = false;
            this.DeleteDrawnRectangleButton.Click += new System.EventHandler(this.DeleteDrawnRectangleButton_Click);
            // 
            // AddDrawnRectangleButton
            // 
            this.AddDrawnRectangleButton.BackColor = System.Drawing.Color.White;
            this.AddDrawnRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddDrawnRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDrawnRectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.AddDrawnRectangleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddDrawnRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddDrawnRectangleButton.Image")));
            this.AddDrawnRectangleButton.Location = new System.Drawing.Point(29, 215);
            this.AddDrawnRectangleButton.Name = "AddDrawnRectangleButton";
            this.AddDrawnRectangleButton.Size = new System.Drawing.Size(41, 41);
            this.AddDrawnRectangleButton.TabIndex = 4;
            this.AddDrawnRectangleButton.UseMnemonic = false;
            this.AddDrawnRectangleButton.UseVisualStyleBackColor = false;
            this.AddDrawnRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(529, 3);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(521, 703);
            this.RectanglesPanel.TabIndex = 0;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesTableLayoutPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(1053, 709);
            this.RectanglesTableLayoutPanel.ResumeLayout(false);
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RectanglesTableLayoutPanel;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.TextBox DrawnRectangleLengthTextBox;
        private System.Windows.Forms.TextBox DrawnRectangleWidthTextBox;
        private System.Windows.Forms.TextBox DrawnRectangleYTextBox;
        private System.Windows.Forms.TextBox DrawnRectangleXTextBox;
        private System.Windows.Forms.TextBox DrawnRectangleIdTextBox;
        private System.Windows.Forms.Label DrawnRectangleLengthLabel;
        private System.Windows.Forms.Label DrawnRectangleYLabel;
        private System.Windows.Forms.Label DrawnRextangleXLabel;
        private System.Windows.Forms.Label SelectedDrawnRectangledLabel;
        private System.Windows.Forms.Label DrawnRectangleIdLabel;
        private System.Windows.Forms.Label DrawnRectangleWidthLabel;
        private System.Windows.Forms.Label Rectangleslabel;
        private System.Windows.Forms.ListBox DrawnRectanglesListBox;
        private System.Windows.Forms.Button DeleteDrawnRectangleButton;
        private System.Windows.Forms.Button AddDrawnRectangleButton;
        private System.Windows.Forms.Panel RectanglesPanel;
    }
}
