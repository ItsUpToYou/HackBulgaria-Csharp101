using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Incrementable
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]

    public class IncrementableAttribute : Attribute
    {
    }

    public static class ExtentionMethod
    {
        public static void IncrementMethod(this object obj)
        {
            if (IsIncrementable(obj))
            {

                PropertyInfo[] props = obj.GetType().GetProperties();
                foreach (var prop in props)
                {
                    var type = prop.PropertyType;
                    if (type == typeof(int))
                    {
                        int val = (int)prop.GetValue(obj) + 1;
                        prop.SetValue(obj, val);
                    }
                    else
                    {
                        throw new Exception("The property is not type of Int");
                    }

                }
            }
        }

        public static bool IsIncrementable(this object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            if (type.IsDefined(typeof(IncrementableAttribute), false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
