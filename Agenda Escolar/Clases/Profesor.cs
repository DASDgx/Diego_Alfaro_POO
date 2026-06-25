using Agenda_Escolar.Clases;

public class Profesor : Contacto{
    public string coordinacion;

    public Profesor(){}
    
    public override void Agregar(){
        Console.Write("Ingrese un nombre: ");
        SetNombre(Console.ReadLine());
        Console.Write("Ingrese un Telefono: ");
        SetTelefono(double.Parse(Console.ReadLine()));
        Console.Write("Ingrese un Correo: ");
        SetCorreo(Console.ReadLine());
        Console.Write("Ingrese una coordinacion: ");
        coordinacion = Console.ReadLine();
    }
    public override void MostrarInfo(){
        Console.Write($"==== PROFESOR ====\nNombre: {GetNombre()}\nTelefono: {GetTelefono()}\nCorreo: {GetCorreo()}\nCoordinacion {coordinacion}\n======================");
    }

    public override string Tipo(){
        return "Profesor";
    }
}