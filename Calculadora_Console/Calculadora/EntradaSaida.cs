using System;

namespace Calculadora_SI
{
    //Classe Estática responsavel pela entrada e saída de dados no sistema.
    public static class EntradaSaida
    {
        //Método que imprimi na tela;
        public static void Imprimir(string texto)
        {
            Console.Write(texto);
        }
        //Método que imprime em tela e salta uma linha no final;
        public static void ImprimirLn(String texto)
        {
            Console.WriteLine(texto);
        }
        //Método que lê o teclado e converte para double (ponto flutuante);
        public static Double LerTeclado(String texto)
        {
            return Convert.ToDouble(texto);
        }
        //Método que lê do teclado e retorna uma string;
        public static String LerOpcao(String texto)
        {
            return texto;
        }
        //Método que lê do teclado um 'char' e retorna um 'char';
        public static char LerOpcao(char texto)
        {
            return texto;
        }
        //Método que carrega a funcionalidade de limpar a tela;
        public static void LimpaSaida()
        {
            Console.Clear();
        }
        //Método que para o cursor em tela e aguarda digitação;
        public static void Parar()
        {
            Console.ReadKey();
        }
    }
}
