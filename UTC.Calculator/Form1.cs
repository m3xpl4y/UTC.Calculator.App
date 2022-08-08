using System.Globalization;

namespace UTC.Calculator
{
    public partial class UtcCalc : Form
    {
        public UtcCalc()
        {
            InitializeComponent();
            lbl_result.Text = string.Empty;
            SetDateTimePicker();
            InitializeUtc();
        }

        private void InitializeUtc()
        {
            foreach (var item in UtcItems.UtcList())
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 13;
        }

        void SetDateTimePicker()
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDateTimePicker();
            InitializeUtc();
            lbl_result.Text = string.Empty;
            btnCopy.Visible = false;

        }
        private void btn_calc_Click(object sender, EventArgs e)
        {
            btnCopy.Visible = true;
            CalculateUTC c = new CalculateUTC(dateTimePicker1.Value, comboBox1.SelectedItem);
            lbl_result.Text = c.Result().ToString("dd.MM.yyyy HH:mm");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lbl_result.Text);
        }
    }
}