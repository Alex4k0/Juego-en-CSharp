using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ProyectoNavidad
{
    public class Hechicero : Enemigo
    {
        private static Random rnd = new Random();

        public Hechicero(string nombre)
            : base(nombre, 40, 8)
        {
        }

        public override void Accion(Entidad objetivo)
        {
            int decision = rnd.Next(2);

            if (decision == 0)
            {
                Vida += 5;
                Console.WriteLine($"{Nombre} (Hechicero) murmura palabras oscuras y recupera 5 de vida.");
            }
            else
            {
                Console.WriteLine($"{Nombre} (Hechicero) lanza un hechizo contra {objetivo.Nombre} causando {Ataque} de daño.");
                objetivo.Vida -= Ataque;
            }
        }

        public override string ToString()
        {
            return $"[HECHICERO] {Nombre} - HP: {Vida}/40";
        }
    }
}
