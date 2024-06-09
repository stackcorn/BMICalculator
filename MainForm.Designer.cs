namespace BMICalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnCalcBmi = new Button();
            grpCalcResult = new GroupBox();
            lblCalcResult = new Label();
            lblBmiMessage = new Label();
            grpCalcResult.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "身長(cm)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "体重(kg)";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(112, 48);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 23);
            txtHeight.TabIndex = 0;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(112, 94);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 23);
            txtWeight.TabIndex = 1;
            // 
            // btnCalcBmi
            // 
            btnCalcBmi.Location = new Point(265, 97);
            btnCalcBmi.Name = "btnCalcBmi";
            btnCalcBmi.Size = new Size(75, 23);
            btnCalcBmi.TabIndex = 4;
            btnCalcBmi.Text = "計算";
            btnCalcBmi.UseVisualStyleBackColor = true;
            btnCalcBmi.Click += btnCalcBmi_Click;
            // 
            // grpCalcResult
            // 
            grpCalcResult.Controls.Add(lblBmiMessage);
            grpCalcResult.Controls.Add(lblCalcResult);
            grpCalcResult.Location = new Point(39, 153);
            grpCalcResult.Name = "grpCalcResult";
            grpCalcResult.Size = new Size(301, 79);
            grpCalcResult.TabIndex = 5;
            grpCalcResult.TabStop = false;
            grpCalcResult.Text = "あなたのBMI";
            // 
            // lblCalcResult
            // 
            lblCalcResult.AutoSize = true;
            lblCalcResult.Location = new Point(98, 19);
            lblCalcResult.Name = "lblCalcResult";
            lblCalcResult.Size = new Size(100, 15);
            lblCalcResult.TabIndex = 0;
            lblCalcResult.Text = "BMIが表示されます";
            // 
            // lblBmiMessage
            // 
            lblBmiMessage.AutoSize = true;
            lblBmiMessage.Location = new Point(98, 48);
            lblBmiMessage.Name = "lblBmiMessage";
            lblBmiMessage.Size = new Size(123, 15);
            lblBmiMessage.TabIndex = 1;
            lblBmiMessage.Text = "メッセージが表示されます";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 261);
            Controls.Add(grpCalcResult);
            Controls.Add(btnCalcBmi);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "BMI Calculator";
            grpCalcResult.ResumeLayout(false);
            grpCalcResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnCalcBmi;
        private GroupBox grpCalcResult;
        private Label lblCalcResult;
        private Label lblBmiMessage;
    }
}
