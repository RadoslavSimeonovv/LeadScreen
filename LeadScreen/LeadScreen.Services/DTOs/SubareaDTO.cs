using System.Collections.Generic;

namespace LeadScreen.Services.DTOs
{
    public class SubareaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set; }
        public ICollection<LeadDTO> Leads { get; set; }
    }
}
