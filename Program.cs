namespace esrcizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presentati");
            Console.Write("Nome: ");
            string NomeAlpha = Console.ReadLine();
            Console.Write("Cognome: ");
            string CognomeAlpha = Console.ReadLine();
            Console.Write("Età: ");
            int EtaAlpha = int.Parse(Console.ReadLine());
            Person myPerson = new Person(NomeAlpha, CognomeAlpha, EtaAlpha);
            Console.WriteLine(myPerson.GetDetails());
        }
    }

    public class Person
    {
        // FIELDS
        private string _nome;
        private string _cognome;
        private int _eta;

        // COSTANTI
        public const int MinLenght = 1;
        public const int NomeMaxLenght = 9;
        public const int CognomeMaxLenght = 16;

        // PROPERTIES 

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if(MinLenght < value.Length && value.Length < NomeMaxLenght)
                {
                    _nome = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if(MinLenght < value.Length && value.Length < CognomeMaxLenght)
                {
                    _cognome = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                if( 1 < value && value < 150)
                {
                    _eta = value;
                }
            }
        }

        // COSTRUCTOR

        public Person(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        // METHODS

        public string GetDetails()
        {
            return $"mi chiamo {Nome} {Cognome} , ed ho {Eta} anni ";
        }
    }
}
