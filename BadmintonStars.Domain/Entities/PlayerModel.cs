namespace BadmintonStars.Domain.Entities
{
    public class PlayerModel
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Club {  get; set; } = string.Empty;
    }
}
