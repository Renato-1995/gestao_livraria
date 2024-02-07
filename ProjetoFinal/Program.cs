namespace Lptrabalhopratico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir a codificação da saída da consola para UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Mensagem de Boas-Vindas ao Sistema
            Console.WriteLine("-------------------Bem-vindo ao Sistema de Registo da Livraria 'Páginas do Saber'----------------------\n");

            //Instanciar a classe Livraria
            Livraria livraria = new Livraria();

            //Método Sistema de Login
            livraria.EntrarUtilizador();
        }
    }
}
