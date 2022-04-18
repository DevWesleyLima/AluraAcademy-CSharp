using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project ByteBank.SistemaAgencia");
            Console.WriteLine("***************************************");

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(340, 4),
                new ContaCorrente(340, 456),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 123)
            };

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(x => x.Numero);

            //var listaSemNull = contas.Where(x => x != null);
                        
            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = listaSemNull.OrderBy(x => x.Numero);

            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas
                .Where(x => x != null)
                .OrderBy(x => x.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Agência: {conta.Agencia} | Conta número: {conta.Numero}");
            }
            Console.WriteLine("||****************************||");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }

        static void TestaContasOrderBy()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(340, 4),
                new ContaCorrente(340, 456),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 123)
            };

            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(x =>
            {
                if (x == null)
                {
                    return int.MaxValue;
                }
                return x.Numero;
            });

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Agência: {conta.Agencia} | Conta número: {conta.Numero}");
                }
            }
        }

        static void TestaContasSort()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(340, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(999, 1),
                new ContaCorrente(111, 99999),
                new ContaCorrente(290, 18950)
            };

            contas.Sort();

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine($"Agência: {conta.Agencia} | Conta número: {conta.Numero}");
            }
        }

        static void TestaListSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Guilherme",
                "Luana",
                "Ana"
            };

            nomes.Sort();

            for (int i = 0; i < nomes.Count; i++)
            {
                string nome = nomes[i];
                Console.WriteLine($"Nome no índice #{i}: {nome}");
            }

            Console.WriteLine("***************************************");

            var idades = new List<int>();
            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(45, 89, 12);
            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Idade no índice #{i}: {idade}");
            }
        }

        static void TestaListaSomarIdades()
        {
            List<int> idades = new List<int>();
            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            //ListExtensoes.AdicionarVarios(idades, 1, 2, 3, 9);

            //idades.Remove(5);

            int idadeSoma = 0;
            for (int i = 0; i < idades.Count; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Idade no índice #{i}: {idade}");
                idadeSoma += idade;
                Console.WriteLine($"Idade Total no índice #{i}: {idadeSoma}");
            }

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