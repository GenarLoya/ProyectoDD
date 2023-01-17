using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class Dragon:Bestia
    {
        public int tamanoalas = 0;

        public Dragon()
        {
            Random raleat1 = new Random();

            tamanoalas = raleat1.Next(1, 4);

            nombre = "Bestia";
            velocidad = velocidad + tamanoalas;
            ats.Add("explosion");
        }

        public int Explosion(int vida, int jele, int def )
        {
            int dano = 0;
            
            switch (elemento)
            {
                case 0:
                    Console.WriteLine("Explosion: agua");
                    break;

                case 1:
                    Console.WriteLine("Explosion: tierra");
                    break;

                case 2:
                    Console.WriteLine("Explosion: fuego");
                    break;

                case 3:
                    Console.WriteLine("Explosion: aire");
                    break;

                case 4:
                    Console.WriteLine("Explosion: electrico");
                    break;

                case 5:
                    Console.WriteLine("Explosion: normal");
                    break;
            }
            dano = Ataquedecontacto(vida, jele, def);
            this.vida -= dano / 4;
            Console.WriteLine("dano de " + Convert.ToString(dano));

            vida -= dano;
            Console.WriteLine("vida restante del heroe " + Convert.ToString(vida));
            Console.WriteLine("vida restante del monstruo " + Convert.ToString(this.vida));
            return dano;
        }

        public override int calcular_ats(int vida, int jele, int def)
        {
            base.calcular_ats(vida, jele, def);

            switch (ats[at])
            {
                case "explosion":
                    danoss = Explosion(vida, jele, def);

                    break;
            }

            return danoss;
        }
    }
}
