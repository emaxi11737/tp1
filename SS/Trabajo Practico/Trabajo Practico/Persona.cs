using System;
using System.Collections.Generic;

namespace Trabajo_Practico
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string fechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string colorFavorito { get; set; }
        public string generosFavoritos { get; set; }
        public void modificarDatos(string nombre,string apellido,int edad,string sexo,string colorFavorito,string fecha,string generosFav)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.colorFavorito = colorFavorito;
            this.fechaNacimiento = fecha;
            this.generosFavoritos = generosFav;
        }
        public Persona(string nombre,string apellido,int edad,string sexo,string colorFavorito,string fecha,string generosFav)
        
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.colorFavorito = colorFavorito;
            this.fechaNacimiento = fecha;
            this.generosFavoritos = generosFav;

        }
    }
  
}