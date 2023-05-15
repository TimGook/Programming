namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.HandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.HandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.HandleGroupBox.Controls.Add(this.GoButton);
            this.HandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(356, 215);
            this.HandleGroupBox.TabIndex = 2;
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
            this.ChooseSeasonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(6, 47);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(263, 21);
            this.ChooseSeasonComboBox.TabIndex = 6;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(275, 46);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HandleGroupBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(356, 215);
            this.HandleGroupBox.ResumeLayout(false);
            this.HandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.Button GoButton;
    }
}
