using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNikon;
using RepoNikon.Factroy;
using RepoNikon.Models.BaseModels;
using RepoNikon.Models.ViewModeles;



namespace Nikon_Soren_Filip.Controllers
{
    public class HomeController : Controller
    {
        ProduktList produktliste = new ProduktList();
        ProduktFac  ProduktPost = new ProduktFac();
        KategoriFac kf = new KategoriFac();
        ForsideFac ff = new ForsideFac();
        FooterFac Foot = new FooterFac();
        
        // GET: Home

        public ActionResult Index()
        {
            return View(kf.GetForsideKats(ff.Get(1)));
        }
        
    
    }
}