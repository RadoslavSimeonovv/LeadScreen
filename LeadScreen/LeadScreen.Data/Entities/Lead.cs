namespace LeadScreen.Data.Entities
{
    using LeadScreen.Data.Entities.Common;

    public class Lead : BaseEntity
    {
        public string Name { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public Subarea Subarea { get; set; }
        public int SubAreaId { get; set; }
    }
}
