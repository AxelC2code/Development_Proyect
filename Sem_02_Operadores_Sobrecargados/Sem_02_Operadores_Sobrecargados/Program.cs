namespace Sem_02_Operadores_Sobrecargados
{
    internal class Program
    {
        public class Fruta
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }

            public Fruta(string nombre, double precio, int cantidad)
            {
                if (precio < 0 || cantidad < 0)
                {
                    Console.WriteLine("Error: precio o cantidad inválida");
                }

                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }

            public static Fruta operator +(Fruta a, Fruta b)
            {
                if (a.Nombre != b.Nombre)
                {
                    Console.WriteLine("Error: frutas diferentes");
                    return a;
                }

                return new Fruta(a.Nombre, a.Precio, a.Cantidad + b.Cantidad);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de suma de frutas");

            Fruta fruta1 = new Fruta("Manzana", 2.5, 3);
            Fruta fruta2 = new Fruta("Manzana", 2.5, 4);
            Fruta fruta3 = fruta1 + fruta2;

            Console.WriteLine($"fruta: {fruta3.Nombre} / precio: {fruta3.Precio} / suma: {fruta3.Cantidad}");
            Console.ReadKey();
        }
    }
}
