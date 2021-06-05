namespace Calculadora_SI
{
    class Multiplicacao : Operacao
    {
        public double calcular()
        {
            //Definição do método calcular desta classe de Operação.
            return valor1 * valor2;
        }

        // Implementação de construtor personalizado.
        public Multiplicacao(double xValor1,double xValor2) {
            this.ajustaValores(xValor1,xValor2);
        }
    }
}
