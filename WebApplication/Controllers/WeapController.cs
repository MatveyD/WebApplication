using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class WeapController : Controller
    {
        // GET: Weap
        public ActionResult Weap()
        {
            WeapModels[] weapons = {
                                           new WeapModels{WeaponName ="AK", WeaponMade= "USSR", WeaponPrice = "500", PicUrl="AK.jpg"},
                                           new WeapModels{WeaponName ="M-60", WeaponMade= "USA", WeaponPrice = "1 500", PicUrl="m60.jpg"},
                                           new WeapModels{WeaponName ="RPG", WeaponMade= "USSR", WeaponPrice = "1 000", PicUrl="RPG.jpg"},
                                           new WeapModels{WeaponName ="Light Saber", WeaponMade= "Old Republic", WeaponPrice = "27 999", PicUrl="LightSaber.jpg"},
                                           new WeapModels{WeaponName ="Bolter", WeaponMade= "Imperium", WeaponPrice = "10 000", PicUrl="Bolter.jpg"},

                                       };


            return View(weapons);
        }

        public ActionResult Lottery()
        {
            WeapModels lot = new WeapModels
            {
                WeaponName = "Light Saber",
                WeaponMade = "Old Republic",
                WeaponPrice = "27 999",
                PicUrl = "LightSaber.jpg"
            };

            return View(lot);
        }
    }
}