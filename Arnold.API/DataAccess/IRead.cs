using System.Collections.Generic;

namespace Arnold.DataAccess

{
    public interface IRead
    {
        IEnumerable<object> Read();
    }
}
