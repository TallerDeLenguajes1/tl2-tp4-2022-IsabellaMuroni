using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeteriaWeb.Models;

namespace CadeteriaWeb.Models
{
    public class Pedido
    {
        private int NRO;
        private string OBS;
        private Cliente Cliente;
        private bool Estado;

        public int nro { get; set; }
        public string obs { get; set; }
        public Cliente cliente { get; set; }
        public bool estado { get; set; }
    }
}