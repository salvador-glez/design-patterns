using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = Context.Instance;
            var context2 = Context.Instance;
             var context3 = Context.Instance;
              var context4 = Context.Instance;
               var context5 = Context.Instance;
            Process(context);
        }

        public static void Process(Context context)
        {
            //...
        }
    }
}
