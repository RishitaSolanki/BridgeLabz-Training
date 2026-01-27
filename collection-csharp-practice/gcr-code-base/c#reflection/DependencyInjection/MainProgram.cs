using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.DependencyInjection
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            UserService service = new UserService();

           
            DIcontainer.InjectDependencies(service);

            service.Run();
        }
    }
}

