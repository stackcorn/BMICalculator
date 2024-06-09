using System.Diagnostics;

namespace BMICalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalcBmi_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHeight.Text, out double height) && double.TryParse(txtWeight.Text, out double weight))
            {
                double heightInMeters = height / 100;
                double bmi = weight / (heightInMeters * heightInMeters);
                lblCalcResult.Text = bmi.ToString("F2");
                if (bmi >= 25)
                {
                    lblBmiMessage.Text = "肥満です";
                } 
                else if (bmi >= 18.5)
                {
                    lblBmiMessage.Text = "普通体重です";
                }
                else
                {
                    lblBmiMessage.Text = "低体重です";
                }
            }
            else
            {
                MessageBox.Show("有効な身長と体重を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
