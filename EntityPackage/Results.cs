using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class Results : ActiveRecord
    {
        public int? id { get; set; }
        public string Course { get; set; }
        public double? Resule { get; set; }
        public int? Student_id { get; set; }
        public DateTime? DateTime { get; set; }

        public Results() : base("tb_Results", "id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
