namespace ModificadoresDeAcesso
{
    class Menu
    {
        public string Mensagem = "Pressione a tecla Enter para ir ao proximo ...";

        public void MenuPrimario()
        {
            System.Console.WriteLine("\n {0}", Mensagem);
            System.Console.ReadLine();
        }
    }
}