using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Controller_Basic.Controllers
{
    public class FriendController : Controller
    {
        public List<string> FriendList()
        {
            List<string> friends = new List<string>()
            {
                "Shovon","Limon","Pranto","Tushar"
            };

            return friends;
        }

        public string BestFriend(int id)
        {
            return $"Best Friend id is {id}";
        }
        public string FriendSubject(string name, string subject)
        {
            return $"Friend Name: {name} Subject:{subject}";
        }
    }
}
