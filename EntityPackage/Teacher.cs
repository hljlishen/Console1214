using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class Teacher : ActiveRecord
    {
        public int? id { get; set; }
        public string TeacherId { get; set; }
        public string Password { get; set; }
        public int? MapPermissins_id { get; set; }
        public string State { get; set; }
        public Teacher() : base("tb_Teacher","id",DbLinkManager.databaseType,DbLinkManager.connectString)
        { 
        
        }
    }
}
