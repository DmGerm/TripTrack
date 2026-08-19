namespace TripTrack.Models
{
    public class UserModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public string LastName { get; set; } = string.Empty;
        public required string Email { get; set; }
        public required byte[] Password { get; set; }
        public required byte[] Salt { get; set; }
        public RolesEn RoleID { get; set; }
    }
}
