using System.Globalization;

namespace CALCULDAORA
{
    public partial class a : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public a()
        {
            InitializeComponent();
        }
        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void TXTRESULTADO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += ",";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TXTRESULTADO.Text != "")
            {
                valor1 = decimal.Parse(TXTRESULTADO.Text, CultureInfo.InvariantCulture);
                TXTRESULTADO.Text = "";
                operacao = "SUB";
                lbloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Operação.")
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (TXTRESULTADO.Text != "")
            {
                valor1 = decimal.Parse(TXTRESULTADO.Text, CultureInfo.InvariantCulture);
                TXTRESULTADO.Text = "";
                operacao = "DIV";
                lbloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Operação.")
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "2";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text += "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TXTRESULTADO.Text != "")
            { 
            valor1 = decimal.Parse(TXTRESULTADO.Text, CultureInfo.InvariantCulture);
            TXTRESULTADO.Text = "";
            operacao = "SOMA";
            lbloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Operação.")
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(TXTRESULTADO.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                TXTRESULTADO.Text = Convert.ToString(valor1 + valor2);
            } 
            else if (operacao == "SUB")
            {
                TXTRESULTADO.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "DIV")
            {
                TXTRESULTADO.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "MULT")
            {
                TXTRESULTADO.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (TXTRESULTADO.Text != "")
            {
                valor1 = decimal.Parse(TXTRESULTADO.Text, CultureInfo.InvariantCulture);
                TXTRESULTADO.Text = "";
                operacao = "MULT";
                lbloperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Operação.")
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text = "";
            lbloperacao.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TXTRESULTADO.Text = "";
            valor2 = 0;
            valor1 = 0;
            lbloperacao.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                     
        }
    }
}