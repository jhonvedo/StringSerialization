using StringSerialization;

using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerializationTest
{
    public class ModelTestWithBasemodel : TextConvertBase
    {
        public ModelTestWithBasemodel(string value):base(value)
        {

        }

        [TextProperty(0, 6)]
        public string Prop1 { get; set; }
        [TextProperty(12, 3)]
        public string Prop2 { get; set; }
    }
}
