using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usersNew
{
    public class Student {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname1 { get; set; }
        public string lastname2 { get; set; }
        public string group { get; set; }
        public string color { get; set; } 

        public Student(int id, string name, string lastname1, string lastname2, string group, string color)
        {
            this.id = id;
            this.name = name;
            this.lastname1 = lastname1;
            this.lastname2 = lastname2;
            this.group = group;
            this.color = color;
        }

    }
}
