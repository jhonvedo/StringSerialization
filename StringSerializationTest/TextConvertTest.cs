using StringSerialization;

using System;

using Xunit;

namespace StringSerializationTest
{
    public class TextConvertTest
    {
        [Fact]
        public void ConvertWithoutBasemodel()
        {
            string value = "orange|blue|red";
            var @object = TextConvert.Deserialize<ModelTestWithOutBasemodel>(value);

            Assert.Equal("orange",@object.Prop1);
            Assert.Equal("red", @object.Prop2);
        }

        [Fact]
        public void ConvertWitBasemodel()
        {
            string value = "orange|blue|red";
            ModelTestWithBasemodel @object = new ModelTestWithBasemodel(value);

            Assert.Equal("orange", @object.Prop1);
            Assert.Equal("red", @object.Prop2);
        }
    }
}
