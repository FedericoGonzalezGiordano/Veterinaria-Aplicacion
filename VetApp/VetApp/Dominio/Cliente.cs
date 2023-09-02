using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Dominio
{
    public class Cliente
    {
     
        public string Nombre { get; set; }
        public int Sexo { get; set; }
        public int IdCliente { get; set; }

        public List<Mascota> lstMascotas { get; set; }

        public Cliente(int IdCliente,string Nombre, int Sexo)
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
            this.Sexo = Sexo;
        }

        public Cliente()
        {
            Nombre = string.Empty;
            Sexo = 0;
            IdCliente = 0;
            lstMascotas = new List<Mascota>();
        }
        
        public string SexoCliente() 
        {
            string sexo=string.Empty;
            if (Sexo == 1)
            {
                sexo = "Hombre";
            }
            else 
            {
                sexo = "Mujer";
            }
            return sexo;
        }
      

        //public 
        
    }
}