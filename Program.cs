

namespace Aula7_Encapsulamento_
{
    class Program
    {
        static void Main(string[] args)
        {
          Cartao card = new Cartao();

          Mastercard master = new Mastercard();
          master.titular = "nayane";
          master.parcelas = 10;
          master.ComprarComDescontoMastercard(20f);  
        }        
    }
}
