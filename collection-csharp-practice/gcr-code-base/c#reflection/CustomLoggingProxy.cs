using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectFive.Reflection
{

           
            public interface IGreeting
            {
                void SayHello(string name);
            }

            
            public class Greeting : IGreeting
            {
                public void SayHello(string name)
                {
                    Console.WriteLine("Hello, " + name);
                }
            }

            
            public class LoggingProxy<T> : DispatchProxy
            {
                private T _target;

                public void SetTarget(T target)
                {
                    _target = target;
                }

                protected override object Invoke(MethodInfo targetMethod, object[] args)
                {
                   
                    Console.WriteLine($"Calling method: {targetMethod.Name}");

                    
                    return targetMethod.Invoke(_target, args);
                }
            }

           
            class CustomLoggingProxy
            {

                public static void Main(string[] args)
                {
                  
                    IGreeting greeting = new Greeting();

                  
                    IGreeting proxy =
                        DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();

                   
                    ((LoggingProxy<IGreeting>)proxy).SetTarget(greeting);

                   
                    proxy.SayHello("Rama");
                }
            }

        }
    

