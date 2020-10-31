using Arnold.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Arnold.Core
{
    public class Manager : IManager
    {
        private readonly ICrud crud;

        public Manager(ICrud crud)
        {
            this.crud = crud;
        }

        public IEnumerable<object> GetAllIPairtems()
        {
            return GetAllItems()
                .Select(x => x as int?)
                .Where(x => x.HasValue && x.Value % 2 == 0)
                .Select(x => x as object)
                .ToArray();
        }

        public IEnumerable<object> GetAllItems()
        {
            return crud.Read();
        }
    }
}
