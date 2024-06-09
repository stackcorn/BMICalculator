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
                    lblBmiMessage.Text = "�얞�ł�";
                } 
                else if (bmi >= 18.5)
                {
                    lblBmiMessage.Text = "���ʑ̏d�ł�";
                }
                else
                {
                    lblBmiMessage.Text = "��̏d�ł�";
                }
            }
            else
            {
                MessageBox.Show("�L���Ȑg���Ƒ̏d����͂��Ă��������B", "���̓G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
