using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class humano
    {
        public string nombre = "";
        public string descripcion = "";
        public int tamano = 0;
        public int vida = 0;
        public float velocidad = 0;
        public int ataque = 0;
        public int defensa = 0;
        public int elemento = 0;
        public int clase = 0;
        public int turno = 0;

        public humano()
        {
            Console.WriteLine("Escribe el nombre de tu personaje: ");
            nombre = Console.ReadLine();
           
            do
            {
                try
                {
                    Console.Write("Escribe el tamano de tu personaje(valor entre 3-10): ");
                    tamano = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                }

            } while (tamano < 3 || tamano > 10);

            Console.WriteLine("Ahora es necesario que escribas la clase de tu personaje(valor entre 0-3): ");
            Console.WriteLine("0-guerrero" +
                "1-arquero" +
                "2-ninja" +
                "3-mago");
            do
            { 
                try
                {
                    Console.WriteLine("Elige...(escribe un numero entre 1 y 3) ");
                    clase = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                }

            } while (clase <= -1 || clase >= 4);

            Console.WriteLine("De acuerdo a la clase que escogiste puedes elegir los siguientes tipos de armas(eleige el numero al lado del arma): ");

            switch (clase)
            {
                case 0:
                    Console.WriteLine("0-agua" +
                        " 5-normal");
                    do
                    {  
                        try
                        {
                            Console.WriteLine("Elige... ");
                            elemento = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                        }

                    } while (elemento != 0 && elemento != 5);

                    break;

                case 1:
                    Console.WriteLine("3-aire" +
                        " 4-electrico");
                    do
                    {
                        try
                        {
                            Console.WriteLine("Elige... ");
                            elemento = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                        }

                    } while (elemento != 3 && elemento != 4);
                    break;

                case 2:
                    Console.WriteLine("1-tierra" +
                        " 3-aire");
                    do
                    {
                        try
                        {
                            Console.WriteLine("Elige... ");
                            elemento = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                        }

                    } while (elemento != 1 && elemento != 3);
                    break;

                case 3:
                    Console.WriteLine("0-agua" +
                        " 4-fuego");
                    do
                    {
                        try
                        {
                            Console.WriteLine("Elige... ");
                            elemento = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                        }

                    } while (elemento != 0 && elemento != 4);
                    break;
            }

            Console.WriteLine("Se te ha otorgado un arma de tu tipo, ahora ponle un nombre... ");
            arma arm1 = new arma();
            arm1.nombre = Console.ReadLine();

            switch (clase)
            {
                case 0:
                    velocidad = 7 / tamano;
                    vida = 20;
                    defensa = 5;
                    ataque = 2;
                    break;

                case 1:
                    velocidad = 9 / tamano;
                    vida = 11;
                    defensa = 3;
                    ataque = 2;
                    break;

                case 2:
                    velocidad = 10 / tamano;
                    vida = 15;
                    defensa = 1;
                    ataque = 1;
                    break;

                case 3:
                    velocidad = 6 / tamano;
                    vida = 9;
                    defensa = 10;
                    ataque = 2;
                    break;
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Esta es la ficha tecnica de tu personaje...");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Tamano: " + tamano);
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

            switch (clase)
            {
                case 0:
                    Console.WriteLine("Clase: Guerrero");
                    break;

                case 1:
                    Console.WriteLine("Clase: Arquero");
                    break;

                case 2:
                    Console.WriteLine("Clase: Ninja");
                    break;

                case 3:
                    Console.WriteLine("Clase: Mago");
                    break;
            }

            Console.WriteLine("Arma: " + arm1.nombre);

        }

        public int Ataquedecontacto(int vida, int jele, int def)
        {

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

            Console.WriteLine("dano de " + Convert.ToString(dano));

            vida -= Convert.ToInt32(dano);
            Console.WriteLine("vida restante del heroe " + Convert.ToString(this.vida));
            Console.WriteLine("vida restante del monstruo " + Convert.ToString(vida));

            int c = 0;
            c = Convert.ToInt32(dano);

            return c;
        }

        public int decision()
        {
            int dec = 0;
            Console.WriteLine("QUE QUIERES HACER?");
            Console.WriteLine("0-Atacar");
            Console.WriteLine("1-Huir");
            
            
            do
            {
                
                try
                {
                    Console.WriteLine("DECIDE....(escribe solo 0 y 1)");
                    dec = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                }

            } while (dec != 0 && dec != 1);

            return dec;
        }
    }
}
