using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAlumno.Models.ListViewModel
{
    public class ListMateriaViewModel
    {
        public int Mat_id { get; set; }
        public string Mat_nombre { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}