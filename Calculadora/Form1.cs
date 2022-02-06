namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void agregarNumero(string numero)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += numero;
        }
        private void eliminarNumero(string numero)
        {
            if (txtResultado.Text == "")
                txtResultado.Text = "0";

            txtResultado.Text = "0";
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
                
        }
        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            txtResultado.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            if (Operador == '÷')
            {
                txtResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            if (Operador == '%')
            {
                txtResultado.Text = (Numero1 % Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);

            }
            if (Operador == 'x')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);

            }

        }
    }
}