using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOT.Models.User.building.Buildings
{
    public class SoliderHouse
    {
        public int id { get; set; }
        public int lev { get; set; }
        public User.UserModel.UserM Building { get; set; }
        public string Buildingid { get; set; }
    }
}
