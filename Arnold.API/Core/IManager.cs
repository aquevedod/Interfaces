using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arnold.Core
{
    public interface IManager
    {
        IEnumerable<object> GetAllItems();
        IEnumerable<object> GetAllIPairtems();
    }
}
