using System.Globalization;

namespace UTC.Calculator
{
    public partial class UtcCalc : Form
    {
        public UtcCalc()
        {
            InitializeComponent();
            lbl_result.Text = string.Empty;
            btnCloseInfo.Visible = false;
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
            lbl_result.Visible = true;
            CalculateUTC c = new CalculateUTC(dateTimePicker1.Value, comboBox1.SelectedItem);
            lbl_result.Text = c.Result().ToString("dd.MM.yyyy HH:mm");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lbl_result.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            label1.Visible = false;
            btnCopy.Visible = false;
            btn_calc.Visible = false;
            btnReset.Visible = false;
            lbl_result.Visible = false;
            comboBox1.Visible = false;
            btnCloseInfo.Visible = true;
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            label1.Visible = true;
            btnCopy.Visible = false;
            btn_calc.Visible = true;
            btnReset.Visible = true;
            lbl_result.Visible = false;
            comboBox1.Visible = true;
            btnCloseInfo.Visible = false;
        }
    }
}