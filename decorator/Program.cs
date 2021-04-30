using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // var guest1 = new Guest();
            // var guest2 = new MinorGuest();
            // var guest3 = new MembershipGuest();
            // var guest4 = new MembershipMinorGuest();
            // Process(guest1);
            // Process(guest2);
            // Process(guest3);
            // Process(guest4);

            var adult = new AdutlGuest();
            var minor = new MinorGuest();

            var membershipAdult = new MembershiDecorator(adult);
            var membershipMinor = new MembershiDecorator(minor);

            var membershipForeignerMinor = new ForeignerDecorator(membershipMinor);
            var membershipForeignerAdult = new ForeignerDecorator(membershipAdult);

            var membershipInGroupForeignerMenor = new InGroupDecorator(membershipForeignerMinor);


            Process(adult);
            Process(minor);
            Process(membershipAdult);
            Process(membershipMinor);
            Process(membershipForeignerMinor);
            Process(membershipForeignerAdult);
            Process(membershipInGroupForeignerMenor);

        }

        public static void Process(Guest guest)
        {
            Console.WriteLine($"Get discount {guest.GetDiscount()}, {guest.GetDiscountDescription()}");
        }
    }
}
