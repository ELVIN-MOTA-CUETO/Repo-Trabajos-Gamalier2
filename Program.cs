namespace Cuentas_de_Estudiantes
{
    internal class Program
    {
        static string GenerarUsuario(string nombre, string apellido)
        {
            string nombrereducido1 = nombre.Substring(0,1) + apellido;

            string usuario = nombrereducido1.ToLower();

            return usuario;
        }


        static bool ClaveValida(string clave, string usuario)
        {


            return clave.Length >= 8 && !clave.Contains(usuario);
        }

        static void MostrarCuenta(string usuario, bool clave)
        {


            Console.WriteLine("Usuario: " + usuario);
            Console.WriteLine("Clave válida: " + clave);

        }
            static void Main(string[] args)
        {
            string nombre, apellido, clave;

            Console.WriteLine("Nombre-Estudiante");
            nombre = Console.ReadLine();

            Console.WriteLine("Apellido-Estudiante");
            apellido = Console.ReadLine();

            Console.WriteLine("Clave");
            clave = Console.ReadLine();


            string usuarioGenerado = GenerarUsuario(nombre, apellido);

            bool esValida = ClaveValida(clave, usuarioGenerado);

            MostrarCuenta(usuarioGenerado, esValida);
        }
    }
}
