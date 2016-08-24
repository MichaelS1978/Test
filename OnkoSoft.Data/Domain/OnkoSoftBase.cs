using System;
using NHibernate.Proxy;
using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class OnkoSoftBase
    {
        private int? m_OldHashCode;

        [IgnoreForDiff()]
        public virtual DateTime DateLastChange { get; set; }

        [IgnoreForDiff()]
        public virtual int Id { get; protected set; }

        [IgnoreForDiff()]
        public virtual string UserLastChange { get; set; }

        public static bool operator !=(OnkoSoftBase a, OnkoSoftBase b)
        {
            return !(a == b);
        }

        public static bool operator ==(OnkoSoftBase a, OnkoSoftBase b)
        {
            return Equals(a, b);
        }

        public override bool Equals(object obj)
        {
            OnkoSoftBase other = obj as OnkoSoftBase;
            if (other == null)
                return false;

            return Equals(other);
        }

        public virtual bool Equals(OnkoSoftBase other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(other, this))
            {
                return true;
            }

            var otherType = NHibernateProxyHelper.GetClassWithoutInitializingProxy(other);
            var thisType = NHibernateProxyHelper.GetClassWithoutInitializingProxy(this);
            if (!otherType.Equals(thisType))
            {
                return false;
            }

            bool otherIsTransient = Equals(other.Id, 0);
            bool thisIsTransient = Equals(Id, 0);
            if (otherIsTransient || thisIsTransient)
                return false;

            return other.Id.Equals(Id);
        }

        public override int GetHashCode()
        {
            // Once we have a hash code we'll never change it
            if (m_OldHashCode.HasValue)
                return m_OldHashCode.Value;

            bool thisIsTransient = Equals(Id == 0);

            // When this instance is transient, we use the base GetHashCode() and remember it, so an
            // instance can NEVER change its hash code.
            if (thisIsTransient)
            {
                m_OldHashCode = base.GetHashCode();
                return m_OldHashCode.Value;
            }
            return Id.GetHashCode();
        }

        public virtual OnkoSoftBase Copy(bool copyIdentity)
        {
            OnkoSoftBase copy = new OnkoSoftBase();
            CopyTo(copy, copyIdentity);

            return copy;
        }

        public virtual void CopyTo(OnkoSoftBase copy, bool copyIdentity) 
        { 
            if (copyIdentity)
                copy.Id = Id;
            copy.DateLastChange = DateLastChange;
            copy.UserLastChange = UserLastChange;
        }
    }
}