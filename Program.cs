using System;

namespace Calculadora
{
    class Program : Calculo
    {
        static void Main(string[] args)
        {
            Calculo calculadora = new Calculo();

            Console.WriteLine("O que deseja fazer? Deseja fazer uma conta básica, ou cálculo da média?");
            calculadora.selecao = Console.ReadLine();

            if(calculadora.selecao == "conta" || calculadora.selecao == "conta básica" || calculadora.selecao =="conta basica"){
                
            Console.WriteLine("Digite os numeros e a operação que deseja realizar");
            calculadora.numero1 = float.Parse(Console.ReadLine());
            calculadora.operacoes = Console.ReadLine();
            calculadora.numero2 = float.Parse(Console.ReadLine());

            //Console.WriteLine(calculadora.numero1);
            //Console.WriteLine(calculadora.operacoes);
            //Console.WriteLine(calculadora.numero2);*/

            if(calculadora.operacoes == "+"){
            calculadora.operacaoSoma();
            Console.WriteLine("O resultado é:" + calculadora.calculoTotalSoma);}

            if(calculadora.operacoes == "-"){
            calculadora.operacaoSub();
            Console.WriteLine("O resultado é:" + calculadora.calculoTotalSub);}

            if(calculadora.operacoes == "/"){
            calculadora.operacaoDiv();
            Console.WriteLine("O resultado é:" + calculadora.calculoTotalDiv);}

            if(calculadora.operacoes == "*"){
            calculadora.operacaoMulti();
            Console.WriteLine("O resultado é:" + calculadora.calculoTotalMulti);}
            }
            else if(calculadora.selecao == "média" || calculadora.selecao == "media"){
                media divisao = new media();

                Console.WriteLine("Programador preguiçoso nao terminou ainda");

                Console.WriteLine("Digite os numeros:");
                divisao.num1 = float.Parse(Console.ReadLine());
                divisao.num2 = float.Parse(Console.ReadLine());
                divisao.num3 = float.Parse(Console.ReadLine());
                divisao.num4 = float.Parse(Console.ReadLine());

                Console.WriteLine("A média é de:" + divisao.resultado);

            }
        }
    }
}
