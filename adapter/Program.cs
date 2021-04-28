using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            UserWebServiceClient service = new UserWebServiceClient();
            //Process(service);
        }

        public static void Process(IUserService service)
        {
            Console.WriteLine($"User name from service: {service.GetUser(1)}");
        }
    }
}
