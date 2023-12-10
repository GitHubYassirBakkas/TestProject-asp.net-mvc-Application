using Microsoft.Ajax.Utilities;
using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class FiliereController : Controller
    {
        // GET: Filiere
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ToutelesFilieres()
        {
            var listFilier = new List<filiere>();
            using (YassirEntities context = new YassirEntities())
            {
                listFilier = context.filieres.ToList();

            }
            return View(listFilier);
        }
        public ActionResult DetailsFilier(string Nom)
        {
            var vm = new DetailsFiliere();
            using (YassirEntities context = new YassirEntities())
            {
                var filier = context.filieres.Where(a => a.nom_filiere == Nom).FirstOrDefault();
                if (filier == null)
                {
                    return RedirectToAction("ToutelesFilieres");
                }
                vm.Num = filier.nom_filiere;
                vm.Id = filier.id_filiere;
                vm.Nom = filier.nom_filiere;
            }

           
            return View(vm); 
        }
    }
}



 