using Triangulo.Models;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Visible = false;

        }

        private void btnVeriicar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txblado1.Text, txbLado2.Text, txbLado3.Text);
            lblResultado.Text = controle.mensagem;
            lblResultado.Visible = true;

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblLado2_Click(object sender, EventArgs e)
        {

        }
    }
}
