namespace Decorator
{
    public class Guest
    {
        public virtual float GetDiscount() => 0;
        public virtual string GetDiscountDescription() => "No discount";
    }

    public class MinorGuest : Guest
    {
        public override float GetDiscount() => 300;
        public override string GetDiscountDescription() => "minor discount";
    }

    public class MembershipGuest : Guest
    {
        public override float GetDiscount() => 100;
        public override string GetDiscountDescription() => "membership discount";
    }

    public class MembershipMinorGuest : Guest
    {
        public override float GetDiscount() => 350;
        public override string GetDiscountDescription() => "minor membership discount";
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
