using System.ComponentModel.DataAnnotations;

namespace LO2P02_2021GS650_2020MP_603.Models
{
    public class clientes
    {
 
            [Key]
            [Display(Name = "ID")]
            public int id { get; set; }
            [Display(Name = "Nombre")]
            public string? nombre { get; set; }
            [Display(Name = "Apellido")]
            public string? apellido { get; set; }

            [Display(Name = "Email")]
             public string? email { get; set; }
        [Display(Name = "url imagen")]
        public string? url_imagen { get; set; }

        [Display(Name = "Direccion")]
        public string? direccion { get; set; }

        [Display(Name = "ID del departamento ")]
            public int id_departamento { get; set; }
            [Display(Name = "Id de puesto")]
            public int id_puesto { get; set; }

            [Display(Name = "estado registro")]
            public char? estado_registro { get; set; }
            [Display(Name = "created_at")]
            public int created_at { get; set; }
            [Display(Name = "pdated_at")]
            public decimal updated_at { get; set; }
            
           
            [Display(Name = "Genero")]
            public char? genero { get; set; }
        }
    }

