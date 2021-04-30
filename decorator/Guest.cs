namespace Decorator
{
    public abstract class Guest
    {
        public abstract float GetDiscount();
        public abstract string GetDiscountDescription();
    }
    public class AdutlGuest : Guest
    {
        public override float GetDiscount() => 0;
        public override string GetDiscountDescription() => "adult discount ";
    }

    public class MinorGuest : Guest
    {
        public override float GetDiscount() => 300;
        public override string GetDiscountDescription() => "minor discount ";
    }


    public class GuestDecorator : Guest
    {
        private Guest _guest;

        public GuestDecorator(Guest guest)
        {   
            _guest = guest;
        }

        public override float GetDiscount()
        {
            return _guest.GetDiscount();
        }

        public override string GetDiscountDescription()
        {
            return _guest.GetDiscountDescription();
        }
    }

    public class MembershiDecorator : GuestDecorator
    {
        public MembershiDecorator(Guest guest) : base(guest)
        {
            
        }
        public override float GetDiscount() => base.GetDiscount() + 100;
        public override string GetDiscountDescription() => base.GetDiscountDescription() + "membership discount ";
    }

    public class ForeignerDecorator : GuestDecorator
    {

        public ForeignerDecorator(Guest guest) : base(guest)
        {
            
        }

        public override float GetDiscount() => base.GetDiscount() + 5;
        public override string GetDiscountDescription() => base.GetDiscountDescription() + "Foreigner discount ";
    }


    public class InGroupDecorator : GuestDecorator
    {

        public InGroupDecorator(Guest guest) : base(guest)
        {
            
        }

        public override float GetDiscount() => base.GetDiscount() + 8;
        public override string GetDiscountDescription() => base.GetDiscountDescription() + "InGroup discount ";
    }

    //public class ForeignerGuest 
    //public class ForeignerMinorGuest
    //public class MembershipForeignerGuest
    //public class MembershipForeignerMinorGuest

    //public class InGroupGuest
    //public class InGroupMinorGuest
    //public class InGroupMembershipGuest
    //public class InGroupMembershipMinorGuest
    //public class InGroupForeignerGuest
    //public class InGroupForeignerMinorGuest
    //public class InGroupMembershipForeignerGuest
    //public class InGroupMembershipForeignerMinorGuest
}
