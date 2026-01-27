using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.DependencyInjection
{
   public class UserService
    {
            [Inject]
            private Logger logger;

            public void Run()
            {
                logger.Log("UserService is running");
            }
        }
    }

