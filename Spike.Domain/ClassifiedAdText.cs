using Spike.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spike.Domain
{
    public class ClassifiedAdText : ValueObject<ClassifiedAdText>
    {
        public string Value { get; }
        internal ClassifiedAdText(string text) => Value = text;
        public static ClassifiedAdText FromString(string text)
        => new ClassifiedAdText(text);
        public static implicit operator string(ClassifiedAdText text)
        => text.Value;
    }
}
