using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Ovni : ObjetoGrafico // Clase que representa un ovni en el juego y hereda de ObjetoGrafico
    {
        Random generador; // Generador de números aleatorios para activar el ovni
        int aleatorio;    // Almacena el número aleatorio generado
        bool activo;      // Indica si el ovni está activo (visible en pantalla) o no
        int X, y;         // Coordenadas X e Y para la posición del ovni en la pantalla
        string imagen;    // Representación visual del ovni como texto

        public Ovni()
        {
            X = 0; // Inicializa la posición X del ovni en 0(extremo izquierdo)
            y = 6; // El ovni empieza por el lado izquierdo de la pantalla
            activo = false;  // El ovni empieza desactivado (no visible)
            generador = new Random(); // Inicializa el generador de números aleatorios
            imagen = "(||)";  // Define la representación del ovni con texto "(||)"
        }

        // Propiedad pública para obtener o asignar el estado activo del ovni
        public bool Activo
        {
            get => activo;
            set => activo = value;
        }

        // Método sobrescrito que devuelve la imagen del ovni si está activo
        protected override string DevolverImagen()
        {
            if (activo) return imagen;    // Si el ovni está activo, devuelve su representación
            else return "";               // Si está inactivo, devuelve una cadena vacía
        }

        // Método sobrescrito que devuelve el color de la consola para el ovni
        protected override ConsoleColor DevolverColor()
        {
            return ConsoleColor.Yellow;   // Color amarillo para el ovni
        }

        // Método que mueve el ovni a través de la pantalla
        public void Mover()
        {
            if (!activo)     // Si el ovni está inactivo
            {
                aleatorio = generador.Next(1, 61);  // Genera un número aleatorio entre 1 y 60
                if (aleatorio == 2) // Si el número aleatorio es 2
                {
                    activo = true; // Activa el ovni (lo hace visible)
                    X = 0;          // Coloca el ovni en el extremo izquierdo de la pantalla
                }
            }
            else   // Si el ovni ya está activo
            {
                X++;  // Incrementa la posición X del ovni(se mueve hacia la derecha)
                if (X >= 76) activo = false; // Si la posición X es igual o mayor a 76 (límite de la pantalla)
            }
        }

        // Método sobrescrito que devuelve la longitud del ovni en caracteres
        protected override int DevolverLongitud()
        {
            return 4;   // La longitud del ovni es 4 caracteres (corresponde a "(||)")
        }
    }
}