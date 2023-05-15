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
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.EnumerationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ComponentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleControl = new Programming.View.Panels.SeasonHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.EnumerationsControl = new Programming.View.Panels.EnumerationsControl();
            this.RectanglesInfoControl = new Programming.View.Panels.RectanglesInfoControl();
            this.RectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.filmsInfoControl1 = new Programming.View.Panels.FilmsInfoControl();
            this.EnumerationsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumerationTableLayoutPanel.SuspendLayout();
            this.ComponentsTableLayoutPanel.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumerationsTabControl
            // 
            this.EnumerationsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumerationsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumerationsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumerationsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumerationsTabControl.Name = "EnumerationsTabControl";
            this.EnumerationsTabControl.SelectedIndex = 0;
            this.EnumerationsTabControl.Size = new System.Drawing.Size(743, 486);
            this.EnumerationsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.EnumerationTableLayoutPanel);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(735, 460);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationTableLayoutPanel
            // 
            this.EnumerationTableLayoutPanel.ColumnCount = 1;
            this.EnumerationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationTableLayoutPanel.Controls.Add(this.ComponentsTableLayoutPanel, 0, 1);
            this.EnumerationTableLayoutPanel.Controls.Add(this.EnumerationsControl, 0, 0);
            this.EnumerationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EnumerationTableLayoutPanel.Name = "EnumerationTableLayoutPanel";
            this.EnumerationTableLayoutPanel.RowCount = 2;
            this.EnumerationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationTableLayoutPanel.Size = new System.Drawing.Size(729, 454);
            this.EnumerationTableLayoutPanel.TabIndex = 0;
            // 
            // ComponentsTableLayoutPanel
            // 
            this.ComponentsTableLayoutPanel.ColumnCount = 2;
            this.ComponentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentsTableLayoutPanel.Controls.Add(this.SeasonHandleControl, 1, 0);
            this.ComponentsTableLayoutPanel.Controls.Add(this.weekdayParsingControl1, 0, 0);
            this.ComponentsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentsTableLayoutPanel.Location = new System.Drawing.Point(3, 230);
            this.ComponentsTableLayoutPanel.Name = "ComponentsTableLayoutPanel";
            this.ComponentsTableLayoutPanel.RowCount = 1;
            this.ComponentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentsTableLayoutPanel.Size = new System.Drawing.Size(723, 221);
            this.ComponentsTableLayoutPanel.TabIndex = 1;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(735, 460);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.RectanglesInfoControl, 0, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.filmsInfoControl1, 1, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 1;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(735, 460);
            this.ClassesTableLayoutPanel.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(735, 460);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleControl
            // 
            this.SeasonHandleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleControl.Location = new System.Drawing.Point(364, 3);
            this.SeasonHandleControl.Name = "SeasonHandleControl";
            this.SeasonHandleControl.Size = new System.Drawing.Size(356, 215);
            this.SeasonHandleControl.TabIndex = 3;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(3, 3);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(355, 215);
            this.weekdayParsingControl1.TabIndex = 4;
            // 
            // EnumerationsControl
            // 
            this.EnumerationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsControl.Location = new System.Drawing.Point(3, 3);
            this.EnumerationsControl.MinimumSize = new System.Drawing.Size(0, 227);
            this.EnumerationsControl.Name = "EnumerationsControl";
            this.EnumerationsControl.Size = new System.Drawing.Size(723, 227);
            this.EnumerationsControl.TabIndex = 2;
            // 
            // RectanglesInfoControl
            // 
            this.RectanglesInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesInfoControl.Location = new System.Drawing.Point(3, 3);
            this.RectanglesInfoControl.Name = "RectanglesInfoControl";
            this.RectanglesInfoControl.Size = new System.Drawing.Size(361, 454);
            this.RectanglesInfoControl.TabIndex = 2;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(0, 0);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(735, 460);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // filmsInfoControl1
            // 
            this.filmsInfoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmsInfoControl1.Location = new System.Drawing.Point(370, 3);
            this.filmsInfoControl1.Name = "filmsInfoControl1";
            this.filmsInfoControl1.Size = new System.Drawing.Size(362, 454);
            this.filmsInfoControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(743, 486);
            this.Controls.Add(this.EnumerationsTabControl);
            this.MinimumSize = new System.Drawing.Size(759, 525);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumerationsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumerationTableLayoutPanel.ResumeLayout(false);
            this.ComponentsTableLayoutPanel.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumerationsTabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TableLayoutPanel EnumerationTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ComponentsTableLayoutPanel;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TableLayoutPanel ClassesTableLayoutPanel;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl RectanglesCollisionControl;
        private View.Panels.SeasonHandleControl SeasonHandleControl;
        private View.Panels.EnumerationsControl EnumerationsControl;
        private View.Panels.RectanglesInfoControl RectanglesInfoControl;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.FilmsInfoControl filmsInfoControl1;
    }
}