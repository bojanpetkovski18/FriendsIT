using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Friends.Models
{
    public class FriendModel
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string MestoZiveenje { get; set; }
        List<FriendModel> Friends;

        public FriendModel()
        {
            this.Id = 0;
            this.Ime = "";
            this.MestoZiveenje = "";
            Friends = new List<FriendModel>();
        }
    }
}