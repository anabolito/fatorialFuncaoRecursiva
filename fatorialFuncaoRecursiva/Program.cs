internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int resposta;

        Console.Write("Informe um valor: ");
        num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine(" Informe um valor positivo! ");
        }
        else
        {
            resposta = fat(num);
            Console.WriteLine($" O fatorial de {num} é {resposta}");

            int fat(int valor)
            {
                if (valor == 0)
                {
                    return 1;
                }
                else
                {
                    return (valor * fat(valor - 1));
                }
            }

        }
    }
}

// ler um número inteiro e converter para binário; 