namespace TripTrack.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required byte[] Password { get; set; }
        public required byte[] Salt { get; set; }
        public RolesEn RoleID { get; set; }
        public virtual RoleModel? Role { get; set; }
    }
}
