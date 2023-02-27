namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnumsListBox_Click(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.Add();
        }
    }
}