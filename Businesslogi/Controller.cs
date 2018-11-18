using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
namespace Businesslogi
{
    
    public class Controller
    {
        Database.Database CasesDatabase = new Database.Database();

        public void CreateCase()
        {
            CasesDatabase.CreateCase( )
        }
    }
}
