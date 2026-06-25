namespace Agenda_Escolar;
using Agenda_Escolar.Clases;


public class Program{
    public static void Main(String [] args){
        int tipoContacto = 0;
        List <Contacto> contactosG = new List<Contacto>();

        bool menuGActivo = true;
        
        while(menuGActivo){
            Console.Clear();
            Console.Write("===== MENU DE CONTACTOS =====\n\n1. Agregar un Contacto\n2. Modificar Contacto\n3. Mostrar Contactos\n4. Buscar Contacto\n5. Eliminar Contacto\n6. Salir============\nOpcion: ");
            int opcionUsr = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(opcionUsr){
                    case 1: Console.Write("Seleccione un tipo de Contacto\n1. Alumno\n2. Profesor\nOpcion: ");
                            tipoContacto = int.Parse(Console.ReadLine());
                            
                            if(tipoContacto == 1){
                                Alumno alumn = new Alumno();
                                alumn.Agregar();
                                contactosG.Add(alumn);
                            }else{
                                Profesor prof = new Profesor();
                                prof.Agregar();
                                contactosG.Add(prof);
                            }
                                Console.WriteLine("Contacto Agregado Exitosamente\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                            break;
                    case 2: 
                            int contador = 1;
                            foreach(Contacto ctt in contactosG){
                                Console.WriteLine($"{contador}. {ctt.GetNombre()}");
                                contador++;
                            }
                            Console.Write("Ingrese el numero del contacto a Modificar: ");
                            int apuntador = int.Parse(Console.ReadLine());
                            contactosG.RemoveAt(apuntador-1);
                            Console.Clear();
                            Console.Write("Seleccione un tipo de Contacto\n1. Alumno\n2. Profesor\nOpcion: ");
                            tipoContacto = int.Parse(Console.ReadLine());
                            
                            if(tipoContacto == 1){
                                Alumno alumn = new Alumno();
                                alumn.Agregar();
                                contactosG.Insert((apuntador-1), alumn);
                            }else{
                                Profesor prof = new Profesor();
                                prof.Agregar();
                                contactosG.Insert((apuntador-1),prof);
                            }
                            Console.WriteLine("Contacto Agregado Exitosamente\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                    case 3: foreach(Contacto ctt in contactosG){
                                ctt.MostrarInfo();
                            }
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                    case 4: Console.Write("Ingrese el nombre del Contacto a Buscar: ");
                            string busqueda = Console.ReadLine();
                            Console.WriteLine("Buscando...\n");
                            foreach (Contacto ctt in contactosG){
                                string nombreCheck = ctt.GetNombre().ToLower();
                                if(nombreCheck == busqueda.ToLower()){
                                    Console.WriteLine("Contacto(s) Encontrado(s)!");
                                    ctt.MostrarInfo();
                                    Console.WriteLine("\n\nPresione una tecla para continuar...");
                                    Console.ReadKey();
                                }else{
                                    Console.Write("Contacto no Encontrado, presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                }
                            }
                            break;
                    case 5: int listaOpciones = 1;
                            foreach(Contacto ctt in contactosG){
                                Console.WriteLine($"{listaOpciones}. {ctt.GetNombre()}");
                                listaOpciones++;
                            }
                            Console.Write("Ingrese el numero del contacto a eliminar: ");
                            int eliminador = int.Parse(Console.ReadLine());
                            contactosG.RemoveAt(eliminador-1);
                            Console.Write("Contacto Eliminado con exito!\nPresione cualquier tecla para continuar");

                            break;
                    case 6: menuGActivo = false;
                            Console.WriteLine("Saliendo...");
                            break;
                                   
        }
    }
}
}
