namespace ModificadoresDeAcesso.Class.Protegido
{
    class Protegida
    {
        protected string IdentificaClass = "Eu sou uma instância da class Protegida e do diretório Protegido";

        protected void GetProtegida()
        {
            System.Console.WriteLine("== Modificador Protegido e seus Membros ==");
            System.Console.WriteLine();
            System.Console.WriteLine("Mensagem Protegida : {0}", IdentificaClass);
        }

        protected string ProtegidaPrimaria()
        {
            return $"{IdentificaClass = "Eu sou um metodo da class Protegida do diretório Protegido"}";
        }

        protected class ProtegidaB : Protegida
        {
            public string ProtegidaSecundaria()
            {
                return $"{IdentificaClass = "Eu sou um metodo da subclass Protegida do diretório Protegido"}";
            }
        }
    }
}