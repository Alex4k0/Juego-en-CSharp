using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ProyectoNavidad
{
    public class Heroe : Entidad
    {
        int experiencia;
        
        public int Experiencia { get => experiencia; set => experiencia = value; }

        public Heroe(string nombre)
            : base(nombre, 100, 10)
        {
            Experiencia = 0;
        }

        public override void Accion(Entidad objetivo)
        {
            int dano = Ataque + 5;
            objetivo.Vida -= dano;
            Console.WriteLine($"{Nombre} lanza un ataque crítico contra {objetivo.Nombre} que causa {dano} de daño.");
        }

        public override string ToString()
        {
            return $"[HÉROE] {Nombre} - HP: {Vida}/100 | EXP: {Experiencia}";
        }
    }
}
