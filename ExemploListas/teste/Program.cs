using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicalizando uma lista (tipo string) passando os valores a serem alucados
            List<string> nomes;
            nomes = new List<string> { "ana","maria","alex","bia","joao","paulo","lucas","leo","pedro","paty"};

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            // inicializando uma lista "tipo string" vazia, e adicionando valores uma a um

            List<string> listaNomes = new List<string>();

            // adicinando valores com Add() que por padrao insere ao final da lista
            listaNomes.Add("mario");
            listaNomes.Add("laura");
            listaNomes.Add("leandro");
            listaNomes.Add("sara");
            listaNomes.Add("victor");
            listaNomes.Add("henrique");
            listaNomes.Add("bernardo");
            listaNomes.Add("denis");
            listaNomes.Add("lucio");
            listaNomes.Add("mateus");
            listaNomes.Add("lia");
            listaNomes.Add("beca");
            listaNomes.Add("dora");

            foreach (var item in listaNomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            // adicinando valores com Insert() que permite escolher o indice para alocar o elemento na lista

            listaNomes.Insert(3, "MARCELA");

            foreach (var item in listaNomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            // contar o numero de elementos da lista
            Console.WriteLine(listaNomes.Count());

            Console.ReadKey();
            Console.WriteLine();

            // encontar a primeira ocorrencia que satisfaça um predicado  + "expressao lambda: (x => x[0] == 'm')"
            var encontrarPrimeiraOcorrencia = listaNomes.Find(x => x[0] == 'm');
            Console.WriteLine(encontrarPrimeiraOcorrencia);

            Console.ReadKey();
            Console.WriteLine();

            // encontar a ultima ocorrencia que satisfaça um predicado  + "expressao lambda: (x => x[0] == 'm')"
            var encontrarUltimaOcorrencia = listaNomes.FindLast(x => x[0] == 'm');
            Console.WriteLine(encontrarUltimaOcorrencia);

            Console.ReadKey();
            Console.WriteLine();

            // encontar a primeira posicao que satisfaça um predicado  + "expressao lambda: (x => x[0] == 'm')"
            var encontrarPrimeiraPosicao = listaNomes.FindIndex(x => x[0] == 'm');
            Console.WriteLine(encontrarPrimeiraPosicao);

            Console.ReadKey();
            Console.WriteLine();

            // encontar a ultima posicao que satisfaça um predicado  + "expressao lambda: (x => x[0] == 'm')"
            var encontrarultimaPosicao = listaNomes.FindLastIndex(x => x[0] == 'm');
            Console.WriteLine(encontrarultimaPosicao);

            Console.ReadKey();
            Console.WriteLine();

            // criar umanova lista apenas contendo os elementos que satisfacao um predicado  + "expressao lambda: (x => x[0] == 'm')"
            List<string> listaFiltro = listaNomes.FindAll(x => x.Length <= 4);
            foreach (var obj in listaFiltro)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
            Console.WriteLine();

            // removendo elementos especifico da lista
            listaNomes.Remove("mateus");

            foreach (var item in listaNomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            // removendo todos os elementos da lista que atendem a uma satisfacao  + "expressao lambda: (x => x[0] == 'm')"
            listaNomes.RemoveAll(x => x[0] == 'l');

            foreach (var item in listaNomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            // removendo elementos especifico da lista pela posicao que ele ocupa RemoveAt()
            listaNomes.RemoveAt(3);

            foreach (var item in listaNomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            // removendo elementos DE UMA DETERMINADA FAIXA "RemoveRange(1,5)" => apartir da posicar "x", retirar "y" elementos
            listaNomes.RemoveRange(1,5);

            foreach (var item in listaNomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            //var removerPrimeiroElemento = listaNomes.Remove(x => x[0] == 'M');




        }
    }
}

