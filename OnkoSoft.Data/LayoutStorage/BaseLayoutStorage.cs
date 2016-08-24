using System.Runtime.Serialization;

namespace OnkoSoft.Data.LayoutStorage
{
    [DataContract()]
    [KnownType(typeof(LayoutStorageByProperty))]
    [KnownType(typeof(LayoutStorageByStream))]
    public abstract class BaseLayoutStorage
    {
        [DataMember()]
        public string ControlName { get; set; }
    }
}
