using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAlumno.Models.ListViewModel
{
    public class ListGradoViewModel
    {
        public int Grd_id { get; set; }
        public string Grd_nombre { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}