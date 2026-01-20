using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ProyectoNavidad
{
    public class Entidad
    {
        string nombre;
        int vida;
        int ataque;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Vida { get => vida; set => vida = value; }
        public int Ataque { get => ataque; set => ataque = value; }

        public Entidad(string nombre, int vida, int ataque)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.ataque = ataque;
        }

        public virtual void Accion(Entidad objetivo)
        {
            objetivo.Vida -= Ataque;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} causando {Ataque} de daño.");
        }

        public override string ToString()
        {
            return $"{Nombre} - HP: {Vida}";
        }
    }
}

