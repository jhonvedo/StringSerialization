using System;
using System.Collections.Generic;
using System.Text;

namespace StringSerialization
{
    public class TextConvertBase
    {
        public TextConvertBase(){}
        public TextConvertBase(string value)
        {
            Fill(value);
        }
        public void Load(string value) => Fill(value);
        private void Fill(string value)
        {
            TextConvert.Fill(value, this);
        }
    }
}
