using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class Aberracion : monstruo
    {
        Random raleat1 = new Random();

        public int multiataque = 0;

        public Aberracion()
        {
            multiataque = raleat1.Next(2, 4);
            nombre = "Aberracion";
            velocidad = (int)Math.Floor(Convert.ToDecimal(velocidad / 2));
            ataque = (int)Math.Floor(Convert.ToDecimal(ataque / 2));
            ats.Add("atmultiple");
            ats.Add("amorfo");
        }


        public int Ataquemultiple(int vida, int jele, int def)
        {
            int dano = 0;
            
            Console.WriteLine("Ataque Multiple");

            for (int i = 0; i < multiataque; i++)
            {
                Console.WriteLine("Ataque" + Convert.ToString(i) + "...");
                dano += Ataquedecontacto(vida, jele, def);
                Console.WriteLine("dano de " + Convert.ToString(dano));
            }

            vida -= dano;
            Console.WriteLine("vida restante del heroe " + Convert.ToString(vida));
            Console.WriteLine("vida restante del monstruo " + Convert.ToString(this.vida));

            return dano;
        }

        public int Amorfo()
        {
            int recobro = 0;

            Console.WriteLine("Amorfo");

            Random raleat1 = new Random();

            recobro = raleat1.Next(2, 4);

            Console.WriteLine("Ha recuperado " + Convert.ToString(recobro));

            return recobro;
        }

        public override int calcular_ats(int vida, int jele, int def)
        {
            base.calcular_ats(vida, jele, def);

            switch (ats[at])
            {
                case "atmultiple":
                    danoss = Ataquemultiple(vida, jele, def);

                    break;

                case "amorfo":
                    danoss = Amorfo();

                    break;
            }

            return danoss;
        }
    }
}

