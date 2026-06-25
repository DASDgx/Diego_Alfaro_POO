namespace Agenda_Escolar.Clases;


public class Contacto{
    private string nombre;
    public double telefono;
    private string correo;

    public void SetNombre(string valor){
        nombre = valor;
    }
    public string GetNombre(){
        return nombre;
    }
    public void SetTelefono(double valor){
        telefono = valor;
    }
    public double GetTelefono(){
        return telefono;
    }

    public void SetCorreo(string valor){
        correo = valor;
    }
    public string GetCorreo(){
        return correo;
    }

    public virtual void Agregar(){
        Console.Write("Ingrese un Nombre: ");
        SetNombre(Console.ReadLine());
        Console.Write("Ingrese un Telefono: ");
        SetTelefono(double.Parse(Console.ReadLine()));
        Console.WriteLine("Ingrese un Correo: ");
        SetCorreo(Console.ReadLine());
    }
    public virtual void MostrarInfo(){
        Console.WriteLine($"\nNombre: {nombre}\nTelefono: {telefono}\nCorreo: {correo}");
    }

    public virtual string Tipo(){
        return "Contacto";
    }

}

