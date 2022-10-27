using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadeteriaWeb.Models;

namespace CadeteriaWeb.Models
{
    public class HelperDeArchivos
    {
        public void cargarListado (List<Cadete> listaCadetes, string fileName)
        {
            string [] content = File.ReadAllLines(fileName);
            
            foreach (string line in content)
            {
                string [] delimitedContent = line.Split(';');
                
                int id = Convert.ToInt32(delimitedContent[0]);
                
                string nombre = delimitedContent[1];
                
                string direccion = delimitedContent[2];
                
                int telefono = Convert.ToInt32(delimitedContent[3]);
                
                Cadete newObject = new Cadete(id, nombre, direccion, telefono);
                listaCadetes.Add(newObject);
            }
        }
    }
}