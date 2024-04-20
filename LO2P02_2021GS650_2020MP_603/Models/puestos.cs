﻿using System.ComponentModel.DataAnnotations;

namespace LO2P02_2021GS650_2020MP_603.Models
{
    public class puestos
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Puesto")]

        public string? puesto { get; set; }

        [Display(Name = "Estado")]

        public string? estado { get; set; }

        [Display(Name = "Created at")]

        public string? created_at { get; set; }
    }
}
