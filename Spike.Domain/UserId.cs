using Spike.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spike.Domain
{
    public class UserId : ValueObject<UserId>
    {
        private readonly Guid _value;

        public UserId(Guid value) { if (value == default) throw new ArgumentNullException(nameof(value), "User id cannot be empty"); _value = value; }
        public static implicit operator Guid(UserId self) => self._value;
    }


}
