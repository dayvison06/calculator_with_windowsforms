using System.Data;
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

            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            txtPanel.Text += "*";

        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            // O método DataTable.Compute permite avaliar as expressões matemáticas e retornar seu resultao.
            
            var result = new DataTable().Compute(txtPanel.Text, null);
            txtPanel.Text = result.ToString();

        }

        private void Nb1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb2_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;

        }

        private void Nb3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void Nb9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPanel.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPanel.Clear();
        }
    }
}