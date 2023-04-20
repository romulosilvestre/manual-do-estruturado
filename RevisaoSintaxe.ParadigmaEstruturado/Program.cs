using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoSintaxe.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentário de uma linha

            /*
             * Comentário de múltiplas linhas
             */

            //declaração de variáveis
            //variáveis de valor
            int idade = 43;
            float altura = 1.79f;
            decimal salario = 9000.50m;
            double media = 6.78;

            //documentação oficial dos tipos
            //Microsoft e Tabelas do Google
            //variáveis de referência
            string nome = "Rômulo Cesar Silvestre Stralong";
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome);
            Console.WriteLine(nome.Substring(23));

            //Estruturas
            //Estrutura de Seleção (Condição)
            if (idade >= 42)
                Console.WriteLine("Super Jovem Jovem");

            if(idade <= 16)
            {
                Console.WriteLine("Hiper Jovem Jovem");
            }

            //Se a Geovana acertar na mega sena
            //Muito Dinheiro --- Verdadeiro
            //Senão
            //Vai ter que trabalhar --- Falso
            //tipo de inferência
            var vencedora = "Geovana";
            bool venceu = true;
            if (venceu)
            {
                Console.WriteLine("É muito Dinheiro! para a :"+vencedora);
            }
            else
            {
                Console.WriteLine(vencedora+ "  Vai ter que trabalhar!");
            }

            //Switch (if compacto)
            var mes = 12;
            if(mes == 1)
            {
                Console.WriteLine("Janeiro");

            }else if(mes == 2)
            {
                Console.WriteLine("Fevereiro");

            }else if(mes == 3)
            {
                Console.WriteLine("Março");

            }else if(mes == 4)
            {
                Console.WriteLine("Abril");
            }else if(mes == 5)
            {
                Console.WriteLine("Maio");

            }else if(mes == 6)
            {
                Console.WriteLine("Junho");

            }else if(mes == 7)
            {
                Console.WriteLine("Julho");

            }else if (mes == 8)
            {
                Console.WriteLine("Agosto");

            }else if(mes == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Outrubro");
            }else if(mes == 11)
            {
                Console.WriteLine("Novembro");
            }else if(mes == 12)
            {
                Console.WriteLine("Dezembro");
            }
            else
            {
                Console.WriteLine("Não existe esse valor! Por favor, digite novamente!");
            }

            switch (mes)
            {
                case 1:Console.WriteLine("não sei");break;
                case 2: Console.WriteLine("não tem");break;
                case 3:Console.WriteLine("peixes - aries");break;
                case 4:Console.WriteLine("aries");break;
                case 5:Console.WriteLine("touro");break;
                case 6:Console.WriteLine("gemeos");break;
                case 7:Console.WriteLine("cancer");break;
                case 8:Console.WriteLine("Leão");break;
                case 9:Console.WriteLine("Virgem");break;
                case 10:Console.WriteLine("Libra");break;
                case 11:Console.WriteLine("Escorpião");break;
                case 12:Console.WriteLine("Sei não");break;
                default: Console.WriteLine("Dado inválido");break;       

            }

            /*
             * 
             * while
             * 
             * do
             * 
             * while
             * 
             * 
             * for
             * 
             * 
             */

            /*
             * 
             * Inicio
             * 
             * Condição - Fim
             * 
             * Incremento ou Decremento
             * 
             *  
             */
            int contador = 1;

            while(contador <= 3)
            {
                Console.WriteLine("Leandro Fernades");
                contador = contador + 1;
            }
            Console.WriteLine("===============Agora utilizando do while-------------");
            contador = 1;
            do
            {
                Console.WriteLine("Leandro Fernades");
                contador = contador + 1;

            } while (contador <= 3);

            for (int i=1;i<=3;i=i+1)
            {
                Console.WriteLine("Daniel");
            }

            Console.ReadKey();




        }
    }
}
