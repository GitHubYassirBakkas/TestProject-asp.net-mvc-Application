using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class DetailsFiliere
    {
        public int Id { get; set; }
        public string Nom { get; set; }
       public string Num { get; set; }

        public List<YassirEntities> Avis;
    }
}