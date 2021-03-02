﻿using System;
using System.Linq;
using System.Reflection;

namespace StringSerialization
{
    public static class TextConvert
    {
        public static T Deserialize<T>(string value) where T : class
        {
            Type type = typeof(T);
            var instance = (T)Activator.CreateInstance(type);
            Fill(value, instance);

            return instance;
        }

        public static void Fill<T>(string value,T model) where T : class
        {
            Type type = model.GetType();

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                if (propertyInfo.IsDefined(typeof(TextPropertyAttribute)))
                {
                    var attribute = (TextPropertyAttribute)propertyInfo.GetCustomAttributes(typeof(TextPropertyAttribute)).First();
                    var newPropertyValue = GetPositionValue(value, attribute.From, attribute.Length);
                    propertyInfo.SetValue(model, newPropertyValue);
                }
            }
            
        }

        private static string GetPositionValue(string line, int from, int length)
        {

            if (from + length > line.Length || from > line.Length)
            {               
                throw new IndexOutOfRangeException();
            }

            return line.Substring(from, length);
        }
    }
}