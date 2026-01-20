using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoNavidad
{
    public class Enemigo : Entidad
    {
        public Enemigo(string nombre, int vida, int ataque)
            : base(nombre, vida, ataque)
        {
        }
    }
}
