using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroAlumno.Models.ListViewModel
{
    public class MateriaViewModel
    {
        [Required]
        [Display(Name ="ID")]
        public int Mat_id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "MATERIA")]
        public string Mat_nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "FECHA DE CREACION")]
        public DateTime Created_at { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "FECHA DE ACTUALIZACION")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Updated_at { get; set; }

        
    }
}