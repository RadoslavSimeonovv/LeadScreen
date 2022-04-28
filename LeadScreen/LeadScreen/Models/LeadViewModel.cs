namespace LeadScreen.Web.Models
{
    public class LeadViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public SubareaViewModel Subarea { get; set; }
        public int SubAreaId { get; set; }
    }
}
