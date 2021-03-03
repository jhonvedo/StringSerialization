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
            string value = "orange|blue|red|true|012|239";
            var @object = TextConvert.Deserialize<ModelTestWithOutBasemodel>(value);

            Assert.Equal("orange",@object.Prop1);
            Assert.Equal("red", @object.Prop2);
            Assert.True(@object.Prop3);
            Assert.Equal(12,@object.Prop4);
            Assert.Equal(239,@object.Prop5);
        }

        [Fact]
        public void ConvertWitBasemodel()
        {
            string value = "orange|blue|red|true|012|239";
            ModelTestWithBasemodel @object = new ModelTestWithBasemodel(value);

            Assert.Equal("orange",@object.Prop1);
            Assert.Equal("red", @object.Prop2);
            Assert.True(@object.Prop3);
            Assert.Equal(12,@object.Prop4);
            Assert.Equal(239,@object.Prop5);
        }

       
    }
}
