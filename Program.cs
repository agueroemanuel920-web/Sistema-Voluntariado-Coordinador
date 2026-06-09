using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        List<Coordinadores> coordinadores = new List<Coordinadores>();
        int opcion = 0;
        do
        {
            System.Console.WriteLine("Bienvenido al sistema de gestion.");

            System.Console.WriteLine("Ingrese una opcion: ");
            System.Console.WriteLine("1. Soy Voluntario.");
            System.Console.WriteLine("2. Soy Coordinador");
            System.Console.WriteLine("3. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("Selecciono voluntario..");

                System.Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                System.Console.Write("Ingrese el apellido: ");
                string apellido = Console.ReadLine();
                System.Console.WriteLine("Id generado aleatoriamente..");
                int id = rnd.Next(999, 9999);
                System.Console.Write("Ingrese el correo: ");
                string correo = Console.ReadLine();
                System.Console.Write("Ingrese horas trabajadas: ");
                int horas = int.Parse(Console.ReadLine());

                Voluntarios voluntario = new Voluntarios(nombre, id, apellido, correo, horas);
                voluntario.MostrarInfo();

                if (coordinadores.Count > 0)
                    {
                        Coordinadores coordinadores1 = coordinadores[coordinadores.Count - 1];
                        coordinadores1.AgregarVoluntario(voluntario);
                    }
                    else
                    {
                        Console.WriteLine("No hay coordinadores disponibles para asignar este voluntario");
                    }
                break;

                case 2:
                System.Console.WriteLine("Selecciono Coordinador..");

                System.Console.Write("Ingrese el nombre: ");
                string NombreCoordinador = Console.ReadLine();
                System.Console.Write("Ingrese el apellido: ");
                string ApellidoCoordinador = Console.ReadLine();
                System.Console.WriteLine("Id generado aleatoriamente..");
                int idCoordinador = rnd.Next(999, 9999);
                System.Console.Write("Ingrese el correo: ");
                string correoCoordinador = Console.ReadLine();
                System.Console.Write("Area asignada: ");
                string area = Console.ReadLine();

                Coordinadores coordinador = new Coordinadores(NombreCoordinador, idCoordinador, ApellidoCoordinador, correoCoordinador, area);
                coordinadores.Add(coordinador);

                Console.WriteLine($"Coordinador {coordinador.Nombre} creado y agregado a la lista");
                break;
            }
        } while (opcion != 3);

        foreach (var c in coordinadores)
        {
            c.MostrarInfo();
        }
    }
}
