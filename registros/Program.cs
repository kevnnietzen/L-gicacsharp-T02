namespace AulaRegistrosArquivos
{
    public struct Cliente
    {
        public string Nome;
        public int Idade;
        public string Email;
    }
    class Programa
    {
        static void Main(string[] args)
        {
            // Declaração e uso básico de registros
            Cliente cliente1;
            cliente1.Nome = "Jotaro";
            cliente1.Idade = 30;
            cliente1.Email = "jotaro@example.com";

            Console.WriteLine(" === Cliente 1 === ");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Idade: " + cliente1.Idade);
            Console.WriteLine("Email: " + cliente1.Email);
            Console.WriteLine();

            //Segunda gravação e exibição de informações 
            Cliente cliente2;
            cliente2.Nome = "Joeline";
            cliente2.Idade = 17;
            cliente2.Email = "joelinekujo@example.com";

            Console.WriteLine(" === Cliente 2 === ");
            Console.WriteLine("Nome: " + cliente2.Nome);
            Console.WriteLine("Idade: " + cliente2.Idade);
            Console.WriteLine("Email: " + cliente2.Email);
            Console.WriteLine();

            // Organização de dados em tabela (vetor registros)
            Cliente[] Clientes = new Cliente[2];
            Clientes[0].Nome = "Jotaro";
            Clientes[0].Idade = 30;
            Clientes[0].Email = "jotaro@exemple.com";
            Clientes[1].Nome = "Joeline";
            Clientes[1].Idade = 17;
            Clientes[1].Email = "joelinekujo@exemple.com";

            Console.WriteLine("=== Tabela de Clientes ===");
            foreach (Cliente Cliente in Clientes)
            {
                Console.WriteLine("Nome: " + Cliente.Nome);
                Console.WriteLine("Idade: " + Cliente.Idade);
                Console.WriteLine("Email: " + Cliente.Email);
                Console.WriteLine();
            }

            // === Gravação de dados em arquivos ===
            Cliente cliente3;
            cliente3.Nome = "Joseph";
            cliente3.Idade = 50;
            cliente3.Email = "joseph@exemple.com";

            string caminhoArquivo = "Clientes.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo)
           {
    sw.WriteLine("===Cliente 3===");
    sw.WriteLine("Nome: " + cliente3.Nome);
    sw.WriteLine("Idade: " + cliente3.Idade);
    sw.WriteLine("Email: " + cliente3.Email);

            }





        Console.WriteLine(" === Gravação em Arquivo === ");
            Console.WriteLine($"Informacões de {cliente3.Nome} gravadas em '{caminhoArquivo}'.");
            Console.WriteLine();

            // Leitura do arquivo gravado
            Console.WriteLine(" === Conteúdo do Arquivo === ");
            string conteudo = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(conteudo;

            Console.WriteLine("\n === Fim da Execuçao === ");
        }
    }
}