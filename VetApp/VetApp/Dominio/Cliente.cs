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

        public Cliente(string Nombre, int Sexo, int IdCliente)
        {
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.IdCliente = IdCliente;
        }

        public Cliente()
        {
            Nombre = string.Empty;
            Sexo = 0;
            IdCliente = 0;
            lstMascotas = new List<Mascota>();
        }

      


        
    }
}