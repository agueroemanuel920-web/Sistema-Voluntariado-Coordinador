using System;

public abstract class Participantes
{
    private string nombre;
    private int id;
    private string apellido;
    private string correo;
    
    public string Nombre{get{return this.nombre;}set{this.nombre = value;}}
    public int Id{get{return this.id;}set{this.id = value;}}
    public string Apellido{get{return this.apellido;}set{this.apellido = value;}}
    public string Correo{get{return this.correo;}set{this.correo = value;}}
    public Participantes(string nombre, int id, string apellido, string correo)
    {
        this.nombre = nombre;
        this.id = id;
        this.apellido = apellido;
        this.correo = correo;

    }   
    public abstract void MostrarInfo();
    
    
}