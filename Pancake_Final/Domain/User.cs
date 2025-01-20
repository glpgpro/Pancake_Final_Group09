namespace Pancake_Final.Domain
{
    public class User : BaseDomainModel
    {
        //primary key
        public int UserId { get; set; }
        // Foreign key
        public int PlayListID { get; set; }
        //methods
        public string? Name     { get; set; }

        public string? Email { get; set; }
       


    }
}
