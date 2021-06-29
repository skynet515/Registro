using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAlumno.Models.ListViewModel
{
    public class ListAlumnoViewModel
    {
        public int Alm_id { get; set; }
        public string Alm_nombre { get; set; }
        public int Alm_edad { get; set; }
        public string Alm_sexo { get; set; }
        public int Alm_id_grd { get; set; }
        public string Alm_observaciones { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }


        
    }
}