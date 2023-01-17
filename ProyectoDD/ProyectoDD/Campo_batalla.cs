using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoDD
{
    class Campo_batalla
    {
        Random raleat = new Random();
        public int danos = 0;
        Random raleat2 = new Random();
        public int at = 0;
        public int mon = 0;
        public int turn = 1;

        public Campo_batalla()
        {
            Console.WriteLine("Estas en un juego, donde eres un humano que va por ahi luchando contra monstruos.");

            //Jugador
            humano hum1 = new humano();

            //Monstruos
            /*
            Aberracion = 0
            Angel = 1
            Bestia = 2
            Demonio = 3
            Dragon = 4
             */

            mon = raleat2.Next(0, 5);

            switch(mon)
            {
                case 0:
                    Aberracion ab = new Aberracion();
                    ab.Datos();

                    while (ab.vida >= 0 && hum1.vida >= 0)
                    {
                        turn++;

                        if (turn % 2 != 0)
                        {
                            if(ab.ats[ab.at] == "atmultiple")
                            {
                                hum1.vida -= ab.calcular_ats(hum1.vida,hum1.elemento,hum1.defensa);
                            }
                            else if (ab.ats[ab.at] == "amorfo")
                            {
                                ab.vida += ab.calcular_ats(hum1.vida, hum1.elemento, hum1.defensa);
                            }
                        }
                        else if (turn % 2 == 0)
                        {
                            int des = 0;

                            des = Convert.ToInt32(hum1.decision());

                            if (des == 0)
                            {
                                ab.vida -= hum1.Ataquedecontacto(ab.vida, ab.elemento, ab.defensa);
                            }
                            else if (des == 1)
                            {
                                Console.WriteLine("Has Huido, cobarde.... FINALIZANDO SESION");
                                break;
                                
                            }
                        }

                        if (hum1.vida <= 0)
                        {
                            Console.WriteLine("Has perdido la batalla.... FINALIZANDO SESION");
                        }
                        else if (ab.vida <= 0)
                        {
                            Console.WriteLine("Has ganado la batalla.... FINALIZANDO SESION");
                        }
                    }

                    break;

                case 1:
                    Angel an = new Angel();
                    an.Datos();

                    while (an.vida >= 0 && hum1.vida >= 0)
                    {
                        turn++;

                        if (turn % 2 != 0)
                        {
                            hum1.vida -= an.calcular_ats(hum1.vida, hum1.elemento, hum1.defensa);
                        }
                        else if (turn % 2 == 0)
                        {
                            int des = 0;

                            des = hum1.decision();

                            if (des == 0)
                            {
                                an.vida -= hum1.Ataquedecontacto(an.vida, an.elemento, an.defensa);
                            }
                            else if (des == 1)
                            {
                                Console.WriteLine("Has Huido, cobarde.... FINALIZANDO SESION");
                                break;
                            }
                        }

                        if (hum1.vida <= 0)
                        {
                            Console.WriteLine("Has perdido la batalla.... FINALIZANDO SESION");
                        }
                        else if (an.vida <= 0)
                        {
                            Console.WriteLine("Has ganado la batalla.... FINALIZANDO SESION");
                        }
                    }

                    break;

                case 2:
                    Bestia be = new Bestia();
                    be.Datos();

                    while (be.vida >= 0 && hum1.vida >= 0)
                    {

                        turn++;

                        if (turn % 2 != 0)
                        {
                            hum1.vida -= be.calcular_ats(hum1.vida, hum1.elemento, hum1.defensa);
                        }
                        else if (turn % 2 == 0)
                        {
                            int des = 0;

                            des = hum1.decision();

                            if (des == 0)
                            {
                                be.vida -= hum1.Ataquedecontacto(be.vida, be.elemento, be.defensa);
                            }
                            else if (des == 1)
                            {
                                Console.WriteLine("Has Huido, cobarde.... FINALIZANDO SESION");
                                break;

                            }
                        }
                    }

                    break;

                case 3:
                    Demonio de = new Demonio();
                    de.Datos();

                    while (de.vida >= 0 && hum1.vida >= 0)
                    {
                        turn++;

                        if (turn % 2 != 0)
                        {
                            if (de.ats[de.at] == "nigromancia")
                            {
                                hum1.vida -= de.calcular_ats(hum1.vida, hum1.elemento, hum1.defensa);
                            }
                            else if (de.ats[de.at] == "levitacion")
                            {
                                de.vida += de.calcular_ats(hum1.vida, hum1.elemento, hum1.defensa);
                            }
                        }
                        else if (turn % 2 == 0)
                        {
                            int des = 0;

                            des = hum1.decision();

                            if (des == 0)
                            {
                                de.vida -= hum1.Ataquedecontacto(de.vida, de.elemento, de.defensa);
                            }
                            else if (des == 1)
                            {
                                Console.WriteLine("Has Huido, cobarde.... FINALIZANDO SESION");
                                break;
                                
                            }
                        }

                        if (hum1.vida <= 0)
                        {
                            Console.WriteLine("Has perdido la batalla.... FINALIZANDO SESION");
                        }
                        else if (de.vida <= 0)
                        {
                            Console.WriteLine("Has ganado la batalla.... FINALIZANDO SESION");
                        }
                    }

                    break;

                case 4:
                    Dragon dr = new Dragon();
                    dr.Datos();

                    while (dr.vida >= 0 && hum1.vida >= 0)
                    {
                        turn++;

                        if (turn % 2 != 0)
                        {
                            hum1.vida -= dr.calcular_ats(hum1.vida, hum1.elemento, hum1.defensa);
                        }
                        else if (turn % 2 == 0)
                        {
                            int des = 0;

                            des = hum1.decision();

                            if (des == 0)
                            {
                                dr.vida -= hum1.Ataquedecontacto(dr.vida, dr.elemento, dr.defensa);
                            }
                            else if (des == 1)
                            {
                                Console.WriteLine("Has Huido, cobarde.... FINALIZANDO SESION");
                                break;
                                
                            }
                        }

                        if (hum1.vida <= 0)
                        {
                            Console.WriteLine("Has perdido la batalla.... FINALIZANDO SESION");
                        }
                        else if (dr.vida <= 0)
                        {
                            Console.WriteLine("Has ganado la batalla.... FINALIZANDO SESION");
                        }
                    }

                    break;
            }

        }

    }
}
