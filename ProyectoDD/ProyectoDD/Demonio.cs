using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class Demonio : monstruo
    {
        public int poderoscuro = 0;
        public int nigro = 0;
        Random raleat1 = new Random();

        public Demonio()
        {

            poderoscuro = (int)Math.Floor(Convert.ToDecimal(ataque / 2));

            ats.Add("nigromancia");
            ats.Add("levitacion");

        }

        public int Nigromancia(int vida, int jele, int def)
        {
            int dano = 0;
            nigro = raleat1.Next(1, 5);
            Muertoviviente[] muertos = new Muertoviviente[nigro];

            for (int i = 0; i <= nigro; i++)
            {
                Console.WriteLine("Ataque de muerto " + i);
                dano += muertos[i].Ataquedecontacto(vida, jele, def);
                Console.WriteLine("dano de " + Convert.ToString(dano));

            }

            vida -= dano;
            Console.WriteLine("vida restante del heroe " + Convert.ToString(vida));
            Console.WriteLine("vida restante del monstruo " + Convert.ToString(this.vida));

            return dano;
        }

        public int Levitacion()
        {
            int recobro = 7;

            return recobro;
        }

        public override int calcular_ats(int vida, int jele, int def)
        {
            base.calcular_ats(vida, jele, def);

            switch (ats[at])
            {
                case "nigromancia":
                    danoss = Nigromancia(vida, jele, def);

                    break;

                case "vuelo":
                    danoss = Levitacion();

                    break;
            }

            return danoss;

        }
    }
}
