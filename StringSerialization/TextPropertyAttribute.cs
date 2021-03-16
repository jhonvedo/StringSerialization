using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerialization
{
    public class TextPropertyAttribute: Attribute
    {
        public int From { get; internal set; }
        public int? Length { get; internal set; }

        public bool AllowPositionException { get; internal set; }

        public TextPropertyAttribute(int from, int length,bool allowPositionException = true)
        {
            From = from;
            Length = length;
            AllowPositionException = allowPositionException;
        }
        public TextPropertyAttribute(int from,bool allowPositionException = true)
        {
            From = from;
            Length = null;
            AllowPositionException = allowPositionException;
        }
    }
}
