

namespace Triangulo.Models
{
    internal class Controle : Abspropriedades
    {
        public Controle(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            this.Executar();
        }

        public override void Executar()
        {
            Validacao validacao = new Validacao(lado1, lado2, lado3);
            if (validacao.mensagem.Equals(""))
            {
                Triangulos triangulo = new Triangulos(validacao.l1, validacao.l2, validacao.l3);
                this.mensagem = triangulo.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

    }
}

//    public Controle(string lado1, string lado2, string lado3) { 

//        this.lado1 = lado1;
//        this.lado2 = lado2;
//        this.lado3 = lado3;
//        this.Executar();
//    }
//    private void Executar()
//    {
//        Validacao validacao = new Validacao(lado1,lado2,lado3);
//        if (validacao.mensagem.Equals(""))
//        {
//            Triangulos triangulo = new Triangulos(validacao.l1,validacao.l2,validacao.l3);
//            this.mensagem = triangulo.mensagem;

//        }
//        else
//        {
//            this.mensagem = validacao.mensagem;
//        }

//    }
