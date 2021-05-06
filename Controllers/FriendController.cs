using Friends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend
        public static List<FriendModel> Friends = new List<FriendModel>()
        {
            new FriendModel() { Id = 0, Ime = "Someone", MestoZiveenje = "Metsoziveenje" }
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowFriends()
        {
            return View(Friends);
        }

        public ActionResult NewFriend()
        {
            FriendModel Model = new FriendModel();
            return View(Model);
        }

        [HttpPost] 
        public ActionResult NewFriend(FriendModel Model)
        {
            Friends.Add(Model);
            return View("ShowFriends");
        }

        public ActionResult EditFriend(int id)
        {
            FriendModel friendForUpdate = Friends.ElementAt(id);
            friendForUpdate.Id = id;
            return View(Friends.ElementAt(id));
        }

        [HttpPost]
        public ActionResult EditFriend(FriendModel Model)
        {
            FriendModel forUpdate = Friends.ElementAt(Model.Id);
            forUpdate.Ime = Model.Ime;
            forUpdate.MestoZiveenje = Model.MestoZiveenje;
            return View("ShowFriends");
        }

        public ActionResult DeleteFriend(int id)
        {
            Friends.RemoveAt(id);
            return View("ShowFriends");
        }
    }
}