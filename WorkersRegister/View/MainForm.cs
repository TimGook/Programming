using WorkersRegister.Classes;
using WorkersRegister.Model.Classes;

namespace WorkersRegister
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ��������� �������.
        /// </summary>
        private readonly DateTime _standardDate = new DateTime(1900, 1, 1);

        /// <summary>
        /// ������������ ����� ����� ���������.
        /// </summary>
        private bool IsValidName = true;

        /// <summary>
        /// ������������ ����� ��������� ���������.
        /// </summary>
        private bool IsValidPosition = true;

        /// <summary>
        /// ������������ ����� ���� ���������������.
        /// </summary>
        private bool IsValidEmploymentDate = true;

        /// <summary>
        /// ������������ ����� ��������.
        /// </summary>
        private bool IsValidSalary = true;

        /// <summary>
        /// ������ ����������.
        /// </summary>
        private List<Worker> _workersList = new List<Worker>();

        /// <summary>
        /// ��������� �������.
        /// </summary>
        private Worker _currentWorker = new Worker();

        /// <summary>
        /// ����� ���������� ���������.
        /// </summary>
        private Worker _clonedCurrentWorker = new();

        /// <summary>
        /// ������ �������� ���������� �������� ��� ���������� 
        /// � ���������� ���������� �������� � ListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// ������ �������� �������� ��� ���������� � �������������� ���������.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// �������� ����� ��� ���������� ��� �������� ������.
        /// </summary>
        // TODO: ���� �� ���������� �������. �����! ������������ ������� ����������� C#, �� ������ ���� ���������� �����.
        // ���� C:/Users/<��� ������������>/AppData/Roaming/<�������� ������ ����������>/<��� �����>,
        // ���� C:/Users/<��� ������������>/Documents/<�������� ������ ����������>/<��� �����>
        private string _fileName = "Workers.json";

        public MainForm()
        {
            InitializeComponent();
            WorkersSerializer.LoadWorkers();
            ClearWorkersInfo();
            WorkersListBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
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
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearWorkersInfo();
            WorkersListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
            ApplyButton.Enabled = true;
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
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidName = false;
                FullNameTextBox.BackColor = Color.LightPink;
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
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidPosition = false;
                PositionTextBox.BackColor = Color.LightPink;
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
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidSalary = false;
                SalaryTextBox.BackColor = Color.LightPink;
                CheckData();
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
                    CheckData();
                }

            }
            catch (ArgumentException)
            {
                IsValidEmploymentDate = false;
                CheckData();
                MessageBox.Show("Date Error");
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) ||
                string.IsNullOrEmpty(PositionTextBox.Text) ||
                string.IsNullOrEmpty(SalaryTextBox.Text))
            {
                MessageBox.Show("������ �����");
                return;
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
                return;
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
        }

        /// <summary>
        /// �����, ����������� �������� ��������� ����� � �� ������ �� ��������� � ������ ������������� �����
        /// </summary>
        private void CheckData()
        {
            if (IsValidEmploymentDate && IsValidName && IsValidPosition && IsValidSalary)
            {
                ApplyButton.Enabled = true;
            }
            else
            {
                ApplyButton.Enabled = false;
            }
        }

        /// <summary>
        /// �����, ������� �������� ��� ��������� ��� ��������.
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
        /// �����, ������� ��������� ������ �������� ���������� ������� � TextBox � ComboBox.
        /// </summary>
        private void UpdateWorkersInfo()
        {
            FullNameTextBox.Text = _currentWorker.FullName;
            PositionTextBox.Text = _currentWorker.Position;
            SalaryTextBox.Text = _currentWorker.Salary.ToString();
            EmploymentDateTimePicker.Value = _currentWorker.EmploymentDate;
        }

        /// <summary>
        /// �����, ������� ��������� <see cref="_workersList"/> � <see cref="WorkersListBox"/>
        /// � ���������� �������.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = WorkersListBox.SelectedIndex;
            WorkersListBox.SelectedIndexChanged -= WorkersListBox_SelectedIndexChanged;
            _workersList = _workersList.OrderBy(worker => worker.ToString()).ToList();
            WorkersListBox.DataSource = _workersList;
            WorkersListBox.SelectedIndex = _indexBeforeSort;
            WorkersListBox.SelectedIndexChanged += WorkersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// �����, ������� ������� ��������� ���� � ComboBox.
        /// </summary>
        private void ClearWorkersInfo()
        {
            FullNameTextBox.Clear();
            PositionTextBox.Clear();
            SalaryTextBox.Clear();
            EmploymentDateTimePicker.Value = _standardDate;
            ApplyButton.Enabled = true;
        }
    }
}