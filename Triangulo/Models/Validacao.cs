
namespace Triangulo.Models
{
    internal class Validacao : Abspropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.l1 = Convert.ToInt32(this.lado1);
                this.l2 = Convert.ToInt32(this.lado2);
                this.l3 = Convert.ToInt32(this.lado3);

                if (l1 + l2 < l3 || l1 + l3 < l2 || l3 + l2 < l1)
                {
                    this.mensagem = "Não é um triângulo";
                }
            }catch (Exception erro)
            {
                this.mensagem = "Digite valores válidos";
            }
        }
    }
}


//private void Executar()
//{

//}


//public Validacao(string lado1, string lado2,string lado3) { 
//    this.lado1 = lado1;
//    this.lado2 = lado2;
//    this.lado3 = lado3;
//    this.Executar();
//}
//private void Executar()
//{
//    this.mensagem = "";
//    try
//    {
//        this.l1 = Convert.ToInt32(this.lado1);
//        this.l2 = Convert.ToInt32(this.lado2);
//        this.l3 = Convert.ToInt32(this.lado3);

//        if (l1+l2<l3 || l1+l3<l2 || l3+l2<l1)
//        {
//            this.mensagem = "Não é um triângulo";
//        }

//    }catch(Exception erro)
//    {
//        this.mensagem = "Digite valores válidos";
//    }
//}