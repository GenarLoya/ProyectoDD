using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class monstruo
    {
        public string nombre = "";
        public string descripcion = "";
        public int tamano = 0;
        public bool agresivo = false;
        public int vida = 0;
        public float velocidad = 0;
        public int ataque = 0;
        public int defensa = 0;
        public int elemento = 0;
        public int turno = 0;
        public List<string> ats = new List<string>();
        Random raleat = new Random();
        public int danos = 0;
        public int danoss = 0;
        Random raleat2 = new Random();
        public int at = 0;

        public void Datos()
        {
            Console.WriteLine("------------------------------MODELANDO MONSTRUOS---------------------------------");
            Console.WriteLine("Cargando...");
            Console.WriteLine("------------------------------Monstruo creado---------------------------------");
            Console.WriteLine("------------------------------imprimiendo stats---------------------------------");

            //nombre = nom;
            tamano = raleat.Next(3, 11);
            agresivo = Convert.ToBoolean(raleat.Next(0, 2));
            vida = raleat.Next(6, 21);
            velocidad = raleat.Next(7, 12) / tamano;
            ataque = raleat.Next(3, 10);
            defensa = raleat.Next(2, 5);
            elemento = raleat.Next(0, 5);

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Esta es la ficha tecnica de este monstruo...");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Tamano: " + tamano);
            Console.WriteLine("Agresivo: " + agresivo);
            Console.WriteLine("Vida: " + vida);
            Console.WriteLine("Velocidad: " + velocidad);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Defensa: " + defensa);

            switch (elemento)
            {
                case 0:
                    Console.WriteLine("Elemento: agua");
                    break;

                case 1:
                    Console.WriteLine("Elemento: tierra");
                    break;

                case 2:
                    Console.WriteLine("Elemento: fuego");
                    break;

                case 3:
                    Console.WriteLine("Elemento: aire");
                    break;

                case 4:
                    Console.WriteLine("Elemento: electrico");
                    break;

                case 5:
                    Console.WriteLine("Elemento: normal");
                    break;
            }

            ats.Add("atcontacto");

        }
        public int Ataquedecontacto(int vida, int jele, int def)
        {

            Console.WriteLine("Ataque de contacto");

            double dano = ((ataque * velocidad) / def);

            switch (elemento)
            {
                case 0:
                    switch (jele)
                    {
                        case 0:
                            dano *= 1;
                            break;

                        case 1:
                            dano *= 2;
                            break;

                        case 2:
                            dano *= 2;
                            break;

                        case 3:
                            dano *= .5;
                            break;

                        case 4:
                            dano *= .2;
                            break;

                        case 5:
                            dano *= .5;
                            break;
                    }
                    break;

                case 1:
                    switch (jele)
                    {
                        case 0:
                            dano *= .5;
                            break;

                        case 1:
                            dano *= 1;
                            break;

                        case 2:
                            dano *= 1.5;
                            break;

                        case 3:
                            dano *= 0;
                            break;

                        case 4:
                            dano *= 2;
                            break;

                        case 5:
                            dano *= 1;
                            break;
                    }
                    break;

                case 2:
                    switch (jele)
                    {
                        case 0:
                            dano *= 2;
                            break;

                        case 1:
                            dano *= 2;
                            break;

                        case 2:
                            dano *= 2;
                            break;

                        case 3:
                            dano *= 2;
                            break;

                        case 4:
                            dano *= 2;
                            break;

                        case 5:
                            dano *= 2;
                            break;
                    }
                    break;

                case 3:
                    switch (jele)
                    {
                        case 0:
                            dano *= 0;
                            break;

                        case 1:
                            dano *= .2;
                            break;

                        case 2:
                            dano *= 2;
                            break;

                        case 3:
                            dano *= 1;
                            break;

                        case 4:
                            dano *= 1;
                            break;

                        case 5:
                            dano *= 1;
                            break;
                    }
                    break;

                case 4:
                    switch (jele)
                    {
                        case 0:
                            dano *= 2;
                            break;

                        case 1:
                            dano *= 0;
                            break;

                        case 2:
                            dano *= .5;
                            break;

                        case 3:
                            dano *= 1;
                            break;

                        case 4:
                            dano *= 1;
                            break;

                        case 5:
                            dano *= 1;
                            break;
                    }
                    break;

                case 5:
                    switch (jele)
                    {
                        case 0:
                            dano *= 1;
                            break;

                        case 1:
                            dano *= 2;
                            break;

                        case 2:
                            dano *= 1;
                            break;

                        case 3:
                            dano *= 1;
                            break;

                        case 4:
                            dano *= 1;
                            break;

                        case 5:
                            dano *= .2;
                            break;
                    }
                    break;
            }

            int c = Convert.ToInt32(dano);

            return c;
        }

        public int Ataque(int vida,int jele, int def)
        {
            int dano = 0;

            dano = Ataquedecontacto(vida, jele, def);
            
            Console.WriteLine("dano de " + Convert.ToString(dano));

            vida -= dano;
            Console.WriteLine("vida restante del heroe " + Convert.ToString(vida));
            Console.WriteLine("vida restante del monstruo " + Convert.ToString(this.vida));

            return dano;
        }

        public virtual int calcular_ats(int vida, int jele, int def)
        {
            Console.WriteLine("Estos son los ataques disponibles:");

            for (int i = 0; i < ats.Count; i++)
            {
                Console.WriteLine(ats[i]);
            }

            at = raleat2.Next(0, ats.Count);

            switch (ats[at])
            {
                case "atcontacto":
                    danoss = Ataque(vida, jele, def);

                    break;
            }

            return danoss;
        }
    }
}
