using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Models
{
    public  class Member:BaseEntity
    {


        public string ImgPath { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public  int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
