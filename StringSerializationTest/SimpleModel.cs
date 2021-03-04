using StringSerialization;

using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerializationTest
{
    public class SimpleModel: TextConvertBase
    {
        [TextProperty(0, 6)]
        public string Prop1 { get; set; }
    }
}
