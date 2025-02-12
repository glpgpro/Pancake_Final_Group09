namespace Pancake_Final.Domain
{
    public class PaymentMethod : BaseDomainModel
    {
        //primary key
        public int PayId { get; set; }

        //foreign key
        public int? UserId { get; set; }

        public int Id { get; set; }

        //methods
        public string? Name { get; set; }

        public string? PaymentM {  get; set; }

    }
}
