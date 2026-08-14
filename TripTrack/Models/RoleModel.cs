namespace TripTrack.Models
{
    public class RoleModel
    {
        public RolesEn RoleID { get; set; }

        public virtual IEnumerable<UserModel>? Users { get; set; }
    }
}
