using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.Models
{
    internal class Triangulos : Abspropriedades
    {
        public Triangulos(int l1, int l2, int l3) : base(l1, l2, l3)
        {
            
        }

        public override void Executar()
        {
            if (l1 == l2 && l2 == l3)
            {
                mensagem = "Equilátero";
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                mensagem = "Isósceles";
            }
            else
            {
                mensagem = "Escaleno";
            }
        }
    }
}





//public Triangulos(int l1, int l2, int l3) { 
//    this.l1 = l1;
//    this.l2 = l2;
//    this.l3 = l3;
//    this.Executar();
//}
//private void Executar()
//{
//    if (l1 == l2 && l2 == l3)
//    {
//        mensagem = "Equilátero";
//    }
//    else if (l1 == l2 || l1 == l3 || l2 == l3)
//    {
//        mensagem = "Isósceles";
//    }
//    else
//    {
//        mensagem = "Escaleno";
//    }
//}