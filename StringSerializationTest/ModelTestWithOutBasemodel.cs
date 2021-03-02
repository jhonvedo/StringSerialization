using StringSerialization;

using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerializationTest
{
    public class ModelTestWithOutBasemodel
    {
        [TextProperty(0, 6)]
        public string Prop1 { get; set; }
        [TextProperty(12, 3)]
        public string Prop2 { get; set; }
    }
}
