using System.Collections.Generic;
using System.Linq;

namespace Arnold.DataAccess.EF
{
    public class EFCrud : IEFCrud
    {
        public IEnumerable<object> Read()
        {
            return Enumerable
                .Range(1, 100)
                .Select(x => x as object)
                .ToArray();
        }
    }
}
