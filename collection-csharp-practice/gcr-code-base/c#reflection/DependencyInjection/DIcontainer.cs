using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectFive.Reflection.DependencyInjection
{
    public class DIcontainer
    
            {
                public static void InjectDependencies(object target)
        {
            Type type = target.GetType();

           
            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance
            );

            foreach (FieldInfo field in fields)
            {
               
                if (field.IsDefined(typeof(InjectAttribute), false))
                {
                   
                    object dependency =
                        Activator.CreateInstance(field.FieldType);

                    // Inject dependency
                    field.SetValue(target, dependency);
                }
            }
        }
    }
}
