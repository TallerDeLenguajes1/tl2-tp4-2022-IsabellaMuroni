using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CadeteriaWeb.Models
{
    public class Cadeteria
    {
        private string Nombre;
        private string Telefono;
        private List<Cadete> ListaCadetes;

        public string nombre { get => Nombre; set => Nombre = value; }
        public string telefono { get => Telefono; set => Telefono = value; }
        public List<Cadete> listaCadetes { get => ListaCadetes; set => ListaCadetes = value; }

        public Cadeteria(string nombre, string telefono, List<Cadete> listaCadetes)
        {
            Nombre = nombre;
            Telefono = telefono;
            listaCadetes = new List<Cadete>();
        }
        
        public static void cargarListado (List<Cadete> listaCadetes, string fileName)
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