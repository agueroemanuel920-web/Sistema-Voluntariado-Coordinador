using System;
public class Voluntarios : Participantes
{
    private int horasTrabajadas;
    public int HorasTrabajadas{get{return this.horasTrabajadas;}set{this.horasTrabajadas = value;}}
    
    public Voluntarios(string nombre, int id, string apellido, string correo, int horasTrabajadas) : base  ( nombre,  id,  apellido,  correo)
    {
        this.horasTrabajadas = horasTrabajadas;
    }

    public override void MostrarInfo()
    {
   
        System.Console.WriteLine($"Nombre completo: {this.Apellido}, {this.Nombre} ");
        System.Console.WriteLine($"Id: {this.Id}");
        System.Console.WriteLine($"Correo: {this.Correo}");
        System.Console.WriteLine($"Horas Trabajadas: {this.horasTrabajadas}");
        
    }
}