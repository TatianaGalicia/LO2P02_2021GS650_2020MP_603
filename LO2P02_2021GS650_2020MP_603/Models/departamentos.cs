using System.ComponentModel.DataAnnotations;

namespace LO2P02_2021GS650_2020MP_603.Models
{
    public class departamentos
    {
        
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Departamento")]
        public string? departamento { get; set; }
        [Display(Name = "Estado")]

        public string? estado { get; set; }
        [Display(Name = "created_at")]

        public string? created_at { get; set; }

       
    }

}

    

