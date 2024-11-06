using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class TorreDefensiva
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Integridad { get; private set; } // Nivel de integridad de la torre

        public TorreDefensiva(int xInicial, int yInicial, int integridadInicial)
        {
            X = xInicial;
            Y = yInicial;
            Integridad = integridadInicial;
        }

        // Método para recibir daño parcial en la torre
        public void RecibirDanio()
        {
            Integridad--;
            Console.WriteLine($"La torre en ({X}, {Y}) ha sido dañada. Integridad restante: {Integridad}");
            if (Integridad <= 0)
            {
                Console.WriteLine("La torre ha sido destruida completamente.");
                // Podrías añadir aquí lógica para remover la torre del juego
            }
        }
    }
}
