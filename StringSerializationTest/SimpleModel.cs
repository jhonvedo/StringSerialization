using StringSerialization;

using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerializationTest
{
    public class SimpleModel : TextConvertBase
    {
        [TextProperty(0, 6)]
        public string Prop1 { get; set; }

        [TextProperty(0, 6, false)]
        public string Prop2 { get; set; }



    }

    public class SimpleModel2 : TextConvertBase
    {

        [TextProperty(0, 6, false)]
        public string Prop1 { get; set; }
    }
}