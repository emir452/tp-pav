using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
namespace entity_builder
{
 public     class ManagerBuilder
    {
        public Manager parseManager(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Manager manager = new Manager();
            manager.id = int.Parse(row[0].ToString());
            manager.name = row[1].ToString();
            manager.surname = row[2].ToString();
            manager.email = row[3].ToString();
            return manager;
        }

    }
}
