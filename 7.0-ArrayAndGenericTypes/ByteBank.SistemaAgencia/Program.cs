using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project ByteBank.SistemaAgencia");
            Console.WriteLine("***************************************");

            Lista<int> idades = new Lista<int>();
            idades.Adicionar(5);
            idades.AdicionarVarios(1, 10, 78);

            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Idade no índice #{i}: {idade}");
                idadeSoma += idade;
                Console.WriteLine($"Idade Total no índice #{i}: {idadeSoma}");
            }

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice #{i}: {idade}");
            }

            Console.WriteLine("***************************************");

            Console.WriteLine(SomarVarios(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            Console.WriteLine(SomarVarios(1, 2, 3, 4, 5));
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456268),
                new ContaCorrente(874, 7781438)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456268),
                new ContaCorrente(874, 7781438)
            );

            //lista.EscreverListaNaTela();
            //lista.Remover(contaDoGui);
            //Console.WriteLine("Após remover o item...");
            //lista.EscreverListaNaTela();

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Conta: {itemAtual.Agencia} / {itemAtual.Numero} | Item na posição: {i}");
            }
        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContaCorrente()
        {
            //  Array
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456268),
                new ContaCorrente(874, 7781438)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta: {i} - {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {            
            //  VAR
            int media_1;

            //  Array
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            //  Data1
            media_1 = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                media_1 += idades[i];
            }

            Console.WriteLine("Média das idades: " + media_1 / idades.Length + " anos!");    
        }
    }
}