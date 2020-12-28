using Console.DBLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.EntityPackage
{
    class Administrator : ActiveRecord
    {
        public int? id { get; set; }
        public string AdministratorName { get; set; }
        public Administrator() : base("tb_Administrator", "id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
