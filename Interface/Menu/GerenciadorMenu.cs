using System;

namespace Interface.Menu
{
    public class GerenciadorMenu
    {
        public void Executar()
        {
            Console.WriteLine("Olá mundo!");
            Console.ReadKey();
            Environment.Exit(0);   
        }
    }
}