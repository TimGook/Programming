using WorkersApp.Model.Classes;

namespace WorkersRegister
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Обнуление времени.
        /// </summary>
        private readonly DateTime _standardDate = new DateTime(2000, 1, 1);

        /// <summary>
        /// Правильность ввода имени работника.
        /// </summary>
        private bool IsValidName = true;

        /// <summary>
        /// Правильность ввода должности работника.
        /// </summary>
        private bool IsValidPosition = true;

        /// <summary>
        /// Правильность ввода даты трудоустройства.
        /// </summary>
        private bool IsValidEmploymentDate = true;

        /// <summary>
        /// Правильность ввода зарплаты.
        /// </summary>
        private bool IsValidSalary = true;

        /// <summary>
        /// Список работников.
        /// </summary>
        private List<Worker> _workersList = new List<Worker>();

        /// <summary>
        /// Выбранный рабочий.
        /// </summary>
        private Worker _currentWorker = new Worker();

        /// <summary>
        /// Копия выбранного работника.
        /// </summary>
        private Worker _clonedCurrentWorker = new();

        /// <summary>
        /// Индекс текущего выбранного элемента для сортировки 
        /// и сохранения выбранного элемента в ListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        public MainForm()
        {
            InitializeComponent();
            _workersList = WorkersSerializer.LoadWorkers();
            WorkersListBox.DataSource = _workersList;
            ClearWorkersInfo();
            WorkersListBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
            ApplyButton.Enabled = false;
            ApplyButton.Visible = false;
        }

        private void WorkersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _clonedCurrentWorker = (Worker)_workersList[WorkersListBox.SelectedIndex].Clone();
                FullNameTextBox.Text = _clonedCurrentWorker.FullName;
                PositionTextBox.Text = _clonedCurrentWorker.Position;
                EmploymentDateTimePicker.Value = _clonedCurrentWorker.EmploymentDate;
                SalaryTextBox.Text = _clonedCurrentWorker.Salary.ToString();
                ApplyButton.Enabled = false;
                ApplyButton.Visible = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearWorkersInfo();
            WorkersListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
            ApplyButton.Enabled = true;
            ApplyButton.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (WorkersListBox.Items.Count == 0 || WorkersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentWorker = _workersList[WorkersListBox.SelectedIndex];
            _workersList.Remove(_currentWorker);
            WorkersListBox.SelectedIndex = -1;
            WorkersSerializer.Save(_workersList);
            Sort();
            ClearWorkersInfo();
            ApplyButton.Enabled = false;
            ApplyButton.Visible = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (WorkersListBox.Items.Count == 0 || WorkersListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = WorkersListBox.SelectedIndex;
            _clonedCurrentWorker = (Worker)_workersList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
            ApplyButton.Enabled = true;
            ApplyButton.Visible = true;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(FullNameTextBox.Text))
                {
                    _clonedCurrentWorker.FullName = FullNameTextBox.Text;
                    FullNameTextBox.BackColor = Color.White;
                    IsValidName = true;
                    FullNameErrorLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidName = false;
                FullNameTextBox.BackColor = Color.LightPink;
                FullNameErrorLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidName = false;
                FullNameTextBox.BackColor = Color.LightPink;
                FullNameErrorLabel.Visible = true;
                CheckData();
            }
            catch (OverflowException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                FullNameErrorLabel.Visible = true;
                CheckData();
            }
        }

        private void PositionTextBox_TextChanged(object sender, EventArgs e)
        {
            PositionTextBox.Text = PositionTextBox.Text;
            try
            {
                if (!string.IsNullOrEmpty(PositionTextBox.Text))
                {
                    _clonedCurrentWorker.Position = PositionTextBox.Text;
                    PositionTextBox.BackColor = Color.White;
                    IsValidPosition = true;
                    PositionErrorLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidPosition = false;
                PositionTextBox.BackColor = Color.LightPink;
                PositionErrorLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidPosition = false;
                PositionTextBox.BackColor = Color.LightPink;
                PositionErrorLabel.Visible = true;
                CheckData();
            }
            catch (OverflowException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                PositionErrorLabel.Visible = true;
                CheckData();
            }
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SalaryTextBox.Text))
                {
                    _clonedCurrentWorker.Salary = Int32.Parse(SalaryTextBox.Text);
                    SalaryTextBox.BackColor = Color.White;
                    IsValidSalary = true;
                    SalaryErrorLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                CheckData();
                SalaryErrorLabel.Visible = true;
            }
            catch (FormatException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                CheckData();
                SalaryErrorLabel.Visible = true;
            }
            catch (OverflowException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                CheckData();
                SalaryErrorLabel.Visible = true;
            }
        }

        private void EmploymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmploymentDateTimePicker.Value != _standardDate)
                {
                    _clonedCurrentWorker.EmploymentDate = EmploymentDateTimePicker.Value;
                    IsValidEmploymentDate = true;
                    EmploymentDateErrorLabel.Visible = false;
                    EmploymentDateTimePicker.BackColor = Color.White;
                    CheckData();
                }

            }
            catch (ArgumentException)
            {
                IsValidEmploymentDate = false;
                EmploymentDateErrorLabel.Visible = true;
                EmploymentDateTimePicker.BackColor = Color.LightPink;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                EmploymentDateErrorLabel.Visible = true;
                EmploymentDateTimePicker.BackColor = Color.LightPink;
                CheckData();
            }
            catch (OverflowException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                EmploymentDateErrorLabel.Visible = true;
                EmploymentDateTimePicker.BackColor = Color.LightPink;
                CheckData();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) ||
                string.IsNullOrEmpty(PositionTextBox.Text) ||
                string.IsNullOrEmpty(SalaryTextBox.Text))
            {
                ApplyErrorLabel.Visible = true;
            }

            if (_selectedIndex == -1)
            {
                _currentWorker = new Worker(
                    FullNameTextBox.Text,
                    PositionTextBox.Text,
                    Int32.Parse(SalaryTextBox.Text),
                    EmploymentDateTimePicker.Value
                );
                _workersList.Add(_currentWorker);
                Sort();
                WorkersSerializer.Save(_workersList);
            }
            else
            {
                _workersList[_selectedIndex] = _clonedCurrentWorker;
                _currentWorker = _clonedCurrentWorker;
            }

            Sort();
            UpdateWorkersInfo();
            WorkersSerializer.Save(_workersList);
            ToggleInputBoxes(false);
            ClearWorkersInfo();
            ApplyButton.Enabled = false;
            ApplyButton.Visible = false;
            ApplyErrorLabel.Visible = false;
        }

        /// <summary>
        /// Метод, проверяющий значения текстовых полей и не дающий их сохранить в случае неправильного ввода
        /// </summary>
        private void CheckData()
        {
            if (IsValidEmploymentDate && IsValidName && IsValidPosition && IsValidSalary)
            {
                ApplyButton.Enabled = true;
                ApplyButton.Visible = true;
            }
            else
            {
                ApplyButton.Enabled = false;
                ApplyButton.Visible = false;
            }
        }

        /// <summary>
        /// Метод, который включает или отключает все элементы.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            FullNameTextBox.Enabled = value;
            PositionTextBox.Enabled = value;
            SalaryTextBox.Enabled = value;
            EmploymentDateTimePicker.Enabled = value;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного перелёта в TextBox и ComboBox.
        /// </summary>
        private void UpdateWorkersInfo()
        {
            FullNameTextBox.Text = _currentWorker.FullName;
            PositionTextBox.Text = _currentWorker.Position;
            SalaryTextBox.Text = _currentWorker.Salary.ToString();
            EmploymentDateTimePicker.Value = _currentWorker.EmploymentDate;
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_workersList"/> и <see cref="WorkersListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = WorkersListBox.SelectedIndex;
            WorkersListBox.SelectedIndexChanged -= WorkersListBox_SelectedIndexChanged;
            _workersList = _workersList.OrderBy(worker => worker.FullName).ToList();
            WorkersListBox.DataSource = _workersList;
            WorkersListBox.SelectedIndex = _indexBeforeSort;
            WorkersListBox.SelectedIndexChanged += WorkersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearWorkersInfo()
        {
            FullNameTextBox.Clear();
            PositionTextBox.Clear();
            SalaryTextBox.Clear();
            EmploymentDateTimePicker.Value = _standardDate;
            ApplyButton.Enabled = true;
            ApplyButton.Visible = true;
            FullNameErrorLabel.Visible = false;
            PositionErrorLabel.Visible = false;
            EmploymentDateErrorLabel.Visible = false;
            SalaryErrorLabel.Visible = false;
            ApplyErrorLabel.Visible = false;
            FullNameTextBox.BackColor = Color.White;
            PositionTextBox.BackColor = Color.White;
            SalaryTextBox.BackColor = Color.White;
            EmploymentDateTimePicker.BackColor = Color.White;
        }
    }
}