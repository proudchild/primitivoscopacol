using Primitivos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivos
{
    class Program
    {
        /*
         Função principal do programa que roda quando o programa é executado

         */
        static void Main(string[] args)
        {
            //Entendendo váriáveis
            /*bool minhaCondicao = false;
            minhaCondicao = true;
            System.Console.WriteLine(minhaCondicao);
            minhaCondicao = true;
            System.Console.WriteLine(minhaCondicao);
            
            //Tipos Primitivos
            sbyte meuByteComSinal = 126;
            byte meuByte = 255;
            //Removemos a linha abaixo pois estava quebrando a compilação
            //Esse erro só aconteco windows
            //meuByte = -100;
            short NumeroZao = -125;
            ushort UNumeroZao = 65000;
            

            int numero = 5272222;
            uint numeroSemSinal = 352222;

            long SuperNumero = 5272222220;
            ulong USuperNumero = 5;

            // 0 5 potencia 6 32 eu vou te dar o meu núemro
            // 125698 x 10^-7
            // 12.5698, 0.000000125698
            float meuPontoFlutuante = 855555.588F;
            double meuPontoFlutuanteDobrado = 8888888;
            


            char minhaLetra = 'L';
            char[] minhaPalavra = {'N','a','o'};
            string meuTexto = "life";

            Lead meuLead = new Lead();
            meuLead.setFirstName("Sergio");
            System.Console.WriteLine(meuLead.getFirstName());
            


            System.Console.WriteLine("Digite qualquer tecla para finalizar...");
            System.Console.ReadKey();*/

            /*System.Console.WriteLine("Digite um número e tecle enter: ");
            int meuNumero = System.Console.Read();
            char meuChar = (char)meuNumero;
            System.Console.WriteLine("Seu número é equivalente a: " + meuChar);
            System.Console.ReadKey();*/

            /*string numeroUsuario = System.Console.ReadLine();
            int numeroLido = Int32.Parse(numeroUsuario);
            System.Console.WriteLine("Seu número é par?");
            bool par = numeroLido % 2 == 0;

            ///Operadores
            ///Usando os tipos primitivos que conhecemos

            System.Console.WriteLine("Quantos inteiros tem no número?");
            int x = 32;
            int y = Int32.Parse(System.Console.ReadLine());
            float result = y / x;
            x = y * x;
            x = y + x;
            bool maior = x > y;
            bool menor = x < y;
            bool maiori = x >= y;
            bool menori = x <= y;
            
            ///Operadores lógicos
            ///Usando bits
            ///
            bool verdadeiro = true;
            bool falso = false;
            bool r1 = verdadeiro && verdadeiro;
            bool r2 = falso && verdadeiro;
            bool r3 = falso || verdadeiro;
            bool r4 = r3 | r2;
            string minhaPalavra = "Texto";
            minhaPalavra = minhaPalavra + " Meu texto extra";
            minhaPalavra += "Meu texto extra 2";
            System.Console.WriteLine("No número tem {0} inteiros", result);

            ///Condicionais
            ///IF e Ternário
            if (par)
            {
                System.Console.WriteLine("Sim");

            }
            else
            {

                System.Console.WriteLine("Não");
            }
            System.Console.ReadKey();*/

            /*int x = 55;
            int y = 40;
            if(!(40 % 55 <= 0))
            {

            }
            else if (System.DateTime.Now.Day == 25)
            {

            }
            else
            {

            }
            if (true) x = 0;
            else if (false) x = 1;
            else x = 2;
            x = y % 2 == 0 ? 25 : 34;
            */


            /*int meuNumero = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= meuNumero; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                if(EPrimo(i) && i > 12)
                {
                    break;
                }
                System.Console.WriteLine(i);
            }*/


            /*foreach(char x in "teste")
            {
                System.Console.WriteLine(x);
            }*/
            /*
            List<Lead> leads = new List<Lead>();
            foreach(Lead l in leads)
            {
                System.Console.WriteLine(l.getFirstName());
            }
            */




            //Desafio Calculadora
            //calculadora();
            //Desafio Adivinho
            //adivinho();
            //Desafio primo
            //primo();
            //Desafio palavra byte
            //palavraByte();

            /*int y = 10;
            System.Console.WriteLine(y); //10
            alteraValor(ref y); //15
            System.Console.WriteLine(y); //15*/

            /*Lead l = new Lead();
            l.setFirstName("Sergio");
            System.Console.WriteLine(l.getFirstName());
            alteraNome(l);
            System.Console.WriteLine(l.getFirstName());
            System.Console.ReadLine();

            l.firstName = "Sergio";*/
            //1 buscar base de dados
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //2 executar a query(tratar os dados)
            var numQuery = 
                from num in numbers 
                where (num % 2) == 0 
                select num;
            //3 apresentar os dados (utilizar os dados tratados)
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            List<Lead> leads = new List<Lead>();
            var leadsVencidos =
                from l in leads
                where l.DataVencimento < System.DateTime.Today
                select l;

            IEnumerable<Lead> superLeads = from l in leads
                                          where l.DataVencimento < System.DateTime.Today
                                          select l;
            var countLeads = superLeads
                    .Where(x => x.DataVencimento > System.DateTime.Now)
                    .OrderBy(y => y.DataVencimento)
                    .Select(x => new
                    {
                        NovaPropriedade = x.DataVencimento
                    });


           

            


        }

        static void alteraNome(Lead l1)
        {
            l1.setFirstName(l1.getFirstName() + " alterei");
            System.Console.WriteLine(l1.getFirstName());
        }

        static void alteraValor(ref int x)
        {
            x += 5;
            System.Console.WriteLine(x); //15
        }

        static void palavraByte()
        {

            bool continua = true;
            while (continua)
            {
                System.Console.WriteLine("Bem vindo ao tradutor de palavras em bytes, escreva uma palavra");
                string palavra = System.Console.ReadLine();
                foreach (char x in palavra)
                {
                    System.Console.WriteLine("A palavra {0} é o número {1}", x, (byte)x);
                    System.Console.WriteLine("Em binário é: " + Convert.ToString(x, 2).PadLeft(8, '0'));
                }
                System.Console.WriteLine("Em hexa é: " + Convert.ToBase64String(Encoding.ASCII.GetBytes(palavra)));
                
                System.Console.WriteLine("Deseja brincar novamente?");
                continua = Boolean.Parse(System.Console.ReadLine());
            }
        }

        static void primo()
        {
            bool continua = true;
            while (continua)
            {
                System.Console.WriteLine("Bem vindo ao primo");
                System.Console.WriteLine("Digite um número para saber se é primo:"); 
                long userNumber = Int64.Parse(System.Console.ReadLine());
                if (EPrimo(userNumber))
                {

                    System.Console.WriteLine("O número {0} é primo", userNumber);
                }
                else
                {
                    System.Console.WriteLine("O número {0} não é primo", userNumber);

                }
                System.Console.WriteLine("Deseja brincar novamente?");
                continua = Boolean.Parse(System.Console.ReadLine());
            }
        }

        public static bool EPrimo(long numero)
        {
            if (numero <= 1)
                return false;
            else if (numero % 2 == 0)
                return numero == 2;

            long N = (long)(Math.Sqrt(numero) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (numero % i == 0)
                    return false;

            return true;
        }

        static void adivinho()
        {

            bool continua = true;
            while (continua)
            {
                System.Console.WriteLine("Bem vindo ao adivinho");
                Random rnd = new Random();
                int systemNumber = rnd.Next(1, 10);
                System.Console.WriteLine("Pensei num número, qual vc acha que foi?");
                int userNumber = Int32.Parse(System.Console.ReadLine());
                if(userNumber == systemNumber)
                {
                    System.Console.WriteLine("ACERTOU eu pensei: {0}", systemNumber);

                }
                else
                {
                    System.Console.WriteLine("ERROU! eu pensei: {0}", systemNumber);
                }
                System.Console.WriteLine("Deseja brincar novamente?");
                continua = Boolean.Parse(System.Console.ReadLine());
            }

        }

        static void calculadora()
        {
            bool continua = true;
            while (continua)
            {
                System.Console.WriteLine("Bem vindo a calculadora do Sergio");
                System.Console.WriteLine("Digite o primeiro número:");
                double primieroNumero = Double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Digite o segundo número:");
                double segundoNumero = Double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Digite a operação:");
                string operacao = System.Console.ReadLine();
                System.Console.WriteLine("Seu resultado é: {0}", calculate(primieroNumero, segundoNumero, operacao));
                System.Console.WriteLine("Deseja fazer outra operação?");
                continua = Boolean.Parse(System.Console.ReadLine());

            }
        }

        static double calculate(double x, double y, string operacao)
        {
            bool isMult = operacao == "*";
            if (isMult)
            {
                return x * y;
            }
            bool isSum = operacao == "+";
            if (isSum)
            {
                return x + y;
            }
            bool isMinus = operacao == "-";
            if (isMinus)
            {
                return x - y;
            }
            bool isDiv = operacao == "/";
            if (isDiv)
            {
                return x / y;
            }

            return 0;

        }


        static int getNumber(string param)
        {
            return Int32.Parse(param);
        }
    }
}
