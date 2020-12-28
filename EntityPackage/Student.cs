using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class Student : ActiveRecord
    {
        public int? id { get; set; }
        public string StudentId { get; set; }
        public string Password { get; set; }
        public int? Class_id { get; set; }
        public int? MapPermissins_id { get; set; }
        public string State { get; set; }
        public Student() : base("tb_Student", "id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
