using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._1._1
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Nivel { get; set; }

        public Personaje(string nombre, int vida, int ataque, int defensa, int nivel)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            Defensa = defensa;
            Nivel = nivel;

            Console.WriteLine($"" +
                $"Nombre: {Nombre}," +
                $" Vida: {Vida}, " +
                $"Ataque: {Ataque}," +
                $" Defensa: {Defensa}, " +
                $"Nivel: {Nivel}");
        }



    }
}
