﻿using Spike.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spike.Domain
{
    public class ClassifiedAdId
    {
        private readonly Guid _value;
        public ClassifiedAdId(Guid value) { if (value == default) throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty"); _value = value; }
        public static implicit operator Guid(ClassifiedAdId self) => self._value;
    }

}
