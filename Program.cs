namespace ProyectoNavidad
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- BIENVENIDO A ECHOES OF THE VOID ---");

            Heroe heroe = new Heroe("Sigurd");

            Enemigo[] enemigos = new Enemigo[2];
            enemigos[0] = new Orco("Gruñidor");
            enemigos[1] = new Hechicero("Malakor");

            while (heroe.Vida > 0 && HayEnemigosVivos(enemigos))
            {
                Console.WriteLine("\nESTADO ACTUAL:");
                Console.WriteLine(heroe);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("ENEMIGOS:");

                for (int i = 0; i < enemigos.Length; i++)
                {
                    if (enemigos[i].Vida > 0)
                    {
                        Console.WriteLine($"{i+1}. {enemigos[i]}");
                    }
                }

                Console.Write("\nTurno del Jugador. Elija índice del enemigo a atacar: ");
                int opcion = Convert.ToInt32(Console.ReadLine())-1;

                if (opcion >= 0 && opcion < enemigos.Length && enemigos[opcion].Vida > 0)
                {
                    heroe.Accion(enemigos[opcion]);

                    if (enemigos[opcion].Vida == 0)
                    {
                        heroe.Experiencia += 100;
                        Console.WriteLine($"{heroe.Nombre} gana 100 puntos de experiencia al derrotar un enemigo.");
                    }
                }

                Console.WriteLine("\nTurno de los Enemigos...");

                for (int i = 0; i < enemigos.Length; i++)
                {
                    if (enemigos[i].Vida > 0)
                    {
                        enemigos[i].Accion(heroe);
                    }
                        
                }

                Console.WriteLine("\nPulsa ENTER para continuar...");
                Console.ReadLine();
            }

            if (heroe.Vida > 0)
            {
                Console.WriteLine("\n¡El héroe ha vencido!");
            }
            else
            {
                Console.WriteLine("\nEl héroe ha caído...");
            }
        }

        static bool HayEnemigosVivos(Enemigo[] enemigos)
        {
            bool hayVivos = false;

            for (int i = 0; i < enemigos.Length; i++)
            {
                if (enemigos[i].Vida > 0)
                {
                    hayVivos = true;
                }
            }

            return hayVivos;
        }

    }
}
