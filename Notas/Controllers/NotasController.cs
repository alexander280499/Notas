
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notas.Controllers
{
    public class NotasController : Controller
    {
       
        // GET: Notas
        public ActionResult Index()
        {
            if (Request.HttpMethod == "POST")
            {
                ViewBag.nombre = Request["nombre"];
                ViewBag.grado = Request["grado"];


                var nota1M = Convert.ToDouble(Request["nota1M"]);
                var nota2M = Convert.ToDouble(Request["nota2M"]);
                var nota3M = Convert.ToDouble(Request["nota3M"]);
                var promedioM =Math.Round(((nota1M*0.33) + (nota2M*0.33) + (nota3M*0.34)),2);
                ViewBag.promedioM = promedioM;
               

                

                var nota1C = Convert.ToDouble(Request["nota1C"]);
                var nota2C = Convert.ToDouble(Request["nota2C"]);
                var nota3C = Convert.ToDouble(Request["nota3C"]);
                var promedioC = Math.Round(((nota1C*0.33) +( nota2C*0.33) + (nota3C*0.34)),2);
                ViewBag.promedioC = promedioC;
                



                var nota1L = Convert.ToDouble(Request["nota1L"]);
                var nota2L = Convert.ToDouble(Request["nota2L"]);
                var nota3L = Convert.ToDouble(Request["nota3L"]);
                var promedioL=Math.Round(((nota1L*0.33) +( nota2L*0.33) + (nota3L*0.34)),2);
                ViewBag.promedioL = promedioL;
                


                var nota1T = Convert.ToDouble(Request["nota1T"]);
                var nota2T = Convert.ToDouble(Request["nota2T"]);
                var nota3T = Convert.ToDouble(Request["nota3T"]);
                var promedioT=Math.Round(((nota1T * 0.33) + (nota2T * 0.33) + (nota3T * 0.34)),2);

                ViewBag.promedioT = promedioT;
                
                ViewBag.cum =Math.Round((promedioM + promedioC + promedioL + promedioT)/3,2);
                return View("Resultado");



            }
            return View();
        }

        public ActionResult Resultado()
        {
            return View();
        }
    }
            
       
}