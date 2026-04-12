using System;
using System.Linq;

namespace UnoMasDosHasta100;

public static class Program {
    public static void Main() {

        int cumulo = 1;
        for (int cont = 2; cont < 101; cont++) {
            Console.WriteLine($"{cumulo}+{cont} = " + (cumulo + cont));
            cumulo += cont;

        }
    }
}
