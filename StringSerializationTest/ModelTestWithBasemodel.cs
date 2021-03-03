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

        [TextProperty(16, 4)]
        public bool Prop3 { get; set; }
        [TextProperty(21, 3)]
        public int Prop4 { get; set; }
        [TextProperty(25, 3)]
        public long Prop5 { get; set; }
    }
}
