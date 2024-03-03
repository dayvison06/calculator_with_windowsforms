using System.Reflection;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnDivision.BackColor = Color.FromArgb(125, 217, 88);
            btnLess.BackColor = Color.FromArgb(125, 217, 88);
            btnCross.BackColor = Color.FromArgb(125, 217, 88);
            btnPlus.BackColor = Color.White;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            btnPlus.BackColor = Color.FromArgb(125, 217, 88);
            btnLess.BackColor = Color.FromArgb(125, 217, 88);
            btnCross.BackColor = Color.FromArgb(125, 217, 88);
            btnDivision.BackColor = Color.White;
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            btnPlus.BackColor = Color.FromArgb(125, 217, 88);
            btnDivision.BackColor = Color.FromArgb(125, 217, 88);
            btnCross.BackColor = Color.FromArgb(125, 217, 88);
            btnLess.BackColor = Color.White;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            btnPlus.BackColor = Color.FromArgb(125, 217, 88);
            btnLess.BackColor = Color.FromArgb(125, 217, 88);
            btnDivision.BackColor = Color.FromArgb(125, 217, 88);
            btnCross.BackColor = Color.White;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            if (txtNumber1.Text == string.Empty || txtNumber2.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 

            try
            {
                
                int n1 = int.Parse(txtNumber1.Text);
                int n2 = int.Parse(txtNumber2.Text);


                if (btnPlus.BackColor == Color.White)
                {
                    txtResult.Text = Sum(n1, n2).ToString();

                }
                else if (btnLess.BackColor == Color.White)
                {
                    txtResult.Text = Less(n1, n2).ToString();

                }
                else if (btnCross.BackColor == Color.White)
                {
                    txtResult.Text = Cross(n1, n2).ToString();

                }
                else if (btnDivision.BackColor == Color.White)
                {
                    txtResult.Text = Division(n1, n2).ToString();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }
            }
        }

        public int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Less(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int Cross(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}