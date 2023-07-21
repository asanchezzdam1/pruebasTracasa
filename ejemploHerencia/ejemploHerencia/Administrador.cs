using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploHerencia
{
    public class Administrador : Empleado
    {
        public bool plaza{ get; set; }
        public int numero{ get; set; }
        public Administrador(string nombre) : base(nombre)
        {
        }        
        public Administrador(string nombre, bool plaza) : base(nombre)
        {
            this.plaza = plaza;
        }        
        public Administrador(string nombre, bool plaza, int numero) : base(nombre)
        {
            this.plaza = plaza;
            this.numero = numero;
        }

        public string PlazaParking()
        {
            // TODO: Conectar a BBDD
            return  new ErrorBaseDatosExcepcion("Error al contectar a BBDD", DateTime.Now).toString();
            //return plaza ? numero.ToString() : "No tiene plaza";
        }
        public override string ToString()
        {
            string str = "El empleado pertenece al grupo: Administrador y su nombre es: " + nombre;
            if (plaza)
                str += ". El Adminstrador tiene plaza y su numero de plaza es: " + numero.ToString();
            else 
                str += ". El Administrado no tiene plaza de garaje.";
            str += ". Y tiene " + diasVacaciones + " dias de vacaciones.";
            return str;
        }
    }
}