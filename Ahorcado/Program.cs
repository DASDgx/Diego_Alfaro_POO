namespace Ahorcado;

public class Program{
    public static void Main(string[]args){
        string [] palabras = ["ventana","pantalon","escritorio","television","ventilador"];             //Arreglo con palabras 
        Random generador = new Random();                                                                //Declara e inicializa el objeto Random

        //Ciclo de todo el juego
        while(true){

            //Inicializacion de variables
            Console.Clear();                                                                            //Limpieza de consola
            int decision;                                                                               //Decision del jugador inicia vacia
            int intentos = 6;                                                                           //intentos inician en 6
            int aciertos = 0;                                                                           //Aciertos inician en 0
            string mensajeFinal = "";                                                                   //Espacio para mensaje Final  (Ganador/Perdedor)

            List<char> tablero = new List<char>();                                                      //Lista para espacios disponibles de juego para el usuario
            string indices = "|";                                                                       //Cadena para mostrar el numero de letras en la palabra

            //Sorteo de palabras
            int azar = generador.Next(0,palabras.Length);                                               //Generador en base a los elementos del arreglo palabras
            string palabra = palabras[azar];                                                            //Se guarda la palabra elegida
            
            //Asignacion de casillas
            for(int fragmentos=0; fragmentos<palabra.Length; fragmentos++){
                tablero.Add('_');                                                                       //Agrega espacio vacio
                indices += $" {fragmentos+1} |";                                                        //Numero de indices en funcion del numero de letras de la palabra elegida
            }
            
            //Ciclo de partida
            while(true){
                Console.WriteLine("Tematica: HABITACION");
                
                //Recorrido de tablero actual
                foreach(char recorrido in tablero)                                                      
                        Console.Write($"| {recorrido} ");                                               //Mostramos espacios vacios y letras encontradas

                Console.Write($"|\n{indices}\nIntentos restantes: {intentos} \nIngrese una letra: ");   //Mostramos indicaciones(Tablero, intentos, indicacion principal)
                char valor;                                                                             //Variable para la entrada del usuario

                //Manejo de Excepcion al ingresar valor
                try{
                    valor = char.Parse(Console.ReadLine());                                             //Asignacion de valor 
                
                //En caso de error al asignar el valor a la variable de tipo char
                }catch(Exception){                                                                      //Atrapamos cualquier Excepcion
                    Console.Clear();
                    Console.WriteLine("No puedes ingresar mas de un caracter, intentalo de nuevo\n");   //Le indicamos al usuario lo sucedido
                    continue;                                                                           //Continuamos para inicar de nuevo el ciclo
                }

                //  -----  Algoritmo de Letra -----  //
                
                //Si la palabra contiene la letra ingresada por el usuario
                if(palabra.Contains(valor)){
                //->
                    //Si anteriormente ya se habia ingresado el mismo caracter
                    if(tablero.Contains(valor)){
                        Console.Clear();                                                                //Limpieza de consola
                        Console.WriteLine("Letra repetida, intentalo de nuevo");
                        continue;                                                                       //Salta todo lo que sigue, regresa al inicio del ciclo
                    
                    //Si anteriormente no se ha ingresado esta letra
                    }else{
                        
                        //Buscara las posiciones de la letra ingresada en la palabra
                       for(int asignacion=0; asignacion<palabra.Length; asignacion++){
                                
                                //Cuando encuentre la coincidencia de la letra
                                if(palabra[asignacion] == valor){                                       
                                tablero[asignacion] = valor;                                            //Asigna el valor en su posicion correspondiente
                                aciertos++;                                                             //Incrementa el numero de letras encontradas
                            }
                       }
                        Console.Clear();

                        //Finalizacion de Partida
                        //Si los aciertos son iguales al numero de letras de la palabra 
                        if(aciertos == palabra.Length) {                                                
                            mensajeFinal = $"LA PALABRA FUE: {palabras[azar]}\nHAZ GANADO ";            //Mensaje Ganador
                            break;                                                                      //Finaliza la partida
                        }
                    }

                //Si la letra ingresada, no existe en la palabra
                }else{
                    Console.Clear();
                    Console.WriteLine(".... INCORRECTO ....");
                    intentos--;                                                                         //Resta un intento
                    
                    //Si los intentos llegan a 0
                    if(intentos == 0){
                        mensajeFinal = $"LA PALABRA ERA {palabras[azar]}\nHAZ PERDIDO";                 //Mensaje perdedor
                        break;                                                                          //Finaliza la partida
                    }
                }
            }

            //Finalizacion de Partida
            Console.Write(mensajeFinal+"\nDesea jugar de nuevo?  1- SI  |  2- NO  :");
            while(true){
                try{
                    decision = int.Parse(Console.ReadLine());                                           //Toma de decision para repetir todo el juego
                    break;                                                                              //Finaliza ciclo de pregunta 
                }
                //Si ingresa un valor no compatible con el tipo char
                catch (Exception){
                    Console.Clear();                                                                    //Limpieza de consola
                    Console.WriteLine("Ingrese unicamente valores enteros, intentelo nuevamente");      //Se le indica la excepcion ocurrida
                }
            }
            if(decision == 2) break;                                                                    //Si elige 2: Finaliza el ciclo, de lo contrario continua
        }
    }
}
