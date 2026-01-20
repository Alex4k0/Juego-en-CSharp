using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ProyectoNavidad
{
    public class Orco : Enemigo
    {
        public Orco(string nombre)
            : base(nombre, 50, 10)
        {
        }

        public override void Accion(Entidad objetivo)
        {
            Console.WriteLine($"{Nombre} (Orco) ataca a {objetivo.Nombre} causando {Ataque} de daño.");
            objetivo.Vida -= Ataque;
        }

        public override string ToString()
        {
            return $"[ORCO] {Nombre} - HP: {Vida}/50";
        }
    }
}
