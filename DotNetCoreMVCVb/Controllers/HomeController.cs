using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace DotNetCoreMVCVb.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "Rode Kool", "Spruitjes", "Broccoli", "Wortel", "Spinazie", "Bloemkool" };

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12? "Goeiemorgen" : "Goedeavond";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groente is " +
                 $"de {Array.IndexOf(groenten, zoekGroente)+1}e uit de lijst";
            }

            return View();
        }


        public ViewResult Student(string name)
        {
            List<Student> studenten = new List<Student>
            {
                new Student {Id=23, Naam="Jefke", AfstudeerGraad=Graad.Voldoening},
                new Student {Id=23, Naam="Marieke", AfstudeerGraad=Graad.Onderscheiding}

            };
            ViewBag.Studenten = studenten;
            return View();
        }
    }

}