using System;

namespace Aula7_Encapsulamento_
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }
        public void ComprarComDescontoMastercard(float desconto){
             
             //Protected
             cvc = 456;

             Console.WriteLine($"Aplicando desconde de {desconto}, no total de {parcelas} parcelas");
        }
    }
}