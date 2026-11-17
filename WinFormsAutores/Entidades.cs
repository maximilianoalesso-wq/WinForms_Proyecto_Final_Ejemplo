using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAutores
{
    //solo se usa para comunicación con la API (DTO - Data Transfer Object)
    public class AutorDTO
    {
        public string nombre { get; set; }  
        public int edad {  get; set; }
    }

    //clase tal cual está definida la tabla Autor
    public class Autor
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public int edad { get; set; }
    }

}
