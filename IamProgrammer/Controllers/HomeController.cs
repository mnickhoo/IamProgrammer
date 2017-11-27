using IamProgrammer;
using IamProgrammer.Models;
using IamProgrammer.Services;
using IdentitySample.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public async Task<ActionResult> Index()
        {
            using (MD5 md5Hash = MD5.Create())
            {
                var hashed = Helper.GetMd5Hash(md5Hash, "mahdinickhoo@gmail.com");
            }
            //System.Diagnostics.Debugger.NotifyOfCrossThreadDependency();

            //ProfileImageService profile = new ProfileImageService();
            //var UsersProfile = db.Users.ToList().Select(async user => new ProfileImageUrl
            //{
            //    url = await Task.Run(() => profile.GetUrlProfileImage(user.Email))
            //}).ToList();

            //TempData["users"] = UsersProfile; 
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
