using System;
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
                    var newPropertyValue = GetPositionValue(value, attribute);
                 
                    propertyInfo.SetValue(model, SetValueByType(newPropertyValue,propertyInfo.PropertyType));
                    

                }
            }
            
        }

        private static object SetValueByType(string value,Type propertyType){
            string typeName = propertyType.Name;            
            switch (typeName)
            {
                case "Boolean":
                    return value.ToUpper().Equals("TRUE");
                case "Int32":
                    return int.Parse(value);
                case "Int64":
                    return long.Parse(value);
                
                default: return value;
            }
        }

        private static string GetPositionValue(string line, TextPropertyAttribute attribute)
        {
            int? length = attribute.Length;
            if(length != null && line.Length <  (attribute.From + length.Value) && !attribute.AllowPositionException)
            {
                length = line.Length - attribute.From;
            }
            return length == null ? line.Substring(attribute.From) :line.Substring(attribute.From, length.Value);
        }

         
    }
}
