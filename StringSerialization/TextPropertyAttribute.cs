using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerialization
{
    public class TextPropertyAttribute: Attribute
    {
        public int From { get; internal set; }
        public int Length { get; internal set; }


        public TextPropertyAttribute(int from, int length)
        {
            From = from;
            Length = length;
        }
    }
}
