using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OnkoSoft.Data.LayoutStorage
{
    [DataContract()]
    public class LayoutStorageByProperty : BaseLayoutStorage
    {
        public LayoutStorageByProperty()
        {
            PropertyBag = new Dictionary<string, string>();
        }

        [DataMember()]
        public Dictionary<string, string> PropertyBag { get; private set; }

    }
}
