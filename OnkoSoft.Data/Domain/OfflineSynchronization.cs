using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnkoSoft.Data.Domain
{
    public class OfflineSynchronization : OnkoSoftBase
    {
        public virtual DateTime SynchronizationDate { get; set; }
    }
}
