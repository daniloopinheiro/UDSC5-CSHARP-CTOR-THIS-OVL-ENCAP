namespace ModificadoresDeAcesso.Class.Publico
{
    // MODIFICADORES E MEMBROS
    class Publica
    {
        public string IdentificaClass = "Eu sou uma instância da class Publica e do diretório Publico";

        public void GetPublica()
        {
            System.Console.WriteLine("== Modificador Public e seus Membros ==");
            System.Console.WriteLine();
            System.Console.WriteLine("Mensagem Publica : {0}", IdentificaClass);
        }

        public string PublicaPrimaria()
        {
            return $"{IdentificaClass = "Eu sou um metodo da class publica do diretório publico"}";
        }

        public class PublicaB : Publica
        {
            public string PublicaSecundaria()
            {
                return $"{IdentificaClass = "Eu sou um metodo da subclass publica do diretório publico"}";
            }
        }
    }
}