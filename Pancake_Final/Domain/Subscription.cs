namespace Pancake_Final.Domain
{
    public class Subscription : BaseDomainModel
    {
        //Primary Key
        public int SubId { get; set; }

        //foreign key
        public int UserId { get; set; }

        //methods
        public string? Name { get; set; }
        public int SubStatus { get; set; } //indicates whether the subscription is free or preimum
        public string? SubPlans { get; set; }


    }
}
