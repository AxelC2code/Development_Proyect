namespace ClsEquiposSobrecargado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Manucci = new Equipo("Manucci", "15% Hinchada", 100);
            var Cienciano = new Equipo("Cienciano", "30% Hinchada", 300);
            //Console.WriteLine(Manucci.ToString() );
            //Console.WriteLine(Cienciano.ToString());

            if (Manucci > Cienciano)
                Console.WriteLine(Manucci);
            else
                Console.WriteLine(Cienciano);
        }

        public class Equipo
        {
            public string nombre { get; set; }
            public string porcentaje { get; set; }
            public int nrohinchas { get; set; }
            public Equipo(string nombre, string porcentaje, int nrohinchas)
            {
                this.nombre = nombre;
                this.porcentaje = porcentaje;
                this.nrohinchas = nrohinchas;
            }
            public static bool operator <(Equipo a, Equipo b) => a.nrohinchas < b.nrohinchas;
            public static bool operator >(Equipo a, Equipo b) => a.nrohinchas > b.nrohinchas;

            public override string ToString()
            {
                return String.Format($"{nombre} {porcentaje}");
            }
        }
    }
}
