using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class Angel : monstruo
    {
        Random raleat2 = new Random();

        public int tamanoalas = 0;
        public int podermagico = 0;

        public Angel()
        {
            Random raleat1 = new Random();

            tamanoalas = raleat1.Next(2, 4);
            podermagico = raleat1.Next(6, 12);

            nombre = "Angel";

            ats.Add("ataquemagico");
            ats.Add("vuelo");
        }

        public int vuelo(int vida, int jele, int def)
        {
            int dano = 0;

            Console.WriteLine("Ataque Magico");
            dano += Ataquedecontacto(vida, jele, def);

            dano = Convert.ToInt32(podermagico / dano);
            Console.WriteLine("dano de " + Convert.ToString(dano));

            vida -= dano;
            Console.WriteLine("vida restante del heroe " + Convert.ToString(vida));
            Console.WriteLine("vida restante del monstruo " + Convert.ToString(this.vida));

            return dano;
        }

        public int Ataquemagico(int vida, int jele, int def)
        {
            int dano = 0;

            Console.WriteLine("Ataque Magico");
            dano += Ataquedecontacto(vida, jele, def);

            dano = dano + tamanoalas;
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
                case "ataquemagico":
                    danoss = Ataquemagico(vida, jele, def);

                    break;

                case "vuelo":
                    danoss = vuelo(vida, jele, def);

                    break;
            }

            return danoss;
        }
    }
}
