using System;
using System.Collections.Generic;

public class Coordinadores : Participantes
{
    private string areasAsignadas;
    private List<Voluntarios> voluntarios;

    public string AreasAsignadas { get{return this.areasAsignadas;}set {this.areasAsignadas = value;}}
    public List<Voluntarios> Voluntarios {get {return this.voluntarios;} set {this.voluntarios = value;}}

    public Coordinadores(string nombre, int id, string apellido, string correo, string areasAsignadas) 
        : base(nombre, id, apellido, correo)
    {
        this.areasAsignadas = areasAsignadas;
        this.voluntarios = new List<Voluntarios>();
    }

    public override void MostrarInfo()
    {
        Console.WriteLine("------Coordinador------");
        Console.WriteLine($"Nombre completo: {this.Apellido}, {this.Nombre} ");
        Console.WriteLine($"Id: {this.Id}");
        Console.WriteLine($"Correo: {this.Correo}");
        Console.WriteLine($"Areas Asignadas: {areasAsignadas}");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Voluntarios a cargo:");

        if (voluntarios.Count == 0)
        {
            Console.WriteLine("No tiene voluntarios asignados.");
        }
        else
        {
            foreach (Voluntarios v in voluntarios)
            {
                v.MostrarInfo();
            }
        }
    }

    public void AgregarVoluntario(Voluntarios voluntario)
    {
        voluntarios.Add(voluntario);
        Console.WriteLine($"Voluntario {voluntario.Nombre} agregado al coordinador {this.Nombre}.");
    }
}