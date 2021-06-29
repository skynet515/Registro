using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroAlumno.Models.ListViewModel
{
    public class GradoViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public int Grd_id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "GRADO")]
        public string Grd_nombre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "FECHA DE CREACION")]
        public DateTime Created_at { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "FECHA DE ACTUALIZACION")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime Updated_at { get; set; }
    }
}