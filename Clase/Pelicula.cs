using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Pelicula
    {
        private int _peliculadirigida;
        private string _nombre;
        private string _fechaestreno;

        public Pelicula() { }

        public Pelicula(int peliculadirigida, string nombre, string fechaestreno)
        {
            _peliculadirigida = peliculadirigida;
            _nombre = nombre;
            _fechaestreno = fechaestreno;

        }

        public int get_peliculadirigida()
        {
            return _peliculadirigida;
        }
        public void set_peliculadirigida(int peliculadirigida)
        {
            _peliculadirigida = peliculadirigida;
        }

        
        public string get_nombre()
        {
            return _nombre;
        }
        public void set_nombre(string nombre)
        {
            _nombre = nombre;
        }

        
        public string get_fechaestreno()
        {
            return _fechaestreno;

        }

        public void set_fechaestreno(string fechaestreno)
        {
            _fechaestreno = fechaestreno;
        }


        public string getPelicula()
        {
            return "Pelicula dirigida por:   " + _peliculadirigida + "Nombre:  " + _nombre + "Fecha de estreno:  " + _fechaestreno;
        }
    }
}