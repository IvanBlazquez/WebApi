using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InterfazdeBeers.Models
{
    [Table("Beer")]
    public class Beer
    {
        [Key]
        public Object _id { get; set; }
        [Required][StringLength(50)]
        public string Marca { get; set; }
        [Required][StringLength(50)]
        public string Origen { get; set; }
        [Required][StringLength(50)]
        public string Tipo { get; set; }
        public double Grados { get; set; }
        public string Imagen { get; set; }
        
    }
}
