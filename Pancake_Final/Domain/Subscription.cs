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
        public int SubStatus { get; set; } //either a 1 or 0 indicating whether the subscription is still on or not
        public string? SubPlans { get; set; }


    }
}
