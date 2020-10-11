using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class personelController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.personels.ToList();
         
            var query = from person in c.personels
                        join dep in c.departmanlars on person.departid equals dep.id
                        select new personel()
                        {
                            ad = person.ad,
                            soyad = person.soyad,
                            sehir = person.sehir,
                            perid = person.perid,
                            departid = person.departid,
                            depart = new departmanlar()
                            {
                                id = dep.id,
                                departmanad = dep.departmanad,
                                personels = null
                            }
                        };
            return View(query.ToList());
        }
    }
}