using Agenda_Escolar.Clases;

public class Alumno : Contacto{
    public double matricula;
    public string carrera;
    public string grupo;

    public Alumno(){}

    public override void Agregar(){
        Console.Write("Asigne un nombre: ");
        SetNombre(Console.ReadLine());
        Console.Write("Asigne un Telefono: ");
        SetTelefono(double.Parse(Console.ReadLine()));
        Console.Write("Asigne un Correo: ");
        SetCorreo(Console.ReadLine());
        Console.Write("Asigne una Matricula: ");
        matricula = double.Parse(Console.ReadLine());
        Console.Write("Asigne una Carrera: ");
        carrera = Console.ReadLine();
        Console.Write("Asigne un grupo: ");
        grupo = Console.ReadLine();
    }

    public override void MostrarInfo(){
        Console.WriteLine($"==== ALUMNO ====\nNombre: {GetNombre()}\nTelefono: {GetTelefono()}\nCorreo: {GetCorreo()}\nMatricula: {matricula}\nCarrera: {carrera}\nGrupo: {grupo}\n======================");
    }

    public override string Tipo(){
        return "Alumno";
    }
}