namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Pedro", "Silva", new DateTime(1991, 10,10));
            Console.WriteLine("Nome: {0}", aluno1.Nome);
            Console.WriteLine("Sobrenome: {0}", aluno1.Sobrenome);
            Console.WriteLine("Nascimento: {0}", aluno1.Nascimento.ToShortDateString());
            Console.WriteLine("Idade: {0}", aluno1.Idade);
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    class Aluno
    {
        private string nome;
        private string sobrenome;
        private DateTime nascimento;
        private int idade;

        public Aluno(string nome, string sobrenome, DateTime nascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Nascimento = nascimento;
            
            var hoje = DateTime.Today;
            idade = hoje.Year - nascimento.Year;

            Idade = idade;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        public int Idade { get; set; }
    }
}
