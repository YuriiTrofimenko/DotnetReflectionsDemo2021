using System;
using System.Reflection;

namespace ReflectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Surprise.GetResult();
            Type type = result.GetType();
            foreach (PropertyInfo propInfo in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                // Console.WriteLine(propInfo.Name);
                if (propInfo.Name == "Name")
                {
                    Console.WriteLine($"Name = {propInfo.GetValue(result)}");
                }
            }
            Console.WriteLine("*** Methods ***");
            foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                // Console.WriteLine($"Name = {methodInfo.Name}, ParametersCount = {methodInfo.GetParameters().Length}");
                
                if (methodInfo.Name == "SetIds" && methodInfo.GetParameters().Length == 1)
                {
                    /* Console.WriteLine("Invoke2:");
                    var arguments = new object[] { 5 };
                    methodInfo.Invoke(result, arguments); */
                    Console.WriteLine("Invoke2:");
                    var arguments = new object[] { new int[] { 5, 6 } };
                    methodInfo.Invoke(result, arguments);
                }

                if (methodInfo.Name == "ToString" && methodInfo.GetParameters().Length == 0)
                {
                    Console.WriteLine("Invoke:");
                    Console.WriteLine(methodInfo.Invoke(result, null));
                }
            }
            // Console.WriteLine(type.Name);
            // Console.WriteLine(result.Name);
        }
    }
}
