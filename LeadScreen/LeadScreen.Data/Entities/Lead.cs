namespace LeadScreen.Data.Entities
{
    using LeadScreen.Data.Entities.Common;

    public class Lead : BaseEntity
    {
        public string Address { get; private set; }
        public string MobileNumber { get; private set; }
        public string Email { get; private set; }
        public Subarea Subarea { get; private set; }
        public int SubAreaId { get; private set; }
    }
}
