namespace ManipulacaoDeStrings.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();

        }
        private static void Exercicio1()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i].Length > 0)
                {
                    char primeiraLetra = char.ToUpper(palavras[i][0]);
                    string restoDaPalavra = palavras[i].Substring(1).ToLower();
                    palavras[i] = primeiraLetra + restoDaPalavra;
                }
            }

            string novaFrase = string.Join(" ", palavras);

            Console.WriteLine(novaFrase);
        }
        private static void Exercicio2()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int numeroPalavras = palavras.Length;

            Console.WriteLine($"A frase digitada contém {numeroPalavras} palavras.");
        }
        private static void Exercicio3()
        {
            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();

            Console.Write("Digite o número de posições para avançar no alfabeto: ");
            int deslocamento = int.Parse(Console.ReadLine());

            string textoCifrado = CifrarTexto(texto, deslocamento);

            Console.WriteLine($"Texto cifrado: {textoCifrado}");
        }
        static string CifrarTexto(string texto, int deslocamento)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alfabetoCifrado = alfabeto.Substring(deslocamento) + alfabeto.Substring(0, deslocamento);

            string textoCifrado = "";

            foreach (char letra in texto)
            {
                if (char.IsLetter(letra))
                {
                    int indice = alfabeto.IndexOf(char.ToUpper(letra));

                    if (indice >= 0)
                    {
                        char letraCifrada = alfabetoCifrado[indice];

                        if (char.IsLower(letra))
                        {
                            letraCifrada = char.ToLower(letraCifrada);
                        }

                        textoCifrado += letraCifrada;
                    }
                }
                else
                {
                    textoCifrado += letra;
                }
            }

            return textoCifrado;
        }
        private static void Exercicio4()
        {
            string sequencia = "73167176531330624919225119674426574742355349194934" +
                              "96983520312774506326239578318016984801869478851843" +
                              "85861560789112949495459501737958331952853208805511" +
                              "12540698747158523863050715693290963295227443043557" +
                              "66896648950445244523161731856403098711121722383113" +
                              "62229893423380308135336276614282806444486645238749" +
                              "30358907296290491560440772390713810515859307960866" +
                              "70172427121883998797908792274921901699720888093776" +
                              "65727333001053367881220235421809751254540594752243" +
                              "52584907711670556013604839586446706324415722155397" +
                              "53697817977846174064955149290862569321978468622482" +
                              "83972241375657056057490261407972968652414535100474" +
                              "82166370484403199890008895243450658541227588666881" +
                              "16427171479924442928230863465674813919123162824586" +
                              "17866458359124566529476545682848912883142607690042" +
                              "32421902267105562632111110937054421750694165896040" +
                              "07198403850962455444362981230987879927244284909188" +
                              "84580156166097919133875499200524063689912560717606" +
                              "05886116467109405077541002256983155200055935729725" +
                              "71636269561882670428252483600823257530420752963450";

            int qtdDigitos = 5;
            long maiorProduto = 0;

            for (int i = 0; i < sequencia.Length - qtdDigitos; i++)
            {
                long produto = 1;
                for (int j = 0; j < qtdDigitos; j++)
                {
                    int digito = int.Parse(sequencia.Substring(i + j, 1));
                    produto *= digito;
                }
                if (produto > maiorProduto)
                {
                    maiorProduto = produto;
                }
            }

            Console.WriteLine("Maior produto: " + maiorProduto);
        }
        private static void Exercicio5()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Frase em letras maiúsculas: " + frase.ToUpper());
            Console.WriteLine("Frase em letras minúsculas: " + frase.ToLower());
            Console.WriteLine("Quantidade de caracteres da frase: " + frase.Length);

            string[] palavras = frase.Split(' ');
            Console.WriteLine("Primeira palavra da frase: " + palavras[0]);
            Console.WriteLine("Última palavra da frase: " + palavras[palavras.Length - 1]);
        }
   
    }
}