using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroAlumno.Models.ListViewModel
{
    public class AlumnoViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public int Alm_id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "NOMBRE")]
        public string Alm_nombre { get; set; }
        [Required]
        [Display(Name = "EDAD")]
        public int Alm_edad { get; set; }
        [StringLength(100)]
        [Display(Name = "SEXO")]
        public string Alm_sexo { get; set; }
        [Required]
        [Display(Name = "GRADO")]
        public int Alm_id_grd { get; set; }
        [StringLength(100)]
        [Display(Name = "OBSERVACIONES")]
        public string Alm_observaciones { get; set; }
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