using System.IO;
using System.Runtime.Serialization;

namespace OnkoSoft.Data.LayoutStorage
{
    [DataContract()]
    public class LayoutStorageByStream : BaseLayoutStorage
    {
        public LayoutStorageByStream()
        {
            LayoutStream = new MemoryStream();
        }

        [DataMember()]
        public MemoryStream LayoutStream { get; private set; }
    }
}
