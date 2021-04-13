namespace ModificadoresDeAcesso.Class.PrivadoProtegido
{
    class PrivadaProtegida
    {
        private protected string IdentificaClass = "Eu sou uma instância da class Privada Protegida e do diretório Privado Protegido";

        private protected void GetPrivadaProtegida()
        {
            System.Console.WriteLine("== Modificador Privada Protegida e seus Membros ==");
            System.Console.WriteLine();
            System.Console.WriteLine("Mensagem Protegida : {0}", IdentificaClass);
        }

        private protected string PrivadaProtegidaPrimaria()
        {
            return $"{IdentificaClass = "Eu sou um metodo da class Privada Protegida do diretório Privado Protegido"}";
        }

        private protected class PrivadaProtegidaB : PrivadaProtegida
        {
            public string PrivadaProtegidaSecundaria()
            {
                return $"{IdentificaClass = "Eu sou um metodo da subclass Privada Protegida do diretório Privado Protegido"}";
            }
        }
    }
}