namespace CalculadoraQuimica
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0, reslut, operation = 0;
        bool other = true;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "1";
            else
                return;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "2";
            else
                return;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "3";
            else
                return;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "4";
            else
                return;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "5";
            else
                return;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "6";
            else
                return;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "7";
            else
                return;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "8";
            else
                return;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + "9";
            else
                return;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (other == true)
                if (txtPreoperation.Text == "")
                    return;
                else
                    txtPreoperation.Text = txtPreoperation.Text + "0";
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (other == true)
                txtPreoperation.Text = txtPreoperation.Text + ".";
            else
                return;
        }
        private void btnLess_Click(object sender, EventArgs e)
        {
            if (txtPreoperation.Text == "" & other)
                txtPreoperation.Text = "-";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDEL_Click(object sender, EventArgs e)
        {
            txtPreoperation.Text = "";
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            txtPreoperation.Text = "";
            txtResult.Text = "";
            num1 = 0;
            num2 = 0;
            reslut = 0;
            operation = 0;
            other = true;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (other)
            {
                num1 = double.Parse(txtPreoperation.Text);
                txtResult.Text = num1 + "+";
                operation = 1;
                txtPreoperation.Text = "";
            }
        }
        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            if (other)
            {
                num1 = double.Parse(txtPreoperation.Text);
                txtResult.Text = num1 + "-";
                operation = 2;
                txtPreoperation.Text = "";
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (other)
            {
                num1 = double.Parse(txtPreoperation.Text);
                txtResult.Text = num1 + "/";
                operation = 3;
                txtPreoperation.Text = "";
            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (other)
            {
                num1 = double.Parse(txtPreoperation.Text);
                txtResult.Text = num1 + "×";
                operation = 4;
                txtPreoperation.Text = "";
            }
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (num1 != 0)
            {
                num2 = double.Parse(txtPreoperation.Text);
                txtResult.Text = txtResult.Text + num2;
                txtPreoperation.Text = "";
                other = false;
                if (operation == 1)
                    reslut = num1 + num2;
                else if (operation == 2)
                    reslut = num1 - num2;
                else if (operation == 3)
                    reslut = num1 / num2;
                else if (operation == 4)
                    reslut = num1 * num2;
                txtResult.Text = txtResult.Text + "=" + reslut;
            }
        }
    }
}