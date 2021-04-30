using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            UserWebServiceClient service = new UserWebServiceClient();
            UserServiceAdapter adapter = new UserServiceAdapter(service);

            Process(adapter);
        }

        public static void Process(IUserService service)
        {
            Console.WriteLine($"User name from service: {service.GetUser(1)}");
        }
    }
}
