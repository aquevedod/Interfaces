using System.Collections.Generic;

namespace Arnold.DataAccess.SQL
{
    public class SqlCrud : ISqlCrud
    {
        public IEnumerable<object> Read()
        {
            return new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
