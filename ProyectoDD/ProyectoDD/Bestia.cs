using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class Bestia : monstruo
    {
        public int afilado = 0;
        public int extremidades = 0;

        public Bestia()
        {
            Random raleat1 = new Random();

            afilado = raleat1.Next(1, 3);
            extremidades = raleat1.Next(1, 3);

            nombre = "Bestia";
            velocidad = velocidad * extremidades;

            ats.Add("mordisco");
        }

        public int mordisco(int vida, int jele, int def)
        {
            int dano = 0;
            
            Console.WriteLine("Mordisco");
            dano = Ataquedecontacto(vida, jele, def) * afilado;
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
                case "mordisco":
                    danoss = mordisco(vida, jele, def);

                    break;
            }

            return danoss;
        }
    }
}

