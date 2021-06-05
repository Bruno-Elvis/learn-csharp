using System;

namespace Calculadora_SI
{
    class Calculadora
    {
        //Método principal e ponto de partida para execução do programa.
        static void Main(string[] args)
        {
            while (true)
            {
                EntradaSaida.LimpaSaida();
                EntradaSaida.ImprimirLn(">>>> Projeto com Classes Estáticas e Dinâmicas [PARA SAIR DIGITE 'S']<<<<<");
                String op = EntradaSaida.LerOpcao(Console.ReadLine());
                if (op.Equals("S") || op.Equals("s"))
                {
                    break;
                }
               
                EntradaSaida.ImprimirLn(">>>> Projeto Calculadora Dinâmica<<<<<");
                EntradaSaida.Imprimir("\n");

                EntradaSaida.Imprimir("Digite o Primeiro Número : ");
                double valor1 = EntradaSaida.LerTeclado(Console.ReadLine());

                EntradaSaida.Imprimir("\n");

                EntradaSaida.Imprimir("Digite o Segundo Número : ");
                double valor2 = EntradaSaida.LerTeclado(Console.ReadLine());

                EntradaSaida.Imprimir("Escolha a Operação [+] [-] [*] [/] ->");
                op = EntradaSaida.LerOpcao(Console.ReadLine());

                EntradaSaida.Imprimir("\n");     
                
                String msg = calcular(op, valor1, valor2);
                EntradaSaida.ImprimirLn(msg);
                EntradaSaida.Imprimir("\n");
                EntradaSaida.ImprimirLn("Pressione  qualquer tecla para continuar ...");
                EntradaSaida.Parar();

            }

            EntradaSaida.ImprimirLn(":( Sistema encerrado.");
            EntradaSaida.ImprimirLn("Pressione  qualquer tecla para encerrar ...");
            EntradaSaida.Parar();
        }

        // Método criado para criar o objeto responsável pela execução de cada operação;
        static String calcular(string op, double valor1, double valor2)
        {
            double resultado = 0;
            String msg = "Inválido";

            switch (op)
            {
                case "+":
                    Soma sum = new Soma();
                    sum.ajustaValores(valor1, valor2);               
                    resultado = sum.calcular();
                    msg = "A soma é :";
                    break;
                case "-":
                    Subtracao sub = new Subtracao();
                    sub.ajustaValores(valor1, valor2);
                    resultado = sub.calcular() ;
                    msg = "A subtração é :";
                    break;
                case "/":
                    //Teste de condição para evitar divisão por zero e conseguentemente uma exceção;
                    if (valor2 != 0)
                    {
                        Divisao div = new Divisao();
                        div.ajustaValores(valor1, valor2);
                        resultado = div.calcular();
                        msg = "A divisão é";
                    }
                    else
                    {
                        resultado = 999999999.999999;
                        msg = "Erro de divisão por zero.";
                    }
                    break;
                case "*":
                    resultado =  new Multiplicacao(valor1,valor2).calcular();
                    msg = "A multiplicação é :";
                    break;
                default:
                    EntradaSaida.LimpaSaida();
                    Console.WriteLine("Operação Inválida.");
                    break;
            }
            return msg + " " + resultado;
        }
    }
    }

