using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBikers.Entidades.Model
{
    public class Moto
    {
        [Key]
        public int MotoID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string UrlFoto { get; set; }

    }
}
